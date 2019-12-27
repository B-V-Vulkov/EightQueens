namespace EightQueens.Logic
{
    using Common;
    using EightQueens.Logic.Figures.Contracts;

    public class ChessBoard
    {
        #region Declarations

        private const int BOARD_ROW = 8;
        private const int BOARD_COL = 8;

        private BoardSquare[,] board;

        #endregion

        #region Initializations

        public ChessBoard()
        {
            this.board = new BoardSquare[BOARD_ROW, BOARD_COL];
            this.Initialize(board);
        }

        #endregion

        #region Properties

        //TODO remove this
        public BoardSquare[,] boardSquares { get { return this.board; } }

        #endregion

        #region Methods

        public void AddFigure(IFigure figure, Position position)
        {
            this.board[position.Row, position.Col].SetFigure(figure);

            foreach (var attack in figure.GetAttackingOperations())
            {
                attack.SetAttackedPositions(board, figure, position);
            }
        }

        public void RemoveFigure(IFigure figure, Position position)
        {
            this.board[position.Row, position.Col].ResetFigure();

            foreach (var attack in figure.GetAttackingOperations())
            {
                attack.ResetAttackedPositions(board, figure, position);
            }
        }

        private void Initialize(BoardSquare[,] board)
        {
            for (int row = 0; row < BOARD_ROW; row++)
            {
                for (int col = 0; col < BOARD_COL; col++)
                {
                    Position currentPosition = new Position(row, col);
                    ChessColor currentColor = GetColorForPosition(currentPosition);
                    
                    board[row, col] = new BoardSquare(currentColor, currentPosition);
                }
            }
        }

        private ChessColor GetColorForPosition(Position position)
        {
            bool isRowEven = position.Row % 2 == 0;
            bool isColEven = position.Col % 2 == 0;

            if ((isRowEven && isColEven) || (!isRowEven && !isColEven))
            {
                return ChessColor.White;
            }

            return ChessColor.Black;
        }

        #endregion
    }
}
