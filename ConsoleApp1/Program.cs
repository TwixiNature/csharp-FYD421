using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double avg_speed = readDouble("Ange medelhastigheten (km/h) : ");
            double remaining_distance = readDouble("Ange återstående körsträcka (mil) : ");
            (int, int) time = remaining_time(avg_speed, remaining_distance);
            System.Console.WriteLine($"Återstående körtid är {time.Item1} timmar och {time.Item2} minuter.");
        }
        static (int, int) remaining_time(double v, double s)
        {
            // s = v * t
            // t = s / v

            double hrs = (s * 10 / v);
            int whole = (int)(hrs);
            double decimals = hrs - whole;
            return (whole, Convert.ToInt32(decimals*60));
        }

        static double readDouble(string q)
        {
            double output;
            Console.Write(q);
            while (!double.TryParse(Console.ReadLine(), out output))
            {
                Console.WriteLine("Please enter a valid number.");
                Console.Write(q);
            }
            return output;
        }
    }


}
