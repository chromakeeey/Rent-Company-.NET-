   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ClientVehicle.ControlsClientVehicle.Controls  U/clr-namespace:ClientVehicle.Dialogs.DialogsUser!ClientVehicle.Dialogs.DialogsUser  :    4ClientVehicle.Dialogs.DialogsUser.UserDocumentWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     9controls$clr-namespace:ClientVehicle.Controls     Alocal/clr-namespace:ClientVehicle.Dialogs.DialogsUser     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$:  4Скан документів користувача��$	��330��$	��800�� � Icon$ 
notify.ico�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������ .��� $��5q�.+���    BorderCornerRadius15#��[  
�������� $��10q� � RowDefinitions �� $
��Auto ��� �� $
��Auto �.+�'  !MaterialDesignThemes.Wpf.PackIcon  -   $��0 0 5 0q�   Kind$ 
CloseThick=�$��Right=�  HoverMouseAnimation#��[ � $��1�� � ColumnDefinitions �� �� .+��� $��0��$��Center=�.+��� $��Center=�$!��Лицева сторона��$��Gilroy)�$
��Bold"����#99A5B6$��0 0 10 0q�$��Center=�'   !ClientVehicle.Controls.ZoomBorder     Child. �� -   	 ��Name$	 image_Front��$	��200��$��	10 0 10 0q�$��top.png���� $��1��$��Center=�.+��� $��Center=�$��Задня сторона��$��Gilroy)�$
��Bold"����#99A5B6$��0 0 10 0q�$��Center=�  . �� -   $	 
image_Back��$	��200��$��	10 0 10 0q�$��
bottom.png���� -   
 ��Name$
 lbox_Category��$��2��$��Center=�$��Gilroy)�$
��Bold"� # MaterialDesignFilterChipListBox#��[ .@��� $��A1��{�.  �� $��A��{�.  �� $��B1��{�.  �� $��B��{�.  �� $��C1��{�.  �� $��C��{�.  