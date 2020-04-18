using System;
using System.Drawing;

namespace Inheritance_Exercise
{

    public class Vehicle
    {
        public string RegistrationNumber { get; }
        public Point CurrentPosition { get; set; }

        public Vehicle(string registrationNumber)
        {
            RegistrationNumber = registrationNumber;
            Console.WriteLine("Vehicle initialized with registration number : {0}", registrationNumber);
        }

        public void Move(Point movingVector)
        {
            CurrentPosition = new Point(CurrentPosition.X + movingVector.X, CurrentPosition.Y + movingVector.Y);
            Console.WriteLine("Vehicle Moved and Current position is {0}", CurrentPosition );
        }
    }
    public class Car : Vehicle
    {
        public Car(string registrationNumber) :
            base(registrationNumber)
        {
            Console.WriteLine("Car initialized with registeration number : {0}", registrationNumber);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("112314");
            Vehicle vhcl = car; //upcasting

            vhcl.Move(new Point(5, 10));

            Car car2 = (Car)vhcl; //downcasting
            car2.Move(new Point(12,-8));
        }
    }
}
