   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    RegisterOfPeopleApp(   "RegisterOfPeopleApp.RegisterWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   -   5          �Name$  registerWindow��5   	    � Title$ Register Of People��5	   	   $	��450��6$   $	��450��61   $	��950��6A   $	��950��6M   .��5
      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $��10q�6?   |�.  $��Stretch=�6]   $��Stretch=�6�   ��6    �� *People+��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � |� �� Value .  62   �� 5       � ��$ Stretch=�6C   5       �� View 5      �� 5      ! �� ColumnHeaderContainerStyle 5      �� 5      " ��6    .�5      ��  � ��$ 30��67   �� 5       � ��$
 Bold"�6;   5      .P�5       ��  �� Width$	 100��6%   $��
First Name��61   	 �� CellTemplate	 5!      �� 5"      .R�5#   "   �� .+�5$   &   �� ��60   �� *	FirstName+y�6K   �� 
 �� Path$
 IsInEdit�   visibleIfTrueConverter �� 	Converter# [   �� ConverterParameter$ Inverted���� 5%   &   y�6.   �� $
 IsInEdit�# [  $ Normal����5&   2   �� *	FirstName+ �� Mode$ TwoWay=� �� ValidatesOnDataErrors .  �� ValidatesOnExceptions .  �� NotifyOnValidationError . 5'   #   5(      5*      �� 5,      $	 100��6%   $��	Last Name��61   	 5-      �� 5.      .R�5/   "   �� .+�50   &   �� ��60   �� *
LastName+y�6J   �� $
 IsInEdit�# [  $ Inverted���� 51   &   y�6.   �� $
 IsInEdit�# [  $ Normal����52   2   �� *
LastName+$ TwoWay=� .  .  . 53   #   54      56      �� 58      $	 170��6%   $��Street Address��61   	 59      �� 5:      .R�5;   "   �� .+�5<   &   �� ��60   �� *StreetAddress+y�6O   �� $
 IsInEdit�# [  $ Inverted���� 5=   &    �� Orientation$ 
Horizontal=�61   y�6J   �� $
 IsInEdit�# [  $ Normal��.+�5>   *   �� $��90��62   ��5?   2   �� *
StreetName+$ TwoWay=� .  .  . �� 5@   *   $��29��62   $��5,0,0,0q�6=   ��5A   2   �� *HouseNumber+$ TwoWay=� .  .  . �� 5B   *   $��/��64   $��0,2,0,0q�6=   �� 5C   *   $��29��62   ��6=   �� *ApartmentNumber+$ TwoWay=�5D   '   5E   #   5F      5H      �� 5J      $ 80��6%   $��Postal Code��60   	 5K      �� 5L      .R�5M   "   �� .+�5N   &   �� ��60   �� *
PostalCode+y�6L   �� $
 IsInEdit�# [  $ Inverted���� 5O   &   y�6.   �� $
 IsInEdit�# [  $ Normal����5P   2   �� *
PostalCode+$ TwoWay=� .  .  . 5Q   #   5R      5T      �� 5V      $	 100��6%   $
��Town��61   	 5W      �� 5X      .R�5Y   "   �� .+�5Z   &   �� ��60   �� *Town+y�6F   �� $
 IsInEdit�# [  $ Inverted���� 5[   &   y�6.   �� $
 IsInEdit�# [  $ Normal����5\   2   �� *Town+$ TwoWay=� .  .  . 5]   #   5^      5`      �� 5b      $	 100��6%   $��Phone Number��61   	 5c      �� 5d      .R�5e   "   �� .+�5f   &   �� ��60   �� *PhoneNumber+y�6M   �� $
 IsInEdit�# [  $ Inverted���� 5g   &   y�6.   �� $
 IsInEdit�# [  $ Normal����5h   2   �� *PhoneNumber+$ TwoWay=� .  .  . 5i   #   5j      5l      �� 5n      $��Date of Birth��6%   $	 120��6<   	 5o      �� 5p      .R�5q   "   �� .+�5r   &   �� ��60   �� *DateOfBirth+ �� StringFormat$ 
yyyy-MM-dd��y�6h   �� $
 IsInEdit�# [  $ Inverted��(  "System.Windows.Controls.DatePicker  5s   &   y�61   �� $
 IsInEdit�# [  $ Normal��   SelectedDate 5t   )   �� *DateOfBirth+$ TwoWay=� .  .  .    DisplayDateEnd 5u   )   �� $ OneWay=� �� Today �� Source# Z 5v   #   5w      5y      �� 5{      $ 50��6%   $	��Age��60   	 5|      �� 5}      .R�5~   "   �� .+�5   &   �� ��60   �� *Age+y�6E   �� $
 IsInEdit�# [  $ Inverted��5�   #   5�      5�      �� 5�      $ 65��6%   	 5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $ 
Horizontal=�61   y�6J   �� $
 IsInEdit�# [  $ Inverted��.+�5�   *   ��   HiddenCommandButton#��[ 61    � ToolTip$
 Edit��6^   ��6m   �� *EditCommand+.��5�   .   �� .+�5�   2   �� $��/Icons/editIcon.png��68   5�   /   5�   +   �� 5�   *   #��[ 61   $ Delete��6_   ��6p   �� ��5�   5   ��  �� ElementName$ registerWindow��$%
 DataContext.DeletePersonCommand�.��5�   .   �� .+�5�   2   �� $��/Icons/deleteIcon.png��68   5�   /   5�   +   5�   '   �� 5�   &   $ 
Horizontal=�61   y�6J   �� $
 IsInEdit�# [  $ Normal��.+�5�   *   ��   CommandButton#��[ 61   $ Accept��6Y   ��6j   �� ��5�   5   �� $ registerWindow��$,
 &DataContext.AcceptPersonChangesCommand�.��5�   .   �� .+�5�   2   �� $��/Icons/okIcon.png��68   5�   /   5�   +   �� 5�   *   #��[ 61   $ Reject��6Y   ��6j   �� ��5�   5   �� $ registerWindow��$,
 &DataContext.RejectPersonChangesCommand�.��5�   .   �� .+�5�   2   �� $��/Icons/rejectIcon.png��68   5�   /   5�   +   5�   '   5�   #   5�      5�      5�      5�      ]� 5�   
   $��1��6   $
��10,0q�6!   $��Stretch=�6/   .+�5�      �� $
��Left=�6   .+�5�      �� $	��100��6   $��32��6%   $
��Left=�61   ��6L   �� *AddNewCommand+.��5�      �� $ 
Horizontal=�6!   .+�5�      ��   ButtonImage#��[ 6    $��/Icons/plusIcon.png��6E   �� 5�      $��Center=�6$   $��Add new��6?   5�      5�      5�      �� 5�      $ 
Horizontal=�6   $��Right=�62   $	��Top=�6N   .+�5�      �� $	��100��6   $��32��6%   ��61   �� *SaveCommand+{�6Q   �� *
HasChanges+.��5�      �� $ 
Horizontal=�6!   .+�5�      �� #��[ 6    $��/Icons/saveIcon.png��6E   �� 5�      $��Center=�6$   $
��Save��6?   5�      5�      �� 5�      $	��100��6   $��32��6%   $��10,0,0,0q�61   ��6C   �� *CancelCommand+{�6e   �� *
HasChanges+.��5�      �� $ 
Horizontal=�6!   .+�5�      �� #��[ 6    $��/Icons/cancelIcon.png��6E   �� 5�      $��Center=�6$   $��Cancel��6?   5�      5�      5�      5�      5�      5�      