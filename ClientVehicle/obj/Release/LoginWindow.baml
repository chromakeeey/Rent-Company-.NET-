   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ClientVehicleClientVehicle      ClientVehicle.LoginWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:ClientVehicle     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   
������   � Title$  LoginWindow��$	��650��$	��500�� � AllowsTransparency .  � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � Icon$ icon.png��.��� $��10q�.+���    BorderCornerRadius25#��[  
�������� $��20q� � RowDefinitions �� $
��Auto ��� �� $
��Auto �.+�� $��0��.+�� $��
20 10 10 0q�$��0��.+��� .+��� $��Center=�$��Center=�$'��!Оренда транспорту��$��14(�$��Gilroy)����#99A5B6$
��Bold"�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
CloseThick=�$��Right=�  HoverMouseAnimation#��[ � $��1��.+�� $��Center=�$��Center=�.+��� .+��� $��Center=�$��Center=�$��Авторизація��$��24(�$��Gilroy)�
���   �$
��Bold"��� $��0 0 0 50q�$��Center=�$��Center=�$F��@Авторизуйтесь для роботи в системі��$��14(�$��Gilroy)����#99A5B6$
��Bold"���  �� Orientation$ 
Horizontal=�.+�  $
 User=�$��Bottom=����#99A5B6$��20��$��20��$��0 0 15 0q��� -    ��Name$ field_Login�� % !MaterialDesignFloatingHintTextBox#��[ $	��300��)  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Введіть логін��$��Gilroy)����#99A5B6$��14(�$
��Bold"�
   
Foreground
 �#3B93F7.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#3B93F7�� $ 
Horizontal=�$��0 20 0 0q�.+�  $	 Key=�$��Bottom=����#99A5B6$��20��$��20��$��0 0 15 0q�G� -    G�Name$ field_Password�� ) %MaterialDesignFloatingHintPasswordBox#��[ $	��300��$!	 Введіть пароль��$��Gilroy)����#99A5B6$��14(�$
��Bold"�
 �#3B93F7 �#3B93F7�� -   $��0 50 0 0q�$��36��$	��242�� " MaterialDesignRaisedDarkButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��$��0q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=� � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $"��Авторизуватись��$��14(�$��Gilroy)�
�������$
��Bold"��� $ 
Horizontal=�$��Center=�$��0 20 0 0q�.+��� $��Center=�$��Center=� �� TextAlignment$ Center=�$'��!Не маєте аккаунта?��$��14(�$��Gilroy)����#99A5B6$
��Bold"��� -   $
��Auto��$
��Auto��$��0q�$��5 0 0 0q�
������ 
������ .���� $"��Зареєструйтесь��$��14(�$��Gilroy)����#3B93F7$
��Bold"�� $��2��.+��� $��Center=�$��Center=�$��© 2020��$��14(�$��Gilroy)����#99A5B6$
��Bold"�� -    �Name$ grid_DialogShow�� J� Opacity$	 0.5Q�$y�Hidden=�.+��� #��[  
���   �