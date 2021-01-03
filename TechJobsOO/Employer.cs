using System;
namespace TechJobsOO
{
    public class Employer : JobField
    {
       
        public Employer()
        {
            
        }

        public Employer(string inputValue) : base (inputValue)
        {
            Value = inputValue;
        }

        
    }
}
