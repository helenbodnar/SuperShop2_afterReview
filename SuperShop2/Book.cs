using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop2
{
    public class Book : Goods
    {
        public enum BookType { newspaper, magazine, book };
        public BookType bookType;

        override public string GetGoodsTypeName()
        {
            return "Book";
        }

        override public List<string> CollectGoodsProperties()
        {
            List<string> collectGoodsProperties = base.CollectGoodsProperties();
            collectGoodsProperties.Add("Book Type: " + bookType.ToString());
           return collectGoodsProperties;
        }
    }
}

