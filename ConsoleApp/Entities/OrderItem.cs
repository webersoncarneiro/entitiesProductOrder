using System.Globalization;
using ConsoleApp.Entities;

namespace ConsoleApp.Entities
{
    class OrderItem
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Price = price;
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name
                + " $ "
                + Price.ToString()
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);


        }
    }
}

