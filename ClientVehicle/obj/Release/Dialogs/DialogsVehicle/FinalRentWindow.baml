   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:ClientVehicle.Dialogs.DialogsVehicle$ClientVehicle.Dialogs.DialogsVehicle  :    4ClientVehicle.Dialogs.DialogsVehicle.FinalRentWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Dlocal2clr-namespace:ClientVehicle.Dialogs.DialogsVehicle     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$!  Відміна оренди��$	��350��$	��400�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������  � Icon$ 
notify.ico��.��� $��5q�.+���    BorderCornerRadius15#��[  
�������� $��10 20 10 20q�.+�'  !MaterialDesignThemes.Wpf.PackIcon  -   $��0 4 5 0q�   Kind$ 
CloseThick=�$��Right=�  HoverMouseAnimation#��[ �� .+�� $	��230��.+���  �� TextAlignment$ Center=�$'��!Завершення оренди��$��Gilroy)�$
��Bold"����#99A5B6$��18(��� $��0 10 0 5q�$ Center=�$��Toyota Prius��$��Gilroy)�$
��Bold"�$��22(��� $ Center=�$���|Введіть необхідну інформація для завершення оренди та підтвердіть.��$
��Wrap=�$��Gilroy)�$
��Bold"����#99A5B6$��12(��� -    ��Name$ 
field_Fuel��$��10q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Бензина��	   
HelperText$.	 (На даний момент в баці��$��Gilroy)�$
��Bold"�$��14(� % !MaterialDesignFloatingHintTextBox#��[ $��Center=�
   
Foreground
 �#3B93F7.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#3B93F7�� -   $ field_Mileage��$��10q�$ Пробіг��$"	 На даний момент��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=�
 �#3B93F7 �#3B93F7�� -    ��Name$ label_Error��$ Center=�$��Center=�$��	0 10 0 20q� J� Opacity$	 0.5Q�$	��256��$�� ��$��12(�$
��Wrap=�$��Gilroy)�
���  ��$��Heavy"��� -   $��Center=�$��32��$	��125�� " MaterialDesignRaisedDarkButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��$��0q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=� � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $��Підтвердити��$��14(�$��Gilroy)�
�������$
��Bold"�