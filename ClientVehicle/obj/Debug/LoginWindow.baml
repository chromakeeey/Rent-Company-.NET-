   M S B A M L   `   `   `  ����H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ClientVehicleClientVehicle  5   	       ClientVehicle.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ClientVehicle     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        
������   � Title$  LoginWindow��5
   	   $	��650��6   $	��500��6*    � AllowsTransparency .  � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$ icon.png��6.   .��5      � $��10q�6   .+�5   
   ��    BorderCornerRadius25#��[  6   
�������6?   � 5   
   $��20q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      �� 5      $
��Auto �6    .+�5      � $��0��6   .+�5      � $��
20 10 10 0q�6   $��0��6+   .+�5      �� .+�5      �� $��Center=�5      $��Center=�5      $'��!Оренда транспорту��5      $��14(�5      $��Gilroy)�5       ���#99A5B6$
��Bold"�5"      5#      '  !MaterialDesignThemes.Wpf.PackIcon  5%         Kind$ 
CloseThick=�5&      $��Right=�5'        HoverMouseAnimation#��[ 5(      5*      5+      � 5-      $��1��6   .+�5.      � $��Center=�6   $��Center=�64   .+�5/      �� .+�50      �� $��Center=�51      $��Center=�52      $��Авторизація��53      $��24(�54      $��Gilroy)�55      
���   �$
��Bold"�57      �� 59      $��0 0 0 50q�6$   $��Center=�5:      $��Center=�5;      $F��@Авторизуйтесь для роботи в системі��5<      $��14(�5=      $��Gilroy)�5>      ���#99A5B6$
��Bold"�5@      �� 5B       �� Orientation$ 
Horizontal=�6%   .+�5C        $
 User=�66   $��Bottom=�5D   6   ���#99A5B6$��20��5F   6   $��20��5G   6   $��0 0 15 0q�5H   6   �� 5I      -   5         ��Name$ field_Login��5J   !    % !MaterialDesignFloatingHintTextBox#��[ 5K   !   $	��300��5L   !   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Введіть логін��5M   !   $��Gilroy)�5N   !   ���#99A5B6$��14(�5P   !   $
��Bold"�5Q   !   
   
Foreground
 �#3B93F7.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#3B93F75S   .   5T      �� 5V      $ 
Horizontal=�6%   $��0 20 0 0q�6>   .+�5W        $	 Key=�66   $��Bottom=�5X   6   ���#99A5B6$��20��5Z   6   $��20��5[   6   $��0 0 15 0q�5\   6   G� 5]      -   5         G�Name$ field_Password��5^   !    ) %MaterialDesignFloatingHintPasswordBox#��[ 5_   !   $	��300��5`   !   $!	 Введіть пароль��5a   !   $��Gilroy)�5b   !   ���#99A5B6$��14(�5d   !   $
��Bold"�5e   !   
 �#3B93F7 �#3B93F75g   .   5h      �� 5j      -   5        $��0 50 0 0q�5j   !   $��36��5k   %   $	��242��61    " MaterialDesignRaisedDarkButton#��[ 5l   %   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5m   %   $��0q�5n   %   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5o   )    � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners��5p   %   ���#3B93F7���#3B93F7.��5s      �� $"��Авторизуватись��5t   )   $��14(�5u   )   $��Gilroy)�5v   )   
�������$
��Bold"�5x   )   5y      �� 5{      $ 
Horizontal=�6%   $��Center=�6>   $��0 20 0 0q�6[   .+�5|      �� $��Center=�5}   !   $��Center=�5~   !    �� TextAlignment$ Center=�5   !   $'��!Не маєте аккаунта?��5�   !   $��14(�5�   !   $��Gilroy)�5�   !   ���#99A5B6$
��Bold"�5�   !   �� 5�      -   5        $
��Auto��5�   !   $
��Auto��5�   !   $��0q�5�   !   $��5 0 0 0q�5�   !   
������ 
������ .��5�   "   �� $"��Зареєструйтесь��5�   -   $��14(�5�   -   $��Gilroy)�5�   -   ���#3B93F7$
��Bold"�5�   -   5�      5�      5�      5�      5�      � 5�      $��2��6   .+�5�      �� $��Center=�5�      $��Center=�5�      $��© 2020��5�      $��14(�5�      $��Gilroy)�5�      ���#99A5B6$
��Bold"�5�      5�      5�      � 5�   
   -   5         �Name$ grid_DialogShow��5�   1    J� Opacity$	 0.5Q�6   $y�Hidden=�6   .+�5�      �� #��[  6   
���   �6C   5�      5�      5�      