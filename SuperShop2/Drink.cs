using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop2
{
    public class Drink : Meal
    {
        public float Volume { get; set; }
        override public string GetGoodsTypeName()
        {
            return "Drink";
        }
        override public List<string> CollectGoodsProperties()
        {
            List<string> collectGoodsProperties = base.CollectGoodsProperties();
            collectGoodsProperties.Add("Volume: " + Volume.ToString());
            return collectGoodsProperties;
        }
    }
}
