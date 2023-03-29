using System;
using System.Text.RegularExpressions;
using System.Windows;
using LastProjectPracticeCsharp.clothes_shopDataSetTableAdapters;
namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Валидация && Вся логика && Адаптивная верстка готовы!
        data_for_log_inTableAdapter data = new data_for_log_inTableAdapter();
        bool IsLogined = false;
        int s = 0;
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if ((LoginTextBox.Text == "") || (PasswordTextBox.Password == ""))
            {
                MessageBox.Show("Поля должны быть заполнены");
            }
            else
            {
                var usersData = data.GetData().Rows;
                for (int i = 0; i < usersData.Count; i++)
                {
                    if ((usersData[i][2].ToString() == LoginTextBox.Text) && (usersData[i][3].ToString() == PasswordTextBox.Password))
                    {
                        IsLogined = true;
                        s = i;
                        break;
                    }

                }
                if (IsLogined == true)
                {
                    if (Convert.ToInt32(usersData[s][4]) == 1)
                    {
                        AdminPanel window1 = new AdminPanel();
                        window1.Show();
                        Close();
                    }
                    else if (Convert.ToInt32(usersData[s][4]) == 12)
                    {
                        TopManagerWindow window2 = new TopManagerWindow();
                        window2.Show();
                        Close();
                    }

                    else if (Convert.ToInt32(usersData[s][4]) == 24)
                    {
                        DesignerWindow window3 = new DesignerWindow();
                        window3.Show();
                        Close();
                    }
                    else if (Convert.ToInt32(usersData[s][4]) == 2)
                    {
                        KassaWindow window4 = new KassaWindow();
                        window4.Show();
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Данные были введенны неверно или Такого пользователя не существует");
                }
            }
        }
    }
}

