namespace EightQueens.Logic
{
    using EightQueens.Logic.Figures.Contracts;
    using Figures;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        #region Declarations

        private const int COUNT_OF_QUEENS = 8;

        private IRenderer renderer;

        private ChessBoard chessBoard;

        #endregion

        #region Initializations

        public Engine(IRenderer renderer)
        {
            this.renderer = renderer;
            this.chessBoard = new ChessBoard();
        }

        #endregion

        #region Properties

        public ChessBoard chessBoardResult { get; private set; }

        #endregion

        #region Methods

        public bool IsRenderer = false;

        public bool Find(ChessBoard chessBoard) 
        {
            if (chessBoard.CountFigures == COUNT_OF_QUEENS && !IsRenderer)
            {
                this.renderer.RenderBoard(chessBoard.boardSquares);
                IsRenderer = true;
                return true;
            }

            Queen queen = new Queen();

            foreach (var position in GetSpareSquare(chessBoard.boardSquares))
            {
                chessBoard.AddFigure(queen, position);

                if (!Find(chessBoard))
                {
                    chessBoard.RemoveFigure(queen, position);
                }
            }

            return false;
        }

        public void FindPositionsOfAllQueens(Position positionOfFirstQueen)
        {
            this.chessBoard.AddFigure(new Queen(), positionOfFirstQueen);

            Find(this.chessBoard);

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
