using System;
namespace TechJobsOO
{
    public class Location : JobField
    {
        public Location ()
        {

        }

        public Location(string inputValue) : base(inputValue)
        {
            
            Value = inputValue;

        }

        // TODO: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.

        
    }
}
