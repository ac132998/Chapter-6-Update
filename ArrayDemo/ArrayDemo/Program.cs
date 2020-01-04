using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany;
            Console.WriteLine("How many numbers are you going to enter?");
            howMany = Convert.ToInt32(Console.ReadLine());
            int[] eightNums = new int[howMany];
            int userEntry;

            for (int i = 0; i < eightNums.Length; ++i)
            {
                Console.WriteLine("Please enter a number >>>> ");
                eightNums[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("How do you want to see the information?\n" +
                "1) First to Last?\n" +
                "2) Last to First?\n" +
                "3) Choose a specific position\n" +
                "4) To exit press 999\n");
            userEntry = Convert.ToInt32(Console.ReadLine());
            if (userEntry == 1)
            {
                DisplayFirstToLast(eightNums);
            }
            else if (userEntry == 2)
            {
                DisplayLastToFirst(eightNums);
            }
            else if (userEntry == 3)
            {
                Console.WriteLine("What position would you like the information to be in?");
            }
            else if (userEntry == 999)
            {

            }

        }
        public static void DisplayFirstToLast(int[] eightNums)
        {
            Array.Sort(eightNums);
            for (int i = 0; i < eightNums.Length; ++i)
            {
                Console.WriteLine(eightNums[i]);
            }


        }
        public static void DisplayLastToFirst(int[] eightNums)
        {
            Array.Reverse(eightNums);
            for (int i = 0; i < eightNums.Length; ++i)
            {
                Console.WriteLine(eightNums[i]);
            }
        }
        public static void DisplaySpecificPosition(int[] eightNums)
        {
            for (int i = 0; i < eightNums.Length; ++i)
            {
                Console.WriteLine(eightNums[i]);

            }

        }
    

    }
}
