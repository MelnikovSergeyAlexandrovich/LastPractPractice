using LastProjectPracticeCsharp.clothes_shopDataSetTableAdapters;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для PartnershipsPage.xaml
    /// </summary>
    public partial class PartnershipsPage : Page
    {
        partnershipTableAdapter partnership = new partnershipTableAdapter();
        public PartnershipsPage()
        {
            InitializeComponent();
            SMDataGrid.ItemsSource = partnership.GetData();
            SMDataGrid.IsReadOnly = true;

        }
        private static readonly Regex _regex = new Regex("[^0-9]+");
        private static bool numValidation(string text)
        {
            return _regex.IsMatch(text);
        }
        private void SMDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SMDataGrid.SelectedItem != null)
            {
                TimeTextBox.Text = ((SMDataGrid.SelectedItem as DataRowView).Row[1]).ToString();
                PriceTextBox.Text = ((SMDataGrid.SelectedItem as DataRowView).Row[2]).ToString();
                NameTextBox.Text = ((SMDataGrid.SelectedItem as DataRowView).Row[3]).ToString();
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            
            if ((TimeTextBox.Text != "") && (PriceTextBox.Text != "") && (NameTextBox.Text != ""))
            {
                if (numValidation(PriceTextBox.Text))
                {
                    MessageBox.Show("Значения были введенны в непредусмотренном виде");
                }
                else
                {
                    if (Convert.ToInt64(PriceTextBox.Text) >= 1 && (NameTextBox.Text.Length <= 40))
                    {
                        partnership.InsertQuery(Convert.ToDateTime(TimeTextBox.Text).ToShortDateString(), Convert.ToInt64(PriceTextBox.Text), NameTextBox.Text);
                        SMDataGrid.ItemsSource = partnership.GetData();
                    }
                    else
                    {
                        MessageBox.Show("Цена не может принимать знаки или буквы");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Поле не должно быть пустым");
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (SMDataGrid.SelectedItem != null)
            {
                object id = (SMDataGrid.SelectedItem as DataRowView).Row[0];
                partnership.DeleteQuery(Convert.ToInt32(id));
                SMDataGrid.ItemsSource = partnership.GetData();
            }
            else
                MessageBox.Show("Выберите элемент из таблицы");
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (SMDataGrid.SelectedItem != null)
            {
                object id = (SMDataGrid.SelectedItem as DataRowView).Row[0];
                if ((TimeTextBox.Text != "") && (PriceTextBox.Text != "") && (NameTextBox.Text != ""))
                {
                    if (!numValidation(PriceTextBox.Text))
                    {
                        if ((Convert.ToInt64(PriceTextBox.Text) >= 1) && (NameTextBox.Text.Length <= 40))
                        {
                            partnership.UpdateQuery(Convert.ToDateTime(TimeTextBox.Text).ToShortDateString(), Convert.ToInt64(PriceTextBox.Text), NameTextBox.Text, Convert.ToInt32(id));
                            SMDataGrid.ItemsSource = partnership.GetData();
                        }
                        else
                        {
                            MessageBox.Show("Значения были введенны в непредусмотренном виде");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Цена не может принимать знаки или буквы");
                    }
                }
                else
                {
                    MessageBox.Show("Поле не должно быть пустым");
                }
            }
            else
            {
                MessageBox.Show("Выберите значение из таблицы");
            }
        }
    }
}
