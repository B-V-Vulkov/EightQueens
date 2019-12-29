namespace EightQueens.WpfApplication.Views
{
    using System.Windows.Controls;

    using EightQueens.WpfApplication.ViewModels;

    public partial class EightQueensView : Page
    {
        public EightQueensView()
        {
            InitializeComponent();
            this.DataContext = new EightQueensViewModel();
        }
    }
}
