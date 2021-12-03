using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRestaurant.Product
{
    class RestaurantProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double VAT { get; set; }

        public RestaurantProduct(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public RestaurantProduct SetVAT(double VAT)
        {
            this.VAT = VAT;
            return this;
        }
        public override string ToString()
        {
            return $"Name: {Name} -> price: {Price} \n -> VAT: {VAT}";
        }
    }
}
