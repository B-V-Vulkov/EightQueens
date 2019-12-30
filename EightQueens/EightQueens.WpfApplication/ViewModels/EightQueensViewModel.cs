namespace EightQueens.WpfApplication.ViewModels
{
    using EightQueens.Logic;
    using EightQueens.WpfApplication.Models;
    using System.Collections.Generic;

    public class EightQueensViewModel
    {
        #region Declarations

        private Engine engine;

        #endregion

        #region Initializations

        public EightQueensViewModel()
        {
            this.engine = new Engine();

            this.Board = new List<Square>();

            Initialize(this.Board);
        }

        #endregion

        #region Properties

        public List<Square> Board { get; set; }

        #endregion

        #region Methods

        public void Play(object sender, System.Windows.RoutedEventArgs e)
        {
            
        }

        private void Initialize(List<Square> board)
        {
            this.engine.Run(new Common.Position(0, 0));

        }

        #endregion
    }
}
