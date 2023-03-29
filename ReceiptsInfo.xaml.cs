using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using LastProjectPracticeCsharp.clothes_shopDataSetTableAdapters;

namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для ReceiptsInfo.xaml
    /// </summary>
    public partial class ReceiptsInfo : Page
    {
        receipt_infoTableAdapter info = new receipt_infoTableAdapter();
        public ReceiptsInfo()
        {
            InitializeComponent();
            RDataGrid.ItemsSource = info.GetData();
            RDataGrid.IsReadOnly = true;
        }

        private static readonly Regex _regex = new Regex("[^0-9]+");
        private static bool numValidation(string text)
        {
            return _regex.IsMatch(text);
        }
        private void DeleteButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (RDataGrid.SelectedItem != null)
            {
                var id = (RDataGrid.SelectedItem as DataRowView).Row[0];
                info.DeleteQuery(Convert.ToInt32(id));
                RDataGrid.ItemsSource = info.GetData();
            }
            else
            {
                MessageBox.Show("Выберите значение в таблице.");
            }
        }
        private void ChangeButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (RDataGrid.SelectedItem != null)
            {
                var id = (RDataGrid.SelectedItem as DataRowView).Row[0];
                if ((UserSumTextBox.Text != "") && (TotalSumTextBox.Text != ""))
                {
                    if ((!numValidation(UserSumTextBox.Text)) && (!numValidation(TotalSumTextBox.Text)))
                    {
                        info.UpdateQuery(Convert.ToInt64(UserSumTextBox.Text), Convert.ToInt64(TotalSumTextBox.Text),Convert.ToInt32(id));
                        RDataGrid.ItemsSource = info.GetData();
                    }
                    else
                    {
                        MessageBox.Show("Cумма не может принимать знаки или буквы.");
                    }
                }
                else
                {
                    MessageBox.Show("Поле не может быть пустым.");
                }
            }
        }

        private void CreateButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if ((UserSumTextBox.Text != "") && (TotalSumTextBox.Text != ""))
            {
                if ((!numValidation(UserSumTextBox.Text)) && (!numValidation(TotalSumTextBox.Text)))
                {
                    info.InsertQuery(Convert.ToInt64(UserSumTextBox.Text), Convert.ToInt64(TotalSumTextBox.Text));
                    RDataGrid.ItemsSource = info.GetData();
                }
                else
                {
                    MessageBox.Show("Cумма не может принимать знаки или буквы.");
                }
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым.");
            }
        }

        private void RDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RDataGrid.SelectedItem != null)
            {
                UserSumTextBox.Text = Convert.ToString((RDataGrid.SelectedItem as DataRowView).Row[1]);
                TotalSumTextBox.Text = Convert.ToString((RDataGrid.SelectedItem as DataRowView).Row[2]);
            }
        }
    }
}
