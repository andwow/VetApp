   M S B A M L   `   `   `  ����A  =VetApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:VetApp.ViewsVetApp.Views  5   	       VetApp.Views.Clients   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:VetApp.Views     5   	     � Title$  Clients��5   	   $	��450��6   $	��800��6&   
����·� � WindowState$ 	Maximized=�6L   .��5	      � ��5
   
   �� 5       �� ImageSource$ ../Images/bg4.jpg��6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $2��,Double-click on a client to see his profile.��6$   $��Bottom=�6X   &   System.Windows.Controls.DataGrid  5   
   -   5        $��1��5      $��1��6       
IsReadOnly .    AutoGenerateColumns .  $��3��6�   ��60   �� *	Clients+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� *Id+  5      $ 
First name��6%   	 69   �� *	FirstName+  5      $ 	Last name��6%   	 68   �� *
LastName+  5       $ E-mail��6%   	 65   �� *Email+  5!      $ 	Phone no.��6%   	 68   �� *Phone+  5"      $ Country��6%   	 66   �� *	Country+  5#      $ State��6%   	 64   �� *
District+  5$      $
 City��6%   	 63   �� *City+  5%      $ Address��6%   	 66   �� *	Address+5'      �� 5(   
   -   5        
 ��Name$
 Refresh��5(   .   $��2��6   $��2��6   $��Refresh��6?   $��5q�6Q   6\   �� 5)   
   -   5        $
 
CreateUser��5)   .   $��2��6   $��3��6   $��Add user��6B   $��5q�6U   6`   5*      5+      