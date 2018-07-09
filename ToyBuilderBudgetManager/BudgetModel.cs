using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyBuilderBudgetManager
{
    public class BudgetModel
    {
        public string expense { get; set; }
        public double cost { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        
    }
}
