using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyCalculator
{
    public class Money : IMoney
    {
        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public override bool Equals(object o)
        {
            if (o is Money)
            {
                var result = o as Money;
                return this.Amount == result.Amount && this.Currency == result.Currency;
            }

            return false;
        }
    }
}
