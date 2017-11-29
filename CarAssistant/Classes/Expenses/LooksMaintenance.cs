using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant.Classes.Expenses
{
    public class LooksMaintenance : Expense
    {
        /// <summary>
        /// Car Wash, Waxing, Upholstery cleaning.
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// e.g. Wunderbaum, air refresher
        /// </summary>
        public string AddedEquipement { get; set; }
        public LooksMaintenance(decimal cost, string description, DateTime when, string type, string addedEquipement)
        {
            Cost = cost;
            Description = description;
            When = when;
            Type = type;
            AddedEquipement = addedEquipement;
        }
    }
}
