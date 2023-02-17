namespace MAU2Assignment
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            //FunFeatures myFeature = new();
            //myFeature.Start();
            //ContinueToNextPart();
            //MathWorks mathObj = new();
            //mathObj.Start();
            TemperatureConverter myConverter = new();
            myConverter.Start();
        }

        private static void ContinueToNextPart()
        {
            Console.WriteLine("\nPRESS ENTER TO CONTINUE TO NEXT PART");
            Console.ReadLine();
            Console.Clear();
        }




    }
}