using System;


namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zips = { 52806, 52807, 52805, 52804, 52803, 52802, 52801, 52800, 58208, 52809 };
            string userInput;
            int zipsConverted;
            int i = 0;
            bool wrong = true;

            Console.Write("Please enter a five digit postal zipcode >>> ");
            userInput = Console.ReadLine();
            zipsConverted = Convert.ToInt32(userInput);

            while (i < 10)
            {
                if (zipsConverted == zips[i])
                {
                    wrong = false;
                    Console.WriteLine("You are in our delivery area");
                }
                else
                {

                }
                i++;
            }
            if (wrong == false)
            {

            }
            else if (wrong == true)
            {
                Console.WriteLine("You do not live in our delivery area");
            }


        }
    }
}
