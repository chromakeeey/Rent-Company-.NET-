   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:ClientVehicle.Dialogs.DialogsStatistic&ClientVehicle.Dialogs.DialogsStatistic  =    7ClientVehicle.Dialogs.DialogsStatistic.DialogCustomDate   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Flocal4clr-namespace:ClientVehicle.Dialogs.DialogsStatistic     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  Вибір дати��$	��450��$	��800��
������  � WindowStyle$
 None=� � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=� � Icon$ 
notify.ico��.��� $��5q�.+���    BorderCornerRadius25#��[  
�������� $��20q� � RowDefinitions �� $
��Auto ��� .+�� $��0��.+�'  !MaterialDesignThemes.Wpf.PackIcon  -   $��0��$��0 0 5 0q�   Kind$ 
CloseThick=�$��Right=�  HoverMouseAnimation#��[ � $��1�� � ColumnDefinitions �� �� $
��Auto ��� .+�&   System.Windows.Controls.Calendar  -     Name$ calendar_Start��$��Gilroy)�$��0��$��Center=�$��Center=�	 � 	Resources	   PrimaryHueMidBrush
 �� Color  MaterialDesignBody��%7   &	       &	      �� $
 #6490F1���� $

 Gray��� $��1��.+��� $��Center=�$��Center=�.+��� -    # MaterialDesignRaisedLightButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5�� � ToolTip$8 2MaterialDesignRaisedLightButton with Round Corners�����#6490F1���#6490F1.���� $��Center=� �� TextAlignment$ Center=�
�������$��Gilroy)�$
��Bold"�$��12(�$��Вибрати��  -   $ calender_Final��$��Gilroy)�$��2��$��Center=�$��Center=�	 ��%7   &	       &	      �� $
 #6490F1���� $

 Gray��