   M S B A M L   `   `   `  ����M  IPersonalAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:PersonalAccounting.View.Counts.UserControls+PersonalAccounting.View.Counts.UserControls  5      D    >PersonalAccounting.View.Counts.UserControls.OneCashCountViewUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Klocal9clr-namespace:PersonalAccounting.View.Counts.UserControls     5        � 	Resources  5	         BoolToVisConverter  _actionbutton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value  _tb��%M  &	        &	      &	 �    �� 5
   
   6'   �� 5   
   " ��6&   .�5      ��  � ��
 �����6+   �� 5       � ��$ 20 0 0 0q�6'   �� 5       � ��$ 30��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �#2980b963   5      5      �� 5   
   " ��6   .�5       ��  � ��$ 15(�6)   �� 5!       � ��$ Center=�62   5$      5%      .��5&      � .+�5(   
   ��  �� Orientation$ 
Horizontal=�6   $��50��5)      .+�5*      �� #��[ 5+      $
��Left=�5,      $	��150��5-      ��5.      �� 	 �� Path$	 CountView.Name�68   �� 5/      #��[ 6   ��50      �� $	 ShowCountDetailsCommand�.��51      �� $��/Resources/details.png��6   52      �� 53      #��[ 6   y�54      �� $'	 !CountView.AmountMoneyChangeEnable�
 �� 	Converter#
 [  .��55      �� $��/Resources/add.png��6   56      �� 57      
�������$��20 0 0 0q�58      $��30��59      ��5:      �� $	 ShowPeriodChangeCommand�.��5;      �� $ 
Horizontal=�6   .+�5<      �� $��Center=�6    $��5q�5=       86Периодические доходы/расходы6I   �� 5>      $��/Resources/time.png��6   5?      5@      5A      �� 5B   
   #��[ 6   $��Right=�5C      $��0 0 30 0q�5D      ��5E      �� $	 CountView.AmountOfMoney�6D   5H      5I      