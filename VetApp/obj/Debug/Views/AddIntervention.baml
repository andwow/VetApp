   M S B A M L   `   `   `  ����A  =VetApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:VetApp.ViewsVetApp.Views  5   	   "    VetApp.Views.AddIntervention   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:VetApp.Views     5   	     � Title$  
AddVaccine��5   	   $	��600��6   $	��525��6)   
����·�.��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      $��3* �6   �� 5      $��30 �6   �� 5      $��3* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��3* �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��1��6!   $��Intervention name: ��61   $��Center=�6L   �� 5   
   -   5         ��Name$ IntvName��5   /   $��1��6   $��2��6   $��5q�6A   ��6L   �� *CurrentIntervention.Name+�� 5   
   $��2��6   $��1��6!   $��Intervention date: ��61   $��Center=�6L   �� 5    
   -   5        $ IntvDate��5    /   $��2��6   $��2��6   $��5q�6A   ��6L   �� * CurrentIntervention.DateString+�� 5!   
   $��3��6   $��1��6!   $��Intervention next date: ��61   $��Center=�6Q   ��5"      �� 5#       �� 
TargetType" ��6    �� Triggers 5$      �� 5%       �� Binding 6&   �� *	Visible+ �� Value	 False6B   .a�5&      ��  �� Property � y�	 �� Value$	 Hidden=�6;   5'      5)      5+      �� 5,   
   -   5        $ IntvNextDate��5,   /   $��3��6   $��2��6   $��5q�6E   ��6P   �� *$"CurrentIntervention.NextDateString+.��6�   ��5-      �� 5.      " ��6    5/      �� 50       6&   �� *	Visible+	 False6B   .a�51      ��  � y�$	 Hidden=�6;   52      54      .��55      56      �� 57   
   $��4��6   $��1��6!   $2��,Double-click on a product to add it to cart.��61   $��Bottom=�6e   &   System.Windows.Controls.DataGrid  58   
   -   5        
  Name$
 AvailableProducts��58      $��5��6.   $��1��6;      
IsReadOnly .    AutoGenerateColumns .  $��2��6�   ��6K   �� *AvailableProducts+   Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5;      $ Product code��6%    6;   �� *ProductCode+  5<      $
 Name��6%    63   �� *Name+  5=      $
 Type��6%    63   �� *Type+  5>      $ Price��6%    64   �� *Price+  5?      $ Quantity��6%    67   �� *
Quantity+5A      �� 5B   
   $��6��6   $��1��6!   $��5��61   $T��NDouble-click on a product to remove it from cart. You can modify the quantity.��6E   $��Bottom=�6�     5C   
   -   5        $
 UsedProducts��5C      $��7��6)   $��1��66    .  $��2��6�   ��6F   �� *UsedProducts+ 5D        5E      $ Quantity��6%    67   �� *
Quantity+  5F      $ ID��6%      
IsReadOnly .  61   �� *Id+6H     5G      $ Product code��6%    .  6;   �� *ProductCode+6[     5H      $
 Name��6%    .  63   �� *Name+6L     5I      $
 Type��6%    .  63   �� *Type+6L     5J      $ Price��6%    .  64   �� *Price+6N   5L      �� 5M   
   $��Price:��6   $��8��6"   $��1��6/   $��Center=�6?   $��Right=�6Z   �� 5N   
   -   5        $ Price��5N      $��8��6!   $��2��6.   $��5q�6>    �� 
IsReadOnly . 6I   �� 5O   
   -   5         ��Name$ 	AddToCart��5O   .   $��9��6   $��2��6   $��Add to cart��6A   $��5q�6W   6b   5P      5Q      