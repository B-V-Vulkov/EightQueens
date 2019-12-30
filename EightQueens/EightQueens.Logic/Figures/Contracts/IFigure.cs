namespace EightQueens.Logic.Figures.Contracts
{
    using System.Collections.Generic;

    using global::Common;

    public interface IFigure
    {
        ChessColor Color { get; }

        ICollection<IAttackingOperation> GetAttackingOperations();
    }
}
