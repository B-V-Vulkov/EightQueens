namespace EightQueens.Logic.Figures.AttackingOperations
{
    using System.Collections.Generic;

    using Contracts;
    using global::Common;

    public class StraightAttackingOperation : IAttackingOperation
    {
        public void SetAttackedPositions(BoardSquare[,] board, IFigure figure, Position figurePosition)
        {
            foreach (var square in BoardTouring(board, figurePosition))
            {
                square.AddAttackingFigure(figure);
            }
        }

        public void ResetAttackedPositions(BoardSquare[,] board, IFigure figure, Position figurePosition)
        {
            foreach (var square in BoardTouring(board, figurePosition))
            {
                square.RemoveAttackingFigure(figure);
            }
        }

        private List<BoardSquare> BoardTouring(BoardSquare[,] board, Position figurePosition)
        {
            List<BoardSquare> squares = new List<BoardSquare>();

            for (int row = 0; row < board.GetLength(0); row++)
            {
                squares.Add(board[row, figurePosition.Col]);
            }

            for (int col = 0; col < board.GetLength(1); col++)
            {
                squares.Add(board[figurePosition.Row, col]);
            }

            squares.Add(board[figurePosition.Row, figurePosition.Col]);

            return squares;
        }
    }
}
