using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarAssistant.Interfaces;

namespace CarAssistant.Classes.Expenses
{
    public class ExpenseCreator
    {
        private Form1 _form;
        private Expense _expense;
        public ExpenseCreator(Form1 form)
        {
            _form = form;
        }

        public ExpenseCreator()
        {
            
        }
        public void CreateExpense(string car, string typeOfExpense, string cost, string description, string addInfo)
        {
            var costInt = ParsePrice(cost);
            var tempExpense = CreateTypeOfExpense(typeOfExpense, costInt, description, addInfo);
            string dupa = tempExpense.AdditionalInfo;
            _form.Driver.UserCars.First(c => c.Vin == dupa).AddExpense(tempExpense);
        }

        private string AddExpenseToCar(string car)
        {
            var splitTable = car.Split(' ');
            return splitTable[3];
        }

        private void FindCar()
        {
            //_form.Driver
        }

        private Expense CreateTypeOfExpense(string typeOfE, decimal cost, string description, string addInfo) // tutaj generic method
        {
            switch (typeOfE)
            {
                case "Exploitation":
                    return new Exploitation(cost,description,new DateTime(),addInfo);
                case "LooksMaintenance":
                    return new LooksMaintenance(cost, description, new DateTime(), addInfo);
                case "Repairs":
                    return new Repairs(cost, description, new DateTime(), addInfo);
                case "Service":
                    return new Service(cost, description, new DateTime(), addInfo);
                default:
                    return new Expense();
            }
        }

        private decimal ParsePrice(string cost)
        {
            try
            {
                var temp = decimal.Parse(cost);
                return temp;
            }
            catch
            {
                MessageBox.Show("Wrong price format! Use digits only!");
                return 0;
            }

        }
    }
}
