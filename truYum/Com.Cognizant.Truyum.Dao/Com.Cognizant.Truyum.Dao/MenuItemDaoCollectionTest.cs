using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    public class MenuItemDaoCollectionTest
    {
        public static void Main(string[] args)
        {

        }
        public static void TestGetMenuItemListAdmin()
        {

            MenuItemDaoCollection menuItemDao = new MenuItemDaoCollection();

            Console.WriteLine("Admin Menu Item List \n Id  Name  Price  Active  Date of Launch  Category  Free Delivery  Action\n");
            foreach (var item in menuItemDao.GetMenuItemListAdmin())
            {
                Console.Write(item.Id + "   ");
                Console.Write(item.Name + "   ");
                Console.Write(item.Price + "  ");
                Console.Write(item.Active ? "Yes   " : "No   ");
                Console.Write(item.DateOfLaunch + "   ");
                Console.Write(item.Category + "   ");
                Console.Write(item.FreeDelivery ? "   Yes" : "   No");
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        public static void TestGetMenuItemListCustomer()
        {
            MenuItemDaoCollection menuItemDao = new MenuItemDaoCollection();
            Console.WriteLine("Customer Menu Item List \n Id  Name  Price  Active  Date of Launch  Category  Free Delivery  Action\n");
            menuItemDao.GetMenuItemListCustomer().ForEach(item => Console.WriteLine($"{item.Id} {item.Name} {item.Price} {(item.Active ? "Yes" : "No")} {item.DateOfLaunch} {item.Category} {(item.FreeDelivery ? "Yes" : "No")}"));
            Console.WriteLine();
        }
        public static void TestModifyMenuItem()
        {

            MenuItem menuItem = new MenuItem(id: 2, name: "Burger", price: 129.00f, active: true, dateOfLaunch: DateUtility.ConvertToDate("2017/12/23"), category: "Main Course", freeDelivery: false);
            MenuItemDaoCollection menuItemDao = new MenuItemDaoCollection();
            menuItemDao.ModifyMenuItem(menuItem);


        }
        public static void TestGetMenuItem()
        {
            Console.Write("Enter product ID to check:");
            long productID = long.Parse(Console.ReadLine());
            MenuItemDaoCollection menuItemDao = new MenuItemDaoCollection();
            menuItemDao.GetMenuItem(productID);
        }
    }
}
