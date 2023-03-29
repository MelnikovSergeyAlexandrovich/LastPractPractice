using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using LastProjectPracticeCsharp.clothes_shopDataSetTableAdapters;

namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для Roles.xaml
    /// </summary>
    public partial class Roles : Page
    {
        // Валидация && Вся логика && Адаптивная верстка готовы!
        rolesTableAdapter roles = new rolesTableAdapter();
        
        public Roles()
        {
            InitializeComponent();
            RolesDataGrid.ItemsSource = roles.GetData();
            RolesDataGrid.IsReadOnly = true;
        }
        private void DeleteAutoButton_Click(object sender, RoutedEventArgs e)
        {
            if (RolesTextBox.Text != null)
            {
                if ((RolesTextBox.Text != "") && (RolesTextBox.Text.Length <= 40))
                {
                    roles.InsertQuery(RolesTextBox.Text);
                    RolesDataGrid.ItemsSource = roles.GetData();
                }
                else
                {
                    MessageBox.Show("Введено недопустимое значение");
                }
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым.");
            }
        }

        private void CreateAutoButton_Click(object sender, RoutedEventArgs e)
        {
            if (RolesDataGrid.SelectedItem != null)
            {
                object id = (RolesDataGrid.SelectedItem as DataRowView).Row[0];
                roles.DeleteQuery(Convert.ToInt32(id));
                RolesDataGrid.ItemsSource = roles.GetData();

            }
            else
            {
                MessageBox.Show("Выберите элемент из таблицы");
            }
        }

        private void ChangeAutoButton_Click(object sender, RoutedEventArgs e)
        {
            if(RolesDataGrid.SelectedItem != null)
            {
                object id = (RolesDataGrid.SelectedItem as DataRowView).Row[0];
                if ((RolesTextBox.Text != "") && (RolesTextBox.Text.Length <= 40))
                {
                    roles.UpdateQuery(RolesTextBox.Text,Convert.ToInt32(id));
                    RolesDataGrid.ItemsSource = roles.GetData();
                }
                else
                {
                    MessageBox.Show("Введено недопустимое значение");
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент из таблицы");
            }
        }

        private void RolesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RolesDataGrid.SelectedItem != null) RolesTextBox.Text = ((RolesDataGrid.SelectedItem as DataRowView).Row[1]).ToString();
        }
    }
}
