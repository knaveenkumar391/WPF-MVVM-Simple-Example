using DammyApp1.MVVM.ViewModel;
using System.Windows;


namespace DammyApp1
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel viewModel = new MainWindowViewModel();
            this.DataContext = viewModel;
        }
    }
}
