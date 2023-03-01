using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            char isTurn = 'X';
            string input = " ";
            int xCord = 0;
            int yCord = 0;
            InitBoard();
            DisplayBoard();

            while (checkWinner())
            {
                Console.Write(isTurn + ", choose your location(row ,column) : ");
                input = Console.ReadLine();
                xCord = input[0] - '0';
                yCord = input[2] - '0';
                Console.WriteLine();
                if (isTurn != 'X')
                {
                    isTurn = 'O';
                    board[xCord, yCord] = isTurn;
                    isTurn = 'X';
                }
                else
                {
                    board[xCord, yCord] = isTurn;
                    isTurn = 'O';
                }
                DisplayBoard();
            }

            if (isTurn == 'X') Console.WriteLine("Winner is O");
            else if (isTurn == 'O') Console.WriteLine("Winner is X");

            Console.ReadLine();
        }

        public static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 2; r++)
            {
                for (var c = 0; c < 2; c++)
                    board[r, c] = ' ';
            }
            
        }

        public static void DisplayBoard()
        {
            Console.WriteLine("   x 0|1|2");
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }

        public static bool checkWinner()
        {
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0,0] == board[0,2]) return true;                  //horizontals
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] == board[1, 2]) return true;
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] == board[2, 2]) return true;
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] == board[2, 0]) return true;             //verticals
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] == board[2, 1]) return true;
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] == board[2, 2]) return true;
            else if (board[0, 0] == board[1, 1] && board[1, 2] == board[2, 2] && board[0, 0] == board[2, 2]) return true;             //diagonals
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] == board[2, 0]) return true;
            else return false;
        }
    }
}
