namespace EightQueens.Logic
{
    using System.Collections.Generic;

    using Figures;
    using global::Common;

    public class Engine
    {
        #region Declarations

        private const int COUNT_OF_QUEENS = 8;

        private bool isFindAllPosition = false;

        #endregion

        #region Initializations

        public Engine()
        {
            this.Board = new ChessBoard();
        }

        #endregion

        #region Properties

        public ChessBoard Board { get; private set; }

        #endregion

        #region Methods

        public void Run(Position positionOfFirstQueen)
        {
            var newBoard = new ChessBoard();
            newBoard.AddFigure(new Queen(), positionOfFirstQueen);

            GetAllPositions(newBoard);
        }

        private bool GetAllPositions(ChessBoard chessBoard)
        {
            if (chessBoard.CountFigures == COUNT_OF_QUEENS && !isFindAllPosition)
            {
                this.Board = chessBoard;
                isFindAllPosition = true;
                return true;
            }

            Queen queen = new Queen();

            foreach (var position in GetSpareSquare(chessBoard.boardSquares))
            {
                chessBoard.AddFigure(queen, position);

                if (!GetAllPositions(chessBoard))
                {
                    chessBoard.RemoveFigure(queen, position);
                }
            }

            return false;
        }

        private List<Position> GetSpareSquare(BoardSquare[,] board)
        {
            var positions = new List<Position>();

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (!board[row, col].IsAttacked)
                    {
                        positions.Add(board[row, col].Position);
                    }
                }
            }

            return positions;
        }

        #endregion
    }
}
