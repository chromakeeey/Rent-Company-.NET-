   M S B A M L   `   `   `  ����H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:ClientVehicle.Dialogs.DialogsVehicle$ClientVehicle.Dialogs.DialogsVehicle  5   	   :    4ClientVehicle.Dialogs.DialogsVehicle.FinalRentWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:ClientVehicle.Dialogs.DialogsVehicle     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$!  Відміна оренди��5	   	   $	��350��6    $	��400��6-    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�6.    � AllowsTransparency . 
������  � Icon$ 
notify.ico��6t   .��5      � $��5q�6   .+�5   
   ��    BorderCornerRadius15#��[  6   
�������6?   � 5   
   $��10 20 10 20q�6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��0 4 5 0q�5         Kind$ 
CloseThick=�5      $��Right=�5        HoverMouseAnimation#��[ 5      6F   �� 5      .+�5      � $	��230��6   .+�5      ��  �� TextAlignment$ Center=�5      $'��!Завершення оренди��5      $��Gilroy)�5      $
��Bold"�5      ���#99A5B6$��18(�5      5      �� 5!      $��0 10 0 5q�5"      $ Center=�5#      $��Toyota Prius��5$      $��Gilroy)�5%      $
��Bold"�5&      $��22(�5'      �� 5)      $ Center=�5*      $���|Введіть необхідну інформація для завершення оренди та підтвердіть.��5+      $
��Wrap=�5,      $��Gilroy)�5-      $
��Bold"�5.      ���#99A5B6$��12(�50      �� 52      -   5         ��Name$ 
field_Fuel��53      $��10q�54      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Бензина��55      	   
HelperText$.	 (На даний момент в баці��56      $��Gilroy)�57      $
��Bold"�58      $��14(�59       % !MaterialDesignFloatingHintTextBox#��[ 5:      $��Center=�5;      
   
Foreground
 �#3B93F7.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#3B93F75=      �� 5?      -   5        $ field_Mileage��5@      $��10q�5A      $ Пробіг��5B      $"	 На даний момент��5C      $��Gilroy)�5D      $
��Bold"�5E      $��14(�5F      #��[ 5G      $��Center=�5H      
 �#3B93F7 �#3B93F75J      �� 5L      -   5         ��Name$ label_Error��5M      $ Center=�5N      $��Center=�5O      $��	0 10 0 20q�5P       J� Opacity$	 0.5Q�5Q      $	��256��5R      $�� ��5S      $��12(�5T      $
��Wrap=�5U      $��Gilroy)�5V      
���  ��$��Heavy"�5X      �� 5Z      -   5        $��Center=�5[      $��32��5\      $	��125��6!    " MaterialDesignRaisedDarkButton#��[ 5]      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5^      $��0q�5_      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5`       � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners��5a      ���#3B93F7���#3B93F7.��5d      �� $��Підтвердити��5e      $��14(�5f      $��Gilroy)�5g      
�������$
��Bold"�5i      5j      5l      5p      5r      5s      