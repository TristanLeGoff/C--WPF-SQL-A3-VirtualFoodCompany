   M S B A M L   `   `   `  ����F  BProjet Cook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Projet_CookProjet_Cook  5          Projet_Cook.PageMyOder   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Projet_Cook     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  
PageMyOder��5
       � 	Resources 5         myHeaderStyle  MaterialDesignFlatButton �� BasedOn �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value  	myLBStyle  MaterialDesignGridViewItem��%�  &	        7  &	     7  �� 5   
   8   " ��6Z   .�5      ��  � {� .  6*    5      P� 5       � {� .  . �5      ��  � �� �	#FF1C653463   �� 5       � �� �	#DDFFFFFF63   �� 5       �@J�Opacity$ 1Q�60   5      5      �� 5   
   " ��6"   8   .�5      ��  � ��$ Center=�6;   �� 5       � �� �	#FFE9E1DF6+    5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �	#FFD3EED663   �� 5       �@J�Opacity$ 1Q�60   5      P� 5       �@��
IsSelected . . �5       ��  � �� �	#FF6CC87A63   5!      5#      5$      .��5&      � .+�5'   
   �� $��UniformToFill=�6   $
��Left=�6*   $	��613��6E   $	��Top=�6R   $
��1120��6j   $��background.png��6w   $y�Visible=�6�   $��0,0,0,-23.4q�6�   �� 5(   
   ���	#FF939393$��1q�6)   	 �� CornerRadius$	 5��6=   $��20,10,196,200q�6N   ._�5)      �� -   5        
 ��Name$
 LVrecipe��5)      #��[ 6*   $��Disabled=�6Z   $��0.2,0.2,-0.8,-0.2q�6�    �� View 5*      �� 5+      ! �� ColumnHeaderContainerStyle# [  6    .P�5,      �� $��Nom de la recette��6)    �� Width$	 300��6D    �� DisplayMemberBinding 6P   �� *
Key.Name+ �� Mode$ Default=��� 5-      $$��Nom du créateur de la recette��6)   $	 225��6P    6\   �� *Key.RecipeCreator+$ Default=��� 5.      $
��Type��6)   $ 80��67    6B   �� *
Key.Type+$ Default=��� 5/      $��Nombre de vente��6)   $	 150��6B    6N   �� *Key.NbrSales+$ Default=��� 50      $
��Prix��6)   $ 60��67    6B   �� *	Key.Price+$ Default=��� 51      $��	Quantité��6)   $ 90��6;    6F   �� *Value+$ Default=�52      54      56      �� 58   
   -   5         ��Name$ BDelete��58      $��0,10,10,470.4q�69   $
��Auto��6P   $��Right=�6^   ���	#FFDA6B6B$	��174��6�   ���	#FFDA6B6B���	#DD000000.��59      �� .+�5:      �� $2��,Supprimer la recette selectionnée du panier��6    �� TextAlignment$ Center=�6O   $
��Wrap=�6f   $	��145��6z   '  !MaterialDesignThemes.Wpf.PackIcon  5;      $��0,10,0,0q�6*      Kind$	 Bin=�6<   $��35��6G   $��35��6S   $��Center=�6^   5<      5>      �� 5?   
   -   5        $ BDetail��5?      $��0,142,10,338.4q�69   $
��Auto��6Q   $��Right=�6_   ���	#FF6CC87A$	��174��6�   .��5@      �� .+�5A      �� $5��/Voir la description de la recette selectionnée��6   $ Center=�6R   $
��Wrap=�6i     5B      $��0,10,0,0q�6*   $ Receipt=�6<   $��35��6K   $��35��6W   $��Center=�6b   5C      5E      �� 5F   
   -   5         ��Name$ TPrice��5F      $
��Left=�6$   $��61��6?   $��498,412,0,0q�6K   $
��Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��174��6�   
��� � �6�   �� 5G   
   -   5        $ TDescription��5G      $
��Left=�6*   $	��162��6E   $��936,291,0,0q�6R   $
��Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��174��6�   �� 5H   
   -   5        $ BCommand��5H      $��0,478,385,27.4q�6;   $
��Auto��6S   $��Right=�6a   ���	#FF6CC87A$	��302��6�   .��5I      �� .+�5J      �� $��Commander mon pannier��6   $ Center=�69   $
��Wrap=�6P     5K      $��0,10,0,0q�6*   $ ShoppingCart=�6<   $��35��6P   $��35��6\   $��Center=�6g   5L      5N      �� 5O   
   -   5        $ TError��5O      $
��Left=�6$   $��61��6?   $��780,494,0,0q�6K   $
��Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��298��6�   
���  ��$��18(�6�   5P      5Q      