using Com.Cognizant.Truyum.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruyumConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //MenuItemDaoCollectionTest.TestGetMenuItemListAdmin();
            //MenuItemDaoCollectionTest.TestGetMenuItemListCustomer();

            MenuItemDaoCollectionTest.TestModifyMenuItem();
             MenuItemDaoCollectionTest.TestGetMenuItem();

            //CartDaoCollectionTest.TestAddCartItem();
            // CartDaoCollectionTest.TestGetAllCartItems();
            // CartDaoCollectionTest.TestRemoveCartItem();

            // Test add item to cart
            // CartDaoCollectionTest.TestAddCartItem();
            Console.ReadKey();

        }
    }
}
