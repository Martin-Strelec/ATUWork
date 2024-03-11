/*
 * Name: Q6
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: worksheet tasks...
 */

using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace Q6
{
    internal class Program
    {

        static int[] coordinates = new int[2]; //Coordinates field
        static string[,] playingBoard = { { "", "", "" }, { "", "", "" }, { "", "", "" } }; //Size of the playing board
        static int sizeX = playingBoard.GetLength(0); //XAxis size
        static int sizeY = playingBoard.GetLength(1); //YAxis size
        static int numberOfPlayers = 2; //Nummber of players
        static bool exit = false, gameOver = false; //Boolean values for triggering methods 

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            while (exit == false)
            {
                TicTacToe();
            }
            Console.WriteLine("\n******End of program******\n");
        }

        static void InputHandlerer(int playerIndex)//Manages the input of coordinates
        {
            
            Console.WriteLine($"Enter coordinates for Player {playerIndex+1}");
            for (int i = 0; i < coordinates.Length; i++)
            {
                Console.Write($"{(i == 0 ? "X" : "Y")}: ");
                while (!int.TryParse(Console.ReadLine(), out coordinates[i]) || (!(coordinates[i] <= playingBoard.GetLength(0)) || coordinates[i] <= 0))
                {
                    Console.WriteLine("Invalid input!");
                    Console.Write("> ");
                }
                coordinates[i]--;
            }

        }
        static bool PlayingBoardManager(int xAxis, int yAxis, int playerIndex)//Writes onto the board and checks if player doesnt input the same coordinates twice
        {

            int playingBoardElementSize = playingBoard.GetLength(0) * playingBoard.GetLength(1);
            int occupied = 0;
            bool isTaken = false;

            //Checks if player inputted previously entered coordinates
            if (playingBoard[xAxis, yAxis] != "")
            {
                Console.WriteLine("\nAlready taken...");
                isTaken = true;
            }
            else
            {
                if (playerIndex == 0)
                {
                    playingBoard[xAxis, yAxis] = "X ";
                }
                else
                {
                    playingBoard[xAxis, yAxis] = "O ";
                }
            }

            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    if (playingBoard[i, j] != "")
                    {
                        occupied++;
                    }
                }
            }
            //if playing board is full it triggers the GameOver function
            if (occupied == playingBoardElementSize)
            {
                gameOver = true;
            }

            return isTaken;
        }
        static void GameOver(int i)
        {
            int choice;

            Console.WriteLine("\n****** GAME OVER! ******");
            Console.WriteLine($"\nWinner: {CheckWinner(i)}\n");
            Console.WriteLine("Restart (1) or Exit (-1)?: ");

            while (!int.TryParse(Console.ReadLine(), out choice) && !(choice != -1 || choice != 1))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }
            if (choice == -1)
            {
                exit = true;
            }
            else
            {
                ResetBoard();
            }
        }//Displays winner and asks if player wants to continue or exit
        static void ResetBoard()
        {
            playingBoard = new string[,] { { "", "", "" }, { "", "", "" }, { "", "", "" } };
        }//Resets the playing board
        static void DisplayTab()
        {
            const string OUTPUT_TAB = "{0,1}{1,3}{2,3}{3,3}{4,1}";
            Console.WriteLine("\n-----------");
            for (int i = 0; i < playingBoard.GetLength(0); i++)
            {
                Console.WriteLine(OUTPUT_TAB, "|", $"{playingBoard[i, 0]}",
                                                   $"{playingBoard[i, 1]}",
                                                   $"{playingBoard[i, 2]}", "|");
            }
            Console.WriteLine("-----------\n");


        }//Displays the playing board
        static string CheckWinner(int i)
        {
            string[] playerSigns = { "X ", "O " };
            int[] score = new int[numberOfPlayers];
            string winner = "DRAW";

            //Row check
            for (int j = 0; j < playingBoard.GetLength(0); j++)
            {
                for (int k = 0; k < playingBoard.GetLength(1); k++)
                {
                    if (playingBoard[j, k] == playerSigns[i])
                    {
                        score[i]++;
                    }
                    if (score[i] == 3)
                    {
                        winner = playerSigns[i];
                        gameOver = true;
                    }
                }
                if (score[i] != 0)
                {
                    score[i] = 0;
                }
            }
            //Column check
            for (int j = 0; j < playingBoard.GetLength(0); j++)
            {
                for (int k = 0; k < playingBoard.GetLength(1); k++)
                {
                    if (playingBoard[k, j] == playerSigns[i])
                    {
                        score[i]++;
                    }
                    if (score[i] == 3)
                    {
                        winner = playerSigns[i];
                        gameOver = true;
                    }
                }
                if (score[i] != 3)
                {
                    score[i] = 0;
                }
            }
           
            //Diagonal check 1
            for (int j = 0; j < playingBoard.GetLength(0); j++)
            {
                if (playingBoard[j, j] == playerSigns[i])
                {
                    score[i]++;
                }
                if (score[i] == 3)
                {
                    winner = playerSigns[i];
                    gameOver = true;
                }
            }
            if (score[i] != 3)
            {
                score[i] = 0;
            }

            //Diagonal check 2
            int column = playingBoard.GetLength(0) - 1;//used in for loop
            for (int j = 0; j < playingBoard.GetLength(0); j++, column--)
            {
                if (playingBoard[j, column] == playerSigns[i])
                {
                    score[i]++;
                }
                if (score[i] == 3)
                {
                    winner = playerSigns[i];
                    gameOver = true;
                }
            }
            if (score[i] != 3)
            {
                score[i] = 0;
            }

            return winner;

        }//Constantly checking for the winner
        static void TicTacToe()
        {
            DisplayTab();
            for (int i = 0; i < numberOfPlayers; i++) //Cycles between two players
            {
                
                InputHandlerer(i);
                if (PlayingBoardManager(coordinates[0], coordinates[1], i))//Respond for player using already inputted coordinates
                {
                    DisplayTab();
                    InputHandlerer(i);
                    PlayingBoardManager(coordinates[0], coordinates[1], i);
                }
                
                CheckWinner(i);
                if (gameOver == true) //Initializes game over screen
                {
                    DisplayTab();
                    GameOver(i);
                    gameOver = false;
                    i = numberOfPlayers + 1;
                }
                else
                {
                    DisplayTab();
                }

            }
        }//Complete fucntion for TicTacToe
    }
}
