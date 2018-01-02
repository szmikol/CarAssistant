using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces;

namespace CarAssistant.Classes.Expenses
{
    [Serializable]
    public class Expense : IExpense
    {
        public string TypeOfExpense { get; set; }
        public Expense()
        {
            GetClassName();
        }
        public void GetClassName()
        {
            TypeOfExpense = this.GetType().Name;
        }

        public decimal Cost { get; set; }
        public string Description { get; set; }
        public DateTime When { get; set; }
        public string AdditionalInfo { get; set; }

    }
}

