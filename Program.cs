using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a board by third person 
            Console.WriteLine("x1 y1 :");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x1 y2 :");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x1 y3 :");
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2 y1 :");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2 y2 :");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2 y3 :");
            int b3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x3 y1 :");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x3 y2 :");
            int c2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x3 y3 :");
            int c3 = Convert.ToInt32(Console.ReadLine());

            // print board 
            Console.WriteLine("  1 2 3 ");
            Console.WriteLine(" + - - - +");
            Console.WriteLine($"1| {a1} {a2} {a3} |");
            Console.WriteLine($"2| {b1} {b2} {b3} |");
            Console.WriteLine($"3| {c1} {c2} {c3} |");
            Console.WriteLine(" + - - - +");
           


            // we write code in while loop because we want to play when we have new series
            while (true) {

                // move the selected column 
                Console.WriteLine("Which column do you want to move?");
                int move = Convert.ToInt32(Console.ReadLine());
                int a_1 = a1;
                int a_2 = a2;
                int a_3 = a3;
                int b_1 = b1;
                int b_2 = b2;
                int b_3 = b3;
                int c_1 = c1;
                int c_2 = c2;
                int c_3 = c3;
                // swich is a statement 
                switch (move)
                {
                    case (1):
                        a1 = a_3;
                        a2 = a_1;
                        a3 = a_2;
                        break;
                    case (2):
                        b1 = b_3;
                        b2 = b_1;
                        b3 = b_2;
                        break;
                    case (3):
                        c1 = c_3;
                        c2 = c_1;
                        c3 = c_2;
                        break;
                    case (4):
                        a1 = c_1;
                        b1 = a_1;
                        c1 = b_1;
                        break;
                    case (5):
                        a2 = c_2;
                        b2 = a_2;
                        c2 = b_2;
                        break;
                    case (6):
                        a3 = c_3;
                        b3 = a_3;
                        c3 = b_3;
                        break;
                }
                // print moved board 
                Console.WriteLine("  1 2 3 ");
                Console.WriteLine(" + - - - +");
                Console.WriteLine($"1| {a1} {a2} {a3} |");
                Console.WriteLine($"2| {b1} {b2} {b3} |");
                Console.WriteLine($"3| {c1} {c2} {c3} |");
                Console.WriteLine(" + - - - +");
                
            }


            // statment of the board 0

            int board = 0;
            if (a1 == a2 - 1 && a2 == a3 - 1 || a3 == a2 - 1 && a2 == a1 - 1)
            {
                if (board == 1)
                {
                    board = 4;
                }
                if (board == 4)
                {
                    board = 9;
                }
                else
                {
                    board = 1;
                }
            }
            if (b1 == b2 - 1 && b2 == b3 - 1 || b3 == b2 - 1 && b2 == b1 - 1)
            {
                if (board == 1)
                {
                    board = 4;
                }
                else if (board == 4)
                {
                    board = 9;
                }
                else
                {
                    board = 1;
                }
            }
            if (c1 == c2 - 1 && c2 == c3 - 1 || c3 == c2 - 1 && c2 == c1 - 1)
            {
                if (board == 1)
                {
                    board = 4;
                }
                else if (board == 4)
                {
                    board = 9;
                }
                else
                {
                    board = 1;
                }
            }
            if (a1 == b1 - 1 && b1 == c1 - 1 || c1 == b1 - 1 && b1 == a1 - 1)
            {
                if (board == 1)
                {
                    board = 4;
                }
                else if (board == 4)
                {
                    board = 9;
                }
                else
                {
                    board = 1;
                }
            }
            if (a2 == b2 - 1 && b2 == c2 - 1 || c2 == b2 - 1 && b2 == a2 - 1)
            {
                if (board == 1)
                {
                    board = 4;
                }
                else if (board == 4)
                {
                    board = 9;
                }
                else
                {
                    board = 1;
                }
            }
            if (a3 == b3 - 1 && b3 == c3 - 1 || c3 == b3 - 1 && b3 == a3 - 1)
            {
                if (board == 1)
                {
                    board = 4;
                }
                else if (board == 4)
                {
                    board = 9;
                }
                else
                {
                    board = 1;
                }
            }
            Console.WriteLine(board);


            // 

        }
    }
}
