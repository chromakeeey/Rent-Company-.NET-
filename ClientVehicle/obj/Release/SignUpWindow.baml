   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ClientVehicleClientVehicle       ClientVehicle.SignUpWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:ClientVehicle     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  SignUpWindow��$	��777��$	��400�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������  � Icon$ icon.png��.��� $��5q�.+���    BorderCornerRadius15#��[  
�������� $��15q� � RowDefinitions �� $
��Auto ��� .+��� $��0��$��Gilroy)�$
��Bold"�$��14(�$,��&Реєстрація в сервісі�� �� TextAlignment$ Center=�$��Center=����#99A5B6'  !MaterialDesignThemes.Wpf.PackIcon  -   $��0 0 5 0q�   Kind$ 
CloseThick=�$��Right=�  HoverMouseAnimation#��[ � $��1��.+��� .+��� -    ��Name$ field_Login��$��10q�)  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 
Логін��
   
HelperText$F
 @Тільки латиниця, від 3 до 16 символів��$��Gilroy)�$
��Bold"�$��14(� % !MaterialDesignFloatingHintTextBox#��[ $��Center=�   
Foreground �#3B93F7.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#3B93F7�� -   $ field_Password��$��10q�$	 Пароль��$'
 !Від 6 до 32 символів��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� -   $ 
field_Mail��$��10q�$%	 Електронна пошта��$!
 gmail, mail, ukr, тощо.��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� -   $ field_Number��$��10q�$!	 Номер телефона��$Q
 KТільки український номер (починати з +380..)��$��Gilroy)�$
��Bold"�$��14(�#��[ $��Center=� �#3B93F7 �#3B93F7�� $��10 20 10 10q�$?��9Завантажте лицеву сторону прав��$��Gilroy)�$
��Bold"����#99A5B6� $��	20 0 20 0q�.+��� -    ��Name$ frontDocumentImage��$	��128��$��
20 0 20 15q�� -    �Name$ 
icon_Front��
�������  HoverMouseAnimationGrid#��[ $	��110��$��	10 0 10 0q�.+�  $ 
CameraPlus=�$��Center=�$��Center=�$	��100��$	��100�����#99A5B6�� $��10 20 10 10q�$=��7Завантажте задню сторону прав��$��Gilroy)�$
��Bold"����#99A5B6� $��	20 0 20 0q�.+��� -   $ backDocumentImage��$	��128��$��
20 0 20 20q�� -	   $ 	icon_Back��
�������#��[ $	��110��$��	10 0 10 0q�.+�  $ 
CameraPlus=�$��Center=�$��Center=�$	��100��$	��100�����#99A5B6�� -
    ��Name$ label_Error��$�� ��$
��Wrap=�$��Center=�$
��Bold"�$��Gilroy)�$��14(�$��0 0 0 5q�
��������� -   $��Center=�$��0 0 0 10q�$��36��$	��220�� " MaterialDesignRaisedDarkButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��$��0q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=� � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $9��3Подати заявку на реєстрацію��$��14(�$��Gilroy)�
�������$
��Bold"�