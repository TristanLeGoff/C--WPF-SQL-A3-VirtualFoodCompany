   M S B A M L   `   `   `  ����F  BProjet Cook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Projet_CookProjet_Cook  5           Projet_Cook.PageAdminBoard   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      %localclr-namespace:Projet_Cook  5        N� Title$  PageAdminBoard��5
       � 	Resources 5         myHeaderStyle  MaterialDesignFlatButton �� BasedOn �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value  	myLBStyle  MaterialDesignGridViewItem��%�  &	        7  &	     7  �� 5   
   8   " ��6Z   .�5      ��  � {� .  6*    5      P� 5       � {� .  . �5      ��  � �� �	#FF1C653463   �� 5       � �� �	#DDFFFFFF63   �� 5       �@J�Opacity$ 1Q�60   5      5      �� 5   
   " ��6"   8   .�5      ��  � ��$ Center=�6;   �� 5       � �� �	#FFE9E1DF6+    5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �	#FFD3EED663   �� 5       �@J�Opacity$ 1Q�60   5      P� 5       �@��
IsSelected . . �5       ��  � �� �	#FF6CC87A63   5!      5#      5$      .��5%      � .+�5&   
   �� $��UniformToFill=�6   $
��Left=�6*   $	��613��6E   $	��Top=�6R   $
��1120��6j   $��background.png��6w   $y�Visible=�6�   $��0,0,0,-23.4q�6�   �� 5'   
   $
��Left=�6   $��41��6/   $��
131,86,0,0q�6;   $
��Wrap=�6O   $@��:Le CdR ayant le plus été commandé cette semaine est :  ��6c   $	��Top=�6�   $	��544��6�   $��22(�6�   �� 5(   
   -   5        	 ��Name$	 TBestCdr��5(      $
��Bold"�6&   $
��Left=�68   $��41��6S   $��
675,86,0,0q�6_   $
��Wrap=�6s   $�� ��6�   $	��Top=�6�   $	��286��6�   $��22(�6�   �� 5)   
   $
��Left=�6   $��41��6/   $��108,169,0,0q�6;   $
��Wrap=�6P   $��Le CdR d'or est : ��6d   $	��Top=�6~   $	��173��6�   $��22(�6�   �� 5*   
   -   5        $	 TGoldCdr��5*      $
��Bold"�6&   $
��Left=�68   $��41��6S   $��281,169,0,0q�6_   $
��Wrap=�6t   $�� ��6�   $	��Top=�6�   $	��243��6�   $��22(�6�   �� 5+   
   $
��Left=�6   $��41��6/   $��131,212,0,0q�6;   $
��Wrap=�6P   $'��!Ainsi que son top 5 des recettes ��6d   $	��Top=�6�   $	��318��6�   $��22(�6�   �� 5,   
   $
��Left=�6   $��41��6/   $��661,186,0,0q�6;   $
��Wrap=�6P   $-��'Top 5 des recettes les plus commandées��6d   $	��Top=�6�   $	��407��6�   $��22(�6�   �� 5-   
   
���   �$
��Left=�6!   $	��434��6<   $��606,158,0,-1.6q�6I   
���   �$	��Top=�6p   $��2��6�   �� 5.   
   ���	#FF939393$��1q�6)   
 �� CornerRadius$
 5��6=   $��13,260,521,11.4q�6N   ._�5/      �� -   5         ��Name$ LVrecipe��5/      #��[ 6*   $��Disabled=�6Z   $��0.2,0.2,-0.8,-0.2q�6�    �� View 50      �� 51      ! �� ColumnHeaderContainerStyle# [  6    .P�52      �� $��Nom de la recette��6)    �� Width$	 270��6D    �� DisplayMemberBinding 6P   �� *Name+ �� Mode$ TwoWay=��� 53      $
��Type��6)   $	 100��67    6C   �� *Type+$ TwoWay=��� 54      $��Ventes��6)   $	 120��69    6E   �� *
NbrSales+$ TwoWay=��� 55      $
��Prix��6)   $	 100��67    6C   �� *Price+$ TwoWay=�56      58      59      �� 5:   
   ���	#FF939393$��1q�6)   $
 5��6=   $��615,260,6,9.4q�6N   ._�5;      �� -   5        $ LVrecipeAll��5;      #��[ 6-   $��Disabled=�6]   $��0.2,0.2,-0.8,-0.2q�6�    5<      �� 5=      # [  6    .P�5>      �� $��Nom de la recette��6)   $	 250��6D    6P   �� *Name+$ TwoWay=��� 5?      $$��Nom du créateur de la recette��6)   $	 250��6P    6\   �� *RecipeCreator+$ TwoWay=�5@      5B      5C      �� 5D   
   
���   �$
��Left=�6!   $	��896��6<   $��570,-321,0,0q�6I   
���   �$	��Top=�6n   $��2��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5E      V� 5F      .~�5G      �� �� 5H      �� 5I       �� Angle$ -89.938Q�6&   T� 5J      5K      5M      5O      5P      