using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
            int round = 1;

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
            Console.WriteLine($"----------Round {round}----------");
            Console.WriteLine("    1 2 3 ");
            Console.WriteLine("  + - - - +");
            Console.WriteLine($"1 | {a1} {a2} {a3} |");
            Console.WriteLine($"2 | {b1} {b2} {b3} |");
            Console.WriteLine($"3 | {c1} {c2} {c3} |");
            Console.WriteLine("  + - - - +");

            int comboCounter = 0;
            int score = 0;
            //1. SATIR KONTROLÜ
            if (((a1 == a2 - 1) && (a2 == a3 - 1)) || ((a1 == a2 + 1) && (a2 == a3 + 1)))
            {
                comboCounter++;
            }
            //2. SATIR CONTROL
            if (((b1 == b2 - 1) && (b2 == b3 - 1)) || ((b1 == b2 + 1) && (b2 == b3 + 1)))
            {
                comboCounter++;
            }
            //3. SATIR KONTROL
            if (((c1 == c2 - 1) && (c2 == c3 - 1)) || ((c1 == c2 + 1) && (c2 == c3 + 1)))
            {
                comboCounter++;
            }
            //1. SÜTUN KONTROL
            if (((a1 == b1 - 1) && (b1 == c1 - 1)) || ((a1 == b1 + 1) && (b1 == c1 + 1)))
            {
                comboCounter++;
            }
            //2. SÜTUN KONTROL
            if (((a2 == b2 - 1) && (b2 == c2 - 1)) || ((a2 == b2 + 1) && (b2 == c2 + 1)))
            {
                comboCounter++;
            }
            //3. SÜTUN KONTROL
            if (((a3 == b3 - 1) && (b3 == c3 - 1)) || ((a3 == b3 + 1) && (b3 == c3 + 1)))
            {
                comboCounter++;
            }
            //SAĞDAN SOLA ÇAPRAZ KONTROL
            if (((a3 == b2 - 1) && (b2 == c1 - 1)) || ((a3 == b2 + 1) && (b2 == c1 + 1)))
            {
                comboCounter++;
            }
            //SOLDAN SAĞA ÇAPRAZ KONTROL
            if (((a1 == b2 - 1) && (b2 == c3 - 1)) || ((a1 == b2 + 1) && (b2 == c3 + 1)))
            {
                comboCounter++;
            }

            if (comboCounter == 1)
            {
                score = 1;
            }
            if (comboCounter == 2)
            {
                score = 4;
            }
            if (comboCounter == 3)
            {
                score = 9;
            }

            int boardScore = score;
            int playerScore = 0;
            int computerScore = 0;
            Console.WriteLine($"Board Score: {boardScore}");
            Console.WriteLine($"Player Score: {playerScore}");
            Console.WriteLine($"Computer Score: {computerScore}");


            bool turn = true;
            int moveCounter = 1;
            string whoPlayer;

            // tahtanın skoru sıfırlanana kadar bu döngüde kalacak
            while (boardScore != 0)
            {
                if (turn)
                {
                    whoPlayer = "Player";
                    Console.WriteLine($"Turn : {moveCounter} / {whoPlayer}");
                }
                else
                {
                    whoPlayer = "Computer";
                    Console.WriteLine($"Turn : {moveCounter} / {whoPlayer}");
                }

                // move the selected column 
                int move;
                if (turn)
                {
                    Console.WriteLine("Which column do you want to move?");
                    move = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("When you enter any button computer going to play");
                    Console.ReadLine();
                    Random random = new Random();
                    move = random.Next(1, 7);
                    Console.WriteLine($"Command: {move}");
                }
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
                Console.WriteLine($"----------Round {round}----------");
                Console.WriteLine("   1 2 3  ");
                Console.WriteLine(" + - - - +");
                Console.WriteLine($"1| {a1} {a2} {a3} |");
                Console.WriteLine($"2| {b1} {b2} {b3} |");
                Console.WriteLine($"3| {c1} {c2} {c3} |");
                Console.WriteLine(" + - - - +");


                //SCORE CONTROL
                comboCounter = 0;
                score = 0;
                //1. SATIR KONTROLÜ
                if (((a1 == a2 - 1) && (a2 == a3 - 1)) || ((a1 == a2 + 1) && (a2 == a3 + 1)))
                {
                    comboCounter++;
                }
                //2. SATIR CONTROL
                if (((b1 == b2 - 1) && (b2 == b3 - 1)) || ((b1 == b2 + 1) && (b2 == b3 + 1)))
                {
                    comboCounter++;
                }
                //3. SATIR KONTROL
                if (((c1 == c2 - 1) && (c2 == c3 - 1)) || ((c1 == c2 + 1) && (c2 == c3 + 1)))
                {
                    comboCounter++;
                }
                //1. SÜTUN KONTROL
                if (((a1 == b1 - 1) && (b1 == c1 - 1)) || ((a1 == b1 + 1) && (b1 == c1 + 1)))
                {
                    comboCounter++;
                }
                //2. SÜTUN KONTROL
                if (((a2 == b2 - 1) && (b2 == c2 - 1)) || ((a2 == b2 + 1) && (b2 == c2 + 1)))
                {
                    comboCounter++;
                }
                //3. SÜTUN KONTROL
                if (((a3 == b3 - 1) && (b3 == c3 - 1)) || ((a3 == b3 + 1) && (b3 == c3 + 1)))
                {
                    comboCounter++;
                }
                //SAĞDAN SOLA ÇAPRAZ KONTROL
                if (((a3 == b2 - 1) && (b2 == c1 - 1)) || ((a3 == b2 + 1) && (b2 == c1 + 1)))
                {
                    comboCounter++;
                }
                //SOLDAN SAĞA ÇAPRAZ KONTROL
                if (((a1 == b2 - 1) && (b2 == c3 - 1)) || ((a1 == b2 + 1) && (b2 == c3 + 1)))
                {
                    comboCounter++;
                }

                if (comboCounter == 1)
                {
                    score = 1;
                }
                if (comboCounter == 2)
                {
                    score = 4;
                }
                if (comboCounter == 3)
                {
                    score = 9;
                }
                boardScore = score;

                Console.WriteLine($"Board Score: {boardScore}");
                Console.WriteLine($"Player Score: {playerScore}");
                Console.WriteLine($"Computer Score: {computerScore}");

                if (turn)
                {
                    turn = false;
                    moveCounter++;
                }
                else
                {
                    turn = true;
                    moveCounter++;
                }
            }
            // we write code in while loop because we want to play when we have new series
            int roundpre = round;
            int computerscorepre = 0;
            int playerscorepre = 0;
            while (round < 6)
            {
                if (roundpre != round)
                {
                    turn = true;
                    moveCounter = 1;
                    roundpre = round;
                }
                if (turn)
                {
                    whoPlayer = "Player";
                    Console.WriteLine($"Turn : {moveCounter} / {whoPlayer}");
                }
                else
                {
                    whoPlayer = "Computer";
                    Console.WriteLine($"Turn : {moveCounter} / {whoPlayer}");
                }

                // move the selected column 
                int move;
                int a_1 = a1;
                int a_2 = a2;
                int a_3 = a3;
                int b_1 = b1;
                int b_2 = b2;
                int b_3 = b3;
                int c_1 = c1;
                int c_2 = c2;
                int c_3 = c3;
                if (turn)
                {
                    Console.WriteLine("Which column do you want to move?");
                    move = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("When you enter any button computer going to play");
                    Console.ReadLine();
                    Random random = new Random();

                    // check the right move if it can ************************************************
                    int checkCounter = 1;
                    int bestOption = 0;
                    int option = 0;
                    int bestPoint = 0;

                    while ( checkCounter < 7)
                    {
                        switch (checkCounter)
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
                        comboCounter = 0;
                        score = 0;
                        //1. SATIR KONTROLÜ
                        if (((a1 == a2 - 1) && (a2 == a3 - 1)) || ((a1 == a2 + 1) && (a2 == a3 + 1)))
                        {
                            comboCounter++;
                        }
                        //2. SATIR CONTROL
                        if (((b1 == b2 - 1) && (b2 == b3 - 1)) || ((b1 == b2 + 1) && (b2 == b3 + 1)))
                        {
                            comboCounter++;
                        }
                        //3. SATIR KONTROL
                        if (((c1 == c2 - 1) && (c2 == c3 - 1)) || ((c1 == c2 + 1) && (c2 == c3 + 1)))
                        {
                            comboCounter++;
                        }
                        //1. SÜTUN KONTROL
                        if (((a1 == b1 - 1) && (b1 == c1 - 1)) || ((a1 == b1 + 1) && (b1 == c1 + 1)))
                        {
                            comboCounter++;
                        }
                        //2. SÜTUN KONTROL
                        if (((a2 == b2 - 1) && (b2 == c2 - 1)) || ((a2 == b2 + 1) && (b2 == c2 + 1)))
                        {
                            comboCounter++;
                        }
                        //3. SÜTUN KONTROL
                        if (((a3 == b3 - 1) && (b3 == c3 - 1)) || ((a3 == b3 + 1) && (b3 == c3 + 1)))
                        {
                            comboCounter++;
                        }
                        //SAĞDAN SOLA ÇAPRAZ KONTROL
                        if (((a3 == b2 - 1) && (b2 == c1 - 1)) || ((a3 == b2 + 1) && (b2 == c1 + 1)))
                        {
                            comboCounter++;
                        }
                        //SOLDAN SAĞA ÇAPRAZ KONTROL
                        if (((a1 == b2 - 1) && (b2 == c3 - 1)) || ((a1 == b2 + 1) && (b2 == c3 + 1)))
                        {
                            comboCounter++;
                        }

                        if (comboCounter == 1)
                        {
                            score = 1;
                            
                        }
                        if (comboCounter == 2)
                        {
                            score = 4;
                            
                        }
                        if (comboCounter == 3)
                        {
                            score = 9;
                            

                        }
                        if (bestPoint < score)
                        {
                            bestPoint = score;
                            option = checkCounter;
                        }

                        if (option>bestOption)
                        {
                            bestOption = option;
                        }
                        switch (checkCounter)
                        {
                            case (1):
                                a1 = a_1;
                                a2 = a_2;
                                a3 = a_3;
                                break;
                            case (2):
                                b1 = b_1;
                                b2 = b_2;
                                b3 = b_3;
                                break;
                            case (3):
                                c1 = c_1;
                                c2 = c_2;
                                c3 = c_3;
                                break;
                            case (4):
                                a1 = a_1;
                                b1 = b_1;
                                c1 = c_1;
                                break;
                            case (5):
                                a2 = a_2;
                                b2 = b_2;
                                c2 = c_2;
                                break;
                            case (6):
                                a3 = a_3;
                                b3 = b_3;
                                c3 = c_3;
                                break;
                        }
                        checkCounter++;
                    }

                    if (bestOption > 0)
                    {
                        move = bestOption;
                    }
                    else {
                        move = random.Next(1, 7);
                    }   
                    Console.WriteLine($"Command: {move}");
                }
                
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
                Console.WriteLine($"----------Round {round}----------");
                Console.WriteLine("   1 2 3  ");
                Console.WriteLine(" + - - - +");
                Console.WriteLine($"1| {a1} {a2} {a3} |");
                Console.WriteLine($"2| {b1} {b2} {b3} |");
                Console.WriteLine($"3| {c1} {c2} {c3} |");
                Console.WriteLine(" + - - - +");


                //SCORE CONTROL
                comboCounter = 0;
                score = 0;
                //1. SATIR KONTROLÜ
                if (((a1 == a2 - 1) && (a2 == a3 - 1)) || ((a1 == a2 + 1) && (a2 == a3 + 1)))
                {
                    comboCounter++;
                }
                //2. SATIR CONTROL
                if (((b1 == b2 - 1) && (b2 == b3 - 1)) || ((b1 == b2 + 1) && (b2 == b3 + 1)))
                {
                    comboCounter++;
                }
                //3. SATIR KONTROL
                if (((c1 == c2 - 1) && (c2 == c3 - 1)) || ((c1 == c2 + 1) && (c2 == c3 + 1)))
                {
                    comboCounter++;
                }
                //1. SÜTUN KONTROL
                if (((a1 == b1 - 1) && (b1 == c1 - 1)) || ((a1 == b1 + 1) && (b1 == c1 + 1)))
                {
                    comboCounter++;
                }
                //2. SÜTUN KONTROL
                if (((a2 == b2 - 1) && (b2 == c2 - 1)) || ((a2 == b2 + 1) && (b2 == c2 + 1)))
                {
                    comboCounter++;
                }
                //3. SÜTUN KONTROL
                if (((a3 == b3 - 1) && (b3 == c3 - 1)) || ((a3 == b3 + 1) && (b3 == c3 + 1)))
                {
                    comboCounter++;
                }
                //SAĞDAN SOLA ÇAPRAZ KONTROL
                if (((a3 == b2 - 1) && (b2 == c1 - 1)) || ((a3 == b2 + 1) && (b2 == c1 + 1)))
                {
                    comboCounter++;
                }
                //SOLDAN SAĞA ÇAPRAZ KONTROL
                if (((a1 == b2 - 1) && (b2 == c3 - 1)) || ((a1 == b2 + 1) && (b2 == c3 + 1)))
                {
                    comboCounter++;
                }

                if (comboCounter == 1)
                {
                    score = 1;
                }
                if (comboCounter == 2)
                {
                    score = 4;
                }
                if (comboCounter == 3)
                {
                    score = 9;
                }

                if (turn)
                {
                    playerScore += score;
                    turn = false;
                    moveCounter++;
                }
                else
                {
                    computerScore += score;
                    turn = true;
                    moveCounter++;
                }
                if (score != 0)
                {
                    boardScore = score;
                }
                Console.WriteLine($"Board Score: {boardScore}");
                Console.WriteLine($"Player Score: {playerScore}");
                Console.WriteLine($"Computer Score: {computerScore}");
                if (computerScore > computerscorepre)
                {
                    if (score != 0)
                    {
                        computerscorepre = computerScore;
                        Console.WriteLine("End of Round!");
                        boardScore = 0;
                        round++;
                        if (round < 6)
                        {
                            Console.WriteLine($"Round {round} başlaması için tıkla");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Game Over");
                            if (playerScore > computerScore)
                            {
                                Console.WriteLine("PLAYER WON");
                            }
                            else if (playerScore < computerScore)
                            {
                                Console.WriteLine("COMPUTER WON");
                            }
                            else
                            {
                                Console.WriteLine("DRAW");
                            }
                            Console.ReadLine();
                            break;
                        }


                        if (round != 1)
                        {
                            Random createBoard = new Random();
                            a1 = createBoard.Next(1, 10);
                            a2 = createBoard.Next(1, 10);
                            while (a1 == a2)
                            {
                                a2 = createBoard.Next(1, 10);
                            }
                            a3 = createBoard.Next(1, 10);
                            while (a3 == a2 || a3 == a1)
                            {
                                a3 = createBoard.Next(1, 10);
                            }
                            b1 = createBoard.Next(1, 10);
                            while (b1 == a1 || b1 == a2 || b1 == a3)
                            {
                                b1 = createBoard.Next(1, 10);
                            }
                            b2 = createBoard.Next(1, 10);
                            while (b2 == b1 || b2 == a1 || b2 == a2 || b2 == a3)
                            {
                                b2 = createBoard.Next(1, 10);
                            }
                            b3 = createBoard.Next(1, 10);
                            while (b3 == b2 || b3 == b1 || b3 == a1 || b3 == a2 || b3 == a3)
                            {
                                b3 = createBoard.Next(1, 10);
                            }
                            c1 = createBoard.Next(1, 10);
                            while ((c1 == a1) || (c1 == a2) || (c1 == a3) || (c1 == b1) || (c1 == b2) || (c1 == b3))
                            {
                                c1 = createBoard.Next(1, 10);
                            }
                            c2 = createBoard.Next(1, 10);
                            while (c2 == a1 || c2 == a2 || c2 == a3 || c2 == b1 || c2 == b2 || c2 == b3 || c2 == c1)
                            {
                                c2 = createBoard.Next(1, 10);
                            }
                            c3 = createBoard.Next(1, 10);
                            while (c3 == a1 || c3 == a2 || c3 == a3 || (c3 == b1) || (c3 == b2) || (c3 == b3) || (c3 == c1) || (c3 == c2))
                            {
                                c3 = createBoard.Next(1, 10);
                            }
                        }

                    }

                    Console.WriteLine($"----------Round {round} ----------");
                    Console.WriteLine("   1 2 3  ");
                    Console.WriteLine(" + - - - +");
                    Console.WriteLine($"1| {a1} {a2} {a3} |");
                    Console.WriteLine($"2| {b1} {b2} {b3} |");
                    Console.WriteLine($"3| {c1} {c2} {c3} |");
                    Console.WriteLine(" + - - - +");
                    Console.WriteLine($"Board Score: {boardScore}");
                    Console.WriteLine($"Player Score: {playerScore}");
                    Console.WriteLine($"Computer Score: {computerScore}");



                }
                if (playerScore > playerscorepre)
                {
                    if (score != 0)
                    {
                        playerscorepre = playerScore;
                        Console.WriteLine("End of Round!");
                        boardScore = 0;
                        round++;
                        if (round < 6)
                        {
                            Console.WriteLine($"Round {round} başlaması için tıkla");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Game Over");
                            if (playerScore > computerScore)
                            {
                                Console.WriteLine("PLAYER WON");
                            }
                            else if (playerScore < computerScore)
                            {
                                Console.WriteLine("COMPUTER WON");
                            }
                            else
                            {
                                Console.WriteLine("DRAW");
                            }
                            Console.ReadLine();
                            break;
                        }

                        if (round != 1)
                        {
                            Random createBoard = new Random();
                            a1 = createBoard.Next(1, 10);
                            a2 = createBoard.Next(1, 10);
                            while (a1 == a2)
                            {
                                a2 = createBoard.Next(1, 10);
                            }
                            a3 = createBoard.Next(1, 10);
                            while (a3 == a2 || a3 == a1)
                            {
                                a3 = createBoard.Next(1, 10);
                            }
                            b1 = createBoard.Next(1, 10);
                            while (b1 == a1 || b1 == a2 || b1 == a3)
                            {
                                b1 = createBoard.Next(1, 10);
                            }
                            b2 = createBoard.Next(1, 10);
                            while (b2 == b1 || b2 == a1 || b2 == a2 || b2 == a3)
                            {
                                b2 = createBoard.Next(1, 10);
                            }
                            b3 = createBoard.Next(1, 10);
                            while (b3 == b2 || b3 == b1 || b3 == a1 || b3 == a2 || b3 == a3)
                            {
                                b3 = createBoard.Next(1, 10);
                            }
                            c1 = createBoard.Next(1, 10);
                            while ((c1 == a1) || (c1 == a2) || (c1 == a3) || (c1 == b1) || (c1 == b2) || (c1 == b3))
                            {
                                c1 = createBoard.Next(1, 10);
                            }
                            c2 = createBoard.Next(1, 10);
                            while (c2 == a1 || c2 == a2 || c2 == a3 || c2 == b1 || c2 == b2 || c2 == b3 || c2 == c1)
                            {
                                c2 = createBoard.Next(1, 10);
                            }
                            c3 = createBoard.Next(1, 10);
                            while (c3 == a1 || c3 == a2 || c3 == a3 || (c3 == b1) || (c3 == b2) || (c3 == b3) || (c3 == c1) || (c3 == c2))
                            {
                                c3 = createBoard.Next(1, 10);
                            }
                        }

                    }

                    Console.WriteLine($"----------Round {round}----------");
                    Console.WriteLine("   1 2 3  ");
                    Console.WriteLine(" + - - - +");
                    Console.WriteLine($"1| {a1} {a2} {a3} |");
                    Console.WriteLine($"2| {b1} {b2} {b3} |");
                    Console.WriteLine($"3| {c1} {c2} {c3} |");
                    Console.WriteLine(" + - - - +");
                    Console.WriteLine($"Board Score: {boardScore}");
                    Console.WriteLine($"Player Score: {playerScore}");
                    Console.WriteLine($"Computer Score: {computerScore}");
                }
            }
            Console.ReadLine();

        }
    }
}