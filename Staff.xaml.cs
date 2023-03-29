using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using LastProjectPracticeCsharp.clothes_shopDataSetTableAdapters;

namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для Staff.xaml
    /// </summary>
    public partial class Staff : Page
    {
        staffTableAdapter staff = new staffTableAdapter();
        Clothes_shopTableAdapter shop = new Clothes_shopTableAdapter();
        public Staff()
        {
            InitializeComponent();
            StaffDataGrid.ItemsSource = staff.GetData();
            StaffDataGrid.IsReadOnly = true;
            ShopIdComboBox.ItemsSource = shop.GetData();
            ShopIdComboBox.DisplayMemberPath = "name";
            ShopIdComboBox.SelectedValuePath = "shop_id";
        }

        private void StaffDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StaffDataGrid.SelectedItem != null)
            {
                SalaryTextBox.Text = (StaffDataGrid.SelectedItem as DataRowView).Row[2].ToString();
                NameTextBox.Text = (StaffDataGrid.SelectedItem as DataRowView).Row[4].ToString();
                SecNameTextBox.Text = (StaffDataGrid.SelectedItem as DataRowView).Row[3].ToString();
                PatrNameTextBox.Text = (StaffDataGrid.SelectedItem as DataRowView).Row[5].ToString();
                AgeTextBox.Text = (StaffDataGrid.SelectedItem as DataRowView).Row[6].ToString();
            }
                
        }
        private static readonly Regex _regex = new Regex("[^0-9]+"); 
        private static bool numValidation(string text)
        {
            return _regex.IsMatch(text);
        }

        public bool strLengthvalidation(string str)
        {
            var pattern = "^.{1,40}$";
            return (Regex.IsMatch(str, pattern));
        }
        private void ChangeAutoButton_Click(object sender, RoutedEventArgs e)
        {
            if (ShopIdComboBox.SelectedValue != null)
            {
                int shopId = Convert.ToInt32(ShopIdComboBox.SelectedValue);
                object id = (StaffDataGrid.SelectedItem as DataRowView).Row[0];
                if ((strLengthvalidation(NameTextBox.Text) == true) && (strLengthvalidation(SecNameTextBox.Text) == true) && (strLengthvalidation(PatrNameTextBox.Text) == true) && (SalaryTextBox.Text != "") && (AgeTextBox.Text != ""))
                {
                    if ((numValidation(AgeTextBox.Text)) && numValidation(SalaryTextBox.Text))
                    {
                        if ((Convert.ToInt32(SalaryTextBox.Text) >= 1)  && (Convert.ToInt32(AgeTextBox.Text) > 1) && ((Convert.ToInt32(AgeTextBox.Text) < 100)))
                        {
                            staff.UpdateQuery(shopId, Convert.ToInt64(SalaryTextBox.Text), SecNameTextBox.Text, NameTextBox.Text, PatrNameTextBox.Text, Convert.ToInt32(AgeTextBox.Text), Convert.ToInt32(id));
                            StaffDataGrid.ItemsSource = staff.GetData();
                        }
                        else
                        {
                            MessageBox.Show("Зарплата или возраст были введены неверно");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Вместо чисел нельзя ввести другие знаки или буквы.");
                    }
                }
                else
                {
                    MessageBox.Show("Поле не может быть пустым.");
                }
            }
            else
            {
                MessageBox.Show("Выберите магазин");
            }

        }

        private void DeleteAutoButton_Click(object sender, RoutedEventArgs e)
        {
            if (StaffDataGrid.SelectedItem != null)
            {
                object id = (StaffDataGrid.SelectedItem as DataRowView).Row[0];
                staff.DeleteQuery(Convert.ToInt32(id));
                StaffDataGrid.ItemsSource = staff.GetData();

            }
            else
            {
                MessageBox.Show("Поле не может быть пустым.");
            }
        }

        private void CreateAutoButton_Click(object sender, RoutedEventArgs e)
        {
            if (ShopIdComboBox.SelectedValue != null)
            { 
                int shopId = Convert.ToInt32(ShopIdComboBox.SelectedValue);
                if ((strLengthvalidation(NameTextBox.Text) == true) && (strLengthvalidation(SecNameTextBox.Text) == true) && (strLengthvalidation(PatrNameTextBox.Text) == true) && (SalaryTextBox.Text != "") && (AgeTextBox.Text != ""))
                {
                    if ((numValidation(AgeTextBox.Text)) && numValidation(SalaryTextBox.Text) )
                    {
                        if ((Convert.ToInt32(SalaryTextBox.Text) >= 1) && (Convert.ToInt32(AgeTextBox.Text) > 1) && ((Convert.ToInt32(AgeTextBox.Text) < 100)))
                        {
                        staff.InsertQuery(shopId, Convert.ToInt64(SalaryTextBox.Text), SecNameTextBox.Text, NameTextBox.Text, PatrNameTextBox.Text, Convert.ToInt32(AgeTextBox.Text));
                        StaffDataGrid.ItemsSource = staff.GetData();
                        }
                        else
                        {
                            MessageBox.Show("Зарплата или возраст были введены неверно");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вместо чисел нельзя ввести другие знаки или буквы.");
                    }
                }
                else
                {
                    MessageBox.Show("Поле не может быть пустым.");
                }
            }
            else
            {
                MessageBox.Show("Выберите магазин.");
            }

        }

        
    }
}
