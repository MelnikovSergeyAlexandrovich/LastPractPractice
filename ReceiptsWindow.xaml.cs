using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для ReceiptsWindow.xaml
    /// </summary>
    public partial class ReceiptsWindow : Window
    {
        public ReceiptsWindow()
        {
            InitializeComponent();
            ReceiptsFrame.Content = new Receipts();
        }
        private void SButton_Click(object sender, RoutedEventArgs e)
        {
            ReceiptsFrame.Content = new ServiceInfo();
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            ReceiptsFrame.Content = new ReceiptsInfo();
        }

        private void ReceiptButton_Click(object sender, RoutedEventArgs e)
        {
            ReceiptsFrame.Content = new Receipts();
        }
    }
}
