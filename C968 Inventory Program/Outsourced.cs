using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_Program
{
    class Outsourced : Part
    {

        string companyName;

        public void setCompanyName(string CompanyName)
        {
            companyName = CompanyName;
        }
        
        public string getCompanyName()
        {
            return companyName;
        }

    }
}
