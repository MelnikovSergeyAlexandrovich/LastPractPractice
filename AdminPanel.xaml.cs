using LastProjectPracticeCsharp.clothes_shopDataSetTableAdapters;
using System.Windows;

namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        data_for_log_inTableAdapter data = new data_for_log_inTableAdapter();
        public AdminPanel()
        {
            InitializeComponent();
            AdminDataFrame.Content = new Staff();
        }

        private void AutorizationButton__Click(object sender, RoutedEventArgs e)
        {
            AdminDataFrame.Content = new dataForAutorization();
        }

        private void RolesButton_Click(object sender, RoutedEventArgs e)
        {
            AdminDataFrame.Content = new Roles();
        }

        private void StaffButton_Click(object sender, RoutedEventArgs e)
        {
            AdminDataFrame.Content = new Staff();
        }

        private void ShopsButton_Click(object sender, RoutedEventArgs e)
        {
            AdminDataFrame.Content = new ShopsPage();
        }

        private void GetBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            Close();
        }
    }
}
