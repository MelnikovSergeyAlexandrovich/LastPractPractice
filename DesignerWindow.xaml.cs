
using System.Windows;


namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для DesignerWindow.xaml
    /// </summary>
    public partial class DesignerWindow : Window
    {
        public DesignerWindow()
        {
            InitializeComponent();
            DesignFrame.Content = new Clothes();
        }

        private void DButton_Click(object sender, RoutedEventArgs e)
        {
            DesignFrame.Content = new Diller();
        }

        private void CButton_Click(object sender, RoutedEventArgs e)
        {
            DesignFrame.Content = new Clothes();
        }

        private void BButton_Click(object sender, RoutedEventArgs e)
        {
            DesignFrame.Content = new BrandsPage();
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            Close();
        }
    }
}
