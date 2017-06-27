using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop2
{
    public abstract class Goods
    {
     private float price = 0;
     
        public virtual List<string> CollectGoodsProperties()
        {
            List<string> goodsMethods = new List<string>();
            goodsMethods.Add("Goods Type:" + GetGoodsTypeName());
            goodsMethods.Add("Name: " + Name);
            goodsMethods.Add("Price: " + Price);
            return goodsMethods;
        }

        public virtual void ConsoleWriteGoodsProperties()
        {
            foreach (var goodsProperty in CollectGoodsProperties())
            {
                Console.WriteLine(goodsProperty);
            }
        }

        public abstract string GetGoodsTypeName();

        public override string ToString() // for display goods type:Book, Dessert, Drink, MainCourse
        {
            return GetGoodsTypeName();
        }

        public string Name { set; get; }

       public float Price
        {
            set
            {
                if (value < 0)
                    throw new Exception();
                else
                    price = value;
            }
            get { return price; }
        }
    }
}
