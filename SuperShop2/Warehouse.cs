using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop2
{
    public class Warehouse
    {
        public List<Goods> AllGoodsItems = new List<Goods>(); // store here

        public void AddGoods(Goods newItem)
        {
            AllGoodsItems.Add(newItem);
        }

        public Goods GetGoods(string type, string name)
        {
            foreach (var goods in AllGoodsItems)
            {
                if (goods.Name == name && goods.GetGoodsTypeName() == type)
                {
                    return goods;
                }
            }
            return null;
        }

        public Goods DeleteGoods(string type, string name)
        {
            Goods finededGood = GetGoods(type, name);
            if (finededGood == null)
            {
                return null;
            }
            AllGoodsItems.Remove(finededGood);
            return finededGood;
        }

        public Goods DeleteGoods(Goods goodsToDelete)
        {
            AllGoodsItems.Remove(goodsToDelete);
            return goodsToDelete;
        }
    }
}
