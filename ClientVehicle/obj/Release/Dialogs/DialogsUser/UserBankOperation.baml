   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:ClientVehicle.Dialogs.DialogsUser!ClientVehicle.Dialogs.DialogsUser  9    3ClientVehicle.Dialogs.DialogsUser.UserBankOperation   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Alocal/clr-namespace:ClientVehicle.Dialogs.DialogsUser     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$*  $Операції з рахунком��$	��390��$	��800�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������  � Icon$ 
notify.ico��.��� $��5q�.+���    BorderCornerRadius15#��[  
�������� $��10q� � RowDefinitions �� $
��Auto ��� .+�'  !MaterialDesignThemes.Wpf.PackIcon  -   $��0��$��0 0 5 0q�   Kind$ 
CloseThick=�$��Right=�  HoverMouseAnimation#��[ � $��1�� � ColumnDefinitions �� �� .+�� $��0��.+��� $��10 0 0 0q�.+��� $��0 0 0 10q�.+��� $��Баланс��$��18(�$��Gilroy)����#99A5B6$
��Bold"��� -    ��Name$ label_Balance��$��
₴ 52 000��$��36(�$��Gilroy)����#8DB57A$
��Bold"��� .+��� $��Борг��$��18(�$��Gilroy)����#99A5B6$
��Bold"��� -   $ label_Credit��$��₴ 600��$��24(�$��Gilroy)����#DF9090$
��Bold"��� $
��Left=�$��	0 10 0 20q�	 J� Opacity$		 0.5Q�$	��256��${��uУвага! При активному боргу ви не зможете вивести кошти з рахунку��$��10(�$
��Wrap=�$��Gilroy)�
���  ��$��Heavy"��� $
��Left=�$��	0 10 0 10q�$		 0.5Q�$	��350��$e��_Виберіть потрібну операцію та заповніть інформацію��$��12(�$
��Wrap=�$��Gilroy)����#99A5B6$��Heavy"��� 
 �� Orientation$
 
Horizontal=�.+�	� -    	�Name$ radio_Minus��$��0 0 20 0q����#3B93F7$��Вивести��$��Gilroy)�$
��Bold"����#99A5B6$��10(�	� -   $ 
radio_Plus�����#3B93F7$��Поповнити��$��Gilroy)�$
��Bold"����#99A5B6$��10(��� $
 
Horizontal=�.+��� -    ��Name$ field_Price��$	��256��$��0��$��0 5 0 0q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Сумма у грн.��$��Gilroy)�$
��Bold"�$��14(� % !MaterialDesignFloatingHintTextBox#��[ $��Center=�   
Foreground �#3B93F7.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#3B93F7�� -    ��Name$ operationButton��$
��Left=�$��0 20 0 0q�$��32��$	��200�� " MaterialDesignRaisedDarkButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��$��0q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=� � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $'��!Виконати операцію��$��14(�$��Gilroy)�
�������$
��Bold"�� $��1��.+��� .+��� $8��2Зміна платіжної інформації��$��18(�$��Gilroy)����#99A5B6$
��Bold"��� -   $ field_CardNumber��$��
0 10 10 10q�$ Номер карти��   
HelperText$H BЗображений на лицевій стороні карти��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� $
 
Horizontal=�.+��� -	   $ field_ExpireDate��$	��155��$��
0 10 10 10q�$) #Термін придатності��$= 7Знаходиться під номером карти��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� -
   $ 	field_CVV��$	��180��$��
0 10 10 10q�$ 
CVV-код��$F @Зображений на задній стороні карти��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� -   $��Bottom=�$
��Left=�$��0 20 0 0q�$��32��$	��100��#��[ $ 15��$��0q�$ Depth3=�$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $��Оновити��$��14(�$��Gilroy)�
�������$
��Bold"��� -   $ label_Error��$
��Left=�$��	0 10 0 20q�$		 0.5Q�$�� ��$��10(�$��Gilroy)�
���  ��$��Heavy"�