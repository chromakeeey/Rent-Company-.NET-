   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:ClientVehicle.Dialogs.DialogsVehicle$ClientVehicle.Dialogs.DialogsVehicle  >    8ClientVehicle.Dialogs.DialogsVehicle.BetterSearchVehicle   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Dlocal2clr-namespace:ClientVehicle.Dialogs.DialogsVehicle     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$%  Пошук автомобіля��$	��471��$	��400�� � Icon$ 
notify.ico�� � AllowsTransparency .  � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�
������ .��� $�� 5q�.+���    BorderCornerRadius15#��[  
�������� $��15q�.+��� .+��� $��0��$��Gilroy)�$
��Bold"�$��14(�$A��;Пошук транспорта за параметрами�� �� TextAlignment$ Center=�$��Center=����#99A5B6�� -    ��Name$ field_MinPrice��$��10q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Мінімальна ціна��$��Gilroy)�$
��Bold"�$��14(� % !MaterialDesignFloatingHintTextBox#��[ $��Center=�   
Foreground �#3B93F7.  (MaterialDesignThemes.Wpf.TextFieldAssist	   UnderlineBrush	 �#3B93F7�� -   $ field_MaxPrice��$��10q�$% Максимальна ціна��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7	 �#3B93F7�� -   
 ��Name$
 
combo_Type�� & "MaterialDesignFloatingHintComboBox#��[ $��10q�$! Тип автомобіля��$��Center=� �� 
IsEditable . $��Gilroy)�$
��Bold"�$��14(� �#3B93F7	 �#3B93F7.@��� $��Легковий���� $��Позашляховик���� $��Вантажний���� $��Мотоцикл���� $��
Мопед���� -   $
 combo_Transmission��#��[ $��10q�$ Трансмісія��$��Center=� .  $��Gilroy)�$
��Bold"�$��14(� �#3B93F7	 �#3B93F7.@��� $�� ���� $��Механічна���� $��Автоматична���� -   $
 combo_Category��#��[ $��10 10 10 20q�$! Категорія прав��$��Center=� .  $��Gilroy)�$
��Bold"�$��14(� �#3B93F7	 �#3B93F7.@��� $�� ���� $��A1���� $��A���� $��B1���� $��B���� $��C1���� $��C���� $��D1���� $��D���� $	��C1E���� $��BE���� $��CE���� $	��D1E���� $��DE���� $��T1���� $��T2����  �� Orientation$ 
Horizontal=�$��Center=�.+��� $��0��$��Gilroy)�$
��Bold"�$��0 0 20 0q�$��14(�$1��+Орендований автомобіль��$ Center=�$��Center=����#99A5B6d� -    d�Name$ toggle_RentStatus�� $  MaterialDesignSwitchToggleButton#��[  � ToolTip$  Default ToggleButton Style�����#3B93F7�� -   $��Center=�$��0 20 0 0q�$��32��$	��155�� " MaterialDesignRaisedDarkButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��$��0q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $��
Пошук��$��14(�$��Gilroy)�
�������$
��Bold"��� $��0��$��Gilroy)�$
��Bold"�$��10(�$��0 10 0 0q�$X��R* пусте поле не буде враховуватись при пошуку��$ Right=�$��Right=����#99A5B6