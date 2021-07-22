using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Outsourced : Part
    {
        // public property
        public string CompanyName { get; set; }

        // constructor -- inherits from Part
        public Outsourced (string companyName, int partID, string name, decimal partPrice, int partStock, int partMin, int partMax) : base (partID, name, partPrice, partStock, partMin, partMax)
        {
            CompanyName = companyName;
        }
    }
}
