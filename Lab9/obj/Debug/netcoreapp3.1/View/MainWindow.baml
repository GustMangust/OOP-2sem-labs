   M S B A M L   `   `   `  ����A  =Lab6-7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab6_7Lab6_7  5   	       Lab6_7.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Z VDevExpress.Mvvm.UI, Version=20.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Lab6_7     5   	     � Title$  
MainWindow��5   	   $	��680��6   $
��1024��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value �� Triggers :� RoutedEvent g� Duration �� TargetProperty		 W� To
 ]� 
Conditions �� Property �� Value��%�  '��       '�� =    '�� �    �� 5
   
   " ��6   .�5      ��  � ��$ 12(�6)   �� 5       � ��$ Verdana)�6+    5      :� 5      $ 	MouseDown��6   [�5      �� 5      .��5      �� .��5   "   W� $ 0:0:0.2D�62   $ FontSize�5   2   	 155   2   5   #   5      5      5      5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   5      �� 5   
   " ��6    5       ]� 5!      
 5"      �� 5#       �@J�IsMouseOver$
 True��6;   �� 5$       �@J�	IsVisible$
 True��69   /�5&      �� 5'       � ��$ 14(�65   �� 5(       � ��
 �  ��67   5*      5-      5.      .��5/      �  � ColumnDefinitions 50   
   �� 51      $
��0.8* �6   �� 52      $��* �6    � RowDefinitions 54   
   �� 55      $
��0.2* �6   �� 56      $��* �6   .+�58   
   ��    HeaderStyle#���   6   $��0��6;    �� Orientation$ 
Horizontal=�6H   $��2��6a   $��Stretch=�6u   .+�59      �� $��20,0,0,0q�6   $��Center=�6+   $ 
Horizontal=�6F   $��Right=�6_   .+�5:      �� -   5         ��Name$ styleBox��5:      $��Center=�6-   $��Center=�6Q   $��15(�6s   $��30��6�   $	��100��6�   
���   ����#5AA9B0
�������6�   5;      �� 5<      $��20,0,0,0q�6   $��Center=�6+   $ 
Horizontal=�6F   $��Right=�6_   .+�5=      �� -   5        $ menuLanguage��5=      $��Center=�61   $��Center=�6U   $��15(�6w   $��30��6�   $	��150��6�   
���   ����#5AA9B0
�������6�   5>      �� 5?      $��20,0,0,0q�6   $��50��6'   $
��Undo��63   $��50��6B   ��6N   �� *undo+6i   �� 5@      $��50��6   $��20,0,0,0q�6    $
��Redo��63   $��50��6B   ��6N   �� *redo+6i   �� 5A      $	��120��6   $��50��6"   $��20,0,0,0q�6.     YellowButtonColor#��[ 6@    �� CornerRadius$ 5��6p   $��1q�6�   
�������._�5B      �� $	��120��6   
������ $��0q�6b   $��Center=�6w   ��6?   �� *openAddProduct+.��5C      �� $��18(�6    $��Medium"�6.   $
��Wrap=�6B     	m_OpenAdd#���  6V   5D      5E      �� 5F      $	��120��6   $��50��6"   $��20,0,0,0q�6.   #��[ 6@   $ 5��6p   $��1q�6�   
�������._�5G      �� $	��120��6   
������ $��0q�6_   $��Center=�6t   ��6>   �� *openEditBook+.��5H      �� $��18(�6    $��Medium"�6.   $
��Wrap=�6B     
m_OpenEdit#���  6V   5I      5J      �� 5K      $	��120��6   $��50��6"   $��20,0,0,0q�6.   ���#FFDE9A$ 5��6U   $��1q�6f   
�������._�5L      �� $	��120��6   
������ $��0q�6]   $��Center=�6r   ��6>   �� *
openFilter+.��5M      �� $��18(�6    $��Medium"�6.   $
��Wrap=�6B     m_OpenFilter#���  6V   5N      5O      �� 5P      $	��120��6   $��50��6"   $��20,0,0,0q�6.   ���#FFDE9A$ 5��6U   $��1q�6f   
�������._�5Q      �� $	��120��6   
������ $��0q�6]   $��Center=�6r   ��6>   �� *
openSearch+.��5R      �� $��18(�6    $��Medium"�6.   $
��Wrap=�6B     m_OpenSearch#���  6V   5S      5T      5U      �� 5V   
     ListBoxStyle#���  6   $��0��69   $��1��6I   ��6V   �� *Books+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5W      �� *SelectedBook+��5X      �� 5Y      .R�5Z      �� $��5q�6!   $ 
Horizontal=�6,   .+�5[      �� $	��330��6%   .+�5\      �� $
��Wrap=�6(   $
��Bold"�6<   $��18(�6N   ��6\   ��  �� Path$ 
Full_title��� 5]      $
��Wrap=�6(   $��13(�6<   ��6J   �� $ Author_name��� 5^      $
��Wrap=�6(   $��13(�6<   ��6J   �� $ Price�5_      �� 5`      $��Right=�6    $��80��6\   $��80��6g   ��6<   �� $ Picture�6g   5a      5b      5d      �� 5e   
   $��50,30,50,50q�6   $��1��6*   $��1��6:    � DataContext 6G   �� *SelectedBook+.+�5f      �� $ 
Horizontal=�6   .+�5g      �� $	��180��6   $��24(�6)   $��DemiBold"�67     m_Title#���  6M   �� 5h      $��Center=�6   $��16(�67   $��30,0,0,0q�6F   ��6X   �� *
Full_title+5i      �� 5j      $��0,30,0,0q�6   $ 
Horizontal=�6+   .+�5k      �� $	��180��6   $��24(�6(   $��DemiBold"�66     m_Author#���  6L   �� 5l      $��Center=�6   $��16(�67   $��30,0,0,0q�6E   ��6W   �� *Author_name+5m      �� 5n      $��0,30,0,0q�6   $ 
Horizontal=�6,   .+�5o      �� $	��180��6   $��24(�6(   $��DemiBold"�66    	 
m_Category#��� 	 6L   �� 5p      $��Center=�6   $��16(�67   $��30,0,0,0q�6E   ��6W   �� *
Category+5q      �� 5r      $��0,30,0,0q�6   $ 
Horizontal=�6+   .+�5s      �� $	��180��6   $��24(�6(   $��DemiBold"�66    
 m_Description#��� 
 6L   �� 5t      $��Center=�6   $��16(�67   $��30,0,0,0q�6E   ��6W   �� *Description+5u      �� 5v      $��0,30,0,0q�6   $ 
Horizontal=�6-   .+�5w      �� $	��180��6   $��24(�6(   $��DemiBold"�66     m_Rating#���  6L   �� 5x      $��Center=�6   $��16(�67   $��30,0,0,0q�6E   ��6W   �� *Rating+5y      �� 5z      $��0,30,0,0q�6   $ 
Horizontal=�6,   .+�5{      �� $	��180��6   $��24(�6(   $��DemiBold"�66     m_Price#���  6L   �� 5|      $��Center=�6   $��16(�67   $��30,0,0,0q�6E   ��6W   �� *Price+5}      �� 5~      $��0,30,0,0q�6   $ 
Horizontal=�6,   .+�5      �� $	��180��6   $��24(�6(   $��DemiBold"�66     m_Amount#���  6L   �� 5�      $��Center=�6   $��16(�67   $��30,0,0,0q�6E   ��6W   �� *Amount+5�      5�      5�      5�      