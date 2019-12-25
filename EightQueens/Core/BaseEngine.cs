namespace Core
{
    using Common;
    using Core.Board;
    using Core.Board.Contracts;
    using Core.Figures;

    public class BaseEngine
    {
        private IBoard board;

        public BaseEngine()
        {
            this.board = new StandardBoard();
        }

        public void InitializeFirstQueen(int row, int col)
        {
            board.AddFigure(new Qween(ChessColor.White), row, col);
        }

        public IBoard FindTheOtherQueens()
        {
            return new StandardBoard();
        }
    }
}
