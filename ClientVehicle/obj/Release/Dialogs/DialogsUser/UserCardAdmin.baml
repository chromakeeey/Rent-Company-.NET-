   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:ClientVehicle.Dialogs.DialogsUser!ClientVehicle.Dialogs.DialogsUser  ?$clr-namespace:ClientVehicle.ControlsClientVehicle.Controls  5    /ClientVehicle.Dialogs.DialogsUser.UserCardAdmin   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Alocal/clr-namespace:ClientVehicle.Dialogs.DialogsUser     9controls$clr-namespace:ClientVehicle.Controls     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$3  -Редагування користувача��$	��850��$	��550�� � Icon$ 
notify.ico��
������  � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � AllowsTransparency . .��� $��5q�.+�� .+���    BorderCornerRadius15#��[  
�������� $��20q� � RowDefinitions �� $
��Auto ��� $
��Auto ��� �� $
��Auto �.+�'  !MaterialDesignThemes.Wpf.PackIcon  -   $��0��$��0 0 5 0q�   Kind$ 
CloseThick=�$��Right=�  HoverMouseAnimation#��[ � $��1��.+��  � ColumnDefinitions �� �� $
��Auto �.+�� $��0��.+���  �� Orientation$ 
Horizontal=�.+�A� $��50��$��50��$
��Left=����� 	 �� ImageSource$	 unnamed.jpg���� $��Center=�.+��� -   
 ��Name$
 label_FullName��$	��162��$
��Wrap=�$��15 0 0 0q�$��Center=�$-��'Паламарчук Олександр��$��14(�$��Gilroy)����#99A5B6$
��Bold"��� -   $
 label_ID��$	��162��$
��Wrap=�$��15 0 0 0q�$��Center=�$��№256��$��14(�$��Gilroy)����#99A5B6$
��Bold"�� $��1��.+��� $��Center=�$��Right=�.+��� .+���  �� TextAlignment$ Right=�$#��Дата реєстрації��$��14(�$��Gilroy)����#99A5B6$
��Bold"��� -   $
 label_Register��$ Right=�$��25.06.2020 12:18:12��$��14(�$��Gilroy)�
���   �$
��Bold"�� $��2��.+�� $	��Top=�.+��� .���� -   $��0 0 15 0q�.+��� -    ��Name$ field_Login��$��palamarchuk��$��10q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логін��   
HelperText$D >Використовується для авторизації��$��Gilroy)�$
��Bold"�$��14(� % !MaterialDesignFloatingHintTextBox#��[ $��Center=�   
Foreground �#3B93F7.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#3B93F7�� -   $ field_Surname��$��Паламарчук��$��10q�$ Прізвище��$I CПрізвище потрібно брати з скана прав��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� -   $ 
field_Name��$��Олександр��$��10q�$ Ім'я��$@ :Ім'я потрібно брати з скана прав��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� -	   $ 
field_Mail��$��palamarchuk@gmail.com��$��10q�$ 
Пошта��$C =Електронна пошта (gmail, ukr, mail, тощо.)��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� -
   $ field_Phone��$��+380665300220��$��10q�$! Номер телефона��$4 .Тільки український номер��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7(  "System.Windows.Controls.DatePicker  -     Name$ date_Birthday��$��2��$��10q�$��Gilroy)�$
��Bold"�$# Дата народження�� ( $MaterialDesignFloatingHintDatePicker#��[  �#3B93F7 �#3B93F7� .+�'   !ClientVehicle.Controls.ZoomBorder  }�. 
�������   Child. �� -    ��Name$ image_Front��$	��200��$��	10 0 10 0q�$��top.png��� $��	0 10 0 20q�.+�  }�. 
�������. �� -   $ 
image_Back��$	��200��$��	10 0 10 0q�$��
bottom.png���� -    ��Name$ listbox_Category��$��0 0 0 10q�$��Center=�$��Gilroy)�$
��Bold"� # MaterialDesignFilterChipListBox#��[ .@��� $��A1��� $��10 20 10 20q� �� �� $
��Auto �.+��� $��0��$��Gilroy)�$
��Bold"�$��14(�$1��+Функції адміністратора��$
 Left=�$
��Left=����#99A5B6d� -    d�Name$ toggle_AdminStatus��$��1�� $  MaterialDesignSwitchToggleButton#��[  � ToolTip$^ XДоступні чи користувачу функції адміністратора�����#3B93F7� $��0 0 0 10q� �� �� .+�� $��0��.+�� $��36��$	��214��$
��Left=�.+��� 
������ $��1q�
������� �� CornerRadius$ 15�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   ShadowDepth$ 5Q�   Opacity$	 0.3Q�� $��	15 5 15 5q�.+��� -   $ field_Password��$��Gilroy)�$
��Bold"�$��0q�   DecorationVisibility$ Hidden=�$, &Введіть новий пароль��� $��1��.+��� $��Right=�$��36��$	��155�� " MaterialDesignRaisedDarkButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��$��0q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�$7 1MaterialDesignRaisedDarkButton with Round Corners��
������ 
������ .���� $!��Оновити пароль��$��14(�$��Gilroy)�
���   �$
��Bold"�� $��3��.+�� $��Center=�$��0 20 0 0q�.+��� .+��� -    ��Name$ button_VehicleUser��$��0 0 0 20q�{�. $��Center=�$
��Auto��$
��Auto��#��[ $ 15��$��2q�$ Depth3=�$7 1MaterialDesignRaisedDarkButton with Round Corners��
������ 
������ .���� $H��BПереглянути орендований автомобіль��$��10(�$��Gilroy)�
���   �$
��Bold"��� -   $ button_Deactivate��$��0 0 0 2q�{�. $��Center=�$
��Auto��$
��Auto��#��[ $ 15��$��2q�$ Depth3=�$7 1MaterialDesignRaisedDarkButton with Round Corners��
������ 
������ .���� $ 
Horizontal=�.+�  $ 	TimerSand=����#99A5B6$��25��$��25��$��0 0 5 0q��� $��Center=�$-��'Деактивувати аккаунт��$��14(�$��Gilroy)����#99A5B6$
��Bold"�� -     �Name$  
GridReason��$��36��$	��214��$��Center=�$y�	Collapsed=�.+��� 
������ $��1q�
�������$ 15��   $ 10Q�$ 5Q�$	 0.3Q�� $��	15 5 15 5q�.+��� -   $ field_Reason��$��Center=�! �� TextAlignment$! Center=�$��Gilroy)�$
��Bold"�$��0q�$ Hidden=�$$ Введіть причину ���� -   $
 label_Error��$y�	Collapsed=�$��Center=�$)��#Ви не ввели причину��$��14(�$��Center=�$��0 10 0 5q�$��Gilroy)����#E25544$
��Bold"��� -   $��0 10 0 0q�$��36��$	��256��#��[ $ 15��$��0q�$ Depth3=�$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $)��#Оновити інформацію��$��14(�$��Gilroy)�
�������$
��Bold"�� -   $  InvalidUserPanel��$y�Hidden=�.+��� #��[  
���   �" J� Opacity$	" 0.7Q�� $��20q�$��Center=�$��Center=�.+��� .+��� $ Center=�$-��'Аккаунт деактивовано��$��24(�$��Gilroy)�
�������$
��Bold"��� -   $
 label_Reason��$ Center=�$5��/Причина: неправомірні дії��$
��Wrap=�$��16(�$��Gilroy)�
�������$
��Bold"��� -   $��0 60 0 0q�$��36��$	��256��#��[ $ 15��$��0q�$ Depth3=�$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $0��*Відновити дію аккаунта��$��14(�$��Gilroy)�
�������$
��Bold"��� -   $��36��$	��256��#��[ $ 15��$��0q�$ Depth3=�$7 1MaterialDesignRaisedDarkButton with Round Corners��
������ 
������ .���� $��Повернутись��$��14(�$��Gilroy)�
�������$
��Bold"�