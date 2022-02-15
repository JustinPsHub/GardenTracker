using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenTracker.Model
{
    public class Item : BaseData
    {
        public string Type { get; set; }    
        public decimal Price { get; set; }  
        public decimal Quantity { get; set; } 
        public string  AcquiredFrom { get; set; }   
    }
}
