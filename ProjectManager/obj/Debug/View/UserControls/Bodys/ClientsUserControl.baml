   M S B A M L   `   `   `  ����A  =PMView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PMView.ViewPMView.View  5      $    PMView.View.ClientsUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:PMView.View     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   .+�5      � $��0��6   .+�5      �� $��Clients:��6   $��18(�6,   $��	0,10,0,10q�6D   5      � 5      $��1��6   .+�5      �� -   5        $��	AddClient��5      $	��Add��6*   $��50��68   $��
10,10,0,10q�6F   ��5      L� 5       �� Opacity$	 0.5Q�6'   5      5      � 5      $��2��6   .+�5       �� -   5        $��
EditClient��5       $
��Edit��6+   $��50��6[   $��
10,10,0,10q�6i   {�6:   �� *
EditButton+��5!      L� 5"      $	 0.5Q�6'   5$      5%      � 5&      $��3��6   .+�5'      �� -   5        $��RemoveClient��5'      $��Remove��6-   $��50��6b   $��
10,10,0,10q�6p   {�6?   �� *RemoveButton+��5(      L� 5)      $	 0.5Q�6'   5+      5,      5-      � 5.   
   $��1��6   $	��Top=�6   $��Stretch=�64   .+�5/      &   System.Windows.Controls.DataGrid  -   5        $��ClientsDataGrid��5/   $   $��0��6      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 50   A      
IsReadOnly .    AutoGenerateColumns .  $   HorizontalScrollBarVisibility$ Hidden=�53      "   VerticalScrollBarVisibility$
 Auto=�6>   $	��300��6a      	RowHeight$ 20Q�54      ��50      �� *ClientsCollection+	   Columns	 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6*   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   ��  �� Path$
 Name� �� Mode$ OneWay=�  57      $
 Surname��6*    6;   �� $ Surname�$ OneWay=�  58      $
 Login��6*    69   �� $ Login�$ OneWay=�  59      $
 Email��6*    69   �� $ Email�$ OneWay=�  5:      $
 Skype��6*    69   �� $ Skype�$ OneWay=�  5;      $
 Country��6*    6;   �� $ Country�$ OneWay=�5>      5?      5@      5A      