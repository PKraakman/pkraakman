using System;


namespace CforBeginners
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 10");
            var input = Console.ReadLine();

            var inpNumber = Convert.ToInt32(input);

            switch (inpNumber)
            {
                case 1: firstTask();
                break;

                case 2: secondTask();
                break;

                case 3: thirdTask();
                break;

                case 4: fourthTask();
                break;

                case 5: fifthTask();
                break;
            }
        }

        private static void firstTask()
        {
            Console.WriteLine("first task");
        }
        static void secondTask()
        {
            Console.WriteLine("second task");
            Console.WriteLine("Enter first number");
            var input1 = Console.ReadLine();
            var n1 = Convert.ToInt32(input1);

            Console.WriteLine("Enter second number");
            var input2 = Console.ReadLine();
            var n2 = Convert.ToInt32(input2);

            Console.WriteLine((n1 > n2) ? n1 : n2);
        }

        static void thirdTask()
        {
            Console.WriteLine("third task");
        }

        static void fourthTask()
        {
            Console.WriteLine("fourth task");
        }

        static void fifthTask()
        {
            Console.WriteLine("fifth task");
        }
    }
}
