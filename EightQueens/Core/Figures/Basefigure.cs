namespace Core.Figures
{
    using Common;
    using Core.Figures.Contracts;

    public abstract class BaseFigure : IFigure
    {
        public BaseFigure(ChessColor chessColor)
        {
            this.Color = chessColor;
        }

        public ChessColor Color { get; }
    }
}
