using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenTracker.Model
{
    public class Garden : BaseData , iCrud, IEnumerable
    {
        public Garden(string? gardenName, string? gardenDescription, string? gardenSquareFeet, DateTime createdDateTime)
        {
            Name = gardenName;
            Description = gardenDescription;
            GardenSquareFeet = gardenSquareFeet;
            DateTimeCreated = createdDateTime;
            this.Id = Interlocked.Increment(ref globalId);
        }

        public Garden ()
        {

        }

        public string? GardenSquareFeet { get; set; }
        public static int globalId;

        public static Garden CreateItem(Garden garden)
        {
            //should go to database return the object so it's added to a garden list

            return garden;
                                   
               
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
