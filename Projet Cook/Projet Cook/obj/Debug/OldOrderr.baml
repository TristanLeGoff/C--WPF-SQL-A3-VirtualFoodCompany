   M S B A M L   `   `   `  ����F  BProjet Cook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Projet_CookProjet_Cook  5          Projet_Cook.OldOrderr   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Projet_Cook     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  	OldOrderr��5
       � 	Resources 5         myHeaderStyle  MaterialDesignFlatButton �� BasedOn �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value  	myLBStyle  MaterialDesignGridViewItem��%�  &	        7  &	     7  �� 5   
   8   " ��6Z   .�5      ��  � {� .  6*    5      P� 5       � {� .  . �5      ��  � �� �	#FF1C653463   �� 5       � �� �	#DDFFFFFF63   �� 5       �@J�Opacity$ 1Q�60   5      5      �� 5   
   " ��6"   8   .�5      ��  � ��$ Center=�6;   �� 5       � �� �	#FFE9E1DF6+    5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �	#FFD3EED663   �� 5       �@J�Opacity$ 1Q�60   5      P� 5       �@��
IsSelected . . �5       ��  � �� �	#FF6CC87A63   5!      5#      5$      .��5%      � .+�5&   
   �� $��UniformToFill=�6   $
��Left=�6*   $	��613��6E   $	��Top=�6R   $
��1120��6j   $��background.png��6w   $y�Visible=�6�   $��0,0,0,-23.4q�6�   �� 5'   
   ���	#FF939393$��1q�6)   	 �� CornerRadius$	 5��6=   $��84,108,577,98.4q�6N   ._�5(      �� -   5        
 ��Name$
 LVListOrder��5(      #��[ 6-   $��Disabled=�6]   $��0.2,0.2,-0.8,-0.2q�6�    �� View 5)      �� 5*      ! �� ColumnHeaderContainerStyle# [  6    .P�5+      �� $
��Date��6)    �� Width$	 150��67    �� DisplayMemberBinding 6C   �� *Date+ �� Mode$ Default=��� 5,      $��Nombre de recette��6)   $	 225��6D    6P   �� *Nombrerecette+$ Default=��� 5-      $
��Prix��6)   $ 80��67    6B   �� *Price+$ Default=�5.      50      52      �� 54   
   ���	#FF939393$��1q�6)   $	 5��6=   $��610,108,80,98.4q�6N   ._�55      �� -   5        $
 LVListREcipe��55      #��[ 6.   $��Disabled=�6^   $��0.2,-0.8,-1.2,-0.8q�6�    56      �� 57      # [  6    .P�58      �� $��Nom de la recette��6)   $	 330��6D    6P   �� *
Key.Name+$ Default=��� 59      $��	Quantité��6)   $	 100��6;    6G   �� *Value+$ Default=�5:      5<      5>      �� 5@   
   -   5         ��Name$ BDetail��5@      $��0,40,130,499.4q�69   $
��Auto��6Q   $��Right=�6_   ���	#FF6CC87A$	��335��6�   .��5A      �� $8��2Voir la liste des recettes du panier sélectionné��6    �� TextAlignment$ Center=�6P   $
��Wrap=�6g   5D      �� 5E   
   -   5        $ BAccueil��5E      $��0,511,383,10.4q�6;   $
��Auto��6S   $��Right=�6a   ���	#FF6CC87A$	��335��6�   .��5F      �� .+�5G      �� $��Retour à l'accueil��6   $ Center=�66   $
��Wrap=�6M   '  !MaterialDesignThemes.Wpf.PackIcon  5H      $��0,10,0,0q�6*      Kind$
 Home=�6<   $��35��6H   $��35��6T   $��Center=�6_   5I      5K      �� 5L   
   $
��Left=�6   $��51��6/   $��
100,40,0,0q�6;   $
��Wrap=�6O   $ ��Liste des anciens panniers��6c   $	��Top=�6�   $	��459��6�   $��36(�6�   $
��Bold"�6�   5N      5O      