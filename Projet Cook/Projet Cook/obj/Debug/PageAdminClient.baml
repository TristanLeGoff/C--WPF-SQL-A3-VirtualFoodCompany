   M S B A M L   `   `   `  ����F  BProjet Cook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Projet_CookProjet_Cook  5      !    Projet_Cook.PageAdminClient   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Projet_Cook     5        N� Title$  PageAdminClient��5	       � 	Resources 5         myHeaderStyle  MaterialDesignFlatButton �� BasedOn �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value  	myLBStyle  MaterialDesignGridViewItem	 �� Binding
 �� Value��%�  &	        7  &	     7  �� 5   
   8   " ��6Z   .�5      ��  � {� .  6*    5      P� 5       � {� .  . �5      ��  � �� �	#FF1C653463   �� 5       � �� �	#DDFFFFFF63   �� 5       �@J�Opacity$ 1Q�60   5      5      �� 5   
   " ��6"   8   .�5      ��  � ��$ Center=�6;   �� 5       � �� �	#FFE9E1DF6+    5      �� 5      	 6   �� *Role+	
 Admin5      .a�5      ��  � �� �	#FFB98A265      5      �� 5      	 6   �� *Role+
 	Cuisinier5       .a�5!      ��  � �� �	#FFB3C0645"      5#      �� 5$      	 6   �� *Role+
 	Créateur5%      .a�5&      ��  � �� �	#FF4C83AF5'      5(      P� 5)       �@J�IsMouseOver . . �5*      ��  � �� �	#FFD3EED663   �� 5+       �@J�Opacity$ 1Q�60   5,      P� 5-       �@��
IsSelected . . �5.      ��  � �� �	#FFD64C4C63   5/      51      52      .��53      � .+�54   
   �� $��UniformToFill=�6   $
��Left=�6*   $	��613��6E   $	��Top=�6R   $
��1120��6j   $��background.png��6w   $y�Visible=�6�   $��0,0,0,-23.4q�6�   �� 55   
   ���	#FF939393$��1q�6)    �� CornerRadius$ 5��6=   $��13,97,187,11.4q�6N   ._�56      �� -   5         ��Name$ LVclient��56      #��[ 6*   $��Disabled=�6Z   $��0.2,0.2,-0.8,-0.2q�6�    �� View 57      �� 58      ! �� ColumnHeaderContainerStyle# [  6    .P�59      �� $��	Telephone��6)    �� Width$	 240��6<    �� DisplayMemberBinding 6H   �� *Phone+ �� Mode$ TwoWay=��� 5:      $��Prenom��6)   $	 150��69    6E   �� *	FirstName+$ TwoWay=��� 5;      $	��Nom��6)   $	 150��66    6B   �� *
LastName+$ TwoWay=��� 5<      $
��Role��6)   $	 130��67    6C   �� *Role+$ TwoWay=��� 5=      $��Adresse��6)   $	 250��6:    6F   �� *Adress+$ TwoWay=�5>      5@      5A      �� 5B   
   -   5         ��Name$ BDelete��5B      $��	Supprimer��68   $
��Left=�6L   $��57��6g   $��
953,97,0,0q�6s   $	��Top=�6�   $	��145��6�   ���	#FFD64C4C6�   �� 5C   
   -   5        $
 BCDR��5C      $��
Passer CDR��62   $
��Left=�6G   $��57��6b   $��953,176,0,0q�6n   $	��Top=�6�   $	��145��6�   ���	#FF4C83AF6�   �� 5D   
   -   5        $ BChef��5D      $��Passer Cuisinier��64   $
��Left=�6O   $��57��6j   $��953,255,0,0q�6v   $	��Top=�6�   $	��145��6�   ���	#FFB3C0646�   �� 5E   
   -   5        $ BAdmin��5E      $��Passer Admin��66   $
��Left=�6M   $��57��6h   $��953,335,0,0q�6t   $	��Top=�6�   $	��145��6�   ���	#FFB98A266�   �� 5F   
   $
��Left=�6   $��41��6/   $��
309,70,0,0q�6;   $
��Wrap=�6O   $��Nombre total de client : ��6c   $	��Top=�6�   $	��239��6�   $��22(�6�   �� 5G   
   -   5         ��Name$ TTotal��5G      $
��Bold"�6$   $
��Left=�66   $��41��6Q   $��
551,70,0,0q�6]   $
��Wrap=�6q   $�� ��6�   $	��Top=�6�   $��57��6�   $��22(�6�   5H      5I      