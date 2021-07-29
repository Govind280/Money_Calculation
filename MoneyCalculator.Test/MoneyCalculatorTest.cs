using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MoneyCalculator.Test
{
    [TestClass]
    public class MoneyCalculatorTest
    {
        [DynamicData(nameof(GetTestDataFor_Max_Test), DynamicDataSourceType.Method)]
        [TestMethod]
        public void Max_Test(IEnumerable<Money> monies, object expected)
        {
            try
            {
                MoneyCalculator mockMoneyCalculator = new MoneyCalculator();

                var actual = mockMoneyCalculator.Max(monies);

                Assert.AreEqual(expected, actual);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("All monies are not in the same currency.", ex.Message);
            }
            catch (Exception e)
            {
                Assert.Fail($"Unexpected exception of type {e.GetType()} caught : {e.Message}");
            }
        }

        private static IEnumerable<object[]> GetTestDataFor_Max_Test()
        {
            List<Money> moneyValidCase = new()
            {
                new Money() { Amount = 10, Currency = "GBP" },
                new Money() { Amount = 20, Currency = "GBP" },
                new Money() { Amount = 50, Currency = "GBP" }
            };

            List<Money> moneyExceptionCase = new()
            {
                new Money() { Amount = 10, Currency = "GBP" },
                new Money() { Amount = 20, Currency = "USD" },
                new Money() { Amount = 50, Currency = "GBP" }
            };

            return new List<object[]>()
            {
                new object[] { null, null },
                new object[] { moneyValidCase, new Money() { Amount = 50, Currency = "GBP" } },
                new object[] { moneyExceptionCase, new ArgumentException("All monies are not in the same currency.") },
            };
        }
    }
}
