using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenTracker.Model
{
    public class BaseData : iCrud
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeModified { get; set; }
        public DateTime DateTimeClosed { get; set; }

        public void CreateItem ()
        {
            Console.WriteLine("Test Create");

        }

     
    }
}
