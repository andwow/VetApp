   M S B A M L   `   `   `  ����A  =VetApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:VetApp.ViewsVetApp.Views  5   	       VetApp.Views.Employees   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:VetApp.Views     5   	     � Title$  	Employees��5   	   $	��450��6   $	��800��6(   
����·� � WindowState$ 	Maximized=�6N    � 	Resources 5	       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Padding	 
� GradientOrigin
 �� RelativeTransform �� CenterX �� CenterY �� ScaleX �� ScaleY T� X T� Y � Offset � Color �� Triggers P� Property P� Value��%]  '��       �� 5
   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� 
�������$��2q�65   $ 10��6I   $ 7q�6[   ��5      
� 5   "   $	 0.496,1.052&�66   
 5   &   V� 5   *   .~�5   .   �� $	 0.5Q�6=   $	 0.5Q�6K   $	 1.5Q�5   9   $	 1.5Q�6F   T� 5   .   $
 0.02Q�6A   $	 0.3Q�6J   5   +   .��5   &   � $ 1Q�63   $ DeepSkyBlue��6>   � 5   &   $	 0.3Q�63   $ SkyBlue��6@   � 5    &   $	 0.3Q�63   $ LightSkyBlue��6@   5!   #   ._�5#      �� #��z��6(   $��Center=�6P   $��12(�6k   $��Center=�6y   $
��Bold"�6�   $��Verdana)�6�   
�������6�   5$      5%      5'       5(      P� 5)       �@J�IsMouseOver . . �5*      ��  � �� 5+      �� 5,      " ��6.   .R�5-   "   �� 
����  �$��2q�6@   $ 10��6T   $ 7q�6f   ��5.   &   
� 5/   *   $	 0.496,1.052&�6>   
 50   .   V� 51   2   .~�52   6   �� $	 0.5Q�6E   $	 0.5Q�6S   $	 1.5Q�53   9   $	 1.5Q�6F   T� 54   6   $
 0.02Q�6I   $	 0.3Q�6R   55   3   .��57   .   � $ 1Q�6;   $ 	LightBlue��6F   � 58   .   $	 0.3Q�6;   $ White��6H   59   +   ._�5;   &   �� #��z��60   $��Center=�6X   $��12(�6s   $��Center=�6�   $
��Bold"�6�   $��Verdana)�6�   
����  �6�   5<   #   5=      5?      5@      5B      5C      .��5D      � ��5E   
   �� 5F       �� ImageSource$ ../Images/bg3.jpg��6    � RowDefinitions 5H   
   �� 5I      $��* �6   �� 5J      $��3* �6   �� 5K      $
��auto �6   �� 5L      $��* �6    � ColumnDefinitions 5N   
   �� 5O      $��* �6   �� 5P      $��3* �6   �� 5Q      $
��auto �6   �� 5R      $
��auto �6   �� 5S      $��* �6   .+�5U   
   �� $��1��6   $4��.Double-click on an eployee to see his profile.��6$   $��Bottom=�6Z   &   System.Windows.Controls.DataGrid  5V   
   -   5        $��1��5V      $��1��6       
IsReadOnly .    AutoGenerateColumns .  $��3��6�   ��60   �� *	Employees+   Columns 5W      0  *System.Windows.Controls.DataGridTextColumn  5X      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5Y      $ 
First name��6%    69   �� *	FirstName+  5Z      $ 	Last name��6%    68   �� *
LastName+  5[      $ E-mail��6%    65   �� *Email+  5\      $ 	Phone no.��6%    68   �� *Phone+  5]      $ Country��6%    66   �� *	Country+  5^      $ State��6%    64   �� *
District+  5_      $
 City��6%    63   �� *City+  5`      $ Address��6%    66   �� *	Address+5b      �� 5c   
   -   5         ��Name$ Refresh��5c   .   $��2��6   $��2��6   $��Refresh��6?   $��5q�6Q   6\   �� 5d   
   -   5        $ 
CreateUser��5d   .   $��2��6   $��3��6   $��Add user��6B   $��5q�6U   6`   5e      5f      