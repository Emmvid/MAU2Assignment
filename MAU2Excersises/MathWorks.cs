namespace MAU2Assignment
{
    internal class MathWorks
    {
        public void Start()
        {
            do // always does the first two methods and continues until exitCalculation returns true.
            {
                PrintMultiplication();
                Calculate();
            }
            while (ExitCalculation());
        }
        private void PrintMultiplication()
        {
            Console.WriteLine();
            Console.WriteLine("  ****** Multiplication Table ******");
            for (int row = 1; row <= 12; row++)
            {
                for (int col = 1; col <= 12; col++)
                {
                    Console.Write(string.Format("{0,4:d} ", row * col));
                }
                Console.WriteLine();
            }
        }
        private void Calculate()
        {
            int startNum;
            int endNum;
            Console.WriteLine("Sum numbers between any two numbers");
            bool validInput;
            do
            {
                Console.Write("Give first number: ");
                validInput = int.TryParse(Console.ReadLine(), out startNum);

                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            } while (!validInput);

            do
            {
                Console.Write("Give second number: ");
                validInput = int.TryParse(Console.ReadLine(), out endNum);

                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a second number.");
                }
            } while (!validInput);
            if (startNum > endNum)
            {
                int tempNum = endNum;
                endNum = startNum;
                startNum = tempNum;
            }

            int sum = SumNumbers(startNum, endNum);
            Console.WriteLine($"The sum of numbers between {startNum} and {endNum} is {sum}");
            PrintEvenNumbers(startNum, endNum);
            Console.WriteLine();
            PrintOddNumbers(startNum, endNum);
            Console.WriteLine();
            CalculateSquareRoots(startNum, endNum);

        }
        private static int SumNumbers(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }
        private void PrintEvenNumbers(int number1, int number2)
        {
            Console.WriteLine($"The even numbers between {number1} and {number2} are:");
           
            for (int i = number1; i <= number2; i++)
            {
                if (i % 2 == 0)
                {
                   
                    Console.Write(i + " ");
                   
                }
            }
        }

        private void PrintOddNumbers(int number1, int number2)
        {
            Console.WriteLine($"The even numbers between {number1} and {number2} are:");
              
            for (int i = number1; i <= number2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        private void CalculateSquareRoots(int num1, int num2)
        {
            Console.WriteLine();
            Console.WriteLine(" ***** Square Roots *****");
            for (int i = num1; i <= num2; i++)
            {
                Console.Write("SQRT({0,3} to {1,3}): ", i, num2);
                for (int j = i; j <= num2; j++)
                {
                    double value = Math.Sqrt(j);
                    Console.Write(string.Format("{0,6:f2}", value));
                }
                Console.WriteLine();
            }
        }

        private bool ExitCalculation() // Returns the value of done, which is set to false until user enters no
        {
            bool done = false;
            bool responseOK = true;
            string response = String.Empty;
            do
            {
                Console.WriteLine("Exit MathWork? y/n");
                response = Console.ReadLine();
                response = response.ToLower();
                responseOK = true;
                if (response == "y")
                {
                    done = false;
                }
                else if (response == "n")
                {
                    done = true;
                }
                else
                {
                    responseOK = false;
                    Console.WriteLine("Invalid input, please try again");
                }
            } while (!responseOK);
            return done;
        }
    }
}
