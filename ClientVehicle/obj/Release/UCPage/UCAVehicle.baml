   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ClientVehicle.UCPageClientVehicle.UCPage  ;"clr-namespace:ClientVehicle.UCHelpClientVehicle.UCHelp  %    ClientVehicle.UCPage.UCAVehicle   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:ClientVehicle.UCPage     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  /UCHelp"clr-namespace:ClientVehicle.UCHelp  
������ .���   � RowDefinitions  �� $
��Auto ��� $
��Auto ��� $
��Auto ��� .+��� $��10q�$��0��$.��(Операції з аккаунтами��$��Gilroy)�$
��Bold"����#99A5B6$��18(�� $��1��$��10q� � ColumnDefinitions �� $
��Auto ��� $
��Auto ��� .+�� $��0��.+�� $��60��$	��231��$��Right=�$��0 0 20 0q�.+��� 
������ $��1q�
������� �� CornerRadius$ 15�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   ShadowDepth$ 5Q�   Opacity$	 0.3Q�� $��Center=�$��	15 5 15 5q�.+��� .+��� $'��!Всього транспорту��$��Gilroy)�$
��Bold"�$��15(����#99A5B6�� -    ��Name$ label_Count��$	��256��$��Gilroy)�$
��Bold"�$��18(�
���   �� $��1��.+���  �� Orientation$ 
Horizontal=�.+�� $��60��$	��231��$��Right=�$��0 0 20 0q�.+��� 
������ $��1q�
�������$ 15��   $ 10Q�$ 5Q�$	 0.3Q�� $��Center=�$��	15 5 15 5q�.+��� .+��� $��В оренді��$��Gilroy)�$
��Bold"�$��15(����#99A5B6�� -   $ 
label_Rent��$��32��$��Gilroy)�$
��Bold"�$��18(�
���   ��� -   
������ 
������ .���� $ 
Horizontal=�.+��� $2��,Додати новий автомобіль��$��Gilroy)�$
��Bold"����#99A5B6$��0 0 10 0q�$��Center=�'  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 PlaylistAdd=����#99A5B6$��20��$��20��$��Center=�� $��2��.+��� -   $��Right=�$��0��
������ 
������ .���� $+��%Деталізований пошук��$��14(�$��Gilroy)����#99A5B6$
��Bold"�� $��2��$��19 10 37 10q� �� $	��170 ��� �� �� �� �� .+��� $��0��$��VIN                 ��$��Gilroy)�$
��Bold"�$��14(�
���   ��� $��1��$��Повна назва��$��Gilroy)�$
��Bold"�$��14(�
���   ��� $��2��$��Ціна��$��Gilroy)�$
��Bold"�$��14(�
���   ��� $��3��$��Статус оренди��$��Gilroy)�$
��Bold"�$��14(�
���   ��� $��4��$��Бензина��$��Gilroy)�$
��Bold"�$��14(�
���   ��� $��5��$��Детальніше��$��Gilroy)�$
��Bold"�$��14(�
���   ��� $��3��$��0 0 0 0q�.���� -   
 ��Name$
 panel_VehicleRow��$��0 0 18 0q�