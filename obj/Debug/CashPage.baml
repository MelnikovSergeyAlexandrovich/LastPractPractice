   M S B A M L   `   `   `  ����T  PLastProjectPracticeCsharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LastProjectPracticeCsharpLastProjectPracticeCsharp  5      (    "LastProjectPracticeCsharp.CashPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:LastProjectPracticeCsharp     5        N� Title$  CashPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��0.15* �6   �� 5       � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      �� 5      $��0.15* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   .+�5   
   �� -   5         ��Name$ 
backButton��5          MaterialDesignOutlinedButton#��[  5      $��1��5      $��0��6   $��Back.��5      $��60��6   $��0 0 0 0q�5      ���	#FF010004
���   �$��18(�5    �    � Cursor$
 Hand��6�   {�6   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�6�   �� 5#   
   -   5        #��[  5$      $��1��5%      $��1��6   $��80��6"   $��^��5&      $��2,0 0 60q�5'      ���	#FF010004
���   �$��18(�5(   �   {�6   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   �� 5*   
   -   5        $ ReceiptGetButton��5*      #��[  5+      $��0��5,      $��5��6   $��3��6"   $��Выгрузить чек��5-      $��Bottom=�6   ���	#FF010004
���   �$��18(�5/   �   $
 Hand��6�   {�6   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   �� 51   
   -   5         ��Name$ ServicesComboBox��51      $��3��6.   $��3��6;   53      �� 55   
   -   5         ��Name$ PriceTextBox��55      	 �� AcceptsReturn	 . 
 �� TextWrapping$

 Wrap=�58      $��4��59      $��3��6   {�5:      ��  �� Path$ 	IsChecked� �� ElementName$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5<   
   -   5        $ 
SumTextBox��5<      $	��Top=�5=      	 . $

 Wrap=�5?      $��2��5@      $��3��6   {�5A      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox��&   System.Windows.Controls.DataGrid  5B   
   -   5          Name$ ClothesDataGrid��5B      $��1��6,   6<     5C   
   -   5        $ CashDataGrid��5C      $��1��6)   $��2��66   6H   �� 5D   
   $)��#Ассортимент одежды��6   $��Center=�6.    �� TextAlignment$ Center=�6J   $��20(�6a   6q   �� 5E   
   $��Корзина��6   $��2��6#   $��Center=�63   $ Center=�6O   $��20(�6f   6v   5F      5G      