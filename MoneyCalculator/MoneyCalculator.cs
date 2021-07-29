using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyCalculator
{
    public class MoneyCalculator : IMoneyCalculator
    {
        public Money Max(IEnumerable<Money> monies)
        {
            if (monies == null || !monies.Any())
                return null;

            int currencyCount =  monies.Select(x => x.Currency).Distinct().Count();

            if (currencyCount > 1)
                throw new ArgumentException("All monies are not in the same currency.");

            var result = monies.OrderByDescending(a => a.Amount).FirstOrDefault();

            return result;
        }

        public IEnumerable<Money> SumPerCurrency(IEnumerable<Money> monies)
        {
            if (monies == null || !monies.Any())
                return null;

            IEnumerable<string> currencyCodes = monies.Select(x => x.Currency).Distinct();

            List<Money> sumOfMonies = new List<Money>();

            foreach(string currency in currencyCodes)
            {
                sumOfMonies.Add(new()
                {
                    Currency = currency,
                    Amount = monies.Where(a => a.Currency == currency).Select(x => x.Amount).Sum()
                });
            }

            return sumOfMonies;
        }
    }
}
