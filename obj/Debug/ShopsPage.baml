   M S B A M L   `   `   `  ����T  PLastProjectPracticeCsharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LastProjectPracticeCsharpLastProjectPracticeCsharp  5      )    #LastProjectPracticeCsharp.ShopsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:LastProjectPracticeCsharp     5        N� Title$  	ShopsPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      $
��0.4* �6    �� 5      $
��0.4* �6    �� 5      $
��0.4* �6    � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $
��0.3* �6   �� 5      �� 5      $��0.15* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ShopsDataGrid��5      $��4��6*   $��2��6;   6O   �� 5   
   -   5         ��Name$ ChangeAutoButton��5      $��6��6+    "  MaterialDesignRaisedDarkButton#��[  5      $��3��6E   $��Bottom=�6U   $��Center=�6p   $��85��6�    � Cursor$
 Hand��6�   .��6�   	Изм.5      �� 5    
   -   5        $ CreateAutoButton��5       $��6��6+   #��[  5!      $��2��6E   $��Bottom=�6U   $��Center=�6p   $��85��6�   $
 Hand��6�   .��6�   Создать5#      �� 5%   
   -   5        $ DeleteAutoButton��5%      $��6��6+   #��[  5&      $��4��6E   $��Bottom=�6U   $��Center=�6p   $��85��6�   $
 Hand��6�   .��6�   Удалить5(      �� 5*   
   -   5         ��Name$ PartnersComboBox��5*      $��2��5+   	   $��1��5,      $��3��5-      $	��Top=�5.   	   $��	10 5 10 0q�5/   	   �� 51   
   $��1��52      $	��Top=�53      $��2��54      $
��Left=�55      $'��!Выберите партнера��56      $��10 35 10 10q�57      $��3��6"   $	��250��58      ���	#FF320B866   �� 5:   
   -   5         ��Name$ NameTextBox��5<   	   $��0��5;      $��3��5<      $	��Top=�5=      $��2��5>      $
��Left=�5?      $��10 20 10 10q�5@      $	��250��5A      �� 5C   
   $��0��5D      $��Bottom=�5E      $��2��5F      $
��Left=�5G      $,��&Введите имя магазина��5H      $��10 10 10 10q�5I      $��3��6"   $	��250��5J      ���	#FF320B866   5L      5M      