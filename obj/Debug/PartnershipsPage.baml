   M S B A M L   `   `   `  ����T  PLastProjectPracticeCsharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LastProjectPracticeCsharpLastProjectPracticeCsharp  5      0    *LastProjectPracticeCsharp.PartnershipsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:LastProjectPracticeCsharp     5        N� Title$  PartnershipsPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��1.5* �6   �� 5      �� 5      �� 5      �� 5      $
��0.4* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
SMDataGrid��5      $��2��6'   $��5��6;   5      �� 5   
   -   5         ��Name$ CreateButton��5      $��4��6'    "  MaterialDesignRaisedDarkButton#��[  5      $��2��6E   $��Bottom=�6U   $
��Left=�6p   $��90��6�   ���	#FFA52270 � Cursor$
 Hand��6�   .��6�   Создать5      �� 5!   
   -   5        $ DeleteButton��5!      $��4��6'   #��[  5"      $��2��6E   $��Bottom=�6U   $��Right=�6p   $��90��6�   ���	#FFA52270.��6�   Удалить5$      �� 5&   
   -   5        $ ChangeButton��5&      $��4��6'   #��[  5'      $��2��6E   $��Bottom=�6U   $��Center=�6p   $��85��6�   $
 Hand��6�   ���	#FFA52270.��6�   	Изм.5)      �� 5+   
   -   5         ��Name$ PriceTextBox��5+      $��1��5,      $��2��5-      $	��Top=�5.      $��10 10 10 10q�5/       % !MaterialDesignFloatingHintTextBox#��[ 50      �� 52   
   -   5        $ TimeTextBox��52      $��2��53      $��2��54      #��[ 55      $	��Top=�56      $��10 10 10 15q�6   �� 57   
   -   5        $ NameTextBox��57      $��3��58      $��2��59      #��[ 5:      $	��Top=�5;      $��10 10 10 10q�6   �� 5<   
   $��2��6   $	��Top=�6$   $��10 35 10 10q�6<   $!��Введите данные��6Q   $��0��6g   ���	#FFA522706�   �� 5=   
   $��2��6   $��Bottom=�6$   $��10 10 10 10q�6?   $��Введите цену��6T   $��1��6h   ���	#FFA522706�   �� 5>   
   $��2��6   $��Bottom=�6$   $��2��6?   $��10 10 10 10q�6L   $-��'Введите длительность��6a   ���	#FFA522706�   �� 5?   
   $��2��6   $��Bottom=�6$   $��3��6?   $��10 10 10 10q�6L   $6��0Введите Название компании��6a   ���	#FFA522706�   5A      5B      