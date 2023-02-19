using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAU2Assignment
{
    internal class TemperatureConverter
    {
        public void Start()
        {
            Console.WriteLine("     TEMPERATUR CONVERTER     ");
            ShowMenu();
            
           
        }
        public void ShowMenu()
        {
            int number;
            string response;
            Console.WriteLine(" Celsius to Fahrenheit    :1");
            Console.WriteLine(" Farenheit to Celsius     :2");
            Console.WriteLine(" Exit                     :0");
            response = Console.ReadLine();

            bool success = int.TryParse(response, out number);
            if (success)// if the tryparse returns true, this will be done
            {
                switch (number)
                {
                    case 0:
                        break;
                    case 1:
                        ShowCelsiusToFarenheit();
                        break;
                    case 2:
                        ShowFarenheitToCelsius();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }


            }
            else// if the tryparse return false, this will be done.
            {
                Console.WriteLine("You need to pick a number");
            }

           

        }

        private void ShowCelsiusToFarenheit()
        {
            Console.WriteLine("You have chosen nr 1");
            CelsiusToFarenheit(0); // 0 is passed as an argument, meaning that it the startCelsius will be 0
            
        }
        double CelsiusToFarenheit(double startCelsius)
        {
            const int maxCelsius = 100;
            double farenheit = 0;


            for (double celsius = startCelsius; celsius <= maxCelsius; celsius += 4) // adds 4 degrees celsius for every iteration
            {
                farenheit = 9 / 5.0 * celsius + 32;
                
                Console.WriteLine($"{celsius:f2} °C = {farenheit:f2} °F");
            }
            
            return farenheit;
        }


        private void ShowFarenheitToCelsius()
        {
            Console.WriteLine("You have chosen nr 2");
            FarenheitToCelsuis(0); // 0 is passed as an argument, meaning that it the startFarenheit will be 0

        } 
        double FarenheitToCelsuis(double startFarenheit)
        {
            const int maxFarenheit = 210; // The maximum farenheit degrees, used in the for loop on line 89.
            double celsius = 0; 
            for(double farenheit = startFarenheit; farenheit <= maxFarenheit; farenheit += 5) //startFarenheit is the value passed in the method call. It will add 5 for every iteration.
            {
                celsius = 5 / 9.0 * (farenheit - 32);
                Console.WriteLine($" {farenheit:f2} °F = {celsius:f2} °C"); // f2 means it will have two decimals.
            }
            return celsius;
        }


    }
}
