   M S B A M L   `   `   `  ����T  PLastProjectPracticeCsharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LastProjectPracticeCsharpLastProjectPracticeCsharp  5      *    $LastProjectPracticeCsharp.BrandsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:LastProjectPracticeCsharp     5        N� Title$  
BrandsPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6    � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      �� 5      �� 5      $��0.16* �6   .+�5   
   �� $��3��6   $��3��6$   $��Center=�68   $��10 55 10 10q�6S   $(��"Введите имя бренда��6h   ���	#FF0059EA6�   �� 5   
   -   5         ��Name$ BrandTextBox��5      $��3��5      $��3��5      $�� 10 0 10 10q�5       %  !MaterialDesignFloatingHintTextBox#��[  5!      $��Center=�5"      &   System.Windows.Controls.DataGrid  5#   
   -   5          Name$ BrandDataGrid��5#      $��3��6*   $��3��6>   6�   �� 5$   
   -   5         ��Name$ DeleteButton��5$      $��5��5%       * &MaterialDesignFlatSecondaryMidBgButton#��[ 5&       � ToolTip$. (MaterialDesignFlatAccentBackgroundButton��5'      $��Удалить��5(      $��3��5)      $��Bottom=�5*      $��Center=�5+      ���	#FF0059EA���	#FF0059EA
�������{�5,      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�6�   �� 5.   
   -   5        $ ChangeButton��5.      $��4��5/      #��[ 50      $. (MaterialDesignFlatAccentBackgroundButton��51      $��3��52      $��Bottom=�53      $��Center=�54      $��85��55      $��Изм.��56      ���	#FF0059EA���	#FF0059EA
�������{�57      �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   �� 59   
   -   5        $ CreateButton��59      $��3��5:      $��Bottom=�5;      $��Center=�5<      $��3��5=      #��[ 5>      $. (MaterialDesignFlatAccentBackgroundButton��5?      $��Создать��5@      ���	#FF0059EA���	#FF0059EA
�������{�5A      �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   �� 5C   
   -   5        $ GetDataButton��5C      $��4��5D      $��Bottom=�5E      $��3��5F      $��0��5G      #��[ 5H      $. (MaterialDesignFlatAccentBackgroundButton��5I      $-��'Импортировать данные��5J      ���	#FF0059EA���	#FF0059EA
�������{�5K      �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   5L      5M      