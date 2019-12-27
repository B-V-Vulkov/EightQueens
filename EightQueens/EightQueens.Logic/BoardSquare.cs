namespace EightQueens.Logic
{
    using Common;
    using Figures.Contracts;
    using System.Collections.Generic;

    public class BoardSquare
    {
        #region Declarations
        #endregion

        #region Initializations

        public BoardSquare(ChessColor chessColor, Position position)
        {
            this.Color = chessColor;
            this.Position = position;
            this.AttackingFigures = new List<IFigure>();
        }

        #endregion

        #region Properties

        public ChessColor Color { get; }

        public Position Position { get; }

        public IFigure Figure { get; private set; }

        public ICollection<IFigure> AttackingFigures { get; private set; }

        public bool IsContainsFigure =>
            this.Figure != null;

        public bool IsAttacked =>
            this.AttackingFigures.Count != 0;

        #endregion

        #region Methods

        public void SetFigure(IFigure figure)
        {
            this.Figure = figure;
        }

        public void ResetFigure()
        {
            this.Figure = null;
        }

        public void AddAttackingFigure(IFigure figure)
        {
            this.AttackingFigures.Add(figure);
        }

        public void RemoveAttackingFigure(IFigure figure)
        {
            this.AttackingFigures.Remove(figure);
        }

        #endregion
    }
}
