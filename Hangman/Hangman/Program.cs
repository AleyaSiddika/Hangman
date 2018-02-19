using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {


            int i;
            int checkWord = 5;
            Random ran = new Random();
            string[] mywords = new string[4] { "light", "dark", "sun","forest"};
            
            int index = ran.Next(0, 3);
            char[] hide = new char[mywords[index].Length];
            string guessword = mywords[index];
            Console.WriteLine("                                    WELCOME TO HAMGMAN!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Please enter your name: ");
            Console.ReadLine();

            Console.Write("Guess the word:");

            for (i = 0; i < hide.Length; i++)
            {
                Console.Write(" _ ");
                hide[i] = '-';
            }
            Console.WriteLine();
            if (checkWord != 0)
            {

                for (int j = 0; j < hide.Length; j++)
                {

                    Console.Write("Guess :");
                    char inputWord = Console.ReadLine().ToCharArray()[0];
                    if (inputWord == guessword[j])
                    {
                        hide[j] = inputWord;
                        Console.WriteLine("charecter matched");


                    }
                    else
                    {
                        Console.WriteLine("charecter doesn't matched");
                        checkWord--;
                        Console.WriteLine("life : {0}", checkWord);
                        j--;
                        if (checkWord == 4)
                        {
                            Program.hangman1();
                            Console.WriteLine("You have 4 lives left");
                        }
                        else if (checkWord == 3)
                        {
                            Program.hangman2();
                            Console.WriteLine("You have 3 lives left");
                        }
                        else if (checkWord == 2)
                        {
                            Program.hangman3();
                            Console.WriteLine("You have 2 lives left");
                        }
                        else if (checkWord == 1)
                        {
                            Program.hangman3();
                            Console.WriteLine("You have 1 lives left");
                        }
                        else if (checkWord == 0)
                        {
                            Program.hangman();
                            break;
                        }

                    }
                }
            }


            Console.WriteLine("your word :"+guessword);
            Program.hangmanWin();
            Console.WriteLine("You win");
            Console.ReadLine();
        }

        
        public static void hangman()
         {
             Console.WriteLine("             ||----------|-------|");
             Console.WriteLine("             ||          |");
             Console.WriteLine("             ||        (*_*)");
             Console.WriteLine("             ||          |");
             Console.WriteLine("             ||         /|\\");
             Console.WriteLine("             ||        / | \\");
             Console.WriteLine("             ||          |");
             Console.WriteLine("             ||         / \\");
             Console.WriteLine("             ||        /   \\");
             Console.WriteLine("             ||");
             Console.WriteLine("             ||");
             Console.WriteLine("             ||______________________________");
             Console.WriteLine("You Lose");
         }
         public static void hangman1()
         {
             Console.WriteLine("             ||------------------|");
             Console.WriteLine("             ||          ");
             Console.WriteLine("             ||        ");
             Console.WriteLine("             ||          ");
             Console.WriteLine("             ||         ");
             Console.WriteLine("             ||        ");
             Console.WriteLine("             ||          ");
             Console.WriteLine("             ||         ");
             Console.WriteLine("             ||        ");
             Console.WriteLine("             ||");
             Console.WriteLine("             ||");
             Console.WriteLine("             ||______________________________");
         }
         public static void hangman2()
         {
             Console.WriteLine("             ||----------|-------|");
             Console.WriteLine("             ||          |");
             Console.WriteLine("             ||        (*_*)");
             Console.WriteLine("             ||          |");
             Console.WriteLine("             ||         ");
             Console.WriteLine("             ||        ");
             Console.WriteLine("             ||          ");
             Console.WriteLine("             ||        ");
             Console.WriteLine("             ||       ");
             Console.WriteLine("             ||");
             Console.WriteLine("             ||");
             Console.WriteLine("             ||______________________________");
         }
         public static void hangman3()
         {
             Console.WriteLine("             ||----------|-------|");
             Console.WriteLine("             ||          |");
             Console.WriteLine("             ||        (*_*)");
             Console.WriteLine("             ||          |");
             Console.WriteLine("             ||         /|\\");
             Console.WriteLine("             ||        / | \\");
             Console.WriteLine("             ||          ");
             Console.WriteLine("             ||         ");
             Console.WriteLine("             ||        ");
             Console.WriteLine("             ||");
             Console.WriteLine("             ||");
             Console.WriteLine("             ||______________________________");
          
         }

        
        public static void hangmanWin()
        {
            Console.WriteLine("             ||----------|-------|");
            Console.WriteLine("             ||           ");
            Console.WriteLine("             ||           ");
            Console.WriteLine("             ||           ");
            Console.WriteLine("             ||      (* _ *)");
           
            Console.WriteLine("             ||         |");
            Console.WriteLine("             ||       \\ | /");
            Console.WriteLine("             ||        \\|/");
            Console.WriteLine("             ||         |");
            Console.WriteLine("             ||        _|_");
            Console.WriteLine("             ||       |   |");
            Console.WriteLine("             ||_______|___|__________________");
            
        }

    }
}