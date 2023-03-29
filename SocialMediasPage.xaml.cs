using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using LastProjectPracticeCsharp.clothes_shopDataSetTableAdapters;

namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для SocialMediasPage.xaml
    /// </summary>
    public partial class SocialMediasPage : Page
    {

        // Валидация && Вся логика && Адаптивная верстка готовы!
        social_mediasTableAdapter socialMedia = new social_mediasTableAdapter();   
        Clothes_shopTableAdapter shop = new Clothes_shopTableAdapter();
        public SocialMediasPage()
        {
            InitializeComponent();
            SMDataGrid.ItemsSource = socialMedia.GetData();
            SMDataGrid.IsReadOnly = true;
            ShopIdComboBox.ItemsSource= shop.GetData();
            ShopIdComboBox.DisplayMemberPath = "shop_id";
            ShopIdComboBox.SelectedValuePath = "shop_id";
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (SMDataGrid.SelectedItem != null)
            {
                object id = (SMDataGrid.SelectedItem as DataRowView).Row[0];
                object shopId = ShopIdComboBox.SelectedValue;
                if (LinkTextBox.Text != "")
                {
                    if (LinkTextBox.Text.Length <= 250)
                    {
                        socialMedia.UpdateQuery(Convert.ToInt32(shopId), LinkTextBox.Text, Convert.ToInt32(id));
                        SMDataGrid.ItemsSource = socialMedia.GetData();
                    }
                    else
                    {
                        MessageBox.Show("Недопустимая длина ссылки. Попробуйте сократить её до оптимальных размеров");
                    }
                }
                else
                {

                    MessageBox.Show("Поле должно быть заполнено");
                }
            }
            else
            {
                MessageBox.Show("Выберите значение из таблицы");
            }

        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (SMDataGrid.SelectedItem != null)
            {
                object id = (SMDataGrid.SelectedItem as DataRowView).Row[0];
                socialMedia.DeleteQuery(Convert.ToInt32(id));
                SMDataGrid.ItemsSource = socialMedia.GetData();
            }
            else
            {
                MessageBox.Show("Выберите элемент в таблице");
            }
            
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            
               
                    int shopId = Convert.ToInt32(ShopIdComboBox.SelectedValue);
                    if (LinkTextBox.Text != "")
                    {
                        if (LinkTextBox.Text.Length <= 250)
                        {
                            socialMedia.InsertQuery(shopId, LinkTextBox.Text);
                            SMDataGrid.ItemsSource = socialMedia.GetData();
                }
                        else
                        {
                            MessageBox.Show("Недопустимая длина ссылки. Попробуйте сократить её до оптимальных размеров");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Поле должно быть заполнено");
                    }
                
                
        }

        private void SMDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SMDataGrid.SelectedItem != null)
            {
                LinkTextBox.Text = Convert.ToString((SMDataGrid.SelectedItem as DataRowView).Row[2]);
            }
            
        }

        private void GetDataButton_Click(object sender, RoutedEventArgs e)
        {
            List<socialMediasClass> forImport = DataConverter.DeserializeObject<List<socialMediasClass>>();
            if (forImport != null)
            {
                foreach (var item in forImport)
                {
                    socialMedia.InsertQuery(item.id,item.link);
                    SMDataGrid.ItemsSource = socialMedia.GetData();
                }

            }
            else
            {
                MessageBox.Show("Файл пуст.");
            }
        }
    }
}
