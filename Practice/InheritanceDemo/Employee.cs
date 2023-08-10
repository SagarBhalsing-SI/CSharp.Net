using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  Employee(int id,string Name)
        {

        }
        public override string ToString()
        {
            return $"Name:{Name}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                Employee other = obj as Employee;
                if (this.Id == other.Id &&  this.Name == other.Name)
                {
                    return true ;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
