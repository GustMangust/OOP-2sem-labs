   M S B A M L   `   `   `  ����C  ?GoodFood, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:GoodFoodGoodFood  5   	       GoodFood.View.LogInPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Z VDevExpress.Mvvm.UI, Version=20.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:GoodFood     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   
   $��Regular"�5	   
   $��13(�5
   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
    � Title$ GoodFood��5   	   $	��506��6   $	��450��6'    � 
ResizeMode$ NoResize=�63   .��5      � 
������� � ColumnDefinitions 5   
   �� 5      6!   �� 5      $��3* �6   6,   �� 5      6!    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   �� $��0��6*   $��20(�67   $	��250��6E   $��1��6T   $��0 85 0 0q�6d     MaterialDesignTextBox#���  6w   .  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#c33124)  #MaterialDesignThemes.Wpf.HintAssist   
FontFamily$ Roboto)�6�    � Cursor$ IBeam��6  	   Hint$(	 " Электронная почта��6  ��6   �� *Email+6  G� 5   
   -   5        
 G�Name$
 PasswordBox��5       G� PasswordChar$ *��6+   $��1��6<   $��20(�6I   $	��250��6W   $��1��6f   $��0 30 0 0q�6v     MaterialDesignPasswordBox#���  6�   $ Roboto)�6�    �#c33124$ IBeam��6#  $	  Пароль��62  �� 5    
   $��2��6   $��1��6   $#��Неверные данные��6-   $��Center=�6G   $��0 10 0 0q�6e   $��14(�6w   $��Roboto)�6�   $��Center=�6�     MaterialDesignLabel#���  6�   y�6�   �� *
Visibility+�� 5!   
   ���#e8a628$��Roboto)�6v   ���#3B0F0B$��3��6�   $��1��6�   $	��125��6�   $��40��6�   $��	0 100 0 0q�6�   $��Вход��6�    # MaterialDesignRaisedLightButton#��[ 6�   $
 Hand��60  ��6   �� *signIn+��6,   ��  �� ElementName$ PasswordBox��60  �� 5"   
   $��4��64   $��1��6A   $	��125��6Q   $��40��6]   ���#f98365$��Roboto)�6~   ���#3B0F0B$��	0 15 0 15q�6�   $��Регистрация��6�   #��[ 6�   $
 Hand��6
  ��6   �� *openSignUpPage+6
  5#      5$      