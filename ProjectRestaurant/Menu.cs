using ProjectRestaurant.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRestaurant
{
    class Menu
    {
        private static List<RestaurantProduct> _productList = new List<RestaurantProduct>();
        private static Menu menu = null;
        private Menu()
        {
            _productList.Add(new RestaurantProduct("Margherita", 28).SetVAT(9));
            _productList.Add(new RestaurantProduct("Quattro Formaggi", 30).SetVAT(9));
            _productList.Add(new RestaurantProduct("Quattro Stagioni", 34).SetVAT(9));

            _productList.Add(new RestaurantProduct("Pollo e funghi", 22).SetVAT(9));
            _productList.Add(new RestaurantProduct("Carbonara", 28).SetVAT(9));
            _productList.Add(new RestaurantProduct("Frutti di mare", 28).SetVAT(9));

            _productList.Add(new RestaurantProduct("Lava cake", 28).SetVAT(10));
            _productList.Add(new RestaurantProduct("Ice cream", 28).SetVAT(10));
            _productList.Add(new RestaurantProduct("Pancakes", 28).SetVAT(10));

            _productList.Add(new RestaurantProduct("Cola", 28).SetVAT(12));
            _productList.Add(new RestaurantProduct("Sprite", 28).SetVAT(12));
            _productList.Add(new RestaurantProduct("WATER", 28).SetVAT(5));

        }

        public static List<RestaurantProduct> getMenu()
        {
            return _productList;
        }
        public static Menu makeMenu()
        {
            if (menu == null)
            {
                menu = new Menu();
            }
            return menu;
        }
        public override string ToString()
        {
            string result = $"The menu contains:\n";
            foreach (var i in _productList)
            {
                result += i.ToString() + "\n\n";
            }
            return result;
        }
    }
}
