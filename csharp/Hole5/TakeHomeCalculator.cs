﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Hole5
{
    public class TakeHomeCalculator
    {
        private readonly TaxRate taxRate;

        public TakeHomeCalculator(TaxRate taxRate)
        {
            this.taxRate = taxRate;
        }

        public Money NetAmount(Money first, params Money[] rest)
        {
            List<Money> monies = rest.ToList();

            Money total = first;

            foreach (Money next in monies)
            {
                total = total.Plus(next);
            }

            var tax = Apply(first, total);

            return total.Minus(tax);
        }

        private Money Apply(Money first, Money total)
        {
            Double amount = total.value * (taxRate.percent / 100d);
            Money tax = Money.Create(Convert.ToInt32(amount), first.currency);
            return tax;
        }
    }
}