   M S B A M L   `   `   `  ����H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ClientVehicle.ControlsClientVehicle.Controls  5   	   U/clr-namespace:ClientVehicle.Dialogs.DialogsUser!ClientVehicle.Dialogs.DialogsUser  5   	   :    4ClientVehicle.Dialogs.DialogsUser.UserDocumentWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9controls$clr-namespace:ClientVehicle.Controls     5   	   Alocal/clr-namespace:ClientVehicle.Dialogs.DialogsUser     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$:  4Скан документів користувача��5
   	   $	��330��6-   $	��800��6:    � Icon$ 
notify.ico��6F    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�6.    � AllowsTransparency . 
������ .��5      � $��5q�6   .+�5   
   ��    BorderCornerRadius15#��[  6   
�������6?   � 5   
   $��10q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      �� 5      $
��Auto �6    .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��0 0 5 0q�5         Kind$ 
CloseThick=�5      $��Right=�5        HoverMouseAnimation#��[ 5      6F   � 5      $��1��6    � ColumnDefinitions 5      �� 5      �� 5      .+�5"      �� $��0��6   $��Center=�6-   .+�5#      �� $��Center=�5$   !   $!��Лицева сторона��5%   !   $��Gilroy)�5&   !   $
��Bold"�5'   !   ���#99A5B6$��0 0 10 0q�5)   !   $��Center=�5*   !   '   !ClientVehicle.Controls.ZoomBorder  5+         Child. 5,      �� -   5        	 ��Name$	 image_Front��5,       $	��200��65   $��	10 0 10 0q�6B   $��top.png��6U   5-      5/      �� 51      $��1��6   $��Center=�6-   .+�52      �� $��Center=�53   !   $��Задня сторона��54   !   $��Gilroy)�55   !   $
��Bold"�56   !   ���#99A5B6$��0 0 10 0q�58   !   $��Center=�59   !     5:      . 5;      �� -   5        $	 
image_Back��5;       $	��200��64   $��	10 0 10 0q�6A   $��
bottom.png��6T   5<      5>      5@      �� 5C      -   5        
 ��Name$
 lbox_Category��5D      $��2��5E      $��Center=�5F      $��Gilroy)�5G      $
��Bold"�5H       # MaterialDesignFilterChipListBox#��[ 5I      .@�5J      �� $��A1��6   {�.  6+   �� 5K      $��A��6   {�.  6*   �� 5L      $��B1��6   {�.  6+   �� 5M      $��B��6   {�.  6*   �� 5N      $��C1��6   {�.  6+   �� 5O      $��C��6   {�.  6*   5Q      5S      5U      5V      