using System;

class Program
{
    static char[,] board = new char[3, 3]; 
    static char currentPlayer = 'X'; 

    static void Main(string[] args)
    {
        InitializeBoard(); 
        PlayGame();        
    }

    static void InitializeBoard() 
    {
        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 3; j++) 
            {
                board[i, j] = ' '; 
            }
        }
    }

    static void PrintBoard() 
    {
        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 3; j++) 
            {
                Console.Write(board[i, j]);
                if (j < 2) Console.Write(" | ");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("--|---|--");
        }
    }

    static void PlayGame() 
    {
        bool gameOver = false;

        while (!gameOver) 
        {
            PrintBoard(); 
            int row, col;
            bool validMove = false;

        }
    }
}
