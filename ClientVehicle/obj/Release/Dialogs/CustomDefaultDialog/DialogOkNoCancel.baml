   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:ClientVehicle.Dialogs.CustomDefaultDialog)ClientVehicle.Dialogs.CustomDefaultDialog  @    :ClientVehicle.Dialogs.CustomDefaultDialog.DialogOkNoCancel   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Ilocal7clr-namespace:ClientVehicle.Dialogs.CustomDefaultDialog     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Icon$  
notify.ico��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�
������ $��Gilroy)� � Title$ DialogOk��$��332.927��$��747.561�� � WindowStyle$
 None=� � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�.��� .+�#  MaterialDesignThemes.Wpf.Card  $��2��+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�$��5q�$��10q�.���  � RowDefinitions �� $
��Auto ��� �� $
��Auto �.+�� $��0��.+��� -   	 ��Name$	 Caption��$��Caption��$��Center=�$��Center=�$
��Bold"�� $��1��.+�� $��Center=�
 � ColumnDefinitions
 �� $
��Auto ��� .+�� $��0��.+�'  !MaterialDesignThemes.Wpf.PackIcon  -     Name$
 Icon��$��20,0,0,0q�   Kind$ WarningCircleOutline=�$	��128��$	��128��� $��1��.+��� -   $	 Message��$
��Wrap=� �� TextAlignment$ Center=�$��Message��$��16(�$��Center=�$��Center=�$
��Bold"�� $��2��.+�� $��Center=�$��Center=�.+���  �� Orientation$ 
Horizontal=�.+��� -    # MaterialDesignRaisedLightButton#��[ $��0,0,0,10q�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5�� � ToolTip$8 2MaterialDesignRaisedLightButton with Round Corners�����#76C466���#76C466.���� $��Center=�$
 Left=�
�������$��Gilroy)�$
��Bold"�$��12(�$
��Ок���� -   #��[ $��	10,0,0,10q�$ 5��$8 2MaterialDesignRaisedLightButton with Round Corners�����#E25544���#E25544.���� $��Center=�$
 Left=�
�������$��Gilroy)�$
��Bold"�$��12(�$��No���� -   #��[ $��	10,0,0,10q�$ 5��$8 2MaterialDesignRaisedLightButton with Round Corners�����#6490F1���#6490F1.���� $��Center=�$
 Left=�
�������$��Gilroy)�$
��Bold"�$��12(�$��Cancel��