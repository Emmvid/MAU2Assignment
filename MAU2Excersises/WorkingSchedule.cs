using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MAU2Assignment
{
    /* I decided to just use the weeks per year, weekend work and night work as my variables and using them
     * to calculate the wheaatherter to work or not. Since the person works night every 4th week, I assign it the value of 4
     * and with the weekends the value of 2 since it is every other week. I use a for loop to determine which weeks the person 
     * is supposed to work, starting at week 1, until it reaches the weeks per year(52) and adding either 4 or 2 depending
     * if it calculates the night shifts or the weekends. I know that this would also be possible checking using a  modulus 
     * and an if-statement, but this just made more sense to me.*/
    internal class WorkingSchedule
    {
        private const int weeksPerYear = 52;
        private const int weekendWork = 2;
        private const int nightWork = 4;
        public void Start()
        {
            Console.WriteLine(" YOUR WORK SCHEDULE  ");
            ShowMenu();
        }
        private void ShowMenu()
        {
            int number;

            do 
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Show list of weekends");
                Console.WriteLine("2. Show list of night shifts");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
               bool sucess =  int.TryParse(Console.ReadLine(), out number);


                if (!sucess)// if the try parse return false it ask the user for new input.
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    
                }

                
                switch (number)
                {
                    case 0:
                        Console.WriteLine("Bye, bye!");
                        break;

                    case 1:
                        PrintWeekendShifts();
                        break;

                    case 2:
                        PrintNightShifts();
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please enter a valid option.");
                        break;
                }

                Console.WriteLine();
            }
            while (number != 0); // everything is wrapped in a do while, that runs while the user is not entering a 0
        }


        private void PrintWeekendShifts()
        {

            Console.WriteLine("Weeks with weekend shifts:");
            for (int week = 1; week <= weeksPerYear; week += weekendWork)
            {
                Console.WriteLine($"Week {week}");
            }
        }

        private void PrintNightShifts()
        {

            Console.WriteLine("Weeks with night shifts:");
            for (int week = 1; week <= weeksPerYear; week += nightWork)
            {
                Console.WriteLine($"Week {week}");
            }
        }

    }
}
