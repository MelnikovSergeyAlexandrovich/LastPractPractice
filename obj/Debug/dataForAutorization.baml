   M S B A M L   `   `   `  ����T  PLastProjectPracticeCsharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LastProjectPracticeCsharpLastProjectPracticeCsharp  5      3    -LastProjectPracticeCsharp.dataForAutorization   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:LastProjectPracticeCsharp     5        N� Title$  dataForAutorization��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��0.7* �6   �� 5      $
��0.7* �6   �� 5      $
��0.7* �6   �� 5      $
��0.7* �6   �� 5      $��0.25* �6   .+�5   
   �� -   5         ��Name$ StaffComboBox��5      $��2��5   	   $��2��5      $��10 10 10 10q�5   	   �� 5#   
   -   5        $ AutoComboBox��5#      $��2��5$   	   $��3��5%      $��10 10 10 10q�5&   	    �� 
IsEditable . 5'   	   �� 5)   
   $
��Left=�6   $��Выберите роль��6/   $��2��6D   $��2 ��6R   $��Bottom=�6c   ���	#FF7347EF$��10 20 10 10q�6�   6�   �� 5+   
   $
��Left=�6   $/��)Выберите пользователя��6/   $��3��6L   $��2 ��6Z   $��Bottom=�6k   ���	#FF7347EF$��10 10 10 10q�6�   6�   &   System.Windows.Controls.DataGrid  5/   
   -   5          Name$ AutorizationInfoDataGrid��5/      $��5��65   $��2��6F   6�   � 50   
    � IsIndeterminate . $��2��51   (   $	��Top=�68   G� 53   
   -   5         G�Name$ PasswordTextBox��53      $��2��54   	   $��10 10 10 10q�55      $��1��56      $	��Top=�57       )  %MaterialDesignFilledRevealPasswordBox#��[  58   	   {�59   	   ��  �� ElementName$! RevealPasswordFilledEnabled��	 �� Path$	 	IsChecked��� 5<   
   $
��Left=�6   $��
Логин��6/   $��2 ��6<   $��Bottom=�6M   ���	#FF7347EF$��0��6�   $��10 10 10 10q�6�   6�   �� 5=   
   $
��Left=�6   $��Пароль��6/   $��2 ��6=   $��Bottom=�6N   ���	#FF7347EF$��1��6�   $��10 10 10 10q�6�   6�   �� 5?   
   -   5        
 ��Name$
 LoginTextBox��5?        MaterialDesignFilledTextBox#��[ 5@      $��2��5A   	   $��10 10 10 10q�5B      $	��Top=�5C       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5E      $	��400��5F      {�5G      �� $	 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5I   
   -   5         ��Name$ CreateAutoButton��5I       " MaterialDesignRaisedDarkButton#��[ 5J      $��2��6E   $�� 4��6U   $��Bottom=�6d   $
��Left=�6   $��90��6�   .��6�   Создать5L      �� 5N   
   -   5        $ DeleteAutoButton��5N      #��[ 5O      $��2��6E   $�� 4��6V   $��Bottom=�6e   $��Right=�6�   $��90��6�   .��6�   Удалить5Q      �� 5S   
   -   5        $ ChangeAutoButton��5S      #��[ 5T      $��2��6E   $�� 4��6U   $��Bottom=�6d   $��Center=�6   $��85��6�    � Cursor$
 Hand��6�   .��6�   	Изм.5V      5X      5Y      