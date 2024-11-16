using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooopsprogram1
{
    public class BookProperties
    {
        private int bid;
        private string name;
        private string author;
        private double price;

        public int Bid
        {
            get { return bid; }
            set { bid = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }



    }
}
