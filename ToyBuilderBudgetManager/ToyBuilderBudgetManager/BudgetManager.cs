using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace ToyBuilderBudgetManager
{
    public class BudgetManager
    {
       
        public List<BudgetModel> GenerateItemList()
        {
            var budgetIem = new List<BudgetModel>();

                budgetIem.Add(new BudgetModel()
                {
                    expense = "EmergencyFund",
                    cost = 2000,
                    startDate = DateTime.Parse("2018-07-01"),
                    endDate = DateTime.Parse("2018-12-31")
                });
                budgetIem.Add(new BudgetModel()
                    { expense = "Savings",
                      cost = 3500,
                      startDate = DateTime.Parse("2018-07-01"),
                      endDate = DateTime.Parse("2018-12-31") });
                budgetIem.Add(new BudgetModel()
                {
                expense = "FoodAndGrocerie",
                cost = 2100,
                startDate = DateTime.Parse("2018-07-01"),
                endDate = DateTime.Parse("2018-12-31")
                });
            return budgetIem;
        }

        private static string GetBudgetDuration(DateTime date)
        {
            DateTime beginningOfMonth = new DateTime(date.Year, date.Month, 1);

            while (date.Date.AddDays(1).DayOfWeek != CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek)

                date = date.AddDays(1);

            int weekNumber = (int)Math.Truncate((double)date.Subtract(beginningOfMonth).TotalDays / 7) + 1;

            string[] weeks = { "first", "second", "third", "fourth", "fifth", "sixth" };

            return weeks[weekNumber - 1];
        }
    }
}