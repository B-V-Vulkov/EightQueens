﻿namespace EightQueens.WpfApplication.Models
{
    using Common;

    public class BoardSquare : BaseModel
    {
        #region Declarations

        private ChessColor color;

        private string urlFigureImage;

        #endregion

        #region Initializations

        public BoardSquare(ChessColor chessColor)
        {
            this.Color = chessColor;
        }

        #endregion

        #region Properties

        public ChessColor Color
        {
            get
            {
                return this.color;
            }
            private set
            {
                this.color = value;
            }
        }

        public string UrlFigureImage
        {
            get
            {
                return this.urlFigureImage;
            }
            set
            {
                this.urlFigureImage = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        #region Methods
        #endregion
    }
}
