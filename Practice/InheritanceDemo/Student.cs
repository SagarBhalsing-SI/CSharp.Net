using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace InheritanceDemo
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        protected double collegeFee { get; set; } = 2000;
        
        public virtual void Display()
        {
            Console.WriteLine(Name + "  " + Department+"  "+Id);
        }
       

    }
    class DaySchooler:Student
    {

        public string busRoute { get; set; }
        public double busFee { get; set; } = 500;
        
        public double CalculateFee()
        {
            collegeFee = collegeFee +busFee;
            return collegeFee;
        }
        public new void Display()
        {
            Console.WriteLine($"Id:{Id}   Name:{Name}    Deaprtement:{Department}     BusRoute:{busRoute}     Bus Fee:{CalculateFee()}");
        }

    }

    class Hostel:Student 
    {
        public int hostelFee { get; set; } = 1000;
        public new void Display() //Here if write ovveride instead of new Child class will ovveride the parent method.
            //By using new we just create method on parent in child class and parent method is called.
        {
            Console.WriteLine($"Id:{Id}   Name:{Name}   Deaprtement:{Department}   Hostel Fee:{CalculateFee()}");
        }
        public double CalculateFee()
        {
            collegeFee = collegeFee + hostelFee;
            return collegeFee;
        }
      
    }
}
