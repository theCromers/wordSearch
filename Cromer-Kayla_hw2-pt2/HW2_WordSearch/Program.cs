//declare all directives
using System;

namespace HW2_WordSearch
{
    class Program
    {
        public static void Main(string[] args)
        {
            //instantiate a WordPuzzle object
            WordPuzzle wp = new WordPuzzle();

            //EXAMPLE: Invoking methods from instantiated object wp
            wp.ParseWater();
            wp.PrintWater();
            wp.ParseBlackberry();
            wp.PrintBlackberry();
            wp.ParseBlueberry();
            wp.PrintBlueberry();
            wp.ParseLemon();
            wp.PrintLemon();
            wp.ParseRaspberry();
            wp.PrintRaspberry();
            wp.ParseCherry();
            wp.PrintCherry();
            wp.ParseFour();
            wp.PrintFour();
            wp.ParseStraw();
            wp.PrintStraw();
            wp.ParseLime();
            wp.PrintLime();

            Console.WriteLine();
            Console.WriteLine("all words presented. press enter to close the console.");
            Console.ReadLine(); //adding this line to prevent console closing
             
        }
    }

   
}
