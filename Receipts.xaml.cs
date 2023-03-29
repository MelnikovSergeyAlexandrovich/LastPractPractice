using LastProjectPracticeCsharp.clothes_shopDataSetTableAdapters;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;


namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для Receipts.xaml
    /// </summary>
    public partial class Receipts : Page
    {
        receiptTableAdapter receipt = new receiptTableAdapter();
        serviceTableAdapter service = new serviceTableAdapter();
        receipt_infoTableAdapter info = new receipt_infoTableAdapter();
        public Receipts()
        {
            InitializeComponent();
            RDataGrid.ItemsSource = receipt.GetData();
            RDataGrid.IsReadOnly = true;
            ServiceComboBox.ItemsSource = service.GetData();    
            ReceiptInfoComboBox.ItemsSource = info.GetData();
            ServiceComboBox.SelectedValuePath = "service_id";
            ServiceComboBox.DisplayMemberPath = "name";
            ReceiptInfoComboBox.SelectedValuePath = "info_id";
            ReceiptInfoComboBox.DisplayMemberPath = "totalPrice";
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if ((ServiceComboBox.SelectedItem != null) && (ReceiptInfoComboBox.SelectedItem != null))
            {
                int servId = Convert.ToInt32(ServiceComboBox.SelectedValue);
                int Id = Convert.ToInt32(ReceiptInfoComboBox.SelectedValue);
                receipt.InsertQuery(Id, servId);
                RDataGrid.ItemsSource = receipt.GetData();
            }
            else
            {
                MessageBox.Show("Поле должно быть заполнено.");
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (RDataGrid.SelectedItem != null)
            {
                var receiptId = (RDataGrid.SelectedItem as DataRowView).Row[0];
                if ((ServiceComboBox.SelectedItem != null) && (ReceiptInfoComboBox.SelectedItem != null))
                {
                    int servId = Convert.ToInt32(ServiceComboBox.SelectedValue);
                    int Id = Convert.ToInt32(ReceiptInfoComboBox.SelectedValue);
                    receipt.UpdateQuery(Id, servId,Convert.ToInt32(receiptId));
                    RDataGrid.ItemsSource = receipt.GetData();
                }
                else
                {
                    MessageBox.Show("Поле должно быть заполнено.");
                }

            }
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (RDataGrid.SelectedItem != null)
            {
                var receiptId = (RDataGrid.SelectedItem as DataRowView).Row[0];
                receipt.DeleteQuery(Convert.ToInt32(receiptId));
                RDataGrid.ItemsSource = receipt.GetData();
            }
        }
    }
}
