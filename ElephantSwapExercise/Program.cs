using System;

namespace ElephantSwapExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() {Name="Lucinda", EarSize=33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

            while (true) 
            {
                Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
                char userInput = Console.ReadKey(true).KeyChar;

                Console.WriteLine("You pressed " + userInput);

                if (userInput == '1')
                {
                    lloyd.WhoAmI();
                }
                else if (userInput == '2')
                {
                    lucinda.WhoAmI();
                }
                else if (userInput == '3')
                {
                    Elephant tempElephant;
                    tempElephant = lloyd;
                    lloyd = lucinda;
                    lucinda = tempElephant;
                    Console.WriteLine("References have been swapped.");
                }
                else if (userInput == '4')
                {
                    lloyd = lucinda;
                    lloyd.EarSize = 4321;
                    lloyd.WhoAmI();
                }
                else if (userInput == '5')
                {
                    lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
                }
                else
                {
                    return;
                }
                Console.WriteLine();

            }
        }
    }
}
