   M S B A M L   `   `   `  ����C  ?GoodFood, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GoodFood.ViewGoodFood.View  5   	   \ XSystem.Drawing.Common, Version=5.0.0.2, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51N;clr-namespace:System.Drawing;assembly=System.Drawing.CommonSystem.Drawing 63       GoodFood.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Z VDevExpress.Mvvm.UI, Version=20.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:GoodFood.View     5   	   Vmaterialdesign;clr-namespace:System.Drawing;assembly=System.Drawing.Common     63   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6�     � Title$  GoodFood��5   	   $	��768��6   $
��1024��6'    � 
ResizeMode$ NoResize=�64    � 	Resources 5	       �� 
TargetType   
menuButton # MaterialDesignFlatLightBgButton �� BasedOn �� Property �� Value+  %MaterialDesignThemes.Wpf.ButtonAssist  MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame	 O� KeyTime
 O� Value  	MenuClose��%{  &	        7  &	 �     &	 �    �� 5
   
   " ��6   8   .�5      ��  � ��$ 
15,15,15,0q�6'   �� 5       � ��$ 60��6'   �� 5       � ��$	 140��6&   �� 5       �@ CornerRadius$ 10��6I   5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $	 0��6'   $
 80Q�63     5      $	 0:0:0.3��6'   $	
 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $	 0��6'   $	
 200Q�63     5      $	 0:0:0.3��6'   $
 80Q�69   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5      �� #��[ 6   5       :� 5!   
   $ ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5"      �� #��[ 6   5#      .��5%      � .+�5&   
   �� $��80 0 0 0q�6@   $��Right=�6R   $	��944��6n   ��6   �� *SelectedViewModel+6n   � 5'   
   -   5         �Name$ GridMenu��5'      $��80��6!   $
��Left=�6,   ���#f98365 K� ZIndex$	 100��6\   .+�5(      �� -   5         ��Name$ MenuControlPanel��5(      .+�5)      � $��60��6   ���#f98365$
��Left=�68   $��10 0 0 0q�6S   .+�5*      �� -   5         ��Name$ ButtonCloseMenu��5*      $��60��6�   $��60��6�   $	��Top=�6�   $��Right=�6   � Cursor$
 Hand��6+  ��66   �� *buttonCloseMenu+y�6Z   �� *ButtonCloseMenuVisibility+ �� Mode$ TwoWay=� �� TargetNullValue$ 	Collapsed����6�   Z� ��6�   Z� .��5+      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�62   
�������$��35��6V   $��35��6a   6o   5,      �� 5-      -   5        $ ButtonOpenMenu��5-      $��60��6�   $��60��6�   $	��Top=�6�   $��Right=�6
  ��65   �� *buttonOpenMenu+y�6X   �� *ButtonOpenMenuVisibility+$ TwoWay=�$ Visible����6�   Z� ��6�   Z� .��5.        $
 Menu=�62   
�������$��35��6Q   $��35��6\   6j   5/      50      �� 51      -   5        $ MenuButtons��51      $	��8 0q�62   $��Disabled=�6?    �� Orientation$ Vertical=�6u   .+�52      �� -   5        $ 
HomeButton��52      $��AllRestaurants��6c   $
��Left=�6�   $��60��6�   $
 Hand��6�   ��61   �� *updateViewModel+$ OneTime=���6�   Z� ��6�   Z� .��53      �� $ 
Horizontal=�6%   .+�54        $
 Home=�66   $��35��6B   $��35��6M   $��Center=�6Y   $��0 0 0 0q�6t   6�   �� 55      $��Главная��6(   $��Center=�67   $��10 10q�6R   $��20(�6a   6q   56      57      �� 58      -   5        $ CreateAdButton��58   )   $��60��6   $
��Left=�6c   $��AddRestaurant��6�   $
 Hand��6�   y�6A   �� *
Visibility+��6~   �� *updateViewModel+$ OneTime=���6�   Z� ��6�   Z� .��59      �� $ 
Horizontal=�6%   .+�5:        $	 Add=�66   $��35��6A   $��35��6L   $��Center=�6X   $��0 0 0 0q�6s   6�   �� 5;      $��Добавить��6(   $��Center=�68   $��10 10q�6S   $��20(�6b   6r   5<      5=      �� 5>      $��60��6   $
��Left=�6�   $��UserBookings��6�   $
 Hand��6�   y�6)   �� *VisibilityUser+��6O   �� *updateViewModel+$ OneTime=���6�   Z� ��6�   Z� .��5?      �� $ 
Horizontal=�6%   .+�5@        $ ClipboardList=�66   $��35��6K   $��35��6V   $��Center=�6b   $��0 0 0 0q�6}   6�   �� 5A      $��Заказы��6(   $��Center=�66   $��10 10 15 10q�6Q   $��20(�6f   6v   5B      5C      �� 5D      $��60��6   $
��Left=�6}   $��AdminStatistics��6�   $
 Hand��6�   y�6)   �� *
Visibility+��6K   �� *updateViewModel+$ OneTime=���6�   Z� ��6�   Z� .��5E      �� $ 
Horizontal=�6%   .+�5F        $ GoogleAnalytics=�66   $��35��6M   $��35��6X   $��Center=�6d   $��0 0 0 0q�6   6�   �� 5G      $��Статистика��6(   $��Center=�6:   $��10 10 15 10q�6U   $��20(�6j   6z   5H      5I      5J      5K      5L      5N      5O      