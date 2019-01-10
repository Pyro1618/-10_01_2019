using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int secondsTotal = 0;

            do
            {
                Console.WriteLine("Write a positive number");
                secondsTotal = Convert.ToInt32(Console.ReadLine());
                if (secondsTotal <= 0)
                {
                    Console.Write("idiot !!!");
                }
            } while (secondsTotal <= 0);

            int days = secondsTotal / 86400;
            secondsTotal = secondsTotal % 86400;
            int hours = secondsTotal / 3600;
            secondsTotal = secondsTotal % 3600;
            int minutes = secondsTotal / 60;
            int seconds = secondsTotal % 60;

            Console.WriteLine($"{days}days, {hours}hours, {minutes}minutes, {seconds}seconds");
        }
    }
}
