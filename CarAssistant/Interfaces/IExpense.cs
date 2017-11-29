using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant.Interfaces
{
    public interface IExpense
    {
        decimal Cost { get; set; }
        string Description { get; set; }
        DateTime When { get; set; }
    }
}
