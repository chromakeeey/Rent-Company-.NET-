   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:ClientVehicle.Dialogs.DialogsVehicle$ClientVehicle.Dialogs.DialogsVehicle  :    4ClientVehicle.Dialogs.DialogsVehicle.VehicleEditPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  >local2clr-namespace:ClientVehicle.Dialogs.DialogsVehicle    � Title$1  +Редагування автомобіля��$	��450��$	��800�� � Icon$ 
notify.ico�� � WindowStyle$
 None=� � AllowsTransparency . 
������  � WindowStartupLocation$ CenterScreen=�.��� $��5q�.+���    BorderCornerRadius15#��[  
�������� $��15q� � ColumnDefinitions �� �� .+�� $��0��.+��� $��Visible=�$��Disabled=�.���� $��0 0 15 0q�.+��� $��Gilroy)�$
��Bold"�$��14(�$B��<Редагування основної інформації�� �� TextAlignment$ Center=�$��Center=����#99A5B6�� -    ��Name$ 
field_Name��$��10q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$% Назва транспорта��	   
HelperText$;	 5Зазвичай це марка автомобіль��$��Gilroy)�$
��Bold"�$��14(� % !MaterialDesignFloatingHintTextBox#��[ $��Center=�
   
Foreground
 �#3B93F7.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#3B93F7�� -   $ field_Model��$��10q�$' !Модель транспорта��$%	 Конкретна модель��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=�
 �#3B93F7 �#3B93F7�� -   $ field_Mileage��$��10q�$ Пробіг��$D	 >Пробіг автомобіля на даний момент��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=�
 �#3B93F7 �#3B93F7�� -   $ field_MaxSpeed��$��10q�$/ )Максимальна швидкість��$D	 >Максимальна швидкість автомобіля��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=�
 �#3B93F7 �#3B93F7�� -   $ field_MaxFuel��$��10q�$ Об'єм бака��$+	 %Загальний об'єм бака��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=�
 �#3B93F7 �#3B93F7�� -   $ 
field_Fuel��$��10q�$  Бензина в баці��$=	 7Бензина в баці на даний момент��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=�
 �#3B93F7 �#3B93F7�� -   $ field_Plate��$��10q�$ Номерний знак��$I	 CУнікальний номерний знак автомобіля��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=�
 �#3B93F7 �#3B93F7�� -   $ field_Price��$��10q�$ Ціна��$F	 @Ціна оренди автомобіля в день (грн.)��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=�
 �#3B93F7 �#3B93F7�� -	    ��Name$ 
combo_Type�� & "MaterialDesignFloatingHintComboBox#��[ $��10q�$! Тип автомобіля��$!	 Тип автомобіля��$��Center=� �� 
IsEditable . $��Gilroy)�$
��Bold"�$��14(�
 �#3B93F7 �#3B93F7.@��� $��Легковий���� $��Позашляховик���� $��Вантажний���� $��Мотоцикл���� $��
Мопед���� -
   $ combo_Transmission��#��[ $��10q� . $ Трансмісія��$/	 )Трансмісія автомобіля��$��Center=�$��Gilroy)�$
��Bold"�$��14(�
 �#3B93F7 �#3B93F7.@��� $��Механічна���� $��Автоматична���� -   $ combo_Category��#��[ $��10 10 10 20q� . $! Категорія прав��$l	 fКатегорія прав яка має право на оренду цього автомобіля��$��Center=�$��Gilroy)�$
��Bold"�$��14(�
 �#3B93F7 �#3B93F7.@��� $��A1���� $��A���� $��B1���� $��B���� $��C1���� $��C���� $��D1���� $��D���� $	��C1E���� $��BE���� $��CE���� $	��D1E���� $��DE���� $��T1���� $��T2��� $��1��.+��� .+�'  !MaterialDesignThemes.Wpf.PackIcon  -   $��0 0 5 0q�   Kind$ 
CloseThick=�$��Right=�  HoverMouseAnimation#��[ �� -    ��Name$ 	label_VIN��$��Gilroy)�$
��Bold"�$��18(�$��WDCGG8JB0DG099158��$ Center=�$��Center=����#99A5B6�� -    ��Name$ image_Vehicle��$	��200��$��Center=�$��toyota_PNG1953.png��� $��
10 20 10 0q� �� $
��Auto ��� .+��� $��0��$
 Left=�$
��Left=�$"��Початок оренди:��$��16(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_StartRent��$��1��$ Right=�$��Right=�$��25.06.2020 12:43:46��$��16(�$��Gilroy)�
���   �$��Medium"�� $��	10 0 10 0q� �� $
��Auto ��� .+��� $��0��$
 Left=�$
��Left=�$ ��Кінець оренди:��$��16(�$��Gilroy)����#99A5B6$��Regular"��� -   $ label_FinalRent��$��1��$ Right=�$��Right=�$��25.06.2020 12:43:46��$��16(�$��Gilroy)�
���   �$��Medium"��� -    ��Name$ button_User��$��	10 20 0 0q�$
��Left=�$
��Auto��$
��Auto��$��0q�
������ 
������ .����  �� Orientation$ 
Horizontal=�.+��� $<��6Переглянути аккаунт орендаря��$��Gilroy)�$
��Bold"����#99A5B6$��0 0 10 0q�$��Center=�  $ RemoveRedEye=����#99A5B6$��20��$��20��$��Center=��� -   $ button_Stop��$��10 0 0 0q�$
��Left=�$
��Auto��$
��Auto��$��0q�
������ 
������ .���� $ 
Horizontal=�.+��� $%��Відмінити оренду��$��Gilroy)�$
��Bold"����#99A5B6$��0 0 10 0q�$��Center=�  $ 
StopCircle=����#99A5B6$��20��$��20��$��Center=��� -   $��0 20 0 0q�$��36��$	��170�� " MaterialDesignRaisedDarkButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��$��0q�$��Right=�$��Bottom=�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=� � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $+��%Зберігти інформацію��$��14(�$��Gilroy)�
�������$
��Bold"��� -   $ label_Error��$
 Left=�$
��Left=�$��Bottom=� J� Opacity$	 0.5Q�$��0 0 0 10q�$	��200��$�� ��$��12(�$
��Wrap=�$��Gilroy)�
���  ��$��Heavy"�