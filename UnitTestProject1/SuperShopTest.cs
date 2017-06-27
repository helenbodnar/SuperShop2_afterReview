using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperShop2;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class SuperShopTest
    {

        [TestMethod]
        public void TestGetGoodsTypeName()
        {
            //Arrange
            Dessert dessert = new Dessert();
            string expected = "Dessert";

            //Act          
            string actual = dessert.GetGoodsTypeName();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCollectGoodsProperties()
        {
            //Arrange

            List<string> expectedGoodsProp =new List<string> { "Goods Type:Dessert", "Name: Plombir", "Price: 12", "Callories: 1000", "Weight: 20", "Dessert type: IceCream" };

            //Act          
            Dessert dessert = new Dessert();
            dessert.Name="Plombir";
            dessert.Price=12f;
            dessert.dessertType = Dessert.DessertType.IceCream;
            dessert.Callories = 1000;
            dessert.Weight = 20;

            List<string> actualGoodsProp = dessert.CollectGoodsProperties();

            //Assert
            for (int i = 0; i < expectedGoodsProp.Count; i++)
            {
                Assert.AreEqual(expectedGoodsProp[i], actualGoodsProp[i]);
            }
}

        [TestMethod]
        public void TestAddGetAllGoods()
        {
            //Arrange
            Dessert dessert = new Dessert();
            dessert.Name="Plombir";
            dessert.Price=12f;
            dessert.dessertType = Dessert.DessertType.IceCream;
            dessert.Callories = 1000;
            dessert.Weight = 20;

            //Act  
            Warehouse warehouse = new Warehouse();
            warehouse.AddGoods(dessert);
          List<Goods>expectedGoods = warehouse.AllGoodsItems;

            // Assert
            Assert.AreEqual(expectedGoods[0], dessert);
        }

        [TestMethod]
        public void TestAddGood()
        {
            //Arrange
            Dessert dessert = new Dessert();
            dessert.Name="Plombir";
            dessert.Price=12f;
            dessert.dessertType = Dessert.DessertType.IceCream;
            dessert.Callories = 1000;
            dessert.Weight = 20;
            Dessert newdessert = new Dessert();
            newdessert = dessert;

            //Act  
            Warehouse warehouse = new Warehouse();
            warehouse.AddGoods(dessert);
            warehouse.AddGoods(newdessert);

            List<Goods> expectedGoods = warehouse.AllGoodsItems;

            // Assert
            Assert.AreEqual(expectedGoods.Count, 2);
        }

        [TestMethod]
        public void TestDeleteGoods()
        {
            Dessert dessert = new Dessert();
            dessert.Name="Plombir";
            dessert.Price=12f;
            dessert.dessertType = Dessert.DessertType.IceCream;
            dessert.Callories = 1000;
            dessert.Weight = 20;

            Dessert newdessert = new Dessert();
            newdessert.dessertType = Dessert.DessertType.IceCream;
            newdessert.Name= "Eskimo";

            Warehouse warehouse = new Warehouse();
            warehouse.AddGoods(dessert);
            warehouse.AddGoods(newdessert);

           List<Goods> allGoods = warehouse.AllGoodsItems;
            Goods deletedItem = warehouse.DeleteGoods(dessert);
            Assert.AreEqual(deletedItem.Name, dessert.Name);
            Assert.AreEqual(warehouse.AllGoodsItems.Count, 1);
        }
       
        [TestMethod]
        public void TestGetGoods()
        {
            Dessert dessert = new Dessert();
            dessert.Name="Plombir";
            dessert.Price=12f;
            dessert.dessertType = Dessert.DessertType.IceCream;
            dessert.Callories = 1000;
            dessert.Weight = 20;

            MainCourse maincourse = new MainCourse();
            maincourse.Price =120f;

            Warehouse warehouse = new Warehouse();
            warehouse.AddGoods(dessert);
            warehouse.AddGoods(maincourse);

            string type = "Dessert";
            string name = "Plombir";
            Goods findedgood = warehouse.GetGoods(type, name);

            Assert.AreEqual(findedgood.Price, 12f);
        }
        }
}

