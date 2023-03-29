using LastProjectPracticeCsharp.clothes_shopDataSetTableAdapters;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для dataForAutorization.xaml
    /// </summary>
    public partial class dataForAutorization : Page
    {
        // Валидация && Вся логика && Адаптивная верстка готовы!
        data_for_log_inTableAdapter data = new data_for_log_inTableAdapter();
        staffTableAdapter staff = new staffTableAdapter();
        rolesTableAdapter roles = new rolesTableAdapter();
        public dataForAutorization()
        {
            InitializeComponent();
            AutorizationInfoDataGrid.ItemsSource = data.GetData();
            AutorizationInfoDataGrid.IsReadOnly = true;
            AutoComboBox.ItemsSource = staff.GetData();
            AutoComboBox.DisplayMemberPath = "surname";
            AutoComboBox.SelectedValuePath = "position_id";
            StaffComboBox.ItemsSource = roles.GetData();
            StaffComboBox.DisplayMemberPath = "role";
            StaffComboBox.SelectedValuePath = "role_id";
        }

        private void AutorizationInfoDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AutorizationInfoDataGrid.SelectedItem != null)
            {
                LoginTextBox.Text = (AutorizationInfoDataGrid.SelectedItem as DataRowView).Row[2].ToString();
                PasswordTextBox.Password = (AutorizationInfoDataGrid.SelectedItem as DataRowView).Row[3].ToString();
            }

        }
        public bool dataLengthvalidation(string str)
        {
            string pattern = @"^(?=.*[@#&()–[{}]:;',?/~^+=<>])$";
            string secondPattern = "^(?=.*[0-9])(?=.*[a-z]).{5,40}$";
            if ((Regex.IsMatch(str, pattern) == false) && (Regex.IsMatch(str,secondPattern) == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void CreateAutoButton_Click(object sender, RoutedEventArgs e)
        {
            if ((StaffComboBox.SelectedValue != null) && (AutoComboBox.SelectedValue != null))
            {
                int RoleId = Convert.ToInt32(StaffComboBox.SelectedValue);
                int posId = Convert.ToInt32(AutoComboBox.SelectedValue);

                if((dataLengthvalidation(LoginTextBox.Text) == true) && (dataLengthvalidation(PasswordTextBox.Password) == true))
                {
                     data.InsertQuery(posId, LoginTextBox.Text, PasswordTextBox.Password, RoleId);
                     AutorizationInfoDataGrid.ItemsSource = data.GetData();

                }
                else
                {
                    MessageBox.Show("Были введенны недопустимые значения.");
                }
            }
            else
            {
                MessageBox.Show("Выберите значения из выпалающих списков.");
            }
        }

        private void ChangeAutoButton_Click(object sender, RoutedEventArgs e)
        {
            if(AutoComboBox.SelectedItem != null)
            {
                if ((StaffComboBox.SelectedValue != null) && (AutoComboBox.SelectedValue != null))
                {
                    int RoleId = Convert.ToInt32(StaffComboBox.SelectedValue);
                    int posId = Convert.ToInt32(AutoComboBox.SelectedValue);
                    object id = (AutorizationInfoDataGrid.SelectedItem as DataRowView).Row[0];
                    if ((dataLengthvalidation(LoginTextBox.Text) == true) && (dataLengthvalidation(PasswordTextBox.Password) == true))
                    {
                        data.UpdateQuery(posId, LoginTextBox.Text, PasswordTextBox.Password, RoleId, Convert.ToInt32(id));
                        AutorizationInfoDataGrid.ItemsSource = data.GetData();

                    }
                    else
                    {
                        MessageBox.Show("Были введенны недопустимые значения.");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите значения из выпалающих списков.");
                }

            }
            else
            {
                MessageBox.Show("Выберите значение из таблицы.");
            }
        }

        private void DeleteAutoButton_Click(object sender, RoutedEventArgs e)
        { if (AutorizationInfoDataGrid.SelectedItem != null)
            {
                object id = (AutorizationInfoDataGrid.SelectedItem as DataRowView).Row[0];
                data.DeleteQuery(Convert.ToInt32(id));
                AutorizationInfoDataGrid.ItemsSource = roles.GetData();
            }
            else
            {
                MessageBox.Show("Выберите значение из таблицы.");
            }
        }
    }
}
