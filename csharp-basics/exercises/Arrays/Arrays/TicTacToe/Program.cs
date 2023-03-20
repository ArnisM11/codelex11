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
            do
            {
                Console.Write(isTurn + ", choose your location(row ,column) : ");
                input = Console.ReadLine();
                xCord = input[0] - '0';
                yCord = input[2] - '0';
                if (checkMove(xCord, yCord))
                {
                    Console.WriteLine();
                    board[xCord, yCord] = isTurn;
                    isTurn = (isTurn == 'X') ? 'O' : 'X';
                    DisplayBoard();
                }
                else Console.WriteLine("Invalid move, try again!" + xCord + " " + yCord);

                if (checkTie())
                {
                    Console.WriteLine("Game is tie!");
                    break;
                }
            } while (!CheckWinner(isTurn));

            if (!checkTie())
            {
                if (isTurn == 'X') Console.WriteLine("Winner is X");
                else if (isTurn == 'O') Console.WriteLine("Winner is O");
            }

            Console.ReadLine();
        }
        public static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }
        public static void DisplayBoard()
        {
            Console.WriteLine();
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
        public static bool CheckWinner(char isTurn)
        {
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == isTurn && board[row, 1] == isTurn && board[row, 2] == isTurn && board[row,0] != ' ') return true;
            }
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == isTurn && board[1, col] == isTurn && board[2, col] == isTurn && board[col, 0] != ' ') return true;
            }

            if (board[0, 0] == isTurn && board[1, 1] == isTurn && board[2, 2] == isTurn && board[0, 0] != ' ' && board[1, 1] != ' ' && board[2, 2] != ' ') return true;

            if (board[0, 2] == isTurn && board[1, 1] == isTurn && board[2, 0] == isTurn && board[0, 2] != ' ' && board[1, 1] != ' ' && board[2, 0] != ' ') return true;
            return false;
        }

        static bool checkMove(int x,int y)
        {
            if (x >= 0 && x < 3 && y >= 0 && y < 3 && board[x, y] == ' ') return true;
            else return false;
        }
        static bool checkTie()
        {
            int symbols = 0;
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                    if (board[r, c] != ' ') symbols++;
            }
            if (symbols >= 9) return true;
            else return false;
        }
    }
}
