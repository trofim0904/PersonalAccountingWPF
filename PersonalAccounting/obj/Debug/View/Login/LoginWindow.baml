   M S B A M L   `   `   `  ����M  IPersonalAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:PersonalAccounting.View.LoginPersonalAccounting.View.Login  5   	   W0clr-namespace:PersonalAccounting.ViewModel.Login"PersonalAccounting.ViewModel.Login  5   	   /    )PersonalAccounting.View.Login.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:PersonalAccounting.View.Login     5   	   ?vm0clr-namespace:PersonalAccounting.ViewModel.Login     5   	   -   5          �Name$  LoginW��5   	    � Title$ LoginWindow��5
   	    � WindowStartupLocation$ CenterScreen=�6    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   $	��530��5   	   $	��350��5   	    � DataContext 5      6   0PersonalAccounting.ViewModel.Login.LoginWindowVM  5   
    � 	Resources 5       �� 
TargetType   _LRText �� Property	 �� Value
 �� Triggers P� Property P� Value��%�   &	        �� 5   
   " ��6   �5      �� 5       � ��
	 ��  �6/   �� 5       � ��$	 5q�6+   
 5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
	 ��  �63   5      5      5!      .��5"      �  � RowDefinitions 5#   
   �� 5$      $��25 �6   �� 5%      .+�5(   
   �� $��0��6    �� Orientation$ 
Horizontal=�5)      $
��Left=�5*      .+�5+      �� #��[  6    J� InputBindings 5,      d� 5-       d� MouseAction$ 	LeftClicke�5.   #    �� Command 5-   #   ��  �� Path$ GoToLoginCommand� �� CommandParameter 5/   #   ��  �� ElementName$ LoginW��
Вход52      �� 54      #��[  6    55      d� 56      $ 	LeftClicke�57   #    56   #   �� $ GoToRegistrationCommand� 58   #   �� $ LoginW��Регистрация5;      5=      �� 5?   
   $��0��6     _imgbuttons#���  5@      $��Right=�5A      ��5B      �� $ LoginW����5C      �� *CloseCommand+.��5D      �� $��/Resources/close.png��6   $��5q�5E       5F      �� 5H   
   -   5         ��Name$ _content��5I      $��1��5H      ��5J      �� $ SelectedViewModel�5L      5M      