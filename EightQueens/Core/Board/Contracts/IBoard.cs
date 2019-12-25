namespace Core.Board.Contracts
{
    using Core.Figures.Contracts;
    using System.Collections.Generic;

    public interface IBoard
    {
        IBoardEntity[,] Board { get; }

        void AddFigure(IFigure figure, int row, int col);

        void RemoveFigure(int row, int col);
    }
}
