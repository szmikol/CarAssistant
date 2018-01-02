using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant.Interfaces
{
    public interface IExpense
    {
        //Property showing cost of expense
        decimal Cost { get; set; }
        //Property showing short description of expense
        //E.g. "Repaired exhaust pipe"
        string Description { get; set; }
        //Property showing date of expense
        DateTime When { get; set; }
    }
}
