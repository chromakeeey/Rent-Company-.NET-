   M S B A M L   `   `   `  ����H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:ClientVehicle.Dialogs.DialogsVehicle$ClientVehicle.Dialogs.DialogsVehicle  5   	   :    4ClientVehicle.Dialogs.DialogsVehicle.VehicleEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   >local2clr-namespace:ClientVehicle.Dialogs.DialogsVehicle  5   	     � Title$1  +Редагування автомобіля��5	   	   $	��450��6(   $	��800��65    � Icon$ 
notify.ico��6A    � WindowStyle$
 None=�5
   	    � AllowsTransparency . 
������  � WindowStartupLocation$ CenterScreen=�6O   .��5      � $��5q�6   .+�5   
   ��    BorderCornerRadius15#��[  6   
�������6?   � 5   
   $��15q�6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      � $��0��6   .+�5      �� $��Visible=�6   $��Disabled=�6E   .��5      �� $��0 0 15 0q�6!   .+�5      �� $��Gilroy)�5      $
��Bold"�5      $��14(�5      $B��<Редагування основної інформації��5       �� TextAlignment$ Center=�5      $��Center=�5      ���#99A5B65      �� 5!      -   5         ��Name$ 
field_Name��5"      $��10q�5#      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$% Назва транспорта��5$      	   
HelperText$;	 5Зазвичай це марка автомобіль��5%      $��Gilroy)�5&      $
��Bold"�5'      $��14(�5(       % !MaterialDesignFloatingHintTextBox#��[ 5)      $��Center=�5*      
   
Foreground
 �#3B93F7.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#3B93F75,      �� 5.      -   5        $ field_Model��5/      $��10q�50      $' !Модель транспорта��51      $%	 Конкретна модель��52      $��Gilroy)�53      $
��Bold"�54      $��14(�55      #��[ 56      $��Center=�57      
 �#3B93F7 �#3B93F759      �� 5;      -   5        $ field_Mileage��5<      $��10q�5=      $ Пробіг��5>      $D	 >Пробіг автомобіля на даний момент��5?      $��Gilroy)�5@      $
��Bold"�5A      $��14(�5B      #��[ 5C      $��Center=�5D      
 �#3B93F7 �#3B93F75F      �� 5H      -   5        $ field_MaxSpeed��5I      $��10q�5J      $/ )Максимальна швидкість��5K      $D	 >Максимальна швидкість автомобіля��5L      $��Gilroy)�5M      $
��Bold"�5N      $��14(�5O      #��[ 5P      $��Center=�5Q      
 �#3B93F7 �#3B93F75S      �� 5U      -   5        $ field_MaxFuel��5V      $��10q�5W      $ Об'єм бака��5X      $+	 %Загальний об'єм бака��5Y      $��Gilroy)�5Z      $
��Bold"�5[      $��14(�5\      #��[ 5]      $��Center=�5^      
 �#3B93F7 �#3B93F75`      �� 5b      -   5        $ 
field_Fuel��5c      $��10q�5d      $  Бензина в баці��5e      $=	 7Бензина в баці на даний момент��5f      $��Gilroy)�5g      $
��Bold"�5h      $��14(�5i      #��[ 5j      $��Center=�5k      
 �#3B93F7 �#3B93F75m      �� 5o      -   5        $ field_Plate��5p      $��10q�5q      $ Номерний знак��5r      $I	 CУнікальний номерний знак автомобіля��5s      $��Gilroy)�5t      $
��Bold"�5u      $��14(�5v      #��[ 5w      $��Center=�5x      
 �#3B93F7 �#3B93F75z      �� 5|      -   5        $ field_Price��5}      $��10q�5~      $ Ціна��5      $F	 @Ціна оренди автомобіля в день (грн.)��5�      $��Gilroy)�5�      $
��Bold"�5�      $��14(�5�      #��[ 5�      $��Center=�5�      
 �#3B93F7 �#3B93F75�      �� 5�      -	   5         ��Name$ 
combo_Type��5�       & "MaterialDesignFloatingHintComboBox#��[ 5�      $��10q�5�      $! Тип автомобіля��5�      $!	 Тип автомобіля��5�      $��Center=�5�       �� 
IsEditable . $��Gilroy)�5�      $
��Bold"�5�      $��14(�5�      
 �#3B93F7 �#3B93F7.@�5�      �� $��Легковий��6+   �� 5�      $��Позашляховик��6+   �� 5�      $��Вантажний��6+   �� 5�      $��Мотоцикл��6+   �� 5�      $��
Мопед��6+   5�      �� 5�      -
   5        $ combo_Transmission��5�      #��[ 5�      $��10q�5�       . $ Трансмісія��5�      $/	 )Трансмісія автомобіля��5�      $��Center=�5�      $��Gilroy)�5�      $
��Bold"�5�      $��14(�5�      
 �#3B93F7 �#3B93F7.@�5�      �� $��Механічна��6+   �� 5�      $��Автоматична��6+   5�      �� 5�      -   5        $ combo_Category��5�      #��[ 5�      $��10 10 10 20q�5�       . $! Категорія прав��5�      $l	 fКатегорія прав яка має право на оренду цього автомобіля��5�      $��Center=�5�      $��Gilroy)�5�      $
��Bold"�5�      $��14(�5�      
 �#3B93F7 �#3B93F7.@�5�      �� $��A1��6+   �� 5�      $��A��6+   �� 5�      $��B1��6+   �� 5�      $��B��6+   �� 5�      $��C1��6+   �� 5�      $��C��6+   �� 5�      $��D1��6+   �� 5�      $��D��6+   �� 5�      $	��C1E��6+   �� 5�      $��BE��6+   �� 5�      $��CE��6+   �� 5�      $	��D1E��6+   �� 5�      $��DE��6+   �� 5�      $��T1��6+   �� 5�      $��T2��6+   5�      5�      5�      5�      � 5�      $��1��6   .+�5�      �� .+�5�      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��0 0 5 0q�5�         Kind$ 
CloseThick=�5�      $��Right=�5�        HoverMouseAnimation#��[ 5�      6F   �� 5�      -   5         ��Name$ 	label_VIN��5�      $��Gilroy)�5�      $
��Bold"�5�      $��18(�5�      $��WDCGG8JB0DG099158��5�      $ Center=�5�      $��Center=�5�      ���#99A5B65�      �� 5�      -   5         ��Name$ image_Vehicle��5�      $	��200��5�      $��Center=�5�      $��toyota_PNG1953.png��6:   � 5�      $��
10 20 10 0q�6    5�      �� 5�      $
��Auto �6/   �� 5�      .+�5�      �� $��0��5�   %   $
 Left=�5�   %   $
��Left=�5�   %   $"��Початок оренди:��5�   %   $��16(�5�   %   $��Gilroy)�5�   %   ���#99A5B6$��Regular"�5�   %   �� 5      -   5        $ label_StartRent��5  )   $��1��5  %   $ Right=�5  %   $��Right=�5  %   $��25.06.2020 12:43:46��5  %   $��16(�5  %   $��Gilroy)�5  %   
���   �$��Medium"�5	  %   5     � 5     $��	10 0 10 0q�6    5     �� 5     $
��Auto �6/   �� 5     .+�5     �� $��0��5  %   $
 Left=�5  %   $
��Left=�5  %   $ ��Кінець оренди:��5  %   $��16(�5  %   $��Gilroy)�5  %   ���#99A5B6$��Regular"�5  %   �� 5     -   5        $ label_FinalRent��5  )   $��1��5   %   $ Right=�5!  %   $��Right=�5"  %   $��25.06.2020 12:43:46��5#  %   $��16(�5$  %   $��Gilroy)�5%  %   
���   �$��Medium"�5'  %   5,     �� 5.     -   5         ��Name$ button_User��5/     $��	10 20 0 0q�50     $
��Left=�51  !   $
��Auto��6<   $
��Auto��6J   $��0q�6W   
������ 
������ .��54     ��  �� Orientation$ 
Horizontal=�6%   .+�56     �� $<��6Переглянути аккаунт орендаря��57  !   $��Gilroy)�58  !   $
��Bold"�59  !   ���#99A5B6$��0 0 10 0q�5;  !   $��Center=�5<  !     5>     $ RemoveRedEye=�5?  !   ���#99A5B6$��20��5A  !   $��20��5B  !   $��Center=�5C  !   5F     5G     �� 5I     -   5        $ button_Stop��5J     $��10 0 0 0q�5K     $
��Left=�5L  !   $
��Auto��6<   $
��Auto��6J   $��0q�6W   
������ 
������ .��5O     �� $ 
Horizontal=�6%   .+�5Q     �� $%��Відмінити оренду��5R  !   $��Gilroy)�5S  !   $
��Bold"�5T  !   ���#99A5B6$��0 0 10 0q�5V  !   $��Center=�5W  !     5Y     $ 
StopCircle=�5Z  !   ���#99A5B6$��20��5\  !   $��20��5]  !   $��Center=�5^  !   5a     5b     5e     �� 5g     -   5        $��0 20 0 0q�5g     $��36��5h  %   $	��170��61    " MaterialDesignRaisedDarkButton#��[ 5i  %   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5j  %   $��0q�5k  %   $��Right=�5l  )   $��Bottom=�5m     +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5n  )    � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners��5o  %   ���#3B93F7���#3B93F7.��5r     �� $+��%Зберігти інформацію��5s  )   $��14(�5t  )   $��Gilroy)�5u  )   
�������$
��Bold"�5w  )   5x     �� 5z     -   5        $ label_Error��5{     $
 Left=�5|     $
��Left=�5}     $��Bottom=�5~      J� Opacity$	 0.5Q�5     $��0 0 0 10q�5�     $	��200��5�     $�� ��5�     $��12(�5�     $
��Wrap=�5�     $��Gilroy)�5�     
���  ��$��Heavy"�5�     5�     5�     5�     5�     