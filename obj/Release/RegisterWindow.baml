   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem   RegisterOfPeopleApp(   "RegisterOfPeopleApp.RegisterWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     9System&clr-namespace:System;assembly=mscorlib     -     �Name$  registerWindow�� � Title$ Register Of People��$	��450��$	��450��$	��950��$	��950��.���  � RowDefinitions �� $��* ��� $��40 �.+��� $��0��$��10q�|�.  $��Stretch=�$��Stretch=����� *People+����  �� 
TargetType" ��.���  �� Property � |� �� Value .  ��  � ��$ Stretch=� �� View �� ! �� ColumnHeaderContainerStyle �� " ��.���  � ��$ 30����  � ��$
 Bold"�.P���  �� Width$	 100��$��
First Name��	 �� CellTemplate	 �� .R��� .+��� ���� *	FirstName+y��� 
 �� Path$
 IsInEdit�   visibleIfTrueConverter �� 	Converter# [   �� ConverterParameter$ Inverted���� y��� $
 IsInEdit�# [  $ Normal������ *	FirstName+ �� Mode$ TwoWay=� �� ValidatesOnDataErrors .  �� ValidatesOnExceptions .  �� NotifyOnValidationError . �� $	 100��$��	Last Name��	 �� .R��� .+��� ���� *
LastName+y��� $
 IsInEdit�# [  $ Inverted���� y��� $
 IsInEdit�# [  $ Normal������ *
LastName+$ TwoWay=� .  .  . �� $	 170��$��Street Address��	 �� .R��� .+��� ���� *StreetAddress+y��� $
 IsInEdit�# [  $ Inverted����  �� Orientation$ 
Horizontal=�y��� $
 IsInEdit�# [  $ Normal��.+��� $��90������ *
StreetName+$ TwoWay=� .  .  . �� $��29��$��5,0,0,0q����� *HouseNumber+$ TwoWay=� .  .  . �� $��/��$��0,2,0,0q��� $��29������ *ApartmentNumber+$ TwoWay=��� $ 80��$��Postal Code��	 �� .R��� .+��� ���� *
PostalCode+y��� $
 IsInEdit�# [  $ Inverted���� y��� $
 IsInEdit�# [  $ Normal������ *
PostalCode+$ TwoWay=� .  .  . �� $	 100��$
��Town��	 �� .R��� .+��� ���� *Town+y��� $
 IsInEdit�# [  $ Inverted���� y��� $
 IsInEdit�# [  $ Normal������ *Town+$ TwoWay=� .  .  . �� $	 100��$��Phone Number��	 �� .R��� .+��� ���� *PhoneNumber+y��� $
 IsInEdit�# [  $ Inverted���� y��� $
 IsInEdit�# [  $ Normal������ *PhoneNumber+$ TwoWay=� .  .  . �� $��Date of Birth��$	 120��	 �� .R��� .+��� ���� *DateOfBirth+ �� StringFormat$ 
yyyy-MM-dd��y��� $
 IsInEdit�# [  $ Inverted��(  "System.Windows.Controls.DatePicker  y��� $
 IsInEdit�# [  $ Normal��   SelectedDate �� *DateOfBirth+$ TwoWay=� .  .  .    DisplayDateEnd �� $ OneWay=� �� Today �� Source# Z �� $ 50��$	��Age��	 �� .R��� .+��� ���� *Age+y��� $
 IsInEdit�# [  $ Inverted���� $ 65��	 �� .R��� $ 
Horizontal=�.+��� $ 
Horizontal=�y��� $
 IsInEdit�# [  $ Inverted��.+���   HiddenCommandButton#��[  � ToolTip$
 Edit������ *EditCommand+.���� .+��� $��/Icons/editIcon.png���� #��[ $ Delete������ ����  �� ElementName$ registerWindow��$%
 DataContext.DeletePersonCommand�.���� .+��� $��/Icons/deleteIcon.png���� $ 
Horizontal=�y��� $
 IsInEdit�# [  $ Normal��.+���   CommandButton#��[ $ Accept������ ���� $ registerWindow��$,
 &DataContext.AcceptPersonChangesCommand�.���� .+��� $��/Icons/okIcon.png���� #��[ $ Reject������ ���� $ registerWindow��$,
 &DataContext.RejectPersonChangesCommand�.���� .+��� $��/Icons/rejectIcon.png��]� $��1��$
��10,0q�$��Stretch=�.+��� $
��Left=�.+��� $	��100��$��32��$
��Left=����� *AddNewCommand+.���� $ 
Horizontal=�.+���   ButtonImage#��[ $��/Icons/plusIcon.png���� $��Center=�$��Add new���� $ 
Horizontal=�$��Right=�$	��Top=�.+��� $	��100��$��32������ *SaveCommand+{��� *
HasChanges+.���� $ 
Horizontal=�.+��� #��[ $��/Icons/saveIcon.png���� $��Center=�$
��Save���� $	��100��$��32��$��10,0,0,0q����� *CancelCommand+{��� *
HasChanges+.���� $ 
Horizontal=�.+��� #��[ $��/Icons/cancelIcon.png���� $��Center=�$��Cancel��