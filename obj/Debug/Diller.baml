   M S B A M L   `   `   `  ����T  PLastProjectPracticeCsharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LastProjectPracticeCsharpLastProjectPracticeCsharp  5      &     LastProjectPracticeCsharp.Diller   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:LastProjectPracticeCsharp     5        N� Title$  Diller��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6    � RowDefinitions 5   
   �� 5      $
��0.6* �6   �� 5      $
��0.6* �6   �� 5      $
��0.4* �6   �� 5      $
��0.8* �6   �� 5      $
��0.3* �6   .+�5   
   �� $��3��6   $��3��6$   $��Center=�68   $��10 55 10 10q�6S   $,��&Введите цену закупки��6h   ���	#FF0059EA6�   �� 5   
   -   5         ��Name$ PriceTextBox��5      $��3��5      $��3��5      $�� 10 0 10 10q�5        %  !MaterialDesignFloatingHintTextBox#��[  5#      $��Center=�5$      �� 5%   
   $��3��6   $��3��6$   $��Center=�68   $��1��6S   $��10 55 10 10q�6a   $!��Введите страну��6v   ���	#FF0059EA6�   �� 5&   
   -   5        $ CountryTextBox��5&      $��3��5'      $��3��5(      $��1��6!   $�� 10 0 10 10q�5)      #��[  5,      $��Center=�5-      &   System.Windows.Controls.DataGrid  5/   
   -   5          Name$ DillerDataGrid��5/      $��3��6+   $��5��6?   6�   �� 50   
   -   5         ��Name$ DeleteButton��50      $��5��51       * &MaterialDesignFlatSecondaryMidBgButton#��[ 52       � ToolTip$. (MaterialDesignFlatAccentBackgroundButton��53      $��Удалить��54      $��4��55      $��Bottom=�56      $��Center=�57      ���	#FF0059EA���	#FF0059EA
�������{�58      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�6�   �� 5:   
   -   5        $ ChangeButton��5:      $��4��5;      #��[ 5<      $. (MaterialDesignFlatAccentBackgroundButton��5=      $��4��5>      $��Bottom=�5?      $��Center=�5@      $��85��5A      $��Изм.��5B      ���	#FF0059EA���	#FF0059EA
�������{�5C      �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   �� 5E   
   -   5        $ CreateButton��5E      $��4��5F      $��Bottom=�5G      $��Center=�5H      $��3��5I      #��[ 5J      $. (MaterialDesignFlatAccentBackgroundButton��5K      $��Создать��5L      ���	#FF0059EA���	#FF0059EA
�������{�5M      �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   �� 5O   
   -   5        	 ��Name$	 BrandIdComboBox��5O      $��3��5P   	   $��2��5Q   	   $��3��6   $	��Top=�5R   	   $��	10 5 10 0q�5S   	   
 �� 
IsEditable
 . 5T   	   �� 5V   
   $��3��6   $��3��6$   $��Bottom=�68   $��
10 0 10 10q�6S   $!��Выберите бренд��6g   $��2��6~   ���	#FF0059EA5W      5[      5\      