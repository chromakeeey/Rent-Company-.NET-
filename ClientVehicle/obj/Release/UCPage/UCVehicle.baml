   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ClientVehicle.UCPageClientVehicle.UCPage  ;"clr-namespace:ClientVehicle.UCHelpClientVehicle.UCHelp  $    ClientVehicle.UCPage.UCVehicle   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:ClientVehicle.UCPage     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  /UCHelp"clr-namespace:ClientVehicle.UCHelp     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�$��Gilroy)�.���  � ColumnDefinitions �� �� .+�� $��0��$��10q�.+��� 
������ $��1q�
������� �� CornerRadius$ 25�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   ShadowDepth$ 5Q�   Opacity$	 0.3Q�� $��20q� � RowDefinitions �� $
��Auto ��� .+��� -   $
��Left=�$��0��
������ 
������ .���� $+��%Деталізований пошук��$��14(�$��Gilroy)����#99A5B6$
��Bold"�� $��1��.+��� $
��Auto=�$��Disabled=�.���� -   	 ��Name$	 panel_VehicleNumerable��$��Center=�� $��1��$��10q�.+��� 
������ $��1q�
�������$ 25��   $ 10Q�$ 5Q�$	 0.3Q�� -   
 �Name$
 VehicleGrid��$��40 20 40 20q� �� $
��Auto ��� .+�� $��0��.+��� .+��� -    ��Name$ image_Vehicle��$	��300��$	��450��$��Center=�$��toyota_PNG1953.png���� -    ��Name$ label_HeaderVehicle�� �� TextAlignment$ Center=�$��Center=�$��Toyota Prius��$��36(�$��Gilroy)�
���   �$
��Bold"��� -   $ 	label_VIN��$ Center=�$��Center=�$��1D8GT28K88W124700��$��22(�$��Gilroy)����#99A5B6$
��Bold"�� $��1�� �� �� $
��Auto �.+�� $��0��$��0 25 0 0q�.+��� .+��  �� $
��Auto ��� .+��� $��0��$
 Left=�$
��Left=�$ ��Номерний знак:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_Plate��$��1��$ Right=�$��Right=�$��
AA 3546 AT��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
 Left=�$
��Left=�$"��Категорія прав:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_Category��$��1��$ Right=�$��Right=�$��B��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
 Left=�$
��Left=�$!��Бензина в баці:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -	   $ 
label_Fuel��$��1��$ Right=�$��Right=�$��32 л.��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
 Left=�$
��Left=�$��Об'єм бака:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -
   $ label_MaxFuel��$��1��$ Right=�$��Right=�$��60 л.��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
 Left=�$
��Left=�$#��Макс. швидкість:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_MaxSpeed��$��1��$ Right=�$��Right=�$��150 км/г��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
 Left=�$
��Left=�$��Тип:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ 
label_Type��$��1��$ Right=�$��Right=�$��Легковий��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
 Left=�$
��Left=�$��Трансмісія:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_Transmission��$��1��$ Right=�$��Right=�$��Автоматична��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
 Left=�$
��Left=�$��Пробіг:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_Mileage��$��1��$ Right=�$��Right=�$��32 000 км��$��22(�$��Gilroy)�
���   �$��Medium"�� $��1��.+�� $��Bottom=�.+��� .+��  �� $
��Auto ��� .+��� $��0��$
 Left=�$
��Left=�$"��Початок оренди:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_StartRent��$��1��$ Right=�$��Right=�$��25.06.2020 12:43:46��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
 Left=�$
��Left=�$ ��Кінець оренди:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_FinalRent��$��1��$ Right=�$��Right=�$��25.06.2020 12:43:46��$��22(�$��Gilroy)�
���   �$��Medium"���  �� Orientation$ 
Horizontal=�$��Right=�.+��� -   $ label_Status��$
��Wrap=�$��	0 20 20 0q�$��Center=�$;��5Цей транспорт вже орендовний��$��14(�$��Gilroy)����#99A5B6$
��Bold"�(  "System.Windows.Controls.DatePicker  -     Name$ date_Picker��$��Center=�$��Bottom=�$��0 0 20 5q�$��Gilroy)�$
��Bold"�$��0q�.  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$! Виберіть дату  ��  CalendarBlueTheme   CalendarStyle# [ �� -    ��Name$ button_Rent��$��0 20 0 0q�$��36��$	��155�� " MaterialDesignRaisedDarkButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��$��0q�$��Right=�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=� � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $ ��Взяти в оренду��$��14(�$��Gilroy)�
�������$
��Bold"�