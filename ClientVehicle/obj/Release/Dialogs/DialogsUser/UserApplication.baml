   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:ClientVehicle.Dialogs.DialogsUser!ClientVehicle.Dialogs.DialogsUser  ?$clr-namespace:ClientVehicle.ControlsClientVehicle.Controls  7    1ClientVehicle.Dialogs.DialogsUser.UserApplication   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Alocal/clr-namespace:ClientVehicle.Dialogs.DialogsUser     9controls$clr-namespace:ClientVehicle.Controls     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$%  Перевірка заявки��$	��590��$	��800�� � Icon$ 
notify.ico�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������ .��� $��5q�.+���    BorderCornerRadius15#��[  
�������� $��10q� � RowDefinitions �� $
��auto ��� $
��Auto ��� $
��auto ��� $
��Auto ��� $
��Auto �.+�'  !MaterialDesignThemes.Wpf.PackIcon  $��0��$��0 0 5 0q�   Kind$ 
CloseThick=�$��Right=�  HoverMouseAnimation#��[ � $��1�� � ColumnDefinitions �� �� .+��� $��0��$��Center=�.+��� $��Center=�$!��Лицева сторона��$��Gilroy)�$
��Bold"����#99A5B6$��0 0 10 0q�$��Center=�� .+�'   !ClientVehicle.Controls.ZoomBorder  }�. 
�������   Child. �� -   	 ��Name$	 image_Front��$	��200��$��	10 0 10 0q�$��top.png���� -   
 ��Name$
 rigthBorderStack��$��1��$��Center=�.+��� $��Center=�$��Задня сторона��$��Gilroy)�$
��Bold"����#99A5B6$��0 0 10 0q�$��Center=�� .+�  }�. 
�������. �� -   $	 
image_Back��$	��200��$��	10 0 10 0q�$��
bottom.png��� $��2��.+�� $��
20 10 20 0q� �� �� �� .+��� $��0��$��Center=�.+���  �� TextAlignment$ Center=�$��
Логін��$��Gilroy)�$
��Bold"�$��14(����#99A5B6�� -    ��Name$ label_Login��$ Center=�$��palamarchuk��$��Gilroy)�$
��Bold"�$��16(�
���   ��� $��1��$��Center=�.+��� $ Center=�$��
Пошта��$��Gilroy)�$
��Bold"�$��14(����#99A5B6�� -   $ 
label_Mail��$ Center=�$��palamarchuk@gmail.com��$��Gilroy)�$
��Bold"�$��16(�
���   ��� $��2��$��Center=�.+��� $ Center=�$��Телефон��$��Gilroy)�$
��Bold"�$��14(����#99A5B6�� -   $ label_Phone��$ Center=�$��+380665300220��$��Gilroy)�$
��Bold"�$��16(�
���   �� $��3��.+�� $��
20 30 20 0q�.+��� .+��� .+��� $ Center=�$C��=Виберіть потрібні категорії прав��$��Gilroy)�$
��Bold"�$��14(����#99A5B6$��0 0 0 10q��� -    ��Name$ listbox_Category��$��Center=�$��Gilroy)�$
��Bold"� # MaterialDesignFilterChipListBox#��[ .@��� $��A1���� $��A���� $��B1���� $��B���� $��C1���� $��C���� $��D1���� $��D���� $	��C1E���� $��BE���� $��CE���� $	��D1E���� $��DE���� $��T1���� $��T2���� $��0 20 0 0q�.+��� $ Center=�$G��AДозаповніть інформацію з документа��$��Gilroy)�$
��Bold"�$��14(����#99A5B6$��0 0 0 10q��  �� �� �� .+��� -    ��Name$ field_Surname��$��0��$��	30 0 30 0q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Прізвище��$��Gilroy)�$
��Bold"�$��14(� % !MaterialDesignFloatingHintTextBox#��[ $��Center=�   
Foreground �#3B93F7.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#3B93F7�� -	   $ 
field_Name��$��1��$��	30 0 30 0q�$ Ім'я��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7(  "System.Windows.Controls.DatePicker  -
     Name$ field_Birthday��$��2��$��	30 0 30 0q�$��Gilroy)�$
��Bold"�$# Дата народження�� ( $MaterialDesignFloatingHintDatePicker#��[  �#3B93F7 �#3B93F7� $��4��.+�� $��Center=�$��Center=�$��0 30 0 0q�.+��� .+��� -   $ label_Error��$��0 0 0 5q�$�� ��$��Gilroy)�$
��Bold"�$��14(�$��Center=�$ Center=����#E25544��  �� Orientation$ 
Horizontal=�.+��� -    # MaterialDesignRaisedLightButton#��[ $��0,0,0,0q�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��$��0q�$
��auto�� � ToolTip$8 2MaterialDesignRaisedLightButton with Round Corners�����#76C466���#76C466.���� $��35 10 35 10q�$��Center=�$
 Left=�
�������$��Gilroy)�$
��Bold"�$��16(�$��Підтвердити���� -   #��[ $��10,0,0,0q�$ 5��$��0q�$
��Auto��$8 2MaterialDesignRaisedLightButton with Round Corners�����#E25544���#E25544.���� $��35 10 35 10q�$��Center=�$
 Left=�
�������$��Gilroy)�$
��Bold"�$��16(�$��Відмовити��