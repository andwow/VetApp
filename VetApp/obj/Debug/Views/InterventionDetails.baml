   M S B A M L   `   `   `  ����A  =VetApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:VetApp.ViewsVetApp.Views  5   	   &     VetApp.Views.InterventionDetails   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:VetApp.Views     5   	     � Title$  InterventionDetails��5   	   $	��450��6%   $	��400��62   
����·�.��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      $��3* �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��3* �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��1��6!   $��Intervention name: ��61   $��Center=�6L   �� 5   
   -   5         ��Name$ IntvName��5   /   $��1��6   $��2��6   $��5q�6A    �� 
IsReadOnly . ��6L   �� *CurrentIntervention.Name+6v   �� 5   
   $��2��6   $��1��6!   $��Intervention date: ��61   $��Center=�6L   �� 5   
   -   5        $ IntvDate��5   /   $��2��6   $��2��6   $��5q�6A    . ��6L   �� * CurrentIntervention.DateString+6|   �� 5   
   $��3��6   $��1��6!   $��Intervention next date: ��61   $��Center=�6Q   ��5      �� 5        �� 
TargetType" ��6    �� Triggers 5!      �� 5"       �� Binding 6&   �� *	Visible+ �� Value	 False6B   .a�5#      �� 	 �� Property	 � y�
 �� Value$
 Hidden=�6;   5$      5&      5(      �� 5)   
   -   5        $ IntvNextDate��5)   /   $��3��6   $��2��6   $��5q�6E    . ��6P   �� *$"CurrentIntervention.NextDateString+.��6�   ��5*      �� 5+      " ��6    5,      �� 5-       6&   �� *	Visible+	 False6B   .a�5.      �� 	 � y�$
 Hidden=�6;   5/      51      .��52      53      &   System.Windows.Controls.DataGrid  54   
   -   5          Name$ InterventionItems��54      $��5��6.   $��1��6;      
IsReadOnly .    AutoGenerateColumns .  $��2��6�   ��6K   �� *InterventionItems+   Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  57      $
 Name��6%    63   �� *Name+  58      $
 Type��6%    63   �� *Type+  59      $ Price��6%    64   �� *Price+  5:      $ Quantity��6%    67   �� *
Quantity+  5;      $ Total price��6%    6:   �� *TotalPriceStr+5=      �� 5>   
   $��6��6   $��1��6!   $��Price: ��61   $��Right=�6@   $��Center=�6\   �� 5?   
   $��6��6   $��2��6    . $��5q�6m   ��6/   �� *TotalPriceStr+ �� Mode$ OneWay=�6m   5@      5A      