   M S B A M L   `   `   `  ����H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ClientVehicleClientVehicle  5   	   ;"clr-namespace:ClientVehicle.UCPageClientVehicle.UCPage  5	   	       ClientVehicle.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ClientVehicle     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   /UCPage"clr-namespace:ClientVehicle.UCPage  5	   	   -   5           MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   $��Gilroy)�5   	    � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5   	   ���#E5E5E5 � Title$ 
MainWindow��5   	   $	��900��6   $
��1440��6)    � Icon$ icon.png��6N   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 0Q�6   .��5      � .+�5   
   �  � ColumnDefinitions 5      �� 5       $��88 �6#   �� 5!      .+�5$      � $��0��6   .+�5%      �� 
������ $��1q�5'      
�������	 J� Effect	 5)      3  -System.Windows.Media.Effects.DropShadowEffect  5*      
   
BlurRadius$
 10Q�5+         ShadowDepth$ 1Q�5,         Opacity$	 0.1Q�5-      5/      � 52       � RowDefinitions 53      �� 54      $
��Auto �6(   �� 55      �� 56      $
��Auto �6(   .+�59      �� $��
0 20 0 100q�5:      $��0��5;      $��Center=�5<      $��Center=�5=      .+�5>      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
KeyVariant=�62   $��Center=�5?   .   $��30��5@   .   $��0 0 0 10q�5A   .   $��30��5B      5I      � 5K      $��1��6   .+�5L      � $��0 0 0 0q�5M      $	��Top=�5N      $��Center=�61   .+�5O      �� .+�5Q   "   � -   5        $��0,0,0,20q�5R   !   
�������  HoverMouseAnimationGrid#��[ 5T   !   .+�5U   &     -   5          Name$ iconMain��5V   %   $��10q�5W   %   $
 Home=�5X   %   $��25��5Y   %   $��25��61   ���#99A5B65Z   %   5[   #   � 5]   "   -   5        $��0,0,0,20q�5^   !   
�������#��[ 5`   !   .+�5a   &     -   5        $ iconVehicle��5b   %   $��10q�5c   %   $ CarMultiple=�5d   %   $��25��5e   %   $��25��61   ���#99A5B65f   %   5g   #   � 5i   "   -   5         �Name$ button_AVehicle��5j   %   $��0,0,0,20q�5k   !   
�������#��[ 5m   !   .+�5n   &     -   5        $ iconAVehicle��5o   %   $��10q�5p   %   $ CarCog=�5q   %   $��25��5r   %   $��25��61   ���#99A5B65s   %   5t   #   � 5v   "   -   5        $ button_AUser��5w   %   $��0,0,0,20q�5x   !   
�������#��[ 5z   !   .+�5{   &     -	   5        $ 	iconAUser��5|   %   $��10q�5}   %   $ 	UserGroup=�5~   %   $��25��5   %   $��25��61   ���#99A5B65�   %   5�   #   � 5�   "   -
   5        $ button_Statistic��5�   %   $��0,0,0,20q�5�   !   
�������#��[ 5�   !   .+�5�   &     -   5        $ iconStatistic��5�   %   $��10q�5�   %   $ ChartTimelineVariant=�5�   %   $��25��5�   %   $��25��61   ���#99A5B65�   %   5�   #   5�      5�      5�      � 5�      -   5        $��1��5�      $��Bottom=�6(   $��Center=�6C   .+�5�      �� .+�5�      � $��0,0,0,20q�5�   !   
�������#��[ 5�   !   .+�5�   "     $��10q�5�   %   $ 
Fullscreen=�5�   %   $��25��5�   %   $��25��61   ���#99A5B65�   %   5�      � 5�      -   5        $��0,0,0,20q�5�   !   
�������#��[ 5�   !   .+�5�   "     $��10q�5�   %   $ 	ExitToApp=�5�   %   $��25��5�   %   $��25��61   ���#99A5B65�   %   5�      5�      5�      5�      5�      � 5�      $��1��6    5�      �� 5�      $
��Auto �6$   �� 5�      .+�5�      � $��
20 10 10 0q�6   $��0��6+   .+�5�        -   5        $ 
CloseThick=�5�      $��Right=�5�        HoverMouseAnimation#��[ 5�      6F   5�      � 5�      -   5        $ pageGrid��5�   0   $��20q�6   $��1��6#   5�      5�      5�      � 5�   
   -   5        $ GridBackgroundDialog��5�   0   
���   � J� Opacity$	 0.5Q�6"   $y�Hidden=�6N   5�      5�      5�      