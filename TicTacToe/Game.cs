using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AI;
namespace TicTacToe
{
    public class Game
    {
        private char[,] board = new char[3, 3];
        private ComputerPlayer aiPlayer = new ComputerPlayer();
        private bool isPlayerXTurn = true;
        private bool isPlayingAgainstAI = false;

        public void Start()
        {
            InitializeBoard();
            Console.WriteLine("Добро пожаловать в крестики нолики!");
            Console.WriteLine("Хотите играть против компьютера? (да/нет)");
            isPlayingAgainstAI = Console.ReadLine().ToLower() == "да";

            while (!IsGameOver())
            {
                DisplayBoard();
                if (isPlayingAgainstAI && !isPlayerXTurn)
                {
                    aiPlayer.MakeMove(board);
                    isPlayerXTurn = !isPlayerXTurn;
                }
                else
                {
                    MakeMove();
                    isPlayerXTurn = !isPlayerXTurn;
                }
            }

            DisplayBoard();
            if (IsWinner('X'))
                Console.WriteLine("Игрок X выиграл!");
            else if (IsWinner('O'))
                Console.WriteLine("Игрок O выиграл!");
            else
                Console.WriteLine("Ничья!");
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
        }

        private void DisplayBoard()
        {
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                    if (j < 2) Console.Write(" | ");
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("---------");
            }
        }

        private void MakeMove()
        {
            int x, y;
            do
            {
                Console.WriteLine(isPlayerXTurn ? "Игрок X ходит" : "Игрок O ходит");
                Console.Write("Введите номер строки (1-3): ");
                x = int.Parse(Console.ReadLine())-1;
                Console.Write("Введите номер столбца (1-3): ");
                y = int.Parse(Console.ReadLine())-1;
            } while (!IsValidMove(x, y));

            board[x, y] = isPlayerXTurn ? 'X' : 'O';
        }

        private bool IsValidMove(int x, int y)
        {
            if (x < 0 || x > 2 || y < 0 || y > 2)
            {
                Console.WriteLine("Неправильные координаты. Попробуйте еще раз.");
                return false;
            }
            if (board[x, y] != ' ')
            {
                Console.WriteLine("Клетка занята . Попробуйте еще раз.");
                return false;
            }
            return true;
        }

        private bool IsGameOver()
        {
            return IsWinner('X') || IsWinner('O') || IsBoardFull();
        }

        private bool IsWinner(char player)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == player && board[i, 1] == player && board[i, 2] == player) ||
                    (board[0, i] == player && board[1, i] == player && board[2, i] == player))
                    return true;
            }
            if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||
                (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))
                return true;
            return false;
        }

        private bool IsBoardFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ') return false;
                }
            }
            return true;
        }
    }
}
