   M S B A M L   `   `   `  ����F  BProjet Cook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Projet_CookProjet_Cook  5           Projet_Cook.PageNewCommand   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Projet_Cook     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  PageNewCommand��5
       � 	Resources 5         myHeaderStyle  MaterialDesignFlatButton �� BasedOn �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value  	myLBStyle  MaterialDesignGridViewItem��%�  &	        7  &	     7  �� 5   
   8   " ��6Z   .�5      ��  � {� .  6*    5      P� 5       � {� .  . �5      ��  � �� �	#FF1C653463   �� 5       � �� �	#DDFFFFFF63   �� 5       �@J�Opacity$ 1Q�60   5      5      �� 5   
   " ��6"   8   .�5      ��  � ��$ Center=�6;   �� 5       � �� �	#FFE9E1DF6+    5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �	#FFD3EED663   �� 5       �@J�Opacity$ 1Q�60   5      P� 5       �@��
IsSelected . . �5       ��  � �� �	#FF6CC87A63   5!      5#      5$      .��5&      � .+�5'   
   �� $��UniformToFill=�6   $
��Left=�6*   $	��613��6E   $	��Top=�6R   $
��1120��6j   $��background.png��6w   $y�Visible=�6�   $��0,0,0,-23.4q�6�   �� 5(   
   ���	#FF939393$��1q�6)   	 �� CornerRadius$	 5��6=   $��20,80,196,20.4q�6N   ._�5)      �� -   5        
 ��Name$
 LVrecipe��5)      #��[ 6*   $��Disabled=�6Z   $��0.2,0.2,-0.8,-0.2q�6�    �� View 5*      �� 5+      ! �� ColumnHeaderContainerStyle# [  6    .P�5,      �� $��Nom de la recette��6)    �� Width$	 300��6D    �� DisplayMemberBinding 6P   �� *Name+ �� Mode$ TwoWay=��� 5-      $$��Nom du créateur de la recette��6)   $	 250��6P    6\   �� *RecipeCreator+$ TwoWay=��� 5.      $
��Type��6)   $	 100��67    6C   �� *Type+$ TwoWay=��� 5/      $��Nombre de vente��6)   $	 150��6B    6N   �� *
NbrSales+$ TwoWay=��� 50      $
��Prix��6)   $	 100��67    6C   �� *Price+$ TwoWay=�51      53      54      �� 56   
   -   5         ��Name$ BAddCart��56      $��900,80,10,400q�6:   $
��Auto��6Q   $��Right=�6_   ���	#FF6CC87A.��57      �� .+�58      �� $0��*Ajouter la recette selectionnée au panier��6    �� TextAlignment$ Center=�6M   $
��Wrap=�6d   '  !MaterialDesignThemes.Wpf.PackIcon  59      $��0,10,0,0q�6*      Kind$ ShoppingCart=�6<   $��35��6P   $��35��6\   $��Center=�6g   5:      5<      �� 5=   
   -   5        $ BDetail��5=      $��0,213,10,267.4q�68   $
��Auto��6P   $��Right=�6^   ���	#FF6CC87A$	��174��6�   .��5>      �� .+�5?      �� $5��/Voir la description de la recette selectionnée��6   $ Center=�6R   $
��Wrap=�6i     5@      $��0,10,0,0q�6*   $ Receipt=�6<   $��35��6K   $��35��6W   $��Center=�6b   5A      5C      �� 5D   
   -   5         ��Name$ TError��5D      $
��Left=�6$   $��61��6?   $��936,509,0,0q�6K   $
��Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��174��6�   
���  ��$��14(�6�   �� 5E   
   -   5        $ TDescription��5E      $
��Left=�6*   $	��162��6E   $��936,342,0,0q�6R   $
��Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��174��6�   5F      5G      