using System;


namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temperature = new int[7];
            int input;
            double average = 0;


            for (int i = 0; i < temperature.Length; ++i)
            {
                Console.WriteLine("Please enter the temperature on Day " + (i + 1));
                input = Convert.ToInt32(Console.ReadLine());
                temperature[i] = input;


            }
            RunLine();
            DisplayTemperatures(temperature, average);
            DisplayDifferenceFromAverage(temperature, average);

        }
        public static void DisplayTemperatures(int[] temperature, double average)
        { 
            int total = 0;

            for (int i = 0; i < temperature.Length; ++i)
            {
                Console.WriteLine("{0 , 6}", temperature[i]);
                total = total + temperature[i];
            }
            average = total / 7;
            Console.WriteLine("The average temperature this week is " + average);

        }
        public static void DisplayDifferenceFromAverage(int[] temperature, double average)
        {

            for (int i = 0; i < temperature.Length; i++)
            {
              Console.WriteLine("The temperature on day " + (i + 1) + " is " + temperature[i] +
                        " degrees, and it is " + Math.Abs(temperature[i] - average) + " degrees away from the average.");
            }
             
        }
        public static void RunLine()
        {
            Console.WriteLine("\n--------------------------------------------------------");

        }
    }
}