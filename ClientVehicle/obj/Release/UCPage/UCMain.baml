   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ClientVehicle.UCPageClientVehicle.UCPage  !    ClientVehicle.UCPage.UCMain   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:ClientVehicle.UCPage     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�$��Gilroy)�.���  � ColumnDefinitions �� �� .+�� $��0��$��10q�.+��� 
������ $��1q�
������� �� CornerRadius$ 25�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   ShadowDepth$ 5Q�   Opacity$	 0.3Q�� -    �Name$ notFoundVehicle_Grid��$y�Hidden=�$��Center=�$��Center=�.+��� .+��� 	 �� TextAlignment$	 Center=�$��Gilroy)�$
��Bold"�$9��3Ви не орендували автомобіль��$
��Wrap=����#99A5B6$��32(��� -   $��Center=�$��0 20 0 0q�$��36��$	��200�� " MaterialDesignRaisedDarkButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist
   CornerRadius$
 15��$��0q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=� � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $)��#Список автомобілів��$��14(�$��Gilroy)�
�������$
��Bold"�� -   $ VehicleGrid��$��40 20 40 20q� � RowDefinitions �� $
��Auto ��� .+�� $��0��.+��� .+��� -    ��Name$ image_Vehicle��$	��300��$	��450��$��Center=�$��toyota_PNG1953.png���� -    ��Name$ label_HeaderVehicle��$	 Center=�$��Center=�$��Toyota Prius��$��36(�$��Gilroy)�
���   �$
��Bold"��� -   $ 	label_VIN��$	 Center=�$��Center=�$��1D8GT28K88W124700��$��22(�$��Gilroy)����#99A5B6$
��Bold"�� $��1�� �� �� $
��Auto �.+�� $��0��$��0 25 0 0q�.+��� .+��  �� $
��Auto ��� .+��� $��0��$
	 Left=�$
��Left=�$ ��Номерний знак:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_Plate��$��1��$	 Right=�$��Right=�$��
AA 3546 AT��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
	 Left=�$
��Left=�$"��Категорія прав:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_Category��$��1��$	 Right=�$��Right=�$��B��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
	 Left=�$
��Left=�$!��Бензина в баці:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -	   $ 
label_Fuel��$��1��$	 Right=�$��Right=�$��32 л.��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
	 Left=�$
��Left=�$��Об'єм бака:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -
   $ label_MaxFuel��$��1��$	 Right=�$��Right=�$��60 л.��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
	 Left=�$
��Left=�$#��Макс. швидкість:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_MaxSpeed��$��1��$	 Right=�$��Right=�$��150 км/г��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
	 Left=�$
��Left=�$��Тип:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ 
label_Type��$��1��$	 Right=�$��Right=�$��Легковий��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
	 Left=�$
��Left=�$��Трансмісія:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_Transmission��$��1��$	 Right=�$��Right=�$��Автоматична��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
	 Left=�$
��Left=�$��Пробіг:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_Mileage��$��1��$	 Right=�$��Right=�$��32 000 км��$��22(�$��Gilroy)�
���   �$��Medium"�� $��1��.+�� $��Bottom=�.+��� .+��  �� $
��Auto ��� .+��� $��0��$
	 Left=�$
��Left=�$"��Початок оренди:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_StartRent��$��1��$	 Right=�$��Right=�$��25.06.2020 12:43:46��$��22(�$��Gilroy)�
���   �$��Medium"��  �� $
��Auto ��� .+��� $��0��$
	 Left=�$
��Left=�$ ��Кінець оренди:��$��22(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_FinalRent��$��1��$	 Right=�$��Right=�$��25.06.2020 12:43:46��$��22(�$��Gilroy)�
���   �$��Medium"���  �� Orientation$ 
Horizontal=�$��Right=�.+��� -   $��0 20 0 0q�
������ 
������ .���� $#��Переглянути чек��$��14(�$��Gilroy)����#99A5B6$
��Bold"��� -   $��0 20 0 0q�$��36��$	��155��#��[ $
 15��$��0q�$��Right=�$ Depth3=�$7 1MaterialDesignRaisedDarkButton with Round Corners�����#DF9090���#DF9090.���� $%��Відмінити оренду��$��14(�$��Gilroy)�
�������$
��Bold"�� $��1��$��10 10 10 10q� �� $	��213 ��� $	��249 ��� .+�� $��0��$��0 0 0 0q�.+��� 
������ $��1q�
�������$ 25��   $ 10Q�$ 5Q�$	 0.3Q�� $��10q� �� $
��Auto ��� .+�� $��0��$��15 0 0 0q�.+�� $��Center=�.+��� .+��� $��0 0 0 10q�.+��� $��Баланс��$��18(�$��Gilroy)����#99A5B6$
��Bold"��� -   $ label_Balance��$��
₴ 52 000��$��36(�$��Gilroy)����#8DB57A$
��Bold"��� .+��� $��Борг��$��18(�$��Gilroy)����#99A5B6$
��Bold"��� -   $ label_Credit��$��₴ 600��$��24(�$��Gilroy)����#DF9090$
��Bold"��� -   $��0 10 0 0q�$��36��$	��155��#��[ $
 15��$��0q�$ Depth3=�$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $)��#Здійснити операцію��$��14(�$��Gilroy)�
�������$
��Bold"�� $��1��.+�� $	��179��$	��297��$��Center=�$��Right=�$��0 0 10 0q�.+��� $	��297��$��0 0 0 0q�
������ $��1q�$ 15������  �� EndPoint$ 1,1.5&� �� 
StartPoint$ 
0.504,0.03&�.���  � Color$ #A97CAD�� � Offset$ 0Q�� $ #F1A5F8��$	 0.5Q�   $ 10Q�$ 5Q�$	 0.3Q�� $��10q� �� �� �� .+�� $��0��.+��� -   $ label_PayType��$��Right=�$
��VISA��$��14(�$��Gilroy)�
�������$��Medium"�� $��1��.+��� -   $ label_Cardnumber��$��Center=�$	 Center=�$��2567 **** **** 3545��$��24(�$��Gilroy)�
�������$��Heavy"�� $��2��.+�� $��Bottom=� �� �� $
��Auto �.+�� $��0��.+��� -   $ label_OwnerCard��$��Bottom=�$
��Left=�$
	 Left=�$-��'Паламарчук Олександр��$��10(�$��Gilroy)�
�������$
��Bold"�� $��1��.+��� -   $ label_ExpireDate��$��Right=�$	 Right=�$��09/22��$��18(�$��Gilroy)�
�������$��Heavy"�� $��1��$��	0 10 0 0 q�.+��� 
������ $��1q�
�������$ 25��   $ 10Q�$ 5Q�$	 0.3Q�� $��20q� �� $
��Auto ��� �� $
��Auto �.+�� $��0��.+��  �� �� $
��Auto �.+�� $��0��.+��� $ 
Horizontal=�.+�A� $��50��$��50��$
��Left=�����  �� ImageSource$ unnamed.jpg���� -   $ label_FullName��$	��162��$
��Wrap=�$��15 0 0 0q�$��Center=�$H��BПаламарчук Олександр Володимирович��$��14(�$��Gilroy)����#99A5B6$
��Bold"�� $��1��.+��� $��Center=�$��Right=�.+��� .+��� $	 Right=�$#��Дата реєстрації��$��14(�$��Gilroy)����#99A5B6$
��Bold"��� -   $ label_DateSignUp��$	 Right=�$��25.06.2020 12:18:12��$��14(�$��Gilroy)�
���   �$
��Bold"�� $��1��.+��� $��Center=�.+��  �� $
��Auto ��� .+��� $��0��$
	 Left=�$
��Left=�$��Логін:��$��14(�$��Gilroy)����#99A5B6$
��Bold"��� -   $ label_Login��$��1��$	 Right=�$��Right=�$��palamarchuk��$��14(�$��Gilroy)�
���   �$
��Bold"��  �� $
��Auto ��� .+��� $��0��$
	 Left=�$
��Left=�$��Пошта:��$��14(�$��Gilroy)����#99A5B6$
��Bold"��� -   $ 
label_Mail��$��1��$	 Right=�$��Right=�$��palamarchuk@gmail.com��$��14(�$��Gilroy)�
���   �$
��Bold"��  �� $
��Auto ��� .+��� $��0��$
	 Left=�$
��Left=�$��Телефон:��$��14(�$��Gilroy)����#99A5B6$
��Bold"��� -   $ label_Phone��$��1��$	 Right=�$��Right=�$��+380665300220��$��14(�$��Gilroy)�
���   �$
��Bold"��� -   $��0 10 0 0q�$
��Left=�$
��Auto��$
��Auto��$��0q�
������ 
������ .���� $ 
Horizontal=�.+��� $8��2Переглянути свої документи��$��Gilroy)�$
��Bold"����#99A5B6$��0 0 10 0q�$��Center=�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ RemoveRedEye=����#99A5B6$��20��$��20��$��Center=�� $��2�� �� �� .+�� $��0��.+�� $��36��$	��214��$
��Left=�.+��� 
������ $��1q�
�������$ 15��   $ 10Q�$ 5Q�$	 0.3Q�� $��	15 5 15 5q�.+��� -     ��Name$ field_Password��$��Gilroy)�$
��Bold"�$��0q�.  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$, &Введіть новий пароль��� $��1��.+��� -!   $��Right=�$��0 0 0 0q�$��36��$	��155��#��[ $
 15��$��0q�$ Depth3=�$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $!��Оновити пароль��$��14(�$��Gilroy)�
�������$
��Bold"�� $��2��