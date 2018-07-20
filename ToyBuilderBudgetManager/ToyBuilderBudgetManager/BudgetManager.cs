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
        private static List<BudgetModel> ItemList = new List<BudgetModel>();
        public BudgetManager()
        {
            AddBudgetItems();
        }
        public List<BudgetModel> GetBudgetItems()
        {
            var budgetIem = AddBudgetItems();
            return budgetIem;
        }

        private static List<BudgetModel> AddBudgetItems()
        {
            listOfExpenses();
            return ItemList;
        }

        public List<BudgetModel> AddItems(BudgetModel items)
        {
            ItemList.Add(items);
            return ItemList;
        }

        private static void listOfExpenses()
        {
            ItemList = new List<BudgetModel>
            {
                new BudgetModel()
                {
                    expense = "EmergencyFund",
                    cost = 2000,
                    startDate = DateTime.Parse("2018-07-01"),
                    endDate = DateTime.Parse("2018-12-31")
                },
                new BudgetModel()
                {
                    expense = "Savings",
                    cost = 3500,
                    startDate = DateTime.Parse("2018-07-01"),
                    endDate = DateTime.Parse("2018-12-31")
                },
                new BudgetModel()
                {
                    expense = "FoodAndGrocerie",
                    cost = 2100,
                    startDate = DateTime.Parse("2018-07-01"),
                    endDate = DateTime.Parse("2018-12-31")
                }
            };
        }
    }
}