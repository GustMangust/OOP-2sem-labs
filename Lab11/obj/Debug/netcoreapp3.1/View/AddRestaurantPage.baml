   M S B A M L   `   `   `  ����C  ?GoodFood, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GoodFood.ViewGoodFood.View  5      %    GoodFood.View.AddRestaurantPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Z VDevExpress.Mvvm.UI, Version=20.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:GoodFood.View     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5   
   $��Regular"�5	   
   $��13(�5
   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignFont#���  5   
    � 	Resources 5        textBox �� 
TargetType  MaterialDesignTextBox �� BasedOn/  )MaterialDesignThemes.Wpf.ValidationAssist �� Property �� Value*  $MaterialDesignThemes.Wpf.ThemeAssist.  (MaterialDesignThemes.Wpf.TextFieldAssist)  #MaterialDesignThemes.Wpf.HintAssist��%$  &	       7  �� 5   
   " ��6    8   .�5      ��  �@ OnlyShowOnFocus$
 True��6P   �� 5       �@ FontSize$ 18Q�6I   �� 5       �@ 
Background
 ���� 6K   �� 5       � ��$	 400��6&   �� 5       � ��$ 30��6'   �� 5       � ��$ 20(�6)   �� 5       � ��$ 0,0,0,0q�6(   �� 5       �@ Theme$ Light=�6A   �� 5       � ��$ 0,40,0,0q�6'   �� 5       �@ UnderlineBrush �#c331246O   �� 5       �@ 
FontFamily$ Roboto)�6F   5      5      .��5      � 
������� � ColumnDefinitions 5!   
   �� 5"      �� 5#      $��0.44* �6   .+�5%   
   �� $��
60,160,0,0q�6   .+�5&      �� $��0,0,0,0q�6l   #��[ 6}      Hint$ Название��6�   	 � Cursor$	 IBeam��6�   ��6   �� *Name+
 �� ValidatesOnDataErrors$

 True�� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5'      $ Вид кухни��6   #��[ 6A   $	 IBeam��6�   ��6c   �� *Type_of_cuisine+$

 True��$ PropertyChanged=�6�   �� 5(      #��[ 6y   $+ %Количество столиков��6�   $	 IBeam��6�   ��6   �� *Number_of_tables+$

 True��$ PropertyChanged=�6�   �� 5)       �� Orientation$ 
Horizontal=�6   $��0,30,0,0q�63   $��Center=�6E   .+�5*      ��   MaterialDesignLabel#��[ 6   $��Center=�6E   $��20(�6`   $��Время работы:��6n   $��Roboto)�6�   ���#3B0F0B$��Center=�6�   $��	0,0,155,0q�6�   �� 5+      #���  6v   $��20(�6�   $��Center=�6�   $��15,0,5,0q�6�   $��30��6  $ 00��6  $	 IBeam��6@  ��6   �� *
Start_time+$

 True��$ PropertyChanged=� � ToolTip 6�   �� *ErrorCollection[Start_time]+.��6O   =� ErrorTemplate 5,      �� 5-      .��5.   0    5/      (  "MaterialDesignThemes.Wpf.SmartHint��%V   '        �� 50      "  6    .�51      ��  � ��$ Center=�6D   52      53      .��6)   54      �� 55      $��40(�6   $��-��6&   �� 56      #���  6t   $��20(�6�   $��Center=�6�   $��5,0,0,0q�6�   $��30��6  $ 23��6  $	 IBeam��6;  ��6   �� *
End_time+$

 True��$ PropertyChanged=� 6�   �� *ErrorCollection[End_time]+.��6J   57      �� 58      .��59   0    5:      ��%V   '        �� 5;      "  6    .�5<      ��  � ��$ Center=�6D   5=      5>      .��6)   5?      5@      �� 5A      $��Center=�6   $ 
Horizontal=�66   $��0,50,0,0q�6O   $
	 Hand��6a   .+�5B      �� $��70��66   $��50��6A   $��	0,0,100,0q�6M    # MaterialDesignRaisedLightButton#��[ 6`   ���#f98365$
	 Hand��6�   ��6   �� *
addImage+.��5C      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ImageAdd=�6.   $��30��6>   $��30��6I   ���#3B0F0B6U   5D      �� 5E      $��70��6;   $��50��6F   #��[ 6R   ���#e8a628$
	 Hand��6�   ��6   �� *addRestaurant+.��5F        ���#3B0F0B$	 Add=�6C   $��30��6N   $��30��6Y   6g   5G      5H      5I      �� 5J   
   $
��Fill=�6   $
��Left=�6o   $��	0,165,0,0q�6�   $	��Top=�6�   $��1��6�   $	��200��6�   $	��170��6�   ��6   �� *ImageSource+$ PropertyChanged=� �� Mode$ TwoWay=�6�   5K      5L      