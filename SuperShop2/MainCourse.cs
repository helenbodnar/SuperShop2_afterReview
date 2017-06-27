using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop2
{
    public class MainCourse : Meal
    {
        public enum CousineType { georgian, ukrainian, french, NA };
        public CousineType cousineType;

        override public string GetGoodsTypeName()
        {
            return "MainCourse";
        }
        override public List<string> CollectGoodsProperties()
        {
            List<string> collectGoodsProperties = base.CollectGoodsProperties();
            collectGoodsProperties.Add("CousineType: " + cousineType.ToString());
            return collectGoodsProperties;
        }
    }
}
