   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:ClientVehicle.Dialogs.ReceiptsClientVehicle.Dialogs.Receipts  2    ,ClientVehicle.Dialogs.Receipts.ReceiptWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     >local,clr-namespace:ClientVehicle.Dialogs.Receipts     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  Перегляд чеку��$	��470��$	��400�� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � AllowsTransparency . 
������  � Icon$ 
notify.ico��.��� $��5q� � RowDefinitions �� �� $
��Auto �.+�� $��1��.+��� -   $
��Left=�
������ 
������ .����  �� Orientation$ 
Horizontal=�.+��� $��Зберегти��$��Gilroy)�$
��Bold"�
�������$��0 0 10 0q�$��Center=�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Download=�
�������$��20��$��20��$��Center=��� -   $��Right=�
������ 
������ .���� $ 
Horizontal=�.+��� $��Закрити��$��Gilroy)�$
��Bold"�
�������$��Center=�$��12(�� -    �Name$ GridReceipt��$��0��
�������	 � ColumnDefinitions	 �� $	��38* ��� .+�� $��
15,15,5,15q� �� $
��Auto ��� �� $
��Auto �.+�� $��0��.+��� $��0,0,0,1q����#8B92A6�� $��Center=�.+��� -   
 ��Name$
 	label_Num�� �� TextAlignment$ Center=����#8B92A6$��Gilroy)�$
��Bold"�$��14(�$��Номер чека - 22���� -   $
 label_NameCompany��$ Center=����#8B92A6$��Gilroy)�$
��Bold"�$��14(�$&�� Автопрокат 'QuickRent'���� -   $
 label_Street��$��0,0,0,5q�$
��Wrap=�$ Center=����#8B92A6$��Gilroy)�$
��Bold"�$��14(�$y��sУкраїна, Чернівецька область, м. Чернівці, вул. Головна 256, офіс 3��� $��1�� �� $
��Auto ��� �� �� .+�� $��0��$��0,5,0,30q�	 �� $
��Auto ��� .+�� $��0��.+��� $
 Left=����#8B92A6$��Gilroy)�$
��Bold"�$��11(�$��Орендар:��� $��1��.+��� -   $
 
label_Name��$ Right=����#8B92A6$��Gilroy)�$
��Bold"�$��11(�$H��BПаламарчук Олександр Володимирович��� $��1��.+��� .+��� $
 Left=����#8B92A6$��Gilroy)�$��Normal"�$��12(�$7��1Інформація про автомобіль:���� -   $
 label_Information��$
 Left=����#8B92A6$��Gilroy)�$
��Bold"�$��12(�$����VIN: JH4CU2F81CC015490
Ім'я: Audi R6
Номерний знак: AA 3435 AT
Бензина в баці: 35 л.
Пробіг: 0 км.��� $��2��	 �� �� .+�� $��0��.+��� $��Center=�.+��� $
 Left=����#8B92A6$��Gilroy)�$��Normal"�$��12(�$"��Початок оренди:���� $
 Left=����#8B92A6$��Gilroy)�$��Normal"�$��12(�$ ��Кінець оренди:��� $��1��.+��� $��Center=�.+��� -	   $
 label_StartDate��$ Right=����#8B92A6$��Gilroy)�$
��Bold"�$��12(�$��16.05.2020 20:12:15���� -
   $
 label_FinalDate��$ Right=����#8B92A6$��Gilroy)�$
��Bold"�$��12(�$��16.05.2020 20:12:15��� $��3��$��0,0,0,7q�	 �� �� .+�� $��0��$��Bottom=�.+��� $
 Left=����#8B92A6$��Gilroy)�$��Normal"�$��12(�$-��'Загальна сума оренди:��� $��1��$��Bottom=�.+��� -   $
 label_Price��$ Right=����#8B92A6$��Gilroy)�$
��Bold"�$��18(�$��1500 грн.��� $��2��.+��� -   $
 
label_Date��$��0,3,0,0q�$ Center=����#8B92A6$��Gilroy)�$
��Bold"�$��14(�$��16.05.2020 20:12:15���� $��0,1,0,0q����#8B92A6