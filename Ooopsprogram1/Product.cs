using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooopsprogram1
{
    public class Product
    {
        private string code;
        private string name;
        private double price;
        private double discountedprice;

        public Product(string code, string name, double price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
            if (price > 1000)
            {
                discountedprice = price - (price * 0.10);
            }
            else
            {
                discountedprice = price;
            }
        }

        public string Print()
        {
            return $"code={code} name={name} price={discountedprice}";
        }

    }
}
