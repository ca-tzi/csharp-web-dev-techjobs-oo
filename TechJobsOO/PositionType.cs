using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {
        
        public PositionType()
        {
            
        }

        public PositionType(string inputValue) : base (inputValue)
        {
            Value = inputValue;
        }

        

       
    }
}
