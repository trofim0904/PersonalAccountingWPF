   M S B A M L   `   `   `  ����M  IPersonalAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:PersonalAccounting.ViewPersonalAccounting.View  5   	   K*clr-namespace:PersonalAccounting.ViewModelPersonalAccounting.ViewModel  5   	   (    "PersonalAccounting.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:PersonalAccounting.View     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   3vm*clr-namespace:PersonalAccounting.ViewModel  5   	   -   5          �Name$  MainW��5	   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ 
MainWindow��5   	   $	��600��6   $
��1080��6)    � DataContext 5      /   )PersonalAccounting.ViewModel.MainWindowVM  5   
    � 	Resources 5         BoolToVisConverter  
_spweather �� 
TargetType �� Property �� Value  	_textmenu  _rightmenubuttons	 �� Triggers
 P� Property P� Value��%  &	        &	      &	 �     &	 �    �� 5   
   6'   �� 5   
   " ��6#   .�5      ��  �@��Orientation$ 
Horizontal=�6,   �� 5       � ��$ 5q�6'   5      �� 5   
   " ��6"   .�5      ��  � ��$ Center=�64   �� 5       � �� �#34495e6+   �� 5       � ��$ 14(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��
 �����6+   �� 5       � ��$ 	15 0 15 0q�6'   5      �� 5"   
   " ��6*   .�5#      ��  � ��$ 15(�6)   	 5$      P� 5%      
 �@J�IsMouseOver . . �5&      ��  � �� �#8e44ad63   5'      5)      5*      .��5-      �  � RowDefinitions 50   
   �� 52      $	��100 �6   �� 53      .+�5:   
   � $��0��6   ���#34495e.+�5=      ��  �� Orientation$ 
Horizontal=�6   $��10q�5>      $��Center=�5?      .+�5@      �� .+�5A      �� $��60��6     _imgbuttons#���  5B      $��	15 0 15 0q�5F      ��5C      ��  �� Path$ CountPageCommand�{�5D      �� *WindowWorkSpaceIsEnable+ J� Opacity 5E      �� *WindowWorkSpaceOpacity+.��5G      �� $��/Resources/counts.png��6    $��5q�5H       5I      �� 5J      #��[ 6    
Счета5K   (   5L      �� 5M      .+�5N      �� $��60��6   #���  5O      $��	15 0 15 0q�5Q      ��5P      �� $ LockWindowCommand�.��5R      �� $��/Resources/lock.png��6    $��5q�5S       5T      �� 5U      #��[ 6    Заблок.5V   *   5W      �� 5X      .+�5Y      �� $��60��6   #���  5Z      $��	15 0 15 0q�5_      ��5[      �� $ CloseAppCommand�{�5\      �� *WindowWorkSpaceIsEnable+ 5]      �� *WindowWorkSpaceOpacity+��5^      ��  �� ElementName$ MainW��.��5`      �� $��/Resources/close.png��6    $��5q�5a       5b      �� 5c      #��[ 6    
Выход6J   5d      5f      5g      � 5h   
   $��1��6   {�5i      �� *WindowWorkSpaceIsEnable+ 5j      �� *WindowWorkSpaceOpacity+ � ColumnDefinitions 5m      �� 5n      $	��200 �6#   �� 5o      .+�5r      �� $��1q�6   ���#bdc3c7$��0��5t      � 5u      $��0��6   .+�5v      �� $��10 0 0 0q�6   .+�5w      �� $��20(�6    $��0 0 0 10q�5x       Панель задач6@   �� 5y      #��[ 6    $��Создать счет��5z        J� InputBindings 5{      d� 5|       d� Gesture$ 	LeftClicka�6+    �� Command 6?   �� *NewCountCommand+5~      �� 5      #��[ 6    $��Закрыть��5�       ���#e74c3c 5�       �� $ CancelButtonVisibility� 5�      d� 5�      $ 	LeftClicka�6+    6?   �� $ BackToAllCountsCommand�5�      5�      �� 5�      $��Bottom=�6   $
��Left=�5�      .+�5�      �� $��5q�6    $��15(�5�       Погода66   �� 5�      #��[ 6!   .+�5�      �� $��0 0 5 0q�6$   Чувствуется:6C   �� 5�      $
��Bold"�6$   ��5�   $   �� $" WeatherModel.Main.Feels_like�6Y   �� 5�      $
��Bold"�6$   C69   5�      �� 5�      #��[ 6!   .+�5�      �� $��0 0 5 0q�6$   	Мин:6;   �� 5�      $
��Bold"�6$   ��5�   $   �� $  WeatherModel.Main.Temp_max�6W   �� 5�      $
��Bold"�6$   C69   5�      �� 5�      #��[ 6!   .+�5�      �� $��0 0 5 0q�6$   	Макс:6<   �� 5�      $
��Bold"�6$   ��5�   $   �� $  WeatherModel.Main.Temp_min�6W   �� 5�      $
��Bold"�6$   C69   5�      5�      5�      � 5�      $��1��6   .+�5�       �   � NavigationUIVisibility$ Hidden=�5�      ��5�      �� $ SelectedViewModel�5�      5�      � 5�      $��0��6   $��0��5�      $��2��5�      $��2��5�       K� ZIndex$ 2��5�      .+�5�      �� $��/Resources/lock.png��6   $��5q�5�      $	��200��5�      y�5�      �� $ LockImgVisibility� �� 	Converter# [  5�      5�      5�      5�      