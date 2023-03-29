using LastProjectPracticeCsharp.clothes_shopDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для CashPage.xaml
    /// </summary>
    public partial class CashPage : Page
    {
        type_of_clothesTableAdapter clothes = new type_of_clothesTableAdapter();
        serviceTableAdapter service = new serviceTableAdapter();   
        receipt_infoTableAdapter receiptInfo = new receipt_infoTableAdapter();
        receiptTableAdapter receipt = new receiptTableAdapter();
        public CashPage()
        {
            InitializeComponent();
            ClothesDataGrid.ItemsSource = clothes.GetData();
            ClothesDataGrid.IsReadOnly = true;
            CashDataGrid.IsReadOnly = true;
            ServicesComboBox.ItemsSource = service.GetData();
            ServicesComboBox.SelectedValuePath = "service_id";
            ServicesComboBox.DisplayMemberPath = "name";
            
        }
        private static readonly Regex _regex = new Regex("[^0-9]+");
        private static bool numValidation(string text)
        {
            return _regex.IsMatch(text);
        }

        public class ClassClothes
        {
            public int id { get; set; }
            public string product { get; set; }
            public long price { get; set; }
            public string season { get; set; }
            public bool isMan { get; set; }
        }
        public List<ClassClothes> list1 = new List<ClassClothes>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ClothesDataGrid.SelectedItem != null)
            {
                var Id = (ClothesDataGrid.SelectedItem as DataRowView).Row[0];
                var Name = (ClothesDataGrid.SelectedItem as DataRowView).Row[1];
                var Price = (ClothesDataGrid.SelectedItem as DataRowView).Row[5];
                var Season = (ClothesDataGrid.SelectedItem as DataRowView).Row[6];
                var IsMan = (ClothesDataGrid.SelectedItem as DataRowView).Row[7];
                var bumbum = new ClassClothes() { id = Convert.ToInt32(Id), product = Convert.ToString(Name), price = Convert.ToInt64(Price), season = Convert.ToString(Season), isMan = Convert.ToBoolean(IsMan) };

                list1.Add(bumbum);
                CashDataGrid.ItemsSource = null;
                CashDataGrid.ItemsSource = list1;
            } 
        }

        private void ReceiptGetButton_Click(object sender, RoutedEventArgs e)
        {
            if(SumTextBox.Text != "" && PriceTextBox.Text!=null)
            {
                if(ServicesComboBox.SelectedItem != null)
                {
                    if (!numValidation(SumTextBox.Text) && !numValidation(PriceTextBox.Text))
                    {
                      
                        var a = receiptInfo.GetDataBy3();
                        int receipt_id = (int)a.Rows[0][0];
                        var total = list1.Sum(x => x.price);
                        if (Convert.ToInt64(SumTextBox.Text) >= total + Convert.ToInt64(PriceTextBox.Text))
                        {
                            var name = (ServicesComboBox.SelectedItem as DataRowView).Row[2].ToString();
                            service.InsertQuery(Convert.ToInt64(PriceTextBox.Text),name);
                            receiptInfo.InsertQuery(Convert.ToInt64(SumTextBox.Text), total);
                            receipt.InsertQuery(receipt_id,Convert.ToInt32(ServicesComboBox.SelectedValue));
                            MessageBox.Show("ssd");

                        }
                        else
                        {
                            MessageBox.Show("Недостаточно денег");
                        }
                        
                        //receiptInfo.InsertQuery()
                    }
                    else
                    {
                        MessageBox.Show("Число было введенно неверно");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите значение в выпадающем списке");
                }
            }
            else
            {
                MessageBox.Show("Поле не должно быть пустым");
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();    
            a.Show();
            
        }
    }
}
