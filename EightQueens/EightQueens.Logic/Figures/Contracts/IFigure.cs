namespace EightQueens.Logic.Figures.Contracts
{
    using System.Collections.Generic;

    using Common;

    public interface IFigure
    {
        ChessColor Color { get; }

        ICollection<IAttackingOperation> GetAttackingOperations();
    }
}
