   M S B A M L   `   `   `  ����A  =VetApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:VetApp.ViewsVetApp.Views  5   	        VetApp.Views.Interventions   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:VetApp.Views     5   	     � Title$  Interventions��5   	   $	��450��6   $	��800��6,   
����·� � WindowState$ 	Maximized=�6R   .��5	      � ��5
   
   �� 5       �� ImageSource$ ../Images/bg1.jpg��6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��1��5      $��1��6    $��3��60      AutoGenerateColumns .     
IsReadOnly . ��6D   �� *InterventionList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� *Id+  5      $
 Name��6%   	 63   �� *Name+  5      $
 Type��6%   	 63   �� *Type+  5      $
 Date��6%   	 63   �� *
DateString+  5       $ 	Next date��6%   	 68   �� *NextDateString+  5!      $ Price��6%   	 64   �� *Price+5#      �� 5$   
   -   5        
 ��Name$
 Refresh��5$   .   $��2��6   $��2��6   $��Refresh��6?   $��5q�6Q   6\   �� 5%   
   -   5        $
 AddIntervention��5%   .   $��2��6   $��3��6   $��Add intervention��6G   $��5q�6b   6m   5&      5'      