using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using LastProjectPracticeCsharp.clothes_shopDataSetTableAdapters;

namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для ServiceInfo.xaml
    /// </summary>
    public partial class ServiceInfo : Page
    {
        serviceTableAdapter service = new serviceTableAdapter();
        public ServiceInfo()
        {
            InitializeComponent();
            RDataGrid.ItemsSource = service.GetData();
            RDataGrid.IsReadOnly = true;
        }

        private static readonly Regex _regex = new Regex("[^0-9]+");
        private static bool numValidation(string text)
        {
            return _regex.IsMatch(text);
        }
        public bool strLengthvalidation(string str)
        {
            var pattern = "^.{1,40}$";
            if (Regex.IsMatch(str, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (RDataGrid.SelectedItem != null)
            {
                var id = (RDataGrid.SelectedItem as DataRowView).Row[0];
                if (strLengthvalidation(ServiceTextBox.Text) && (PriceTextBox.Text != ""))
                {
                    if (!numValidation(PriceTextBox.Text))
                    {
                        if (Convert.ToInt64(PriceTextBox.Text) >= 1)
                        {
                            service.UpdateQuery(Convert.ToInt64(PriceTextBox.Text), ServiceTextBox.Text,Convert.ToInt32(id));
                            RDataGrid.ItemsSource = service.GetData();
                        }
                        else
                        { MessageBox.Show("Неверное значение цены."); }
                    }
                    else
                    {
                        MessageBox.Show("Цена не может состоять из знаков и букв.");
                    }

                }
                else
                {
                    MessageBox.Show("Были введенны недопустимые значения.");
                }
            }
            else
            {
                MessageBox.Show("Выберите значение из таблицы");
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (strLengthvalidation(ServiceTextBox.Text) && (PriceTextBox.Text != ""))
            {
                if (!numValidation(PriceTextBox.Text))
                {
                    if (Convert.ToInt64(PriceTextBox.Text) >= 1)
                    {
                        service.InsertQuery(Convert.ToInt64(PriceTextBox.Text), ServiceTextBox.Text);
                        RDataGrid.ItemsSource = service.GetData();
                    }
                    else 
                    { MessageBox.Show("Неверное значение цены."); }
                }
                else
                {
                    MessageBox.Show("Цена не может состоять из знаков и букв.");
                }

            }
            else
            {
                MessageBox.Show("Были введенны недопустимые значения.");
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (RDataGrid.SelectedItem != null)
            {
                var id = (RDataGrid.SelectedItem as DataRowView).Row[0];
                service.DeleteQuery(Convert.ToInt32(id));
                RDataGrid.ItemsSource = service.GetData();
            }
            else
            {
                MessageBox.Show("Выберите значение из таблицы");
            }
        }

        private void RDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RDataGrid.SelectedItem != null)
            {
                ServiceTextBox.Text = Convert.ToString((RDataGrid.SelectedItem as DataRowView).Row[2]);
                PriceTextBox.Text = Convert.ToString((RDataGrid.SelectedItem as DataRowView).Row[1]);
            }
        }
    }
}
