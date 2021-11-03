using System;

namespace Hole2
{
    public class Money
    {
        public int value;
        public readonly String currency;

        public Money(int value, string currency)
        {
            this.value = value;
            this.currency = currency;
        }
    }
}