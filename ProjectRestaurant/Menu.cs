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
            _productList.Add(new RestaurantProduct("Carbonara", 25).SetVAT(9));
            _productList.Add(new RestaurantProduct("Frutti di mare", 40).SetVAT(9));

            _productList.Add(new RestaurantProduct("Lava cake", 15).SetVAT(10));
            _productList.Add(new RestaurantProduct("Ice cream", 12).SetVAT(10));
            _productList.Add(new RestaurantProduct("Pancakes", 20).SetVAT(10));

            _productList.Add(new RestaurantProduct("Cola", 7).SetVAT(12));
            _productList.Add(new RestaurantProduct("Sprite", 5).SetVAT(12));
            _productList.Add(new RestaurantProduct("WATER", 3).SetVAT(5));

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
