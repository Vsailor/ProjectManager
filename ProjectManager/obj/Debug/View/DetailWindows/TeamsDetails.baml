   M S B A M L   `   `   `  ����A  =PMView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PMViewPMView  5   	   =#clr-namespace:PMView.View.WrapperVMPMView.View.WrapperVM  5   	       PMView.TeamsDetails   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:PMView     5   	   9	WrapperVM#clr-namespace:PMView.View.WrapperVM     5   	   -   5          � Title$  Team Details��5	   	   $	��500��6   $	��850��6+    � WindowStartupLocation$ CenterScreen=�68    � 	Resources 5
         validationFailed �� Orientation J� Opacity  ProfileButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType	 ��Name
 �� Triggers P� Property P� Value �� RelativeSource �� Path��%  &	        &	 �     '��     �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� 
���  ��$��2q�6+   $	 0.3Q�6?   ._�5      �� 5      �� 5      
���  ��$��15(�6-   $
��Bold"�6;   $��!��6M   5      5      5      �� 5   
   " ��6+   .�5      ��  � ��
 ���� 6+   �� 5       � ��
 ���� 6,   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5      #��z��5      ._�5      �� $	 PART_Content��6/   #��z��5   +   #��z��5   +   #��z��5    +   6c   5!      5"      5$      
 5%      P� 5&       �@J�IsMouseOver . . �5'      ��  � ��
 ��·�63   �� 5(       �@J�Opacity$	 0.8Q�60   �� 5*       � ��
 ��·�64   5+      5-      �� 5.   
   " ��6   
 5/      P� 50       �@=�HasError . . �51      ��  �@�ToolTip 52      ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent��� 54       � ��
 �  ��63   55      57      58      .��5:      � $��Stretch=�6   $��Stretch=�6(   ��5;   
   �� 5<       �� ImageSource$  /Assets/MainBackground.png��6   6D    � RowDefinitions 5>   
   �� 5?      $
��auto �6   �� 5@      $
��auto �6   �� 5A      $
��auto �6   �� 5B      $
��auto �6   �� 5D      $
��auto �6    5F   
    �� DataType'   !PMView.View.WrapperVM.User_TeamVM �� Opacity �� Color��%,  (��       5G      *, +)�� 6   "  6   .R�5H      �� 
�������$	��Top=�6.   ._�5I      � $	��Top=�6    5J      �� 5K      $
��auto �6,   �� 5L      $��* �6,   .+�5N      �� $��0��6$   $��14(�6G   $
��Bold"�6U   ��61   �� *User+6U   �� 5O      $��1��6"   $	��Top=�6R   $��Disabled=�6j   ��6/   �� *	Positions+��5P      �� 5Q   "   $ 0Q�62   $ SkyBlue��6>   ��5S      �� 5T   "   $ 0Q�62   ��5V      �� 5W   "   .R�5X   &   � 5Y   #   5[      5\      5]      5^      5_      .+�5a   
   � $��0��6   $	��Top=�6   $��Stretch=�64   ��5b      �� 5c      $ White��6"   $	 0.3Q�60   6@   .+�5e      �� $��Team properties��6   $��30(�6.   $��Center=�6<   5f      � 5g   
   $��1��6   $��
15,15,15,0q�6   ��5h      �� 5i      $ White��6"   $	 0.5Q�60   6@    � ColumnDefinitions 5k      �� 5l      $��* �6#   �� 5m      $��* �6#   .+�5p      � $��0��6   $��Stretch=�6#   $��Stretch=�6@    5q      �� 5r      $
��auto �6$   �� 5s      $
��auto �6$   �� 5t      $
��auto �6$   �� 5u      $
��auto �6$   �� 5v      $
��auto �6$   �� 5w      $��* �6$   .+�5z      � $��0��6   $	��Top=�6$   $��15,0,0,0q�6<   .+�5{      �� $��Team:��6    $��18(�6-   5|      � 5}      $��1��6   $	��Top=�6$   $��15,0,0,0q�6<   .+�5~      �� -   5         �� TextWrapping$
 Wrap=�5~      $��12(�62    =� ErrorTemplate# [  6@   .��6�   .��5      �� $
 Name�6"    �� ValidationRules 5�      5  /System.Windows.Controls.DataErrorValidationRule  5�   "   5�      5�      5�      � 5�      $��2��6   $	��Top=�6$   $��15,0,0,0q�6<   .+�5�      �� $��Description:��6    $��18(�64   5�      � 5�      $��3��6   $	��Top=�6$   $��15,0,0,0q�6<   .+�5�      �� -   5        $
 Wrap=�5�      $��12(�62   # [  6@   .��6�   .��5�      �� $ Description�6"    5�        5�   "   5�      5�      5�      � 5�      $��4��6   $	��Top=�6$   $��15,0,0,0q�6<    5�      �� 5�      $
��auto �6+   �� 5�      $
��auto �6+   .+�5�      � $��0��6   .+�5�      �� $��
Employees:��6$   $��18(�66   $��	0,10,0,10q�6N   5�      � 5�      $��1��6   .+�5�      �� -   5        $��AddEmployee��5�   W   $��Add/Edit��6!   $	��100��64   $��
10,10,0,10q�6C   ��5�      L� 5�   "   $	 0.5Q�6/   5�      5�      5�      � 5�      $��5��6   $��Stretch=�6$   $��15,0,0,0q�6@   .+�5�      �� -   5        $��EmployeesListBox��5�   (   $��14(�6   $��Disabled=�6@   $	��Top=�6w   ��5�      �� *EmployeesCollection+��5�      �� 5�      $ 0Q�6.   $ SkyBlue��6:   ��5�      �� 5�      $ 0Q�6.   ��5�      �� 5�      .R�5�   "   � 5�      5�      5�      5�      � 5�      $��1��6   $��Stretch=�6#   $��15,0,0,0q�6?    5�      �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   �� 5�      $��* �6$   .+�5�      � $��0��6   .+�5�      �� $��Skills:��6    $��18(�6/   5�      � 5�      $��1��6   .+�5�      �� -   5        $��SkillsListBox��5�   (   $��14(�6   $��Disabled=�6=   $	��Top=�6t   ��5�      �� *SkillsCollection+��5�      �� 5�      $ 0Q�6.   $ SkyBlue��6:   ��5�      �� 5�      $ 0Q�6.   ��5�      �� 5�      .R�5�   "   � 5�      5�      5�      � 5�      -   5        $��PositionsGrid��5�   $   $��2��6   $y�Hidden=�69    5�      �� 5�      $
��auto �6(   �� 5�      $
��auto �6(   �� 5�      $
��auto �6(   .+�5�      � $��0��6   $��Stretch=�6(   .+�5�      �� $��
Positions:��6$   $��18(�66   5�      � 5�      $��1��6   $��Stretch=�6(   $��5,0,5,5q�6F   .+�5�      �� -   5        $��PositionListBox��5�   (   $��14(�6   $��Disabled=�6?   $	��Top=�6v   $
��Auto=�6�   ��5�      �� 5�   "   $	 0.5Q�62   $ SkyBlue��6@   ��5�      �� 5�   "   $	 0.8Q�62   $ White��6@   5�      5�      5�      5�      5�      � 5�   
   $��2��6   $��	15,0,15,0q�6   ��5�      �� 5�      $ White��6"   $	 0.5Q�60   6@   .+�5�      �� $��Orders:��6   $��18(�6'   $��
15,0,15,10q�65   5�      � 5�   
   $��3��6   $��	15,0,15,0q�6   ��5�      �� 5�      $ White��6"   $	 0.5Q�60   6@   .+�5�      &   System.Windows.Controls.DataGrid  -	   5        $��OrdersDataGrid��5�         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5�   @      
IsReadOnly .    AutoGenerateColumns .  $   HorizontalScrollBarVisibility$ Hidden=�5�      "   VerticalScrollBarVisibility$
 Auto=�6>   $	��300��6a   ��5�      �� *OrdersCollection+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Project name��6*   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� $
 Name�  �� Mode$  OneWay=�  5�      $ Description��6*    6?   �� $ Description�$  OneWay=�  5�      $ 
Start date��6*    6>   �� $ 	StartDate�$  OneWay=�  5�      $ Release date��6*    6@   �� $ ReleaseDate�$  OneWay=�  5�      $ Price��6*    69   �� $ Price�$  OneWay=�  5      $ Status��6*    6:   �� $ Status�$  OneWay=�5     5     � 5  
   $��4��6   .+�5     � $��Right=�6   $��
15,0,15,15q�6/   .+�5     � .+�5     �� -
   5        $��
SaveButton��5     $
��Save��6/   $	��100��6>   $��
20,10,10,0q�6J   ��5     �� 5	     " ��6$   .�5
  "   ��  � {� 6>   �� $ ButtonsActive�5     ��5     L� 5     $	 0.5Q�6+   5     5     5     5     5     5     