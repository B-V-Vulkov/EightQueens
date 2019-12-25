namespace Core.Board.Contracts
{
    using Common;
    using Core.Figures.Contracts;

    public interface IBoardEntity
    {
        ChessColor Color { get; }

        IFigure Figure { get; }

        bool IsAttacked { get; }

        bool IsEmpty { get; }

        void SetFigure(IFigure figure);

        void RemoveFigure();
    }
}
