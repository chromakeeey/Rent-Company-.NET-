   M S B A M L   `   `   `  ����H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ClientVehicleClientVehicle  5   	        ClientVehicle.SignUpWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ClientVehicle     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  SignUpWindow��5	   	   $	��777��6   $	��400��6+    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�6.    � AllowsTransparency . 
������  � Icon$ icon.png��5   	   .��5      � $��5q�6   .+�5   
   ��    BorderCornerRadius15#��[  6   
�������6?   � 5   
   $��15q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      .+�5      �� $��0��5      $��Gilroy)�5      $
��Bold"�5      $��14(�5      $,��&Реєстрація в сервісі��5       �� TextAlignment$ Center=�5      $��Center=�5      ���#99A5B65      '  !MaterialDesignThemes.Wpf.PackIcon  5!      -   5        $��0 0 5 0q�5"         Kind$ 
CloseThick=�5#      $��Right=�5$        HoverMouseAnimation#��[ 5%      6F   � 5'      $��1��6   .+�5(      �� .+�5*      �� -   5         ��Name$ field_Login��5+      $��10q�5,      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 
Логін��5-      
   
HelperText$F
 @Тільки латиниця, від 3 до 16 символів��5.      $��Gilroy)�5/      $
��Bold"�50      $��14(�51       % !MaterialDesignFloatingHintTextBox#��[ 52      $��Center=�53         
Foreground �#3B93F7.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#3B93F755      �� 57      -   5        $ field_Password��58      $��10q�59      $	 Пароль��5:      $'
 !Від 6 до 32 символів��5;      $��Gilroy)�5<      $
��Bold"�5=      $��14(�5>      #��[ 5?      $��Center=�5@       �#3B93F7 �#3B93F75B      �� 5D      -   5        $ 
field_Mail��5E      $��10q�5F      $%	 Електронна пошта��5G      $!
 gmail, mail, ukr, тощо.��5H      $��Gilroy)�5I      $
��Bold"�5J      $��14(�5K      #��[ 5L      $��Center=�5M       �#3B93F7 �#3B93F75O      �� 5Q      -   5        $ field_Number��5R      $��10q�5S      $!	 Номер телефона��5T      $Q
 KТільки український номер (починати з +380..)��5U      $��Gilroy)�5V      $
��Bold"�5W      $��14(�5X      #��[ 5Y      $��Center=�5Z       �#3B93F7 �#3B93F75\      �� 5^      $��10 20 10 10q�5_      $?��9Завантажте лицеву сторону прав��5`      $��Gilroy)�5a      $
��Bold"�5b      ���#99A5B65c      � 5e      $��	20 0 20 0q�6   .+�5f      �� -   5         ��Name$ frontDocumentImage��5f       $	��128��6<   $��
20 0 20 15q�6I   � 5g      -   5         �Name$ 
icon_Front��5k      
�������  HoverMouseAnimationGrid#��[ 5h      $	��110��5i      $��	10 0 10 0q�5l      .+�5m        $ 
CameraPlus=�5o      $��Center=�5p      $��Center=�5q      $	��100��5r      $	��100��6)   ���#99A5B65s      5t      5u      �� 5w      $��10 20 10 10q�5x      $=��7Завантажте задню сторону прав��5y      $��Gilroy)�5z      $
��Bold"�5{      ���#99A5B65|      � 5~      $��	20 0 20 0q�6   .+�5      �� -   5        $ backDocumentImage��5       $	��128��6;   $��
20 0 20 20q�6H   � 5�      -	   5        $ 	icon_Back��5�      
�������#��[ 5�      $	��110��5�      $��	10 0 10 0q�5�      .+�5�        $ 
CameraPlus=�5�      $��Center=�5�      $��Center=�5�      $	��100��5�      $	��100��6)   ���#99A5B65�      5�      5�      �� 5�      -
   5         ��Name$ label_Error��5�      $�� ��5�      $
��Wrap=�5�      $��Center=�5�      $
��Bold"�5�      $��Gilroy)�5�      $��14(�5�      $��0 0 0 5q�5�      
�������5�      �� 5�      -   5        $��Center=�5�   !   $��0 0 0 10q�5�   !   $��36��5�   %   $	��220��61    " MaterialDesignRaisedDarkButton#��[ 5�   %   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5�   %   $��0q�5�   %   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5�   )    � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners��5�   %   ���#3B93F7���#3B93F7.��5�      �� $9��3Подати заявку на реєстрацію��5�   )   $��14(�5�   )   $��Gilroy)�5�   )   
�������$
��Bold"�5�   )   5�      5�      5�      5�      5�      5�      