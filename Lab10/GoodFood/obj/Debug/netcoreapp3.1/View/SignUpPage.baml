   M S B A M L   `   `   `  ����C  ?GoodFood, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:GoodFoodGoodFood  5   	       GoodFood.View.SignUpPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Z VDevExpress.Mvvm.UI, Version=20.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:GoodFood     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   
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
��auto �6   6,   .+�5   
   �� $��0��6   $��1��6"   .+�5      �� $��20(�6/   $	��250��6=   $��0 50 0 0q�6L   
���   �  MaterialDesignTextBox#���  6r   .  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#c33124)  #MaterialDesignThemes.Wpf.HintAssist   
FontFamily$ Roboto)�6�    � Cursor$ IBeam��6	  	   Hint$'	 !Электронная почта��6  ��6   �� *Email+6  G� 5      -   5        
 G�Name$
 PasswordBox��5       G� PasswordChar$ *��6/   $��20(�6B   $	��250��6P   $��0 20 0 0q�6_   
���   �  MaterialDesignPasswordBox#���  6�    �#c33124$ Roboto)�6�   $ IBeam��6!  $	 Пароль��60  �� 5      $��20(�6-   $	��250��6;   $��0 20 0 0q�6J   
���   �#���  6q    �#c33124$ Roboto)�6�   $ IBeam��6  $	 Имя��6  ��6   �� *Name+6  �� 5       $��20(�6/   $	��250��6=   $��0 20 0 0q�6L   
���   �#���  6r    �#c33124$ Roboto)�6�   $ IBeam��6	  $	 Фамилия��6  ��6   �� *	Surname+6  5!      �� 5"   
   $��1��6   $��1��6   $#��Неверные данные��6-   $��0 10 0 0q�6G   $��Center=�6Y   $��Roboto)�6v   $��14(�6�   $��Center=�6�     MaterialDesignLabel#���  6�   y�6�   �� *
Visibility+�� 5#   
   $��2��6   $��1��6"   $��0 40 0 0q�62   .+�5$      �� ���#e8a628$��Roboto)�6z   ���#3B0F0B$	��125��6�   $��40��6�   $��0 20 0 0q�6�   $��Регистрация��6�    # MaterialDesignRaisedLightButton#��[ 6�   $
 Hand��6  ��6   �� *signUp+��60   ��  �� ElementName$ PasswordBox��6  �� 5%      ���#f98365$��Roboto)�6C   ���#3B0F0B$��2��6m   $��1��6z   $��0 15 0 0q�6�   $	��125��6�   $��40��6�   $��
Назад��6�   #��[ 6�   $
 Hand��6�   ��6   �� *back+6�   5&      5'      5(      