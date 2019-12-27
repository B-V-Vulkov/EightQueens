﻿namespace EightQueens.ConsoleUI
{
    using System;
    using EightQueens.Logic.Common;
    using Logic;

    class ConsoleRenderer : IRenderer
    {
        private ChessColor chessColor;

        public void RenderBoard(BoardSquare[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col].IsAttacked)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
