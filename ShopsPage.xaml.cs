
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using LastProjectPracticeCsharp.clothes_shopDataSetTableAdapters;

namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для ShopsPage.xaml
    /// </summary>
    public partial class ShopsPage : Page
    {
        Clothes_shopTableAdapter shop = new Clothes_shopTableAdapter();
        partnershipTableAdapter partner = new partnershipTableAdapter();

        public ShopsPage()
        {
            InitializeComponent();
            ShopsDataGrid.ItemsSource = shop.GetData();
            ShopsDataGrid.IsReadOnly = true;
            PartnersComboBox.ItemsSource = partner.GetData();
            PartnersComboBox.SelectedValuePath = "partnership_id";
            PartnersComboBox.DisplayMemberPath = "partner";
        }
        
        public bool strLengthvalidation(string str)
        {
            var pattern = "^.{1,40}$";
            return Regex.IsMatch(str, pattern);
        }

        private void ShopsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ShopsDataGrid.SelectedItem != null)
            {
                NameTextBox.Text = Convert.ToString((ShopsDataGrid.SelectedItem as DataRowView).Row[2]);
            }
        }

        private void DeleteAutoButton_Click(object sender, RoutedEventArgs e)
        {
            if (PartnersComboBox.SelectedValue != null)
            {
                var shopid = (ShopsDataGrid.SelectedItem as DataRowView).Row[0];
                shop.DeleteQuery(Convert.ToInt32(shopid));
                ShopsDataGrid.ItemsSource = shop.GetData();
            }
            else
            {
                MessageBox.Show("Выберите значение из таблицы.");
            }
        }

        private void ChangeAutoButton_Click(object sender, RoutedEventArgs e)
        {
            if (PartnersComboBox.SelectedValue != null)
            {
                var shopid = (ShopsDataGrid.SelectedItem as DataRowView).Row[0];
                if ((strLengthvalidation(NameTextBox.Text) == true) && (PartnersComboBox.SelectedItem != null))
                {
                    int id = Convert.ToInt32(PartnersComboBox.SelectedValue);
                    shop.UpdateQuery(id, NameTextBox.Text,Convert.ToInt32(shopid));
                    ShopsDataGrid.ItemsSource = shop.GetData();
                }
                else
                {
                    MessageBox.Show("Значения были введены неверно.");
                }
            }
            else
            {
                MessageBox.Show("Выберите значение из таблицы.");
            }
        }

        private void CreateAutoButton_Click(object sender, RoutedEventArgs e)
        {
             if ((strLengthvalidation(NameTextBox.Text) == true) && (PartnersComboBox.SelectedItem != null))
             {
                int id = Convert.ToInt32(PartnersComboBox.SelectedValue);
                shop.InsertQuery(id, NameTextBox.Text);
                ShopsDataGrid.ItemsSource = shop.GetData();
             }
            else
            {
                MessageBox.Show("Значения были введены неверно.");
            }
        }
    }
}
