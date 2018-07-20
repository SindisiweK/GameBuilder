using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyBuilderBudgetManager.Model
{
    public class BudgetPlan
    {
        public int ExpenseId  { get; set; }
        public string ExpenseName  { get; set; }
        public decimal Cost  { get; set; }
        public DateTime DueDate  { get; set; }
        public int  UserId  { get; set; }
    }

    public class UserProfile
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
    }
}
