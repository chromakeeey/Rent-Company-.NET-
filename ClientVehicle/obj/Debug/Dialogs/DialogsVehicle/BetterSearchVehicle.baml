   M S B A M L   `   `   `  ����H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:ClientVehicle.Dialogs.DialogsVehicle$ClientVehicle.Dialogs.DialogsVehicle  5   	   >    8ClientVehicle.Dialogs.DialogsVehicle.BetterSearchVehicle   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:ClientVehicle.Dialogs.DialogsVehicle     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$%  Пошук автомобіля��5	   	   $	��471��6"   $	��400��6/    � Icon$ 
notify.ico��6;    � AllowsTransparency .  � WindowStyle$
 None=�5
   #    � WindowStartupLocation$ CenterScreen=�66   
������ .��5      � $�� 5q�6   .+�5   
   ��    BorderCornerRadius15#��[  6   
�������6?   � 5   
   $��15q�6   .+�5      �� .+�5      �� $��0��5      $��Gilroy)�5      $
��Bold"�5      $��14(�5      $A��;Пошук транспорта за параметрами��5       �� TextAlignment$ Center=�5      $��Center=�5      ���#99A5B65      �� 5      -   5         ��Name$ field_MinPrice��5      $��10q�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Мінімальна ціна��5      $��Gilroy)�5      $
��Bold"�5      $��14(�5        % !MaterialDesignFloatingHintTextBox#��[ 5!      $��Center=�5"         
Foreground �#3B93F7.  (MaterialDesignThemes.Wpf.TextFieldAssist	   UnderlineBrush	 �#3B93F75$      �� 5&      -   5        $ field_MaxPrice��5'      $��10q�5(      $% Максимальна ціна��5)      $��Gilroy)�5*      $
��Bold"�5+      $��14(�5,      #��[ 5-      $��Center=�5.       �#3B93F7	 �#3B93F750      �� 52      -   5        
 ��Name$
 
combo_Type��53       & "MaterialDesignFloatingHintComboBox#��[ 54      $��10q�55      $! Тип автомобіля��56      $��Center=�57       �� 
IsEditable . $��Gilroy)�59      $
��Bold"�5:      $��14(�5;       �#3B93F7	 �#3B93F7.@�5?      �� $��Легковий��6#   �� 5@      $��Позашляховик��6#   �� 5A      $��Вантажний��6#   �� 5B      $��Мотоцикл��6#   �� 5C      $��
Мопед��6#   5E      �� 5G      -   5        $
 combo_Transmission��5H      #��[ 5I      $��10q�5J      $ Трансмісія��5K      $��Center=�5L       .  $��Gilroy)�5N      $
��Bold"�5O      $��14(�5P       �#3B93F7	 �#3B93F7.@�5T      �� $�� ��6#   �� 5U      $��Механічна��6#   �� 5V      $��Автоматична��6#   5X      �� 5Z      -   5        $
 combo_Category��5[      #��[ 5\      $��10 10 10 20q�5]      $! Категорія прав��5^      $��Center=�5_       .  $��Gilroy)�5a      $
��Bold"�5b      $��14(�5c       �#3B93F7	 �#3B93F7.@�5g      �� $�� ��6#   �� 5h      $��A1��6#   �� 5i      $��A��6#   �� 5j      $��B1��6#   �� 5k      $��B��6#   �� 5l      $��C1��6#   �� 5m      $��C��6#   �� 5n      $��D1��6#   �� 5o      $��D��6#   �� 5p      $	��C1E��6#   �� 5q      $��BE��6#   �� 5r      $��CE��6#   �� 5s      $	��D1E��6#   �� 5t      $��DE��6#   �� 5u      $��T1��6#   �� 5v      $��T2��6#   5x      �� 5~       �� Orientation$ 
Horizontal=�6   $��Center=�66   .+�5�      �� $��0��5�      $��Gilroy)�5�      $
��Bold"�5�      $��0 0 20 0q�5�      $��14(�5�      $1��+Орендований автомобіль��5�      $ Center=�5�      $��Center=�5�      ���#99A5B65�      d� 5�      -   5         d�Name$ toggle_RentStatus��5�       $  MaterialDesignSwitchToggleButton#��[ 5�       � ToolTip$  Default ToggleButton Style��5�      ���#3B93F75�      5�      �� 5�      -   5        $��Center=�5�   !   $��0 20 0 0q�5�   !   $��32��5�   %   $	��155��61    " MaterialDesignRaisedDarkButton#��[ 5�   %   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5�   %   $��0q�5�   %   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5�   )   $7 1MaterialDesignRaisedDarkButton with Round Corners��5�   %   ���#3B93F7���#3B93F7.��5�      �� $��
Пошук��5�   )   $��14(�5�   )   $��Gilroy)�5�   )   
�������$
��Bold"�5�   )   5�      �� 5�      $��0��5�      $��Gilroy)�5�      $
��Bold"�5�      $��10(�5�      $��0 10 0 0q�5�      $X��R* пусте поле не буде враховуватись при пошуку��5�      $ Right=�5�      $��Right=�5�      ���#99A5B65�      5�      5�      5�      5�      