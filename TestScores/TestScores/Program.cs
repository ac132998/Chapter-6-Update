using System;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] scores = new int[8];
            int input;

            for (int i = 0; i < scores.Length; ++i)
            {
                Console.WriteLine("Please enter a test score # " + (i + 1));
                input = Convert.ToInt32(Console.ReadLine());
                scores[i] = input;

            }
            RunLine();
            DisplayScores(scores);
            DisplayTotal(scores);


        }
        public static void DisplayTotal(int[] scores)
        {
            int total = 0;
            int average = 0;

            for (int i = 0; i < scores.Length; ++i)
            {
                total = total + scores[i];
                average = total / scores.Length;
            }
            RunLine();
            Console.WriteLine(total);
            Console.WriteLine(average);

        }
        public static void DisplayScores(int[] scores)
        {
            Console.WriteLine("Scores in original order");

            for (int i = 0; i < scores.Length; ++i)
            {
                Console.Write("{0, 6} ", scores[i]);
            }

        }
        public static void RunLine()
        {
            Console.WriteLine("\n--------------------------------------------------------");

        }
    

    }
}
