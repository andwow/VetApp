   M S B A M L   `   `   `  ����A  =VetApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:VetApp.ViewsVetApp.Views  5   	       VetApp.Views.AllSales   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:VetApp.Views     5   	     � Title$  AllSales��5   	   $	��450��6   $	��800��6'   
����·� � WindowState$ 	Maximized=�6M   .��5	      � ��5
   
   �� 5       �� ImageSource$ ../Images/bg6.jpg��6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      $��3* �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��3* �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��1��6!   $��Start date: ��61   $��Center=�6E   �� 5   
   -   5         ��Name$ IntvName��5   /   $��1��6   $��2��6   $��5q�6A   ��6L   �� *StartDateStr+ �� Mode$ TwoWay=��� 5    
   $��2��6   $��1��6!   $��	End date:��61   $��Center=�6B   �� 5!   
   -   5        $ IntvDate��5!   /   $��2��6   $��2��6   $��5q�6A   ��6L   �� *
EndDateStr+$ TwoWay=��� 5"   
   -   5         ��Name$ Search��5"   .   $��2��6   $��3��6   $��Search��6>   6O   &   System.Windows.Controls.DataGrid  5#   
   -   5          Name$ InterventionItems��5#      $��5��6.   $��1��6;   	   
IsReadOnly	 . 
   AutoGenerateColumns
 .  $��2��6�   ��6K   �� *Sales+   Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5&      $
 Date��6%    63   �� *
DateString+  5'      $
 Name��6%    63   �� *Name+  5(      $
 Type��6%    63   �� *Type+  5)      $ Price��6%    64   �� *Price+  5*      $ Quantity��6%    67   �� *
Quantity+  5+      $ Total price��6%    6:   �� *TotalPriceStr+5-      �� 5.   
   $��6��6   $��1��6!   $��Total: ��61   $��Right=�6@   $��Center=�6\   �� 5/   
   -   5        $ Total��5/   /   $��6��6   $��2��6    �� 
IsReadOnly . $��5q�6|   ��6>   �� *TotalPriceStr+$ OneWay=�6|   51      52      