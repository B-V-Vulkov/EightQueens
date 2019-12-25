namespace Core.Board
{
    using Common;
    using Core.Board.BoardEntities;
    using Core.Board.Contracts;
    using Core.Figures.Contracts;
    using System;

    public class StandardBoard : IBoard
    {
        #region Declarations

        private int boardRow = GlobalConstants.STANDARD_BOARD_ROW;

        private int boardCol = GlobalConstants.STANDARD_BOARD_COL;

        private readonly IBoardEntity[,] board;

        #endregion

        #region Initializations

        public StandardBoard()
        {
            this.board = new Square[boardRow, boardCol];

            Initialize(board);
        }

        #endregion

        #region Properties

        public IBoardEntity[,] Board
        {
            get
            {
                return board.Clone() as IBoardEntity[,];
            }
        }

        #endregion

        #region Methods

        #region Public

        public void AddFigure(IFigure figure, int row, int col)
        {
            this.board[row, col].SetFigure(figure);
        }

        public void RemoveFigure(int row, int col)
        {
            this.board[row, col].RemoveFigure();
        }

        #endregion

        #region Rrivate

        private void Initialize(IBoardEntity[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = new Square(GetColor(row, col));
                }
            }
        }

        private ChessColor GetColor(int row, int col)
        {
            bool isRowEven = row % 2 == 0;
            bool isColEven = col % 2 == 0;

            if ((isRowEven && isColEven) || (!isRowEven && !isColEven))
            {
                return ChessColor.White;
            }

            return ChessColor.Black;
        }

        private void SetAttackedEntity()
        {
            
        }

        #endregion

        #endregion
    }
}
