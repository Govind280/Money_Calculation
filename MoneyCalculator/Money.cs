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
    }
}
