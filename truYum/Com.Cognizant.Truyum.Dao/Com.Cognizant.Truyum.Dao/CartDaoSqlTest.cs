using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    class CartDaoSqlTest
    {
        public static void Main(string[] args)
        {

        }
        public static void TestAddCartItem()
        {
            CartDaoSql cartDao = new CartDaoSql();
            cartDao.AddCartItem(1, 2);

        }
        public static void TestGetAllCartItems()
        {

        }
        public static void TestRemoveCartItem()
        {

        }
    }
}
