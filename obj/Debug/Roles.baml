   M S B A M L   `   `   `  ����T  PLastProjectPracticeCsharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LastProjectPracticeCsharpLastProjectPracticeCsharp  5      %    LastProjectPracticeCsharp.Roles   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:LastProjectPracticeCsharp     5        N� Title$  Roles��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      $
��0.3* �6   �� 5      $��0.15* �6   .+�5   
   �� $
��Left=�6   $/��)Данные для заполнения.��6/   $��2 ��6M   $��Bottom=�6^   ���	#FF7347EF$��10 60 10 10q�6�   6�   �� 5   
   $
��Left=�6   $��Новая роль��6/   $��2 ��6A   $��1��6R   $��Bottom=�6_   ���	#FF7347EF$��
10 0 10 10q�6�   6�   �� 5   
   -   5         ��Name$ RolesTextBox��5         MaterialDesignFilledTextBox#��[  5      $��2��5   	   $��10 10 10 10q�5      $��1��5      $	��Top=�5       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5!      $	��400��5#      {�5$      ��  �� Path$ 	IsChecked� �� ElementName$0 *MaterialDesignFilledTextBoxEnabledComboBox��� 5&   
    � IsIndeterminate . $��2��5'   (   $	��Top=�68   &   System.Windows.Controls.DataGrid  5(   
   -   5        	  Name$	 RolesDataGrid��5(      $��2��6*   $��3��6p   6�   �� 5)   
   -   5        
 ��Name$
 DeleteAutoButton��5)       " MaterialDesignRaisedDarkButton#��[ 5*      $��2��6E   $��2��6V   $��Bottom=�6d   $
��Left=�6   $��90��6�   .��6�   Создать5,      �� 5.   
   -   5        $
 CreateAutoButton��5.      #��[ 5/      $��2��6E   $��2��6V   $��Bottom=�6d   $��Right=�6   $��90��6�   .��6�   Удалить51      �� 53   
   -   5        $
 ChangeAutoButton��53      #��[ 54      $��2��6E   $��2��6U   $��Bottom=�6c   $��Center=�6~   $��85��6�    � Cursor$
 Hand��6�   .��6�   	Изм.56      57      58      