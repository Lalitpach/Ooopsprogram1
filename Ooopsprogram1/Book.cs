using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooopsprogram1
{
    public class Book
    {
        private int bid;
        private string name;
        private string author;
        private double price;

        public Book()
        {

        }
        public Book(int bid, string name, string author, double price)
        {
            this.bid = bid;
            this.name = name;
            this.author = author;
            this.price = price;
        }

        public string Display()
        {
            return $"bid={bid} name={name} author={author} price={price}";
        }
    }
}
