namespace EightQueens.Logic
{
    using EightQueens.Logic.Figures.Contracts;
    using Figures;
    using System.Collections.Generic;

    public class Engine
    {
        #region Declarations

        private const int MAX_COUNT_OF_QUEENS = 8;

        private IRenderer renderer;

        private ChessBoard chessBoard;

        private Stack<Queen> queens;

        #endregion

        #region Initializations

        public Engine(IRenderer renderer)
        {
            this.renderer = renderer;
            this.chessBoard = new ChessBoard();
            this.queens = new Stack<Queen>();

            InitializeQueens(queens);
        }

        #endregion

        #region Properties
        #endregion

        #region Methods

        public void FindPositionsOfAllQueens(Position positionOfFirstQueen)
        {
            Queen firstQueen = this.queens.Pop();
            this.chessBoard.AddFigure(firstQueen, positionOfFirstQueen);

            while (queens.Count != 0)
            {
                //TODO
                break;
            }

            this.renderer.RenderBoard(this.chessBoard.boardSquares);
        }

        private Position GetNextSpareSquare(BoardSquare[,] board, int positionPointer)
        {
            int counter = 0;

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (!board[row, col].IsAttacked)
                    {
                        if (counter == positionPointer)
                        {
                            return board[row, col].Position;
                        }
                        counter++;
                    }
                }
            }

            return null;
        }

        private void InitializeQueens(Stack<Queen> figures)
        {
            for (int i = 1; i <= MAX_COUNT_OF_QUEENS; i++)
            {
                figures.Push(new Queen());
            }
        }

        #endregion
    }
}
