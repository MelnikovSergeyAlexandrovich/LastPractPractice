   M S B A M L   `   `   `  ����T  PLastProjectPracticeCsharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LastProjectPracticeCsharpLastProjectPracticeCsharp  5   	   *    $LastProjectPracticeCsharp.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:LastProjectPracticeCsharp     5   	     � Title$  
MainWindow��5	   	   $	��400��6   $	��500��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��3* �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $
��0.3* �6   .+�5   
   �� -   5         ��Name$ LoginTextBox��5         MaterialDesignFilledTextBox#��[  5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��5      $��1��5      $��Center=�5      $��Center=�6(   $��45��5      $	��300��5      $��1��5      .��6   5      �� 5    
   $��1��6   $��Center=�6$   $��Center=�6?   $	��200��6\   $��8 60 8 8q�6h   $'��!Войдите в аккаунт.��6z    �� TextAlignment$ Center=�6�   $��14(�6�   $��Bahnschrift)�6�   6�   G� 5"   
   -   5         G�Name$ PasswordTextBox��5"      $��Center=�5#   	   $��Center=�6$   $��2��5$   	   $��45��5%   	   $	��300��5&   	   $��1��5'   	    ) %MaterialDesignFilledRevealPasswordBox#��[ 5(   	   $ Пароль��5*   	   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . {�5)   	   ��  �� ElementName$! RevealPasswordFilledEnabled��	 �� Path$	 	IsChecked�5+   	   �� 5.   
   -   5        
 ��Name$
 LogInButton��5.       " MaterialDesignFlatDarkBgButton#��[ 5/   	    � ToolTip$" MaterialDesignFlatDarkButton��50   	   $��3��51   	   $��1��52   	   $��
Войти��53   	   $��9q�54   	    � Cursor$
 Hand��55   ~   {�6	   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�6�   � 57   
    � IsIndeterminate . $��3��58       $��3��64   $��Bottom=�6A   59      5:      