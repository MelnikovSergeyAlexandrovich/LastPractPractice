   M S B A M L   `   `   `  ����T  PLastProjectPracticeCsharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LastProjectPracticeCsharpLastProjectPracticeCsharp  5      +    %LastProjectPracticeCsharp.ServiceInfo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:LastProjectPracticeCsharp     5        N� Title$  ServiceInfo��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      $
��0.4* �6   �� 5      $
��0.4* �6   �� 5      $
��0.4* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      $
��0.3* �6   .+�5   
   �� -   5         ��Name$ ServiceTextBox��5      $��2��5   	   $��10 10 10 10q�5      $��3��5       $��1��5!      $	��Top=�5"       �� AcceptsReturn . $��25��5$      �� 5'   
   $��1��6   $��3��6!   $��2��65   $��Center=�6E   $��10 10 10 20q�6`   $4��.Введите название сервиса��6u   ���	#FF1B9E116�   �� 5)      -   5        $ PriceTextBox��5)   
   $��2��5,   	   $��10 10 10 10q�5-      $��3��5.      $��2��5/      $	��Top=�50       . $��25��52      �� 55   
   $��2��6   $��3��6!   $��2��65   $��Center=�6E   $��10 10 10 20q�6`   $��Введите Цену��6u   ���	#FF1B9E116�   � 57   
    � IsIndeterminate . $��0��58      $��2��6'   $��3��67   $	��Top=�6K   ���	#FF1B9E11���	#FF6DA43A���	#FF26C33E6�   �� 5:   
   -   5         ��Name$ DeleteButton��5:       '  #MaterialDesignRaisedSecondaryButton#��[  5;   	    � ToolTip$8 2Resource name: MaterialDesignRaisedSecondaryButton��5<   	   $��Удалить��5=   	   $��4��6   $��4��6+   ���	#FF1B9E11 � Cursor$
 Hand��5>   �   {�6	   �� *DataContext.ControlsEnabled+	 �� RelativeSource	 �� *FindAncestor+
 �� AncestorType$
 WindowL�6�   &   System.Windows.Controls.DataGrid  5@   
   -   5          Name$ 	RDataGrid��5@      $��5��6&   $��2��67   6K   �� 5B   
   -   5        $ ChangeButton��5B      #��[  5C   	   $8 2Resource name: MaterialDesignRaisedSecondaryButton��5D   	   $��Изм.��5E   	   $��3��6   $��4��6(   ���	#FF1B9E11{�5F   	   �� *DataContext.ControlsEnabled+	 �� *FindAncestor+$
 WindowL�6�   �� 5H   
   -   5        $ CreateButton��5H      #��[  5I   	   $8 2Resource name: MaterialDesignRaisedSecondaryButton��5J   	   $��Создать��5K   	   $��2��6   $��4��6+   ���	#FF1B9E11{�5L   	   �� *DataContext.ControlsEnabled+	 �� *FindAncestor+$
 WindowL�6�   5M      5N      