namespace EightQueens.Logic.Figures
{
    using System.Collections.Generic;

    using Common;
    using Contracts;
    using AttackingOperations;

    public class Queen : IFigure
    {
        public ChessColor Color => throw new System.NotImplementedException();

        public ICollection<IAttackingOperation> GetAttackingOperations()
        {
            ICollection<IAttackingOperation> attacks = new List<IAttackingOperation>()
            {
                new StraightAttackingOperation(),
                new DiagonalAttackingOperation(),
            };

            return attacks;
        }
    }
}
