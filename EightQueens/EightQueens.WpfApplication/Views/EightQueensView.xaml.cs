namespace EightQueens.WpfApplication.Views
{
    using System.Windows.Controls;

    using EightQueens.WpfApplication.ViewModels;

    public partial class EightQueensView : Page
    {
        public EightQueensView()
        {
            InitializeComponent();
            EightQueensViewModel eightQueensViewModel = new EightQueensViewModel();
            this.DataContext = eightQueensViewModel;
            this.PlayButton.Click += eightQueensViewModel.Play;
        }
    }
}
