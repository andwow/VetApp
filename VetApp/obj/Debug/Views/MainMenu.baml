   M S B A M L   `   `   `  ����A  =VetApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:VetApp.ViewsVetApp.Views  5   	       VetApp.Views.MainMenu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:VetApp.Views     5   	     � Title$  	Main Menu��5   	   $	��450��6   $	��800��6(   
����·� � WindowState$ 	Maximized=�6N    � 	Resources 5	       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Padding	 
� GradientOrigin
 �� RelativeTransform �� CenterX �� CenterY �� ScaleX �� ScaleY T� X T� Y � Offset � Color �� Triggers P� Property P� Value��%C  '��       �� 5
   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� 
�������$��2q�65   $ 10��6I   $ 10q�6[   ��5      
� 5   "   $	 0.496,1.052&�66   
 5   &   V� 5   *   .~�5   .   �� $	 0.5Q�6=   $	 0.5Q�6K   $	 1.5Q�5   9   $	 1.5Q�6F   T� 5   .   $
 0.02Q�6A   $	 0.3Q�6J   5   +   .��5   &   � $ 1Q�63   $ DeepSkyBlue��6>   � 5   &   $	 0.3Q�63   $ SkyBlue��6@   � 5    &   $	 0.3Q�63   $ LightSkyBlue��6@   5!   #   ._�5#      �� #��z��6(   $��Center=�6P   $��Center=�6k   $
��Bold"�6�   $��Verdana)�6�   
�������6�   5$      5%      5'       5(      P� 5)       �@J�IsMouseOver . . �5*      ��  � �� 5+      �� 5,      " ��6.   .R�5-   "   �� 
����  �$��2q�6@   $ 10��6T   $ 10q�6f   ��5.   &   
� 5/   *   $	 0.496,1.052&�6>   
 50   .   V� 51   2   .~�52   6   �� $	 0.5Q�6E   $	 0.5Q�6S   $	 1.5Q�53   9   $	 1.5Q�6F   T� 54   6   $
 0.02Q�6I   $	 0.3Q�6R   55   3   .��57   .   � $ 1Q�6;   $ 	LightBlue��6F   � 58   .   $	 0.3Q�6;   $ White��6H   59   +   ._�5;   &   �� #��z��60   $��Center=�6X   $��Center=�6s   $
��Bold"�6�   $��Verdana)�6�   
����  �6�   5<   #   5=      5?      5@      5B      5C      .��5D      � ��5E   
   �� 5F       �� ImageSource$ ../Images/bg1.jpg��6    � RowDefinitions 5H   
   �� 5I      $��* �6   �� 5J      $
��auto �6   �� 5K      $
��auto �6   �� 5L      $
��auto �6   �� 5M      $
��auto �6   �� 5N      $
��auto �6   �� 5O      $��* �6    � ColumnDefinitions 5Q   
   �� 5R      $��2* �6   �� 5S      $��* �6   �� 5T      $��2* �6   .+�5W   
   �� $��Vet App��6   $��0��6#   $��3��63   $��Center=�6G   $��Center=�6d   $��50(�6   
����� �$
��Bold"�6�   �� 5X   
   -   5         ��Name$ Clients��5X   .   $��1��6   $��1��6   $��Clients��6?   $��5q�6Q   6\   �� 5Y   
   -   5        $ Stocks��5Y   .   $��2��6   $��1��6   $��Stocks��6>   $��5q�6O   6Z   �� 5Z   
   -   5        $ AllSales��5Z   .   $��3��6   $��1��6   $��	All sales��6@   $��5q�6T   6_   �� 5[   
   -   5        $ 	Employees��5[   .   $��4��6   $��1��6   $��	Employees��6A   $��5q�6U   6`   �� 5\   
   -   5        $ Profile��5\   .   $��5��6   $��1��6   $��
My profile��6?   $��5q�6T   6_   5]      5^      