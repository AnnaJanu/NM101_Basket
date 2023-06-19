using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM101_Basket
{
    internal class Basket
    {
        private List<Item> _items = new List<Item>();
        public string? Name { get; set; }
        
        public void AddItem(Item item) 
        { _items.Add(item); }

        public void RemoveItem(Item item)
        { _items.Remove(item); }

        public string CountTotalCalories()
        {
            int result = 0;

            if (_items.Count > 0)
            {
                foreach (Item item in _items)
                { result = result + item.calories; }
                if (result > 0)
                    return result.ToString();
                else return "No calories added";
            }
            else return "The basket is empty";
        }
        public string ShowItems()
        {
            var sb = new StringBuilder();

            if (_items.Count > 0)
            {
                foreach (Item item in _items)
                {
                    sb.AppendLine(item.Name);
                }
                return sb.ToString();
            }
            else return "The basket is empty";
        }

        public string CountTotalCost()
        {
            double result = 0;
            if (_items.Count > 0)
            {
                foreach (Item item in _items)
                { result = +item.CalculateCost(); }

                 return result.ToString();
            }
            else return "The basket is empty";
        }
    }
}
