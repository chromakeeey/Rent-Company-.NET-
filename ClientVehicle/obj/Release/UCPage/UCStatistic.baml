   M S B A M L   `   `   `  ���� H  DClientVehicle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ClientVehicle.UCPageClientVehicle.UCPage  &     ClientVehicle.UCPage.UCStatistic   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:ClientVehicle.UCPage     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  
������ .���   � ColumnDefinitions  �� $
��Auto ���  � RowDefinitions �� $
��Auto ��� .+�� $��0��$
��Left=�$��20 0 0 0q�.+��� -   
������ 
������ .����  �� Orientation$ 
Horizontal=�.+��� $)��#Налаштування чеків��$��Gilroy)�$
��Bold"����#99A5B6$��0 0 10 0q�$��Center=�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Receipt=����#99A5B6$��20��$��20��$��Center=�� $��0��$��1��$��10q�.+���    BorderCornerRadius25#��[  
�������� $��20 30 20 30q� �� �� $
��Auto �.+�� $��0��.+��� .+��� $��0 0 0 20q�$��Gilroy)�$'��!Період статистики�����#99A5B6$
��Left=�$��Bottom=� �� TextAlignment$
 Left=�$��18(�$
��Bold"�� $��0 0 0 35q�.+��� -    ��Name$ border_Year��  BorderCornerRadius15#��[ 
�������� $��10 20 10 20q�  �� �� .+��� $��0��$��	0 0 120 0q�.+��� $��Gilroy)�$��Рік��$
��Bold"�$��24(��� -    ��Name$ label_YearDate��$��Gilroy)�$��-�����#99A5B6$
��Left=�$��Bottom=�$
 Left=�$��12(�$
��Bold"��� -   $��1��$��0q�
������ 
������ $��Right=�$	��Top=�$��Center=�$
��Auto��.���� -   $ label_button_Year��$��Gilroy)�$��Перейти�����#99A5B6$
��Left=�$��Bottom=�$
 Left=�$��12(�$
��Bold"�� $��0 0 0 35q�.+��� -   $ border_Month��#��[ 
�������� $��10 20 10 20q�  �� �� .+��� $��0��$��	0 0 120 0q�.+��� $��Gilroy)�$��Місяць��$
��Bold"�$��24(��� -   $ label_MonthDate��$��Gilroy)�$��-�����#99A5B6$
��Left=�$��Bottom=�$
 Left=�$��12(�$
��Bold"��� -   $��1��$��0q�
������ 
������ $��Right=�$	��Top=�$��Center=�$
��Auto��.���� -	   $ label_button_Month��$��Gilroy)�$��Перейти�����#99A5B6$
��Left=�$��Bottom=�$
 Left=�$��12(�$
��Bold"�� $��0 0 0 35q�.+��� -
   $ border_Week��#��[ 
�������� $��10 20 10 20q�  �� �� .+��� $��0��$��	0 0 120 0q�.+��� $��Gilroy)�$��Неділя��$
��Bold"�$��24(��� -   $ label_WeekDate��$��Gilroy)�$��-�����#99A5B6$
��Left=�$��Bottom=�$
 Left=�$��12(�$
��Bold"��� -   $��1��$��0q�
������ 
������ $��Right=�$	��Top=�$��Center=�$
��Auto��.���� -   $ label_button_Week��$��Gilroy)�$��Перейти�����#99A5B6$
��Left=�$��Bottom=�$
 Left=�$��12(�$
��Bold"�� $��0 0 0 35q�.+��� -   $ 
border_Day��#��[ 
�������� $��10 20 10 20q�  �� �� .+��� $��0��$��	0 0 120 0q�.+��� $��Gilroy)�$��День��$
��Bold"�$��24(��� -   $ label_DayDate��$��Gilroy)�$��-�����#99A5B6$
��Left=�$��Bottom=�$
 Left=�$��12(�$
��Bold"��� -   $��1��$��0q�
������ 
������ $��Right=�$	��Top=�$��Center=�$
��Auto��.���� -   $ label_button_Day��$��Gilroy)�$��Перейти�����#99A5B6$
��Left=�$��Bottom=�$
 Left=�$��12(�$
��Bold"�� $��1��.+��� -   $ border_Custom��#��[ 
�������� $��10 20 10 20q�  �� �� .+��� $��0��$��	0 0 120 0q�.+��� -   $ label_CustomDate��$��Gilroy)�$��--/--/--- - --/--/----��$
��Bold"�$��14(��� -   $��0q�
������ 
������ $
��Left=�$	��Top=�$
��Auto��.���� $��Gilroy)�$&�� Вибрати нову дату�����#99A5B6$
��Left=�$��Bottom=�$
 Left=�$��12(�$
��Bold"��� -    ��Name$ label_button_Custom��$��1��$��0q�
������ 
������ $��Right=�$	��Top=�$��Center=�$
��Auto��.���� $��Gilroy)�$��Перейти�����#99A5B6$
��Left=�$��Bottom=�$
 Left=�$��12(�$
��Bold"�� $��1��$��1��$��25 10 10 10q�.+��� #��[  
�������� -    �Name$ GridStatistic��$��20 30 20 30q� �� $
��Auto ��� $
��Auto ��� .+�� $��0��.+��� .+�  $ Money=����#99A5B6$
��Left=�$��0q�$��42��$��64��$��
-12 0 0 20q��   �� ��  �� �� �� .+��� $��0��$��0��.+��� $��Gilroy)�$>��8Всього орендовано автомобілів��$
��Bold"�$��18(����#99A5B6�� -   $ label_Count��$��Gilroy)�$	��112��$
��Bold"�$��36(�
���   ��� $��1��$��0��.+��� $��Gilroy)�$A��;Орендовано без подальшого боргу��$
��Bold"�$��18(����#99A5B6�� -   $ label_CountNoCredit��$��Gilroy)�$	��103��$
��Bold"�$��36(�
���   ��� $��0��$��1��$��0 40 0 0q�.+��� $��Gilroy)�$(��"Прибуток без боргу��$
��Bold"�$��18(����#99A5B6�� -   $ label_ProfitNoCredit��$��Gilroy)�$��
₴ 52 000��$
��Bold"�$��36(����#8DB57A�� $��1��$��1��$��0 40 0 0q�.+��� $��Gilroy)�$5��/При при нарахуванні боргу��$
��Bold"�$��18(����#99A5B6�� -   $ label_ProfitCredit��$��Gilroy)�$��
₴ 12 500��$
��Bold"�$��36(����#8DB57A�� $��0��$��2��$��	0 40 0 80q�.+��� $��Gilroy)�$��Всього��$
��Bold"�$��18(����#99A5B6�� -   $ label_ProfitCount��$��Gilroy)�$��
₴ 64 500��$
��Bold"�$��48(����#8DB57A� $��1��  �� ��  �� �� .+��� $��0��$��0��.+��� $��Gilroy)�$'��!Поповненно грошей��$
��Bold"�$��18(����#99A5B6�� -   $ label_PlusBalance��$��Gilroy)�$��₴ 0��$
��Bold"�$��36(����#8DB57A�� $��1��$��0 0 0 40q�.+��� $��Gilroy)�$#��Виведено грошей��$
��Bold"�$��18(����#99A5B6�� -   $ label_MinusBalance��$��Gilroy)�$��₴ 0��$
��Bold"�$��36(����#DF9090�� $��0��$��1��.+��� $��Gilroy)�$4��.На рахунках користувачів��$
��Bold"�$��18(����#99A5B6�� -   $ label_Balance��$��Gilroy)�$��
₴ 93 000��$
��Bold"�$��36(����#8DB57A�� -   $ label_DateBalance��$��Gilroy)�$��на 13.05.2020 19:11:03��$
��Bold"�$��14(����#99A5B6$��0 -5 0 0q�� $��2��.+�� $��Bottom=�$
��Left=�.+��� -    $��0 20 0 0q�$��36��$	��256�� " MaterialDesignRaisedDarkButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist	   CornerRadius$	 15��$��0q�$��Right=�+  %MaterialDesignThemes.Wpf.ShadowAssist
   ShadowDepth$
 Depth3=� � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners�����#3B93F7���#3B93F7.���� $<��6Експортувати статистику в Excel��$��14(�$��Gilroy)�
�������$
��Bold"�