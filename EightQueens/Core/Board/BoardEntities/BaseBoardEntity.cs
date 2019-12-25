namespace Core.Board
{
    using Common;
    using Core.Board.Contracts;
    using Core.Figures.Contracts;

    public abstract class BaseBoardEntity : IBoardEntity
    {
        public BaseBoardEntity(ChessColor chessColor)
        {
            this.Color = chessColor;
        }

        public ChessColor Color { get; }

        public IFigure Figure { get; private set; }

        public bool IsAttacked { get; set; }

        public bool IsEmpty =>
            this.Figure == null;

        public void SetFigure(IFigure figure)
        {
            this.Figure = figure;
        }

        public void RemoveFigure()
        {
            this.Figure = null;
        }
    }
}
