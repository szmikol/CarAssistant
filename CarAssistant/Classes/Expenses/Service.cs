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
        public string WhatChanged { get; set; }
        public Service(decimal cost, string description, DateTime when,string whichServiceStation, string whatChanged)
        {
            Cost = cost;
            Description = description;
            When = when;
            WhichServiceStation = whichServiceStation;
            WhatChanged = whatChanged;
        }

    }
}
