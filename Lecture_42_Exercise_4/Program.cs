using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_42_Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed limit");
            var speedLimit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the speed of the car");
            var speedOfCar = Int32.Parse(Console.ReadLine());

            SpeedCamera(speedLimit, speedOfCar);
            ShowExit();
        }

        static void SpeedCamera(int speedLimit, int speedOfCar)
        {
            if (speedOfCar <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if (speedOfCar > speedLimit)
            {
                var demerits = (speedOfCar - speedLimit) / 5;
                if (demerits > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("# of demerits = " + demerits);
                }
            }
        }

        static void ShowExit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
