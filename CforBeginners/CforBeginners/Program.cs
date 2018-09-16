using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;


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
            var random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                
                Console.WriteLine(random.Next());
            }

        }

        static void fourthTask()
        {
            Console.WriteLine("fourth task");

            var input = "";

            while (true)
            {
                Console.WriteLine("Enter a name");
                input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                Console.WriteLine("Echo: {0}",input);

            }
        }

        static void fifthTask()
        {
            Console.WriteLine("fifth task");

            var friends = new List<string>();


            while (true)
            {
                Console.WriteLine("Enter a name:");
                var name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(name))
                    break;

                friends.Add(name);
            }

            if (friends.Count == 1)
                Console.WriteLine(friends[0] + " likes you");
            else if (friends.Count == 2)
                Console.WriteLine(friends[0] + " and " + friends[1] + " Like your post") ;
            else if (friends.Count > 2)
                Console.WriteLine(friends[0] + " and " + friends[1] + " and " + (friends.Count - 2) + " more Like your post") ;


            Console.WriteLine();
            
                

        }

    }
}
