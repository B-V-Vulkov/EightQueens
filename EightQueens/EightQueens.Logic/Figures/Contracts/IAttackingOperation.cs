using Common;

namespace EightQueens.Logic.Figures.Contracts
{
    public interface IAttackingOperation
    {
        void SetAttackedPositions(BoardSquare[,] board, IFigure figure, Position figurePosition);

        void ResetAttackedPositions(BoardSquare[,] board, IFigure figure, Position figurePosition);
    }
}
