   M S B A M L   `   `   `  ����A  =VetApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:VetApp.ViewsVetApp.Views  5   	       VetApp.Views.MyCart   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:VetApp.Views     5   	     � Title$  MyCart��5   	   $	��450��6   $	��700��6%   
����·�.��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��3* �6   �� 5      $��30 �6   �� 5      $
��auto �6   �� 5      $��3* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��1��6!   $��3��61   $^��XDouble-click on an intervention to remove it. You can modify the Name and the Next date.��6E   $��Bottom=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Interventions��5      $��2��6*   $��1��67   $��2��6G      AutoGenerateColumns .  ��6[   �� *MyCart.Interventions+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $ Pet ID��6%    .  65   �� *Pet+6M     5       $
 Name��6%    .   63   �� *Name+6L     5!      $
 Type��6%    .  63   �� *Type+6L     5"      $
 Date��6%    .  63   �� *
DateString+6R     5#      $ 	Next date��6%    .   68   �� *NextDateString+6[     5$      $ Price��6%    .  64   �� *Price+6N   5&      �� 5'   
   $��4��6   $��1��6!   $��3��61   $X��RDouble-click on a product to remove it from the cart. You can modify the Quantity.��6E   $��Bottom=�6�     5(   
   -   5        $ UsedProducts��5(      $��5��6)   $��1��66   $��2��6F    .  ��6Z   �� *MyCart.Items+ 5)        5*      $ Quantity��6%    67   �� *
Quantity+  5+      $ Intervention ID��6%    .  6>   �� *InterventionId+6a     5,      $ ID��6%    .  61   �� *Id+6H     5-      $
 Name��6%    .  63   �� *Name+6L     5.      $
 Type��6%    .  63   �� *Type+6L     5/      $ Price��6%    .  64   �� *Price+6N   51      �� 52   
   $��Price:��6   $��6��6"   $��1��6/   $��Center=�6?   $��Right=�6Z   �� 53   
   -   5        	 ��Name$	 Price��53      $��6��6!   $��2��6.   $��5q�6>   
 �� 
IsReadOnly
 . ��6[   �� *MyCart.TotalPrice+�� 54   
   -   5         ��Name$ PlaceInterventions��54   .   $��7��6   $��2��6   $��Place interventions��6J   $��5q�6h   6s   55      56      