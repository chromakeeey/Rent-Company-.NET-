   M S B A M L   `   `   `  ����H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:ClientVehicle.Dialogs.CustomDefaultDialog)ClientVehicle.Dialogs.CustomDefaultDialog  5   	   @    :ClientVehicle.Dialogs.CustomDefaultDialog.DialogOkNoCancel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Ilocal7clr-namespace:ClientVehicle.Dialogs.CustomDefaultDialog     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Icon$  
notify.ico��5   	      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   
������ $��Gilroy)�5   	    � Title$ DialogOk��5   	   $��332.927��6   $��747.561��6+    � WindowStyle$
 None=�6;    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��2��6   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6+   $��5q�6\   $��10q�6h   .��5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      �� 5      $
��Auto �6$   .+�5      � $��0��6   .+�5      �� -   5        	 ��Name$	 Caption��5       $��Caption��61   $��Center=�6@   $��Center=�6]   $
��Bold"�6x   5      � 5!      $��1��6   .+�5"      � $��Center=�6   
 � ColumnDefinitions
 5#      �� 5$      $
��Auto �6/   �� 5%      .+�5(      � $��0��6   .+�5)      '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$
 Icon��5)   6   $��20,0,0,0q�6D      Kind$ WarningCircleOutline=�6V   $	��128��6r   $	��128��6   5*      � 5,      $��1��6   .+�5-      �� -   5        $	 Message��5-   (   $
��Wrap=�69    �� TextAlignment$ Center=�6M   $��Message��5.   (   $��16(�67   $��Center=�5/   (   $��Center=�6E   $
��Bold"�6`   50      51      52      � 54      $��2��6   .+�55      � $��Center=�6   $��Center=�68   .+�56      ��  �� Orientation$ 
Horizontal=�6%   .+�57      �� -   5         # MaterialDesignRaisedLightButton#��[ 57   %   $��0,0,0,10q�6^   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��58       � ToolTip$8 2MaterialDesignRaisedLightButton with Round Corners��59      ���#76C466���#76C466.��5<   "   �� $��Center=�6,   $
 Left=�6G   
�������$��Gilroy)�6o   $
��Bold"�6�   $��12(�6�   $
��Ок��6�   5=      �� 5>      -   5        #��[ 5>   %   $��	10,0,0,10q�6^   $ 5��5?      $8 2MaterialDesignRaisedLightButton with Round Corners��5@      ���#E25544���#E25544.��5C   "   �� $��Center=�6,   $
 Left=�6G   
�������$��Gilroy)�6o   $
��Bold"�6�   $��12(�6�   $��No��6�   5D      �� 5E      -   5        #��[ 5E   %   $��	10,0,0,10q�6^   $ 5��5F      $8 2MaterialDesignRaisedLightButton with Round Corners��5G      ���#6490F1���#6490F1.��5J   "   �� $��Center=�6,   $
 Left=�6G   
�������$��Gilroy)�6o   $
��Bold"�6�   $��12(�6�   $��Cancel��6�   5K      5L      5M      5N      5P      5R      5S      5T      