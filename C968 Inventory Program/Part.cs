using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_Program
{
    abstract class Part
    {

        

        private int partID;
        private string name;
        private double price;
        private int inStock;
        private int max;
        private int min;


        public int PartID
        {
            get
            {
                return partID; }
            set
            {
                partID = PartID;
            }
        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = Name;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = Price;
            }
        }

        public int InStock
        {
            get
            {
                return inStock;
            }
            set
            {
                inStock = InStock;
            }
        }

        public int Max
        {
            get
            {
                return max;
            }
            set
            {
                max = Max;
            }
        }

        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                max = Max;
            }
        }

    }
}
