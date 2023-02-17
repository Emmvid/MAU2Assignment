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
                    case 1:
                        CelsiusToFarenheit(0);
                        break;
                    case 2:
                        break;
                    case 0:
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
            double  
        }
        double CelsiusToFarenheit(double celsius)
        {
            const int max = 100;
            double farenheit = 0;

            while (celsius < max)
            {
                celsius += 4;
                farenheit = 9 / 5.0 * celsius + 32;
                Console.WriteLine(farenheit);
            }
            
            return farenheit;
        }
    }
}
