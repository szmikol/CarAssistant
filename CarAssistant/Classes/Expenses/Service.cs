using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant.Classes.Expenses
{
    public class Service : Expense
    {
        public string WhichServiceStation { get; set; }
        public Service(decimal cost, string description, DateTime when,string whichServiceStation)
        {
            Cost = cost;
            Description = description;
            When = when;
            WhichServiceStation = whichServiceStation;
        }

    }
}
