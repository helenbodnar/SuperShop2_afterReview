using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dessert dessert = new Dessert();
            
            dessert.Name = "Plombir"; // desert.SetName("Plombir");
            dessert.Price = 12f;
            dessert.dessertType = Dessert.DessertType.IceCream;
            dessert.ConsoleWriteGoodsProperties();
            Console.WriteLine("******");

            Goods newgood = dessert; //Copy one goods to anoyher
            newgood.ConsoleWriteGoodsProperties();
            Console.WriteLine("******");

            Drink drink = new Drink();
            drink.Name = "Apple";

            Book book = new Book();
            book.Name = "Pravda";
            book.Price = 20f;
            book.bookType = Book.BookType.newspaper;

            Goods[] order = { dessert, newgood, drink, book }; // Display all list
            PrintOrder(order);

            Drink newdrink = new Drink(); //  set aditional items
            newdrink.Name = "Orange";

            MainCourse maincourse = new MainCourse();
            maincourse.Name = "Borsch";
            maincourse.Price = 28f;
            maincourse.cousineType = MainCourse.CousineType.ukrainian;
            maincourse.Callories = 400;

            Warehouse warehouse = new Warehouse();
            warehouse.AddGoods(drink);
            warehouse.AddGoods(dessert);
            warehouse.AddGoods(newdrink);
            warehouse.AddGoods(book);
            warehouse.AddGoods(maincourse);

            Console.WriteLine("============WAREHOSE ALL==========");
            PrintOrder(warehouse.AllGoodsItems);

            Console.WriteLine("============WAREHOSE FINDED AND UPDATED PRICE ==========");
            string name = "Plombir";
            string type = "Dessert";
            Goods findedgood = warehouse.GetGoods(type, name);
            if (findedgood != null)
            {
                findedgood.Price = findedgood.Price + 10;
            }
            else
            {
                Console.WriteLine("Price is not changed. The requested item is not found.");
                Console.WriteLine("*********");
            }
            PrintOrder(warehouse.AllGoodsItems);

            Console.WriteLine("============WAREHOSE AFTER DELETION ==========");
            Goods deletedgood = warehouse.DeleteGoods(type, name);
            PrintOrder(warehouse.AllGoodsItems);

            Console.WriteLine("============WAREHOSE AFTER NULL PASS ==========");
            try
            {
                warehouse.DeleteGoods(null);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null is not allowed");
                //    throw;
            }
            PrintOrder(warehouse.AllGoodsItems);

            Console.WriteLine("000000000000000000000000000");
            ICollection<Goods> goodscollection = (ICollection<Goods>)warehouse.AllGoodsItems;
            Console.WriteLine("\r\n Goods count in warehouse: " + goodscollection.Count);
            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }

        static void PrintOrder(ICollection<Goods> order)
        {
            foreach (Goods g in order)
            {
                g.ConsoleWriteGoodsProperties();
                Console.WriteLine("#: " + g.ToString());
                Console.WriteLine("=======");
            }
        }
    }

}

