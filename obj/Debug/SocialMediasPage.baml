   M S B A M L   `   `   `  ����T  PLastProjectPracticeCsharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LastProjectPracticeCsharpLastProjectPracticeCsharp  5      0    *LastProjectPracticeCsharp.SocialMediasPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:LastProjectPracticeCsharp     5        N� Title$  SocialMediasPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��0.15* �6   �� 5      $��0.07* �6   �� 5      $��0.06* �6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
SMDataGrid��5      $��2��6+   $��3��6?   5      �� 5   
   -   5         ��Name$ ShopIdComboBox��5      $��10 10 10 10q�5   	    �� 
IsEditable . $��1��5      $��2��6(   $	��Top=�68   $��25��6P   �� 5   
   $��1��6   $��2��6!   $��Bottom=�61   $%��Выберите магазин��6L   ���	#FFA52270$��
10 0 10 25q�6|   6�   �� 5!   
   -   5         ��Name$ CreateButton��5!       "  MaterialDesignRaisedDarkButton#��[  5"      $��2��6E   $��Bottom=�6U   $��2��6q   $
��Left=�6~   $��90��6�   ���	#FFA52270 � Cursor$
 Hand��6�   .��6�   Создать5$      �� 5&      -   5        $ DeleteButton��5&      #��[  5'      $��2��6E   $��Bottom=�6U   $��2��6q   $��Right=�6~   $��90��6�   ���	#FFA52270$
 Hand��6�   .��6�   Удалить5)      �� 5+      -   5        $ ChangeButton��5+      #��[  5,      $��2��6E   $��Bottom=�6U   $��2��6p   $��Center=�6}   $��85��6�   $
 Hand��6�   ���	#FFA52270.��6�   	Изм.5.      �� 50   
   -   5        $ GetDataButton��50      $��Внести данные��6(   #��[  51      $��0��6E   $��Bottom=�6U   $��3��6p   $��3��6~   ���	#FFA5227053      �� 55   
   -   5         ��Name$ LinkTextBox��55      $��2��56      $	��Top=�57      $��10 60 10 10q�58       % !MaterialDesignFloatingHintTextBox#��[ 59      �� 5@   
   $��2��6   $	��Top=�6$   $��10 35 10 10q�6<   $!��Введите данные��6Q   ���	#FFA522706�   �� 5A   
   $��2��6   $	��Top=�6$   $��10 100 10 10q�6<   $6��0Введите ссылку на соц.сеть��6R   ���	#FFA522706�   5C      5D      