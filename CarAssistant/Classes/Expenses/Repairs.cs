using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant.Classes.Expenses
{
    [Serializable]
    public class Repairs : Expense
    {
        public Repairs(decimal cost, string description, DateTime when, string additionalInfo)
        {
            Cost = cost;
            Description = description;
            When = when;
            AdditionalInfo = additionalInfo;
            GetClassName();
        }
        public Repairs()
        {

        }
    }
}
