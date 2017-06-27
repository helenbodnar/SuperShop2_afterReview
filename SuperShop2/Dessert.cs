using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop2
{
    public class Dessert : Meal
    {
        public enum DessertType { Cake, Cookie, IceCream };
        public DessertType dessertType;

        override public List<string> CollectGoodsProperties()
        {
            List<string> collectGoodsProperties = base.CollectGoodsProperties();
            collectGoodsProperties.Add("Dessert type: " + dessertType.ToString());
            return collectGoodsProperties;
        }

        override public string GetGoodsTypeName()
        {
            return "Dessert";
        }
    }
}
