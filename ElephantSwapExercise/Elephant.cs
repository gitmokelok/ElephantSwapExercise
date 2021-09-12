using System;
using System.Collections.Generic;
using System.Text;

namespace ElephantSwapExercise
{
    class Elephant
    {
        public string Name;
        public int EarSize;

        public void WhoAmI() 
        {
            Console.WriteLine("Calling " + this.Name + ".WhoAmI()");
            Console.WriteLine("My name is " + this.Name + ".");
            Console.WriteLine("My ears are " + EarSize + " inches tall.");
        }
    }
}
