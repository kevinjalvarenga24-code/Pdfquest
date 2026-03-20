using System.Windows;


namespace Pdfquest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var vm = new StudentsViewModel();
        }
    }
}