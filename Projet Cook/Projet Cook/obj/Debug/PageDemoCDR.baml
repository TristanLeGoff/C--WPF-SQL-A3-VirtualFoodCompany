   M S B A M L   `   `   `  ����F  BProjet Cook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Projet_CookProjet_Cook  5          Projet_Cook.PageDemoCDR   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Projet_Cook     5        N� Title$  PageDemoCDR��5	       � 	Resources 5         myHeaderStyle  MaterialDesignFlatButton �� BasedOn �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value  	myLBStyle  MaterialDesignGridViewItem��%�  &	        7  &	     7  �� 5   
   8   " ��6Z   .�5      ��  � {� .  6*    5      P� 5       � {� .  . �5      ��  � �� �	#FF1C653463   �� 5       � �� �	#DDFFFFFF63   �� 5       �@J�Opacity$ 1Q�60   5      5      �� 5   
   " ��6"   8   .�5      ��  � ��$ Center=�6;   �� 5       � �� �	#FFE9E1DF6+    5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �	#FFD3EED663   �� 5       �@J�Opacity$ 1Q�60   5      P� 5       �@��
IsSelected . . �5      ��  � �� �	#FF6CC87A63   5       5"      5#      .��5%      � .+�5&   
   �� $��UniformToFill=�6   $
��Left=�6*   $	��613��6E   $	��Top=�6R   $
��1120��6j   $��background.png��6w   $y�Visible=�6�   $��0,0,0,-23.4q�6�   �� 5'   
   $
��Left=�6   $��41��6/   $��
442,50,0,0q�6;   $
��Wrap=�6O   $ ��Nombre total de recette : ��6c   $	��Top=�6�   $	��256��6�   $��22(�6�   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   z�5(      V� 5)      .~�5*      �� �� 5+      �� 5,      
 �� Angle$
 -0.119Q�6&   T� 5-      5.      50      �� 51   
   -   5         ��Name$ TTotal��51      $
��Bold"�6$   $
��Left=�66   $��41��6Q   $��
693,49,0,0q�6]   $
��Wrap=�6q   $�� ��6�   $	��Top=�6�   $��57��6�   $��22(�6�   �� 52   
   ���	#FF939393$��1q�6)    �� CornerRadius$ 5��6=   $��134,86,134,33.4q�6N   ._�53      �� -   5         ��Name$ LVCDR��53      #��[ 6'   $��Disabled=�6W   $��0.2,0.2,-0.8,-0.2q�6�    �� View 54      �� 55      ! �� ColumnHeaderContainerStyle# [  6    .P�56      �� $(��"Numéro de télephone du créateur��6)    �� Width$	 300��6R    �� DisplayMemberBinding 6^   �� *	Key.Phone+ �� Mode$ Default=��� 57      $��Prénom��6)   $	 150��69    6E   �� *Key.FirstName+$ Default=��� 58      $	��Nom��6)   $	 150��66    6B   �� *Key.LastName+$ Default=��� 59      $"��Nombre de recette commandée��6)   $	 250��6N    6Z   �� *Value+$ Default=�5:      5<      5>      5?      5@      