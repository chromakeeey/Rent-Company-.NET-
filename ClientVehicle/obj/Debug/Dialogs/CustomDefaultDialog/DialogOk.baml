   M S B A M L   `   `   `  ����H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:ClientVehicle.Dialogs.CustomDefaultDialog)ClientVehicle.Dialogs.CustomDefaultDialog  5   	   8    2ClientVehicle.Dialogs.CustomDefaultDialog.DialogOk   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Ilocal7clr-namespace:ClientVehicle.Dialogs.CustomDefaultDialog     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   
������ $��Gilroy)�5   	    � Title$ DialogOk��5   	   $��332.927��6   $��747.561��6+    � WindowStyle$
 None=�6;    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � Icon$ 
notify.ico��6.   .��5      � $��5q�6   .+�5   
   ��   BorderCornerRadius25#��[ 6   
�������6?   � 5   
   $��15q�6   .+�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      �� 5      $
��Auto �6$   .+�5       � $��0��6   .+�5!      �� -   5         ��Name$ Caption��5!       $��Caption��61   $��Center=�6@   $��Center=�6]   $
��Bold"�6x   5"      � 5$      $��1��6   .+�5%      � $��Center=�6   	 � ColumnDefinitions	 5&      �� 5'      $
��Auto �6/   �� 5(      .+�5+      � $��0��6   .+�5,      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        
  Name$

 Icon��5,   6   $��20,0,0,0q�6D      Kind$ WarningCircleOutline=�6V   $	��128��6r   $	��128��6   5-      � 5/      $��1��6   .+�50      �� -   5        $ Message��50   (   $
��Wrap=�69    �� TextAlignment$ Center=�6M   $��Message��51   (   $��16(�67   $��Center=�52   (   $��Center=�6E   $
��Bold"�6`   53      54      55      � 57      $��2��6   .+�58      � $��Center=�6   $��Center=�68   .+�59      �� -   5         # MaterialDesignRaisedLightButton#��[ 59   !   $��0,0,0,10q�6Z   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��5:      $��0q�5;      $
��Auto��6)    � ToolTip$8 2MaterialDesignRaisedLightButton with Round Corners��5<      ���#76C466���#76C466.��5?      �� $��	15 5 15 5q�5@   !   $��Center=�5A   !   $
 Left=�5B   !   
�������$��Gilroy)�5D   !   $
��Bold"�5E   !   $��12(�63   $��Окей��5F   !   5G      5H      5I      5K      5M      5O      5P      