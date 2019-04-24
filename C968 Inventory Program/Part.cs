using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_Program
{
    abstract class Part
    {

        //public int partID { get; set; }
        //public string name { get; set; }
        //public double price { get; set; }
        //public int inStock { get; set; }
        //public int max { get; set; }
        //public int min { get; set; }

        private int partID;
        private string name;
        private double price;
        private int inStock;
        private int max;
        private int min;

        public void setName(string Name)
        {
            name = Name;
        }

        public string getName()
        {
            return name;
        }

        public void setPrice(double Price)
        {
            price = Price;
        }

        public double getPrice()
        {
            return price;
        }

        public void setInStock(int InStock)
        {
            inStock = InStock;
        }

        public int getInStock()
        {
            return inStock;
        }

        public void setMin(int Min)
        {
            min = Min;
        }

        public int getMin()
        {
            return min;
        }

        public void setMax(int Max)
        {
            max = Max;
        }

        public int getMax()
        {
            return max;
        }

        public void setPartID(int PartID)
        {
            partID = PartID;
        }

        public int getPartID()
        {
            return partID;
        }



    }
}
