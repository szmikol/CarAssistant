using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces;

namespace CarAssistant.Classes.Expenses
{
    public class Expense : IExpense
    {
        public Expense()
        {

        }

        public decimal Cost { get; set; }
        public string Description { get; set; }
        public DateTime When { get; set; }

    }
}

