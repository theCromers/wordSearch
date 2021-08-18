using System;

namespace HW2_WordSearch
{
   
    class WordPuzzle
    {
        //Declare fields/class variables
        //Given strings
        string line01 = "BSADWATERL";
        string line02 = "BLACKBERRY";
        string line03 = "KIUOETNAHE";
        string line04 = "CIIEATTSAJ";
        string line05 = "SHWNBSIPEA";
        string line06 = "SFEIIEOBYL";
        string line07 = "KTOROIRECE";
        string line08 = "AERURBLRNM";
        string line09 = "RKHARYARYO";
        string line10 = "LIMEWHNYAN";

        //YOUR HOMEWORK SOLUTION CODE GOES BELOW HERE
        //Solution strings
        //ADVISE: name the with identifiers that are the same as the
        //9 words you must parse from the 10 strings below.
        string waterSolution;//EXAMPLE


        // Constructor goes here
        public WordPuzzle()
        {
            
            
        }

        /* Parse and Print methods that extract string parts
        *  and methods that concatenate those parts go here
        */

        //EXAMPLE for WATER: Declared string parsing method
        public string ParseWater()
        {
            //declare temporary method variable
            //to hold result of string being built
            string waterBuild;
            //assign result of parsed substring
            waterBuild = line01.Substring(4,5);

            //required output of method
            return waterBuild;
        }
        
        public string ParseBlackberry()
        {
            //temporary method variable
            string blackberryBuild;
            //result of string
            blackberryBuild = line02.Substring(0, 10);

            //output of method
            return blackberryBuild;
        }

        public string ParseBlueberry()
        {
            //temporary method
            string blueberryBuild; 
            //string result
            blueberryBuild = line01.Substring(0,1) + line02.Substring(1,1) + line03.Substring(2,1) + line04.Substring(3,1) + line05.Substring(4,1) + line06.Substring(5,1) + line07.Substring(6,1) + line08.Substring(7,1) + line09.Substring(8,1);

            //output of method
            return blueberryBuild;
        }

        public string ParseLemon()
        {
            //temporary method
            string lemonBuild;
            //string result
            lemonBuild = line06.Substring(9, 1) + line07.Substring(9,1) + line08.Substring(9,1) + line09.Substring(9,1) + line10.Substring(9,1);

            //output of method
            return lemonBuild;
        }
        public string ParseRaspberry()
        {
            //temporary method
            string raspBuild;
            //string result
            raspBuild = line02.Substring(7, 1) + line03.Substring(7,1) + line04.Substring(7,1) + line05.Substring(7,1) + line06.Substring(7,1) + line07.Substring(7,1) + line08.Substring(7,1) + line09.Substring(7,1) + line10.Substring(7,1);

            //output method
            return raspBuild;
        }
        public string ParseCherry()
        {
            //temporary method
            string cherryBuild;
            //string reault
            cherryBuild = line04.Substring(0, 1) + line05.Substring(1,1) + line06.Substring(2,1) + line07.Substring(3,1) + line08.Substring(4,1) + line09.Substring(5,1);

            //return 
            return cherryBuild;
        }
        public string ParseFour()
        {
            //temporary method
            string fourBuild;
            //string result
            fourBuild = line06.Substring(1, 1) +line07.Substring(2,1) + line08.Substring(3,1) + line09.Substring(4,1);

            //return
            return fourBuild;
        }
        public string ParseStraw()
        {
            //temporary method
            string strawBuild;
            //string result
            strawBuild = line06.Substring(0, 1) + line07.Substring(1,1) + line08.Substring(2,1) + line09.Substring(3,1) + line10.Substring(4,1);

            //return
            return strawBuild;
        }
        public string ParseLime()
        {
            //temporary method
            string limeBuild;
            //string result
            limeBuild = line10.Substring(0, 4);

            //return
            return limeBuild;
        }

        /* Last method prints the final found 10 words 
        *  to the console.
        */

        //EXAMPLE: Utility method that prints
        public void PrintWater()
        {
            Console.WriteLine(ParseWater());
        }
        public void PrintBlackberry() //blackberry shows up 2nd with method under word water
        {
            Console.WriteLine(ParseBlackberry());
        }
        public void PrintBlueberry() //blueberry shows up 3rd
        {
            Console.WriteLine(ParseBlueberry());
        }
        public void PrintLemon() //lemon is 4th word
        {
            Console.WriteLine(ParseLemon());
        }

        public void PrintRaspberry() //raspberry is 5th
        {
            Console.WriteLine(ParseRaspberry());
        }

        public void PrintCherry() //cherry is 6th
        {
            Console.WriteLine(ParseCherry());
        }

        public void PrintFour() //four is 7th
        {
            Console.WriteLine(ParseFour());
        }
        public void PrintStraw() //straw is 8th
        {
            Console.WriteLine(ParseStraw());
        }
       public void PrintLime() //lime is the last word
        {
            Console.WriteLine(ParseLime());
        } 
    }
}
