using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant.Classes.Expenses
{
    public class Insurance : Expense
    {
        public bool HirePurchase;
        public DateTime ExpirationDate { get; set; }
        public string WhichInsurer { get; set; }
        public Insurance(decimal cost, string description, DateTime when, bool hirePurchase, DateTime expirationDate, string whichInsurer)
        {
            Cost = cost;
            Description = description;
            When = when;
            HirePurchase = hirePurchase;
            ExpirationDate = expirationDate;
            WhichInsurer = whichInsurer;
            GetClassName();
        }
        public Insurance()
        {

        }
    }
}
