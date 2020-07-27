using System;

namespace MoreBucketsMoreFun
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare All The Things
            // (Usually it's a good idea to declare them at the beginning of the program)
            int butterflies, beetles, bugs;
            string color, size, shape, thing;
            double number;

            //Now give a couple of them some values
            butterflies = 2;
            beetles = 4;

            bugs = butterflies + beetles;
            Console.WriteLine("There are only  " + butterflies + butterflies);
            Console.WriteLine("but " + bugs + " bugs total.");

            Console.WriteLine("Uh oh, my dog ate one.");
            butterflies--;
            Console.WriteLine("Now there only " + butterflies + " butterlies left.");
            Console.WriteLine("But still " + bugs + " bugs left, wait a minute!!!");
            Console.WriteLine("Maybe I just counted wrong the first time...");
        }
    }
}
    