   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:ClientVehicle.Dialogs.ReceiptsClientVehicle.Dialogs.Receipts  0    *ClientVehicle.Dialogs.Receipts.ReceiptEdit   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     >local,clr-namespace:ClientVehicle.Dialogs.Receipts     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  ReceiptEdit��$	��500��$	��700�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������ .��� $��5q�.+���    BorderCornerRadius15#��[  
�������� $��10q� � ColumnDefinitions �� $
��Auto ���  � RowDefinitions �� $
��Auto ��� .+��� $��0��$��0��$%��Редагування чека��$��Center=�$��Gilroy)�$
��Bold"�'  !MaterialDesignThemes.Wpf.PackIcon  $��0��$��1��$��0 0 5 0q�   Kind$ 
CloseThick=�$��Right=�  HoverMouseAnimation#��[ � $��0��$��1��.+�� $��20q�.+�� $
��Left=�$��Center=�.+��� .+��� -    ��Name$ field_Company��$��10q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$! Назва компанії��$	��230��	   
HelperText$C	 =Відображається після номеру чека��$��Gilroy)�$
��Bold"�$��14(� % !MaterialDesignFloatingHintTextBox#��[ $��Center=�
   
Foreground
 �#3B93F7.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#3B93F7�� -   $ field_Street��$��10 10 10 40q�$# Адреса компанії��$	��230��$I	 CВідображається після назви компанії��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=�
 �#3B93F7 �#3B93F7�� -   $��Center=�$��0 0 0 10q�$��32��$	��180�� " MaterialDesignRaisedDarkButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��$��0q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=� � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $)��#Оновити інформацію��$��14(�$��Gilroy)�
�������$
��Bold"�� $��1��$��1��.+�#  MaterialDesignThemes.Wpf.Card  $ Depth4=�$��10q�$��10q�
�������.���  �� $
��Auto ��� �� $
��Auto �.+�� $��0��.+��� $��0,0,0,1q����#8B92A6�� $��Center=�.+���  �� TextAlignment$ Center=����#8B92A6$��Gilroy)�$
��Bold"�$��14(�$��Номер чека - 22���� -    ��Name$ label_Company��$ Center=����#8B92A6$��Gilroy)�$
��Bold"�$��14(�$&�� Автопрокат 'QuickRent'���� -   $ label_Street��$��0,0,0,5q�$
��Wrap=�$ Center=����#8B92A6$��Gilroy)�$
��Bold"�$��14(�$y��sУкраїна, Чернівецька область, м. Чернівці, вул. Головна 256, офіс 3��� $��1�� �� $
��Auto ��� �� �� .+�� $��0��$��0,5,0,30q� �� $
��Auto ��� .+�� $��0��.+��� $
 Left=����#8B92A6$��Gilroy)�$
��Bold"�$��11(�$��Орендар:��� $��1��.+��� $ Right=����#8B92A6$��Gilroy)�$
��Bold"�$��11(�$H��BПаламарчук Олександр Володимирович��� $��1��.+��� .+��� $
 Left=����#8B92A6$��Gilroy)�$��Normal"�$��12(�$7��1Інформація про автомобіль:���� $
 Left=����#8B92A6$��Gilroy)�$
��Bold"�$��12(�$��VIN: JH4CU2F81CC015490���� $
 Left=����#8B92A6$��Gilroy)�$
��Bold"�$��12(�$��Ім'я: Audi R6���� $
 Left=����#8B92A6$��Gilroy)�$
��Bold"�$��12(�$+��%Номерний знак: AA 3435 AT���� $
 Left=����#8B92A6$��Gilroy)�$
��Bold"�$��12(�$(��"Бензина в баці: 35 л.���� $
 Left=����#8B92A6$��Gilroy)�$
��Bold"�$��12(�$��Пробіг: 0 км.��� $��2�� �� �� .+�� $��0��.+��� $��Center=�.+��� $
 Left=����#8B92A6$��Gilroy)�$��Normal"�$��12(�$"��Початок оренди:���� $
 Left=����#8B92A6$��Gilroy)�$��Normal"�$��12(�$ ��Кінець оренди:��� $��1��.+��� $��Center=�.+��� $ Right=����#8B92A6$��Gilroy)�$
��Bold"�$��12(�$��16.05.2020 20:12:15���� $ Right=����#8B92A6$��Gilroy)�$
��Bold"�$��12(�$��16.05.2020 20:12:15��� $��3��$��0,0,0,7q� �� �� .+�� $��0��$��Bottom=�.+��� $
 Left=����#8B92A6$��Gilroy)�$��Normal"�$��12(�$-��'Загальна сума оренди:��� $��1��$��Bottom=�.+��� $ Right=����#8B92A6$��Gilroy)�$
��Bold"�$��12(�$��1500 грн.��� $��2��.+��� $��0,3,0,0q�$ Center=����#8B92A6$��Gilroy)�$
��Bold"�$��14(�$��16.05.2020 20:12:15���� $��0,1,0,0q����#8B92A6