using FSW.Application.Interview.ViewModel;
using System.Windows;

namespace FSW.Application.Interview.UI
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(ProductViewModel viewModel)
        {
            InitializeComponent();

            ViewModel = viewModel;
        }

        public ProductViewModel ViewModel
        {
            get => (ProductViewModel) DataContext;
            set => DataContext = value;
        }
    }
}