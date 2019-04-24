using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_Program
{
    class InHouse : Part
    {

        int machineID;

        public void setMachineID(int MachineID)
        {
            machineID = MachineID;
        }

        public int getMachineID()
        {
            return machineID;
        }


    }
}
