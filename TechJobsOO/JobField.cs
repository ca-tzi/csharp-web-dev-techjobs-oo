using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        private string name = "Data Not Available";
        public string Value
        {
            get { return name; }
            set { name = value; }
        }


        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string inputValue) : this()
        {
            Value = inputValue;

        }

        public override bool Equals(object obj)
        {
            return obj is JobField baseClass &&
                   Id == baseClass.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
