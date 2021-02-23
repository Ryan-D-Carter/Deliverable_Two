using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chat Bot!");

            Console.WriteLine("What would you like to say to the bot?");

            var previousInput = "";
            var repeat = true;
            while (repeat)
            {

                var input = Console.ReadLine().ToLower();

                if (input == previousInput)
                {
                    Console.WriteLine("I'm sorry but you have already said that");
                    continue;
                }

                switch (input)
                {
                    case "hello":
                        Console.WriteLine("Hi good to see you");
                        break;

                    case "bye":
                        Console.WriteLine("Good bye!");
                        break;

                    case "sup":
                        Console.WriteLine("I am good");
                        break;

                    case "hello there":
                        Console.WriteLine("General Kenobi");
                        break;
                }
                

                if (input != "bye")
                {
                    Console.WriteLine("Say something else to the bot");
                }
                else
                {
                    repeat = false;
                }

                previousInput = input;
            }
        }
    }
}
