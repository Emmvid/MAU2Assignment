namespace MAU2Assignment
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            FunFeatures myFeature = new();
            myFeature.Start();
            ContinueToNextPart();
            MathWorks mathObj = new();
            mathObj.Start();
            ContinueToNextPart();
            TemperatureConverter myConverter = new();
            myConverter.Start();
            //ContinueToNextPart();
            WorkingSchedule mySchedule = new();
            mySchedule.Start();
        }

        private static void ContinueToNextPart()
        {
            Console.WriteLine("\nPRESS ENTER TO CONTINUE TO NEXT PART");
            Console.ReadLine();
            Console.Clear();
        }




    }
}