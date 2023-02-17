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
            if (success)
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
            else
            {
                Console.WriteLine("You need to pick a number");
            }

           

        }

        private void ShowCelsiusToFarenheit()
        {
            Console.WriteLine("You have chosen nr 1");
            CelsiusToFarenheit(0);
            
        }
        double CelsiusToFarenheit(double startCelsius)
        {
            const int maxCelsius = 100;
            double farenheit = 0;


            for (double celsius = startCelsius; celsius <= maxCelsius; celsius += 4)
            {
                farenheit = 9 / 5.0 * celsius + 32;
                
                Console.WriteLine($"{celsius:f2} °C = {farenheit:f2} °F");
            }
            
            return farenheit;
        }


        private void ShowFarenheitToCelsius()
        {
            Console.WriteLine("You have chosen nr 2");
            FarenheitToCelsuis(0);

        } 
        double FarenheitToCelsuis(double startFarenheit)
        {
            const int maxFarenheit = 210;
            double celsius = 0; 
            for(double farenheit = startFarenheit; farenheit <= maxFarenheit; farenheit += 5)
            {
                celsius = 5 / 9.0 * (farenheit - 32);
                Console.WriteLine($" {farenheit:f2} °F = {celsius:f2} °C");
            }
            return celsius;
        }


    }
}
