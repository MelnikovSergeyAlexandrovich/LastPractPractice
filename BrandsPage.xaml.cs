using LastProjectPracticeCsharp.clothes_shopDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;


namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для BrandsPage.xaml
    /// </summary>
    public partial class BrandsPage : Page
    {
        brandTableAdapter brand = new brandTableAdapter();
        public BrandsPage()
        {
            InitializeComponent();
            BrandDataGrid.ItemsSource = brand.GetData();
            BrandDataGrid.IsReadOnly = true;
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
        private void BrandDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BrandDataGrid.SelectedItem != null)
            {
                BrandTextBox.Text = Convert.ToString((BrandDataGrid.SelectedItem as DataRowView).Row[1]);
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (BrandDataGrid.SelectedItem != null)
            {
                var id = (BrandDataGrid.SelectedItem as DataRowView).Row[0];
                if (strLengthvalidation(BrandTextBox.Text) == true)
                {
                    brand.UpdateQuery(BrandTextBox.Text,Convert.ToInt32(id));
                    BrandDataGrid.ItemsSource = brand.GetData();
                    
                }
                else
                {
                    MessageBox.Show("Недопустимое имя бренда");
                }
            }
            else
            {
                MessageBox.Show("Выберите значение из таблицы");
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (strLengthvalidation(BrandTextBox.Text) == true)
            {
                brand.InsertQuery(BrandTextBox.Text);
                BrandDataGrid.ItemsSource = brand.GetData();
            }
            else
            {
                MessageBox.Show("Недопустимое имя бренда");
            }
            
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (BrandDataGrid.SelectedItem != null)
            {
                var id = (BrandDataGrid.SelectedItem as DataRowView).Row[0];
                brand.DeleteQuery(Convert.ToInt32(id));
                BrandDataGrid.ItemsSource = brand.GetData();
            }
            else
            {
                MessageBox.Show("Выберите значение из таблицы");
            }
        }

        private void GetDataButton_Click(object sender, RoutedEventArgs e)
        {
            List<brandClass> forImport = DataConverter.DeserializeObject<List<brandClass>>();
            if (forImport != null)
            {
                foreach (var item in forImport)
                {
                    brand.InsertQuery(item.brand);
                    BrandDataGrid.ItemsSource = brand.GetData();
                }
            }
            else
            {
                MessageBox.Show("Файл пуст.");
            }
        }
    }
}
