using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant.Classes.Expenses
{
    public class Repairs : Expense
    {
        public string RepairedPart { get; set; }
        public string WhichMechanic { get; set; }
        public Repairs(decimal cost, string description, DateTime when, string repairedPart, string whichMechanic)
        {
            Cost = cost;
            Description = description;
            When = when;
            RepairedPart = repairedPart;
            WhichMechanic = whichMechanic;
        }
    }
}
