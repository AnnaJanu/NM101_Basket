using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM101_Basket
{
    internal class HouseholdItem : Item
    {
        public HouseholdItem(string name, double cost, int amount) : base(name, cost, amount) { }

        public override void AddCalories(int calories)
        {

        }
        public override string ShowCalories()
        {
            return string.Empty;
        }
    }
    
}
