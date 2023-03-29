using System.Windows;


namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для TopManagerWindow.xaml
    /// </summary>
    public partial class TopManagerWindow : Window
    {
        public TopManagerWindow()
        {
            InitializeComponent();
            ManagerFrame.Content = new PartnershipsPage();
        }

        private void SocialMediasButton_Click(object sender, RoutedEventArgs e)
        {
            ManagerFrame.Content = new SocialMediasPage();
        }

        private void BusinessPartnersButton_Click(object sender, RoutedEventArgs e)
        {
            ManagerFrame.Content = new PartnershipsPage();
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();    
            a.Show();
            Close();
        }
    }
}
