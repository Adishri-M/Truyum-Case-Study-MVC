using Com.Cognizant.Truyum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{

    class CartDaoCollection : IcartDao
    {
        private static Dictionary<long, Cart> userCart;
        public CartDaoCollection()
        {
            if (userCart == null)
            {
                userCart = new Dictionary<long, Cart>();

            }
        }

        public void AddCartItem(long userId, long menuItemId)
        {
            MenuItemDaoCollection menuItemDao = new MenuItemDaoCollection();
            MenuItem menuItem = menuItemDao.GetMenuItem(menuItemId);

            if (userCart.ContainsKey(userId))
            {
                userCart[userId].MenuItemList.Add(menuItem);
            }
            else
            {
                List<MenuItem> menuItemList = new List<MenuItem>() { menuItem };
                userCart.Add(userId, new Cart(menuItemList, 0));
            }

        }

        public Cart GetAllCartItems(long userId)
        {

            float totalPrice = 0f;
            var menuItemList = userCart[userId];
            if (menuItemList.MenuItemList.Count.Equals(0))
            {
                throw new CartEmptyException();
            }
            else
            {
                foreach (var item in menuItemList.MenuItemList)
                {
                    totalPrice += item.Price;
                }

            }
            Cart cart = new Cart(menuItemList.MenuItemList, totalPrice);
            return cart;
        }

        public void RemoveCartItem(long userId, long productId)
        {
            List<MenuItem> menuItem = userCart[userId].MenuItemList;
            foreach (MenuItem item in menuItem)
            {
                if (item.Id.Equals(productId))
                {
                    userCart[userId].MenuItemList.Remove(item);
                    break;
                }
            }
        }
    }
}
