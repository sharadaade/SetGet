using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGet
{
    class Pro
    {
        private string name;
        private int price;
        private int quantity;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public int Price
        {
            set
            {
                if(value > 0 )
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Invalid price");
                }
            }
            get
            {
                return price;
            }

        }

        public int Quantity
        {
            set
            {
                if(value >= 0)
                {
                    quantity = value;
                }
                else
                {
                    Console.WriteLine("Invalid quantity");
                }
            }
            get
            {
                return quantity;
            }
        }

        public int TotalValuePrice
        {
            get
            {
                return price * quantity;
            }
        }
    }

    internal class Product
    {
        static void Main(string[] args)
        {
            Pro p = new Pro();
            p.Name = "Mango Juice";
            p.Price = 30;
            p.Quantity = 4;

            Console.WriteLine("Total is : {0}",p.TotalValuePrice);
        }
    }
}
