   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ClientVehicleClientVehicle  ;"clr-namespace:ClientVehicle.UCPageClientVehicle.UCPage      ClientVehicle.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:ClientVehicle     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  /UCPage"clr-namespace:ClientVehicle.UCPage  -      MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�$��Gilroy)� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=����#E5E5E5 � Title$ 
MainWindow��$	��900��$
��1440�� � Icon$ icon.png��'  !System.Windows.Shell.WindowChrome   WindowChrome      CaptionHeight$ 0Q�.��� .+��  � ColumnDefinitions �� $��88 ��� .+�� $��0��.+��� 
������ $��1q�
�������	 J� Effect	 3  -System.Windows.Media.Effects.DropShadowEffect  
   
BlurRadius$
 10Q�   ShadowDepth$ 1Q�   Opacity$	 0.1Q��  � RowDefinitions �� $
��Auto ��� �� $
��Auto �.+��� $��
0 20 0 100q�$��0��$��Center=�$��Center=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
KeyVariant=�$��Center=�$��30��$��0 0 0 10q�$��30��� $��1��.+�� $��0 0 0 0q�$	��Top=�$��Center=�.+��� .+�� -   $��0,0,0,20q�
�������  HoverMouseAnimationGrid#��[ .+�  -     Name$ iconMain��$��10q�$
 Home=�$��25��$��25�����#99A5B6� -   $��0,0,0,20q�
�������#��[ .+�  -   $ iconVehicle��$��10q�$ CarMultiple=�$��25��$��25�����#99A5B6� -    �Name$ button_AVehicle��$��0,0,0,20q�
�������#��[ .+�  -   $ iconAVehicle��$��10q�$ CarCog=�$��25��$��25�����#99A5B6� -   $ button_AUser��$��0,0,0,20q�
�������#��[ .+�  -	   $ 	iconAUser��$��10q�$ 	UserGroup=�$��25��$��25�����#99A5B6� -
   $ button_Statistic��$��0,0,0,20q�
�������#��[ .+�  -   $ iconStatistic��$��10q�$ ChartTimelineVariant=�$��25��$��25�����#99A5B6� -   $��1��$��Bottom=�$��Center=�.+��� .+�� $��0,0,0,20q�
�������#��[ .+�  $��10q�$ 
Fullscreen=�$��25��$��25�����#99A5B6� -   $��0,0,0,20q�
�������#��[ .+�  $��10q�$ 	ExitToApp=�$��25��$��25�����#99A5B6� $��1�� �� $
��Auto ��� .+�� $��
20 10 10 0q�$��0��.+�  -   $ 
CloseThick=�$��Right=�  HoverMouseAnimation#��[ � -   $ pageGrid��$��20q�$��1��� -   $ GridBackgroundDialog��
���   � J� Opacity$	 0.5Q�$y�Hidden=�