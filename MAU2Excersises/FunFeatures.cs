using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MAU2Assignment
{
    internal class FunFeatures
    {
        private string? _name = "";
        private string? _email = "";

        public void Start()
        {
            do
            {
                Introduce();
                FortuneTeller();
                CalculateStringLength();
            }
            while (RunAgain());


        }

        private void Introduce()
        {

            Console.WriteLine("My name is Emma and I am a student of the spring semester 2023!");
            Console.WriteLine("Let me know about yourself!");
            ReadName();
            ReadEmail();
            Console.WriteLine($"Nice to meet you {_name}\nYour email is {_email}");
        }
        private void ReadName()
        {
            Console.Write("Your first name please: ");
            string firstName = Console.ReadLine();
            Console.Write("Your last name please: ");
            string lastName = Console.ReadLine();
            _name = lastName.ToUpper() + ", " + firstName;
        }
        private void ReadEmail()
        {
            Console.Write("Your email please: ");
            _email = Console.ReadLine();
            Console.WriteLine();
        }
        private bool RunAgain()
        {
            bool again = false;
            Console.WriteLine("Would you like to run the program again? Type yes.");
            string answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer == "yes")
            {
                again = true;
            }
            return again;

        }
        private void FortuneTeller()
        {
            int day;
            Console.WriteLine();
            Console.WriteLine(" **** FORTUNE TELLER *****");

            while (true) // Reruns the method if the user enters something that isnt a number.
            {
                Console.Write("Select a number between 1 and 7: ");
                bool parsedDay = int.TryParse(Console.ReadLine(), out day);

                if (parsedDay)
                { 
                    string fortune = string.Empty;

                    switch (day)
                    {
                        case 1:
                            fortune = "Keep calm on Mondays! You can fall apart";
                            break;
                        case 2:
                        case 3:
                            fortune = "Tuesdays and Wednesdays break your heart";
                            break;
                        case 4:
                            fortune = "Thursdays doesn't even start!";
                            break;
                        case 5:
                            fortune = "It's friday, you're in love!";
                            break;
                        case 6:
                            fortune = "Saturday, do nothing at all!";
                            break;
                        case 7:
                            fortune = "And Sunday always comes too late";
                            break;
                        default:
                            fortune = "No day? Must be a good day even though it doesn't exist!";// If the user enters a number thats not 1-7
                            break;
                    }

                    Console.WriteLine(fortune);
                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 7."); // this catches the program if the user enters something that isn't a number.
                }
            }
        }

        private void CalculateStringLength()
        {
            Console.WriteLine("----STRENGTH lENGTH----");
            Console.WriteLine("Write a text with any number of characters and press Enter.");
            Console.WriteLine("You can even copy a text from a file and paste it here!");
            string input = Console.ReadLine();
            int length = input.Length;
            string upperCase = input.ToUpper(); 
            Console.WriteLine(upperCase);
            Console.WriteLine($"Number of chars = {length}");

        }
    }
}
