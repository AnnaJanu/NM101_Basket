using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM101_Basket
{
    internal class Dairy : Item
    {
        private double _fatPercentage = -1;
        public Dairy(string name, double price, int amount) : base(name, price, amount) { }
        public void AddFatPercentage (double fatPercentage)
        { if (fatPercentage >= 0)
            { _fatPercentage = fatPercentage; }
            else EnteredInvalidData();
        }

        public string ShowFatPercentage()
        { if (_fatPercentage < 0)
            {
                return "The fat percentage was not added";
            }
            else return _fatPercentage.ToString();
        }


    }
}
