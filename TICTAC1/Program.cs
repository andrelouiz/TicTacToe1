using System;

namespace TICTAC1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the tic-tac-toe game!");

            //game

            Console.WriteLine("What's the state of the first field?");
            Console.WriteLine("What's the state of the second field?");
            Console.WriteLine("What's the state of the third field?");
            Console.WriteLine("What's the state of the fourth field?");
            Console.WriteLine("What's the state of the fifth field?");
            Console.WriteLine("What's the state of the sixth field?");
            Console.WriteLine("What's the state of the seventh field?");
            Console.WriteLine("What's the state of the eight field?");
            Console.WriteLine("What's the state of the nineth field?");

            string a = (Console.ReadLine());
            string b = (Console.ReadLine());
            string c = (Console.ReadLine());
            string d = (Console.ReadLine());
            string e = (Console.ReadLine());
            string f = (Console.ReadLine());
            string g = (Console.ReadLine());
            string h = (Console.ReadLine());
            string i = (Console.ReadLine());

            //Board

            Console.WriteLine($" {a} | {b} | {c} ");
            Console.WriteLine("- - -+- - -+- - -");
            Console.WriteLine($" {d} | {e} | {f} ");
            Console.WriteLine("- - -+- - -+- - -");
            Console.WriteLine($" {g} | {h} | {i} ");


        }
    }
}
