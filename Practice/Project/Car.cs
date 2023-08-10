using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project
{
    internal class Car
    {
        string carName;
        string color;
        int speed;
        public Car()
        {

        }
        public Car  (string carName, string color, int speed)
        { 
            this.carName = carName; 
            this.color = color;
            this.speed = speed;
        }

        public  Car (string carName, string color)
        {
            this.carName = carName;
            this.color = color;
        }

        public string CarName
        {
            get { return carName; }
            set { carName = value; }
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (speed > 5)
                {
                    speed = value;
                }
                else
                {
                    speed = 5;
                }
            }
        }
        public void Display()
        {
            WriteLine($"{carName} is {color} and running at a speed of {speed}km.");
        }
        public void SpeedUp(int delta)
        {
            speed += delta;
        }
        public static void Main()
        {
            Car car1 = new Car("I20", "Matt Black");
            car1.SpeedUp(100); 
            car1.Display();

            Car car2 = new Car("I10","Matt Green",120);
            car2.Display();

            Car car3 = new Car();
            car3.CarName = "Lamborgini";
            car3.Display();

            Car car4 = new Car("Rolls Royce","Black");
            car4.speed = 3;
            car4.Display();
            
        }
    }
}
