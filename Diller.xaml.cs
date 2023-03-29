using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using LastProjectPracticeCsharp.clothes_shopDataSetTableAdapters;

namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для Diller.xaml
    /// </summary>
    public partial class Diller : Page
    {
        dillerTableAdapter diller = new dillerTableAdapter();
        brandTableAdapter brand = new brandTableAdapter();  
        public Diller()
        {
            InitializeComponent();
            DillerDataGrid.ItemsSource = diller.GetData();
            DillerDataGrid.IsReadOnly = true;
            BrandIdComboBox.ItemsSource = brand.GetData();
            BrandIdComboBox.DisplayMemberPath = "brandName";
            BrandIdComboBox.SelectedValuePath = "brand_id";
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


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (DillerDataGrid.SelectedItem != null)
            {
                object dillerId = (DillerDataGrid.SelectedItem as DataRowView).Row[0];
                diller.DeleteQuery(Convert.ToInt32(dillerId));
                DillerDataGrid.ItemsSource = diller.GetData();
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DillerDataGrid.SelectedItem != null)
            {
                object dillerId = (DillerDataGrid.SelectedItem as DataRowView).Row[0];
                if (BrandIdComboBox.SelectedItem != null)
                {
                    int id = Convert.ToInt32(BrandIdComboBox.SelectedValue);
                    if (!numValidation(PriceTextBox.Text))
                    {
                        if ((Convert.ToInt64(PriceTextBox.Text) >= 0) && ((strLengthvalidation(CountryTextBox.Text) == true)))
                        {
                            diller.UpdateQuery(id, Convert.ToInt64(PriceTextBox.Text), CountryTextBox.Text,Convert.ToInt32(dillerId));
                            DillerDataGrid.ItemsSource = diller.GetData();
                        }
                        else
                        {
                            MessageBox.Show("Недопустимые значения цены или Страны.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Цена не может состоять из букв или знаков");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите бренд в выпадающем списке.");
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент в таблице.");
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (BrandIdComboBox.SelectedItem != null)
            { 
                int id = Convert.ToInt32(BrandIdComboBox.SelectedValue);
                if (!numValidation(PriceTextBox.Text))
                {
                    if ((Convert.ToInt64(PriceTextBox.Text) >= 0) && ((strLengthvalidation(CountryTextBox.Text) == true)))
                    {
                        diller.InsertQuery(id,Convert.ToInt64(PriceTextBox.Text),CountryTextBox.Text);
                        DillerDataGrid.ItemsSource = diller.GetData();
                    }
                    else
                    {
                        MessageBox.Show("Недопустимые значения цены или Страны.");
                    }
                }
                else
                {
                    MessageBox.Show("Цена не может состоять из букв или знаков");
                }
            }
            else
            {
                MessageBox.Show("Выберите бренд в выпадающем списке.");
            }
        }
        private void BrandDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DillerDataGrid.SelectedItem != null)
            {
                PriceTextBox.Text = Convert.ToString((DillerDataGrid.SelectedItem as DataRowView).Row[2]);
                CountryTextBox.Text = Convert.ToString((DillerDataGrid.SelectedItem as DataRowView).Row[3]);
            }
        }
    }
}
