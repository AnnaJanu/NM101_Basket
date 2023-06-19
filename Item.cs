using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM101_Basket
{
    internal class Item
    {
        public string Name {  get; private set; }
        public double Price { get; private set; }
        public double Amount { get; private set; }

        public string? AdditionalDetails;

        public int calories;

        public Item (string name, double price, double amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }
        public void AddDetails (string additionalDetails) 
        { AdditionalDetails = additionalDetails; }

        public string ShowDetails()
        {
            if (AdditionalDetails != null)
            { return AdditionalDetails; }
            else return "No details added";
        }

        public double CalculateCost()
        {
            return Price * Amount;
        }

        public virtual void AddCalories(int calories)
        {
            if (calories > 0) 
            { this.calories = calories; }
            else EnteredInvalidData();
        }
        public virtual string ShowCalories()
        {
            if (calories > 0)
            {
                return calories.ToString();
            }
            else return "No calories added";
        }
        protected static string EnteredInvalidData()
        { return "Entered invalid data"; }
    }
}
