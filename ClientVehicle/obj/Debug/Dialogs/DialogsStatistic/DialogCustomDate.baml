   M S B A M L   `   `   `  ����H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:ClientVehicle.Dialogs.DialogsStatistic&ClientVehicle.Dialogs.DialogsStatistic  5   	   =    7ClientVehicle.Dialogs.DialogsStatistic.DialogCustomDate   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:ClientVehicle.Dialogs.DialogsStatistic     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Вибір дати��5	   	   $	��450��6   $	��800��6)   
������  � WindowStyle$
 None=�5
   "    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � Icon$ 
notify.ico��6.   .��5      � $��5q�6   .+�5   
   ��    BorderCornerRadius25#��[  6   
�������6?   � 5   
   $��20q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      .+�5      � $��0��6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��0��5      $��0 0 5 0q�5         Kind$ 
CloseThick=�5      $��Right=�5        HoverMouseAnimation#��[ 5      6F   5      � 5      $��1��6    � ColumnDefinitions 5      �� 5       �� 5!      $
��Auto �6'   �� 5"      .+�5%      &   System.Windows.Controls.Calendar  -   5          Name$ calendar_Start��5&      $��Gilroy)�5'      $��0��5(      $��Center=�5)      $��Center=�5*      	 � 	Resources	 5+        PrimaryHueMidBrush
 �� Color  MaterialDesignBody��%S   &	       &	 !     �� 5,      $
 #6490F1��6E   �� 5-      $

 Gray��6E   5.      5/      � 51      $��1��6   .+�52      �� $��Center=�6!   $��Center=�6>   .+�53      �� -   5         # MaterialDesignRaisedLightButton#��[ 54      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��55       � ToolTip$8 2MaterialDesignRaisedLightButton with Round Corners��56      ���#6490F1���#6490F1.��59      �� $��Center=�5:       �� TextAlignment$ Center=�5;      
�������$��Gilroy)�5=      $
��Bold"�5>      $��12(�5?      $��Вибрати��6+   5@      5A      5B        5D      -   5        $ calender_Final��5E      $��Gilroy)�5F      $��2��5G      $��Center=�5H      $��Center=�5I      	 5J      ��%S   &	       &	 !     �� 5K      $
 #6490F1��6E   �� 5L      $

 Gray��6E   5M      5N      5O      5Q      5S      5T      