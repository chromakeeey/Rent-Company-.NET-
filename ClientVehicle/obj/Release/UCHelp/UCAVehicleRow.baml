   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ClientVehicle.UCHelpClientVehicle.UCHelp  (    "ClientVehicle.UCHelp.UCAVehicleRow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:ClientVehicle.UCHelp     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  .��� .+��� $��5q�
������ $��1q�
�������  �� CornerRadius$  25�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   ShadowDepth$ 5Q�   Opacity$	 0.3Q�� $��20 15 20 15q� � ColumnDefinitions �� $	��170 ��� �� �� �� �� .+��� -    ��Name$ 	label_VIN��$��Center=�$��0��$��1FTLR4FE8APA75891��$��Gilroy)�$
��Bold"�$��15(����#99A5B6�� -   $ label_Fullname��$��Center=�$��1��$
��Wrap=�$��Toyota Prius��$��Gilroy)�$
��Bold"�$��15(����#99A5B6�� -   $ label_Price��$��Center=�$��2��$��₴ 500��$��Gilroy)�$
��Bold"�$��15(����#99A5B6�� -   $ label_Status��$��Center=�$��3��$!��Не орендований��$��Gilroy)�$
��Bold"�$��15(����#99A5B6�� -   $ 
label_Fuel��$��Center=�$��4��$��36 л.��$��Gilroy)�$
��Bold"�$��15(����#99A5B6�� -   $��5��$��32��$��32��$��0q�
������ 
������ $
��Left=� � ContextMenu �� .@�m� -   ����  �� Orientation$ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon  $��0 0 10 0q�$��Center=�	   Kind$		 Cog=�$��20��$��20�����#99A5B6�� $��Center=�$��Редагувати�����#99A5B6$��Gilroy)�$��12(�$
��Bold"�m� -   ���� $ 
Horizontal=�.+�  $��0 0 10 0q�$��Center=�$	 DeleteForever=�$��20��$��20�����#DF9090�� $��Center=�$��Видалити��$��12(����#DF9090$��Gilroy)�$
��Bold"�.��  $	 	MoreHoriz=�$��5�����#99A5B6$��Center=�$��32��$��32��