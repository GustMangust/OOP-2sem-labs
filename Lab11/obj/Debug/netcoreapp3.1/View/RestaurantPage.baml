   M S B A M L   `   `   `  ����C  ?GoodFood, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GoodFood.ViewGoodFood.View  5      "    GoodFood.View.RestaurantPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Z VDevExpress.Mvvm.UI, Version=20.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:GoodFood.View     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5   
   $��Regular"�5	   
   $��13(�5
   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignFont#���  5   
    � Cursor$
 Hand��5   8    � 	Resources 5        textBox �� 
TargetType  MaterialDesignTextBox �� BasedOn/  )MaterialDesignThemes.Wpf.ValidationAssist �� Property �� Value*  $MaterialDesignThemes.Wpf.ThemeAssist��%�  &	       7  �� 5   
   " ��6    8   .�5      ��  �@ OnlyShowOnFocus$
 True��6P   �� 5       �@ FontSize$ 18Q�6I   �� 5       �@ 
Background
 ���� 6K   �� 5       � ��$ 30��6'   �� 5       � ��$ 20(�6)   �� 5       � ��$ 0,0,0,0q�6(   �� 5       �@ Theme$ Light=�6A   �� 5       � ��$ 0,60,0,0q�6'   5      5      .��5      � 
������� � RowDefinitions 5   
   �� 5      �� 5      .+�5!   
   �� 	 �� Orientation$	 
Horizontal=�6   $
��Left=�6.   $��	60 70 0 0q�6I   .+�5"      �� $
��Fill=�6-   $	��350��6<   $	��250��6H   ��6   �� *Image+6H   �� 5#      $��70 0 0 0q�6   $��Center=�6+   .+�5$      �� $	 
Horizontal=�6   .+�5%      �� $��20(�6   $��Roboto)�6*   $��Center=�6>   ���#6B1B14$��Ресторан:��6n     MaterialDesignLabel#��[ 6�   �� 5&      $��25(�6   $��Roboto)�6*   $��Center=�6>   ���#3B0F0B$��Italic$�6n   $��10 0 0 0q�6�   #��[ 6�   ��6�   �� *Name+6�   5'      �� 5(      $	 
Horizontal=�6   $��	0 10 0 10q�66   .+�5)      �� $��20(�6   $��Roboto)�6*   $��Center=�6>   ���#6B1B14$��Вид кухни:��6o   #��[ 6�   �� 5*      $��25(�6   $��Roboto)�6*   $��Center=�6>   ���#3B0F0B$��10 0 0 0q�6n   $��Italic$�6�   #��[ 6�   ��6�   �� *Type_of_cuisine+6�   5+      �� 5,      $	 
Horizontal=�6   .+�5-      �� $��20(�6   $��Roboto)�6*   $��Center=�6>   ���#6B1B14$��Время работы:��6n   #��[ 6�   �� 5.      $��25(�6   $��Roboto)�6*   $��Center=�6>   ���#3B0F0B$��10 0 5 0q�6n   $��Italic$�6�   #��[ 6�   ��6�   �� *
Start_time+6�   �� 5/      $��25(�6   $
��Bold"�6*   $��Center=�6<   $��-��6W   #��[ 6c   �� 50      $��25(�6   $��Roboto)�6*   $��Center=�6?   ���#3B0F0B$��5 0 0 0q�6o   $��Italic$�6�   #��[ 6�   ��6�   �� *
End_time+6�   51      52      53      �� 54   
   $��1��6   $��60 0 0 0q�6"   $	 
Horizontal=�64   .+�55      �� $
��Left=�6   $��	25 60 0 0q�64   .+�56      �� $��24(�6   $-��'Забронировать столик��6&   $��Center=�6F   $��Roboto)�6c   ���#3B0F0B#��[ 6�   �� 57      $	 
Horizontal=�6   $��Center=�66   $��0 20 0 0q�6S   .+�58      ��  & "MaterialDesignFloatingHintComboBox#��[ 6    ���#3B0F0B.  (MaterialDesignThemes.Wpf.TextFieldAssist
   UnderlineBrush
 �#c33124$��50��6�   $��40��6�   $��Center=�6�   )  #MaterialDesignThemes.Wpf.HintAssist   
HelperText$ 
Время��6     HelperTextFontSize$ 13Q�61  $ �� IsSynchronizedWithCurrentItem$
 TrueY�6d  ��6�   �� *List_of_time+ �� SelectedItem 6�  �� *Selected_time+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 59      $��	30 0 30 0q�6   #��[ 62   ���#3B0F0B
 �#c33124$��Center=�6�   $ 
Месяц��6�   $ 13Q�6-  $��80��6_  $��40��6j  $
 TrueY�6v  ��6�   �� *List_of_months+ 6�  �� *Selected_month+$ PropertyChanged=�$ TwoWay=��� 5:      #��[ 6   ���#3B0F0B
 �#c33124$��0 0 30 0q�6�   $
��Auto=�6�   $��Center=�6�   $ День��6  $ 13Q�64  $��50��6�  $��40��6�  $
 TrueY�6�  ��6f  �� *List_of_days+ 6�  �� *Selected_day+$ PropertyChanged=�$ TwoWay=��� 5;      #��[ 6   ���#3B0F0B
 �#c33124$
��Auto=�6�   $��Center=�6�   $ Cтолик��6�   $ 13Q�6K  $��50��6  $��40��6�  $
 TrueY�6�  ��6$  �� *List_of_tables+ 6�  �� *Selected_table+$ PropertyChanged=�$ TwoWay=�5<      �� 5=       # MaterialDesignRaisedLightButton#��[ 6   ���#f98365$��0 40 0 0q�6�   $��30��6�   $��60��6�   $
 Hand��6�   ��6h   �� *restaurantBooking+.��5>      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Check=�6.   ���#3B0F0B6R   5?      5@      �� 5C      $��	80 60 0 0q�6   $	 
Horizontal=�6,   .+�5D      �� .+�5E      �� $��24(�6   $&�� Оцените зведение!��6*   $��Roboto)�6F   ���#3B0F0B#��[ 6p   �� 5F      
 �#c33124���#3B0F0B#��[ 6l   $	��Top=�6�   $ 13Q�6�   $��
20 30 20 0q�6�   $��50��6-  $��40��68  $ Оценка��6E  $
 TrueY�6�  ��6  �� *List_of_rates+ �� SelectedIndex 6s  �� *Selected_index+ 6�  �� *Selected_rate+$ TwoWay=�$ PropertyChanged=��� 5G      #��[ 6   $	��Top=�6V   ���#e8a628$��0 30 0 0q�6�   $��30��6�   $��60��6�   $
 Hand��6�   ��6�   �� *restaurantRating+.��5H        $ Check=�62   ���#3B0F0B6V   5I      �� 5J      #��[ 6   $	��Top=�6V   ���#e8a628$��0 30 0 0q�6�   $��30��6�   $��60��6�   $
 Hand��6�   ��6�   �� *deleteRating+.��5K        $ Trash=�62   ���#3B0F0B6V   5L      5M      5N      5O      5P      5Q      