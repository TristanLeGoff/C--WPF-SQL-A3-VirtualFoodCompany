   M S B A M L   `   `   `  ����F  BProjet Cook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Projet_CookProjet_Cook  5          Projet_Cook.PageMyRecipe   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Projet_Cook     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  PageMyRecipe��5
       � 	Resources 5         myHeaderStyle  MaterialDesignFlatButton �� BasedOn �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value  	myLBStyle  MaterialDesignGridViewItem��%�  &	        7  &	     7  �� 5   
   8   " ��6Z   .�5      ��  � {� .  6*    5      P� 5       � {� .  . �5      ��  � �� �	#FF1C653463   �� 5       � �� �	#DDFFFFFF63   �� 5       �@J�Opacity$ 1Q�60   5      5      �� 5   
   " ��6"   8   .�5      ��  � ��$ Center=�6;   �� 5       � �� �	#FFE9E1DF6+    5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �	#FFD3EED663   �� 5       �@J�Opacity$ 1Q�60   5      P� 5       �@��
IsSelected . . �5       ��  � �� �	#FF6CC87A63   5!      5#      5$      .��5&      � .+�5'   
   �� $��UniformToFill=�6   $
��Left=�6*   $	��613��6E   $	��Top=�6R   $
��1120��6j   $��background.png��6w   $y�Visible=�6�   $��0,0,0,-23.4q�6�   �� 5(   
   ���	#FF939393$��1q�6)   	 �� CornerRadius$	 5��6=   $��107,29,109,125.4q�6N   ._�5)      �� -   5        
 ��Name$
 LVrecipe��5)      #��[ 6*   $��Disabled=�6Z   $��0.2,0.2,-0.8,-0.2q�6�    �� View 5*      �� 5+      ! �� ColumnHeaderContainerStyle# [  6    .P�5,      �� $��Nom de la recette��6)    �� Width$	 300��6D    �� DisplayMemberBinding 6P   �� *Name+ �� Mode$ TwoWay=��� 5-      $
��Type��6)   $	 100��67    6C   �� *Type+$ TwoWay=��� 5.      $��Nombre de vente��6)   $	 150��6B    6N   �� *
NbrSales+$ TwoWay=��� 5/      $
��Prix��6)   $	 100��67    6C   �� *Price+$ TwoWay=��� 50      $��Disponibilités��6)   $	 260��6A    6M   �� *	Available+$ TwoWay=�51      53      54      �� 55   
   -   5         ��Name$ 	Baccueuil��55      $��0,496,399,26.4q�6<   $
��Auto��6T   $��Right=�6b   ���	#FF6CC87A$	��297��6�   .��56      �� .+�57      �� $��Retour à l'accueil��6    �� TextAlignment$ Center=�66   $
��Wrap=�6M   '  !MaterialDesignThemes.Wpf.PackIcon  58      $��0,10,0,0q�6*      Kind$
 Home=�6<   $��35��6H   $��35��6T   $��Center=�6_   59      5;      5<      5=      