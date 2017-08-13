using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            // Give the user some instruction
            Console.WriteLine("Please enter up to 30 names. When you're done, hit enter");

            // Create an array of 30 items and a counter so you know how many they entered.
            var names = new string[30];
            var numberNamesEntered = 0;

            // Now loop thirty times
            // Notice I used < instead of <=. Any ideas why?
            for (int i = 0; i < 30; i++)
            {
                Console.Write("Please enter name #{0}: ", i + 1); // Any ideas what this + 1 thing is about??
                var userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput)) break;
                names[i] = userInput;
                numberNamesEntered = i; // This line has to go after the break for a specific reason... Can anybody guess why?
            }

            // Now, we have to pick a random name as a "winner"
            var rnd = new Random();
            var winner = rnd.Next(numberNamesEntered);

            Console.WriteLine("{0}Congratulations to {1}!! They won!", Environment.NewLine, names[winner]); // What the environment.newline does is put some "returns" in front of my text.

            // Now loop through the non winning names to write them out and skip the winner number:
            Console.WriteLine("{0}The \"Better Luck Next Time\" award goes to: ", Environment.NewLine); 

            for (int x = 0; x <= numberNamesEntered; x++) // What? Now I'm using <=?? How come?
            {
                if (x == winner) continue; // This skips the winner number.
                Console.WriteLine(names[x]);
            }

            Console.ReadLine();

        }
    }
}
