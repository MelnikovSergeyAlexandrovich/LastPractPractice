using System.Windows;


namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для KassaWindow.xaml
    /// </summary>
    public partial class KassaWindow : Window
    {
        public KassaWindow()
        {
            InitializeComponent();
            cashFrame.Content = new CashPage();
        }

        private void receiptsButton_Click(object sender, RoutedEventArgs e)
        {
            
            cashFrame.Content = new TotalReceiptsPage();
        }

        private void boxOfficeButton_Click(object sender, RoutedEventArgs e)
        {
            cashFrame.Content = new CashPage();
        }
    }
}
