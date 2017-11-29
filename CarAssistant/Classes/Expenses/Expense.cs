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

        public decimal Cost
        {
            get
            {
                return Cost;
            }
            set
            {
                Cost = value;
            }

        }
        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = value;
            }
        }
        public DateTime When
        {
            get
            {
                return When;
            }
            set
            {
                When = value;
            }
        }
    }
}
