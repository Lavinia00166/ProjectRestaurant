using ProjectRestaurant.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRestaurant
{
    class Cart
    {
        public List<RestaurantProduct> cart = new List<RestaurantProduct>();

        public Cart()
        { }

        public Cart addProduct(RestaurantProduct product)
        {

            cart.Add(product);
            return this;

        }
        public override string ToString()
        {
            string result = $"Your cart contains:\n";
            foreach (var i in cart)
            {
                result += i.ToString() + "\n";
            }
            return result;
        }
    }
}
