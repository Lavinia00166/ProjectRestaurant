using ProjectRestaurant.Product;
using System;
using System.Collections.Generic;

namespace ProjectRestaurant
{
    class Program
    {
        public static List<RestaurantProduct> list;
        static void Main(string[] args)
        {
            Menu menu = Menu.makeMenu();
            Console.WriteLine(menu);
            list = Menu.getMenu();

            Cart cart = new Cart();
            cart.addProduct(list[0]);
            Console.WriteLine(cart);
        }
    }
}
