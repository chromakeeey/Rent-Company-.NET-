   M S B A M L   `   `   `  ����H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ClientVehicle.UCHelpClientVehicle.UCHelp  5      %    ClientVehicle.UCHelp.UCAUserRow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:ClientVehicle.UCHelp     5      V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � .+�5   
   �� $��5q�5      
������ $��1q�5      
�������  �� CornerRadius$  25��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�5         ShadowDepth$ 5Q�5         Opacity$	 0.3Q�5      5      � 5   
   $��20 15 20 15q�6    � ColumnDefinitions 5      �� 5      $��64 �6#   �� 5      �� 5      �� 5      �� 5      �� 5       .+�5#      �� -   5         ��Name$ label_ID��5$      $��Center=�5%      $��0��5&      $	��256��5'      $��Gilroy)�5(      $
��Bold"�5)      $��15(�5*      ���#99A5B65+      �� 5-      -   5        $ 
label_Name��5.      $��Center=�5/      $��1��50      $
��Wrap=�51      $H��BПаламарчук Олександр Володимирович��52      $��Gilroy)�53      $
��Bold"�54      $��15(�55      ���#99A5B656      �� 58      -   5        $ label_Balance��59      $��Center=�5:      $��2��5;      $��
₴ 35 000��5<      $��Gilroy)�5=      $
��Bold"�5>      $��15(�5?      ���#99A5B65@      �� 5B      -   5        $ label_Credit��5C      $��Center=�5D      $��3��5E      $��	₴ 5 000��5F      $��Gilroy)�5G      $
��Bold"�5H      $��15(�5I      ���#99A5B65J      �� 5L      -   5        $ label_Create��5M      $��Center=�5N      $��4��5O      $��25.06.2020 12:24:2020��5P      $��Gilroy)�5Q      $
��Bold"�5R      $��15(�5S      ���#99A5B65T      �� 5V      -   5        $��5��5V      $��32��6%   $��32��60   $��0q�6<   
������ 
������ $
��Left=�6{    � ContextMenu 5W      �� 5X      .@�5\      m� -   5        ��5]      �� 5^   "    �� Orientation$ 
Horizontal=�6-   .+�5_   &   '  !MaterialDesignThemes.Wpf.PackIcon  $��0 0 10 0q�6>   $��Center=�5`   1   	   Kind$		 Cog=�5a   1   $��20��5b   1   $��20��6=   ���#99A5B65d   1   �� 5f   &   $��Center=�5g   1   $��Редагувати��5h   1   ���#99A5B6$��Gilroy)�5j   1   $��12(�5k   1   $
��Bold"�5l   1   5m   #   5o      m� 5r      ��5s      �� 5t   "   $ 
Horizontal=�6-   .+�5u   &     $��0 0 10 0q�6>   $��Center=�5v   1   $	 DeleteForever=�5w   1   $��20��5x   1   $��20��6=   ���#DF90905y   1   �� 5{   &   $��Center=�5|   1   $��Видалити��5}   1   $��12(�5~   1   ���#DF9090$��Gilroy)�5�   1   $
��Bold"�5�   1   5�   #   5�      5�      .��5�        $	 	MoreHoriz=�6*   $��5��5�   &   ���#99A5B6$��Center=�5�   &   $��32��5�   &   $��32��62   5�      5�      5�      5�      