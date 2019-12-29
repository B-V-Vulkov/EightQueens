namespace EightQueens.WpfApplication.Models
{
    using Common;

    public class BoardSquare
    {
        #region Initializations

        public BoardSquare(Position position, string backgroundImage)
        {
            this.Position = position;
            this.BackgroundImage = backgroundImage;
        }

        #endregion

        #region Properties

        public string BackgroundImage { get; }

        public Position Position { get; }

        #endregion
    }
}
