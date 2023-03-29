
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using LastProjectPracticeCsharp.clothes_shopDataSetTableAdapters;
namespace LastProjectPracticeCsharp
{
    /// <summary>
    /// Логика взаимодействия для Clothes.xaml
    /// </summary>
    public partial class Clothes : Page
    {
        Clothes_shopTableAdapter shop = new Clothes_shopTableAdapter();
        type_of_clothesTableAdapter clothes = new type_of_clothesTableAdapter();
        dillerTableAdapter diller = new dillerTableAdapter();
        receiptTableAdapter receipt = new receiptTableAdapter();
        public Clothes()
        {
            InitializeComponent();
            IsManComboBox.Items.Add("Женский");
            IsManComboBox.Items.Add("Мужской");
            ClothesDataGrid.ItemsSource = clothes.GetData();
            ClothesDataGrid.IsReadOnly = true;

            shopIdComboBox.ItemsSource = shop.GetData();
            shopIdComboBox.SelectedValuePath = "shop_id";
            shopIdComboBox.DisplayMemberPath  = "name";

            SupplierIdComboBox.ItemsSource = diller.GetData();
            SupplierIdComboBox.SelectedValuePath = "supplier_id";
            SupplierIdComboBox.DisplayMemberPath = "country";

            ReceiptIdComboBox.ItemsSource = receipt.GetData();
            ReceiptIdComboBox.SelectedValuePath = "receipt_id";
            ReceiptIdComboBox.DisplayMemberPath = "receipt_id";

        }

        private static readonly Regex _regex = new Regex("[^0-9]+");
        private static bool numValidation(string text)
        {
            return _regex.IsMatch(text);
        }
        public bool strValidation(string str)
        {
            var pattern = "^.{1,40}$";
            return (Regex.IsMatch(str, pattern));
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ClothesDataGrid.SelectedItem != null)
            {
                var id = (ClothesDataGrid.SelectedItem as DataRowView).Row[0];
                clothes.DeleteQuery(Convert.ToInt32(id));
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (ClothesDataGrid.SelectedItem != null)
            {
                if ((IsManComboBox.SelectedItem != null) && (shopIdComboBox.SelectedItem != null) && (ReceiptIdComboBox.SelectedItem != null) && (SupplierIdComboBox.SelectedItem != null))
                {
                    var id = (ClothesDataGrid.SelectedItem as DataRowView).Row[0];
                    bool isMan;
                    if (IsManComboBox.SelectedIndex == 0)
                    {
                        isMan = false;
                    }
                    else
                    {
                        isMan = true;
                    }
                    int shopid = Convert.ToInt32(shopIdComboBox.SelectedValue);
                    int recid = Convert.ToInt32(ReceiptIdComboBox.SelectedValue);
                    int supid = Convert.ToInt32(SupplierIdComboBox.SelectedValue);

                    if ((strValidation(TypeOfProductTextBox.Text)) && (strValidation(SeasonTextBox.Text)) && (!numValidation(PriceTextBox.Text)))
                    {
                        clothes.UpdateQuery(TypeOfProductTextBox.Text, recid, supid, shopid, Convert.ToInt64(PriceTextBox.Text), SeasonTextBox.Text, isMan,Convert.ToInt32(id));
                        ClothesDataGrid.ItemsSource = clothes.GetData();
                    }
                    else
                    {
                        MessageBox.Show("Поля были заполнены неверно.");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите значение в выпадающем списке.");
                }
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if ((IsManComboBox.SelectedItem != null) && (shopIdComboBox.SelectedItem != null) && (ReceiptIdComboBox.SelectedItem != null) && (SupplierIdComboBox.SelectedItem != null))
            {
                bool isMan;
                if (IsManComboBox.SelectedIndex == 0)
                {
                    isMan = false;
                }
                else
                {
                    isMan = true;
                }
                int shopid = Convert.ToInt32(shopIdComboBox.SelectedValue);
                int recid = Convert.ToInt32(ReceiptIdComboBox.SelectedValue);
                int supid = Convert.ToInt32(SupplierIdComboBox.SelectedValue);
               
                if ((strValidation(TypeOfProductTextBox.Text)) && (strValidation(SeasonTextBox.Text)) && (!numValidation(PriceTextBox.Text)))
                {
                    clothes.InsertQuery(TypeOfProductTextBox.Text, recid,supid,shopid,Convert.ToInt64(PriceTextBox.Text), SeasonTextBox.Text,isMan);
                    ClothesDataGrid.ItemsSource = clothes.GetData();
                }
                else
                {
                    MessageBox.Show("Поля были заполнены неверно.");
                }
            }
            else
            {
                MessageBox.Show("Выберите значение в выпадающем списке.");
            }
            
        }

        private void ClothesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ClothesDataGrid.SelectedItem != null)
            {
                TypeOfProductTextBox.Text = Convert.ToString((ClothesDataGrid.SelectedItem as DataRowView).Row[1]);
                PriceTextBox.Text = Convert.ToString((ClothesDataGrid.SelectedItem as DataRowView).Row[5]);
                SeasonTextBox.Text = Convert.ToString((ClothesDataGrid.SelectedItem as DataRowView).Row[6]);
            }    
        }

        private void MarketWindowButton_Click(object sender, RoutedEventArgs e)
        {
            ReceiptsWindow window = new ReceiptsWindow();
            window.Show();
        }
    }
}
