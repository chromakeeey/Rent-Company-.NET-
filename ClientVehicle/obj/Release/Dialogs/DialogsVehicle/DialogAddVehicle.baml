   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:ClientVehicle.Dialogs.DialogsVehicle$ClientVehicle.Dialogs.DialogsVehicle  ;    5ClientVehicle.Dialogs.DialogsVehicle.DialogAddVehicle   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Dlocal2clr-namespace:ClientVehicle.Dialogs.DialogsVehicle     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$/  )Добавлення автомобіля��$	��700��$	��450�� � Icon$ 
notify.ico�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������ .��� $��5q�.+���    BorderCornerRadius15#��[  
�������� $��10 15 10 15q� � RowDefinitions �� $
��Auto ��� .+��� $��0��$��Gilroy)�$
��Bold"�$��14(�$M��GДодання нового транспорту в базу даних�� �� TextAlignment$ Center=�$��Center=����#99A5B6'  !MaterialDesignThemes.Wpf.PackIcon  -   $��0 0 5 0q�   Kind$ 
CloseThick=�$��Right=�  HoverMouseAnimation#��[ � $��1��.+��� $��Visible=�$��Disabled=�.���� $��0 0 15 0q�.+��� -    ��Name$ 	field_VIN��$��10q�)  #MaterialDesignThemes.Wpf.HintAssist	   Hint$		 VIN��
   
HelperText$J
 DУнікальний ідентифікатор автомобіля��$��Gilroy)�$
��Bold"�$��14(� % !MaterialDesignFloatingHintTextBox#��[ $��Center=�   
Foreground �#3B93F7.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#3B93F7�� -   $ 
field_Name��$��10q�$%	 Назва транспорта��$;
 5Зазвичай це марка автомобіль��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� -   $ field_Model��$��10q�$'	 !Модель транспорта��$%
 Конкретна модель��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� -   $ field_Mileage��$��10q�$	 Пробіг��$D
 >Пробіг автомобіля на даний момент��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� -   $ field_MaxSpeed��$��10q�$/	 )Максимальна швидкість��$D
 >Максимальна швидкість автомобіля��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� -   $ field_MaxFuel��$��10q�$	 Об'єм бака��$+
 %Загальний об'єм бака��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� -   $ 
field_Fuel��$��10q�$ 	 Бензина в баці��$=
 7Бензина в баці на даний момент��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� -	   $ field_Plate��$��10q�$	 Номерний знак��$I
 CУнікальний номерний знак автомобіля��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� -
   $ field_Price��$��10q�$	 Ціна��$F
 @Ціна оренди автомобіля в день (грн.)��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� -    ��Name$ 
combo_Type�� & "MaterialDesignFloatingHintComboBox#��[ $��10q�$!	 Тип автомобіля��$!
 Тип автомобіля��$��Center=� �� 
IsEditable . $��Gilroy)�$
��Bold"�$��14(� �#3B93F7 �#3B93F7.@��� $��Легковий���� $��Позашляховик���� $��Вантажний���� $��Мотоцикл���� $��
Мопед���� -   $ combo_Transmission��#��[ $��10q�$	 Трансмісія��$/
 )Трансмісія автомобіля��$��Center=� .  $��Gilroy)�$
��Bold"�$��14(� �#3B93F7 �#3B93F7.@��� $��Механічна���� $��Автоматична���� -   $ combo_Category��#��[ $��10 10 10 20q�$!	 Категорія прав��$l
 fКатегорія прав яка має право на оренду цього автомобіля��$��Center=� .  $��Gilroy)�$
��Bold"�$��14(� �#3B93F7 �#3B93F7.@��� $��A1���� $��A���� $��B1���� $��B���� $��C1���� $��C���� $��D1���� $��D���� $	��C1E���� $��BE���� $��CE���� $	��D1E���� $��DE���� $��T1���� $��T2���� -    ��Name$ image_Vehicle��$	��330��$	��140��$��0 0 0 20q��� -   $��0 0 0 30q�$
��Auto��$
��Auto��
������ 
������ .���� $��Center=�$ Center=����#99A5B6$@��:Вибрати зоображення автомобіля���� -   $��Center=�$��0 0 0 10q�$��36��$	��155�� " MaterialDesignRaisedDarkButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��$��0q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=� � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $'��!Додати автомобіль��$��14(�$��Gilroy)�
�������$
��Bold"��� -    ��Name$ label_Error��$��Center=�$ Center=����#DF9090$��Gilroy)�$
��Bold"�$6��0Не були заповнені всі поля��$y�Visible=�