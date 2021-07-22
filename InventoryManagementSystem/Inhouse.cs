using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Inhouse : Part
    {
        // public property
        public int MachineID { get; set; }

        // constructor -- inherits from Part
        public Inhouse(int machineID, int partID, string name, decimal partPrice, int partStock, int partMin, int partMax) : base(partID, name, partPrice, partStock, partMin, partMax)
        {
            MachineID = machineID;
        }
    }
}
