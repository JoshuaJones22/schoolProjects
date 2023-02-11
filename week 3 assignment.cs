using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string speedString = "";
            string speedLimitstring = "";
            string make = "";
            string model = "";
            Console.WriteLine("Enter the speed limit");
            speedLimitstring = Console.ReadLine();
            int speedLimit = Convert.ToInt32(speedLimitstring);
            Console.WriteLine("Speed limit: " + speedLimitstring);

            car a = new car();
            Console.WriteLine("Enter the make for car a: ");
            make = Console.ReadLine();
            a.make = (make);


            Console.WriteLine("Enter the model for car a: ");
            model = Console.ReadLine();
            a.model = (model);

            Console.WriteLine("Enter the speed for car a: ");
            speedString = Console.ReadLine();
            int speed = Convert.ToInt32(speedString);
            a.speed = (speed);

            car b = new car();
            Console.WriteLine("Enter the make for car b: ");
            make = Console.ReadLine();
            b.make = (make);


            Console.WriteLine("Enter the model for car b: ");
            model = Console.ReadLine();
            b.model = (model);

            Console.WriteLine("Enter the speed for car b: ");
            speedString = Console.ReadLine();
            //int speed = Convert.ToInt32(speedString);
            b.speed = (speed);

            car c = new car();
            Console.WriteLine("Enter the make for car c: ");
            make = Console.ReadLine();
            c.make = (make);


            Console.WriteLine("Enter the model for car c: ");
            model = Console.ReadLine();
            c.model = (model);

            Console.WriteLine("Enter the speed for car c: ");
            speedString = Console.ReadLine();
            c.speed = (speed);

            Console.WriteLine(make, model, speed);
        }
    }

    public class car
    {
        public string make;
        public string model;
        public int speed;
        
    }
}
    

