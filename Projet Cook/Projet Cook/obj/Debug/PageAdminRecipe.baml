   M S B A M L   `   `   `  ����F  BProjet Cook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Projet_CookProjet_Cook  5      !    Projet_Cook.PageAdminRecipe   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Projet_Cook     5        N� Title$  PageAdminRecipe��5	       � 	Resources 5         myHeaderStyle  MaterialDesignFlatButton �� BasedOn �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value  	myLBStyle  MaterialDesignGridViewItem  placeHolder	 �� 
TargetType
 ��Name K� ZIndex �� Path �� RelativeSource �� Mode �� UpdateSourceTrigger
 � Tag �� TextWrapping �� Binding �� Source%  System.Windows.Markup.Reference �� Value��%�  &	        7  &	     7  &	 z    7���� 5   
   8   " ��6Z   .�5      ��  � {� .  6*    5      P� 5       � {� .  . �5      ��  � �� �	#FF1C653463   �� 5       � �� �	#DDFFFFFF63   �� 5       �@J�Opacity$ 1Q�60   5      5      �� 5   
   " ��6"   8   .�5      ��  � ��$ Center=�6;   �� 5       � �� �	#FFE9E1DF6+    5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �	#FFD3EED663   �� 5       �@J�Opacity$ 1Q�60   5      P� 5       �@��
IsSelected . . �5      ��  � �� �	#FF6CC87A63   5       5"      �� 5#   
   " ��6$   8   .�5$      ��  � �� 5%      �� 5&      "	 ��6&   .R�5'      � .+�5(      �� $
 
textSource��5,   "   
������ $ 2��5.   "   $��10,5,5,5q�5/   "   ��5(   &   �� $
 Text� �� *TemplatedParent+$ TwoWay=�$ PropertyChanged=�5/   "   �� 51      #��z 6&   #��z��6C   $ 1��6m   $
 Wrap=�6~   .��6�   ��52   "   �� 53   &   " ��6,   .�54   *   ��  � ��
 ���� 6G   �� 55   *    � �� �	#FFBFBFBF6H   �� 56   *    � ��$ 20,13,10,10q�6D   �� 57   *    � ��$ 21(�6E    59   *   �� 5:   .    6:   �� $
 Text�   *
textSource+  6y   .a�5;   2   ��  � �� �	#FFA3A3A36O   �� 5<   2    �@��TextWrapping$
 Wrap=�6Q   5=   /   5?   '   .��5@   1   5A      5B      5C      5E      5F      5G      .��5H      � .+�5I   
   �� $��UniformToFill=�6   $
��Left=�6*   $	��613��6E   $	��Top=�6R   $
��1120��6j   $��background.png��6w   $y�Visible=�6�   $��0,0,0,-23.4q�6�   �� 5J   
   ���	#FF939393$��1q�6)    �� CornerRadius$ 5��6=   $��37,120,534,27.4q�6N   ._�5K      �� -   5         ��Name$ LVrecipe��5K      #��[ 6*   $��Disabled=�6Z   $��0.2,0.2,-0.8,-0.2q�6�    �� View 5L      �� 5M      ! �� ColumnHeaderContainerStyle# [  6    .P�5N      �� $��Nom de la recette��6)    �� Width$	 275��6D    �� DisplayMemberBinding 6P   �� *Name+$ Default=��� 5O      $!��Nom du créateur de recette��6)   $	 275��6M    6Y   �� *Value+$ Default=�5P      5R      5T      �� 5U   
   $��Quantitée commandée : ��6   $��22(�6V   $��656,301,76,254.4q�6d    �� Target 61   ��  �� ElementName$ TName��6d   �� 5V   
   -   5        $
 	TQuantity��5V   )   ���	#FFF3F3F3#��[ 6<   $ Ex: 10��6a   $��1q�6n   $��20(�6�   $��60��6�   $��656,337,76,193.4q�6�   �� 5W   
   -   5         ��Name$ TError��5W      $
��Left=�6$   $��61��6?   $��674,505,0,0q�6K   $
��Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��361��6�   
���  ��$��18(�6�   �� 5X   
   -   5         ��Name$ BDelete��5X      $(��"Supprimer la recette selectionnée��68   $
��Left=�6d   $��33��6   $��	39,71,0,0q�6�   $	��Top=�6�   $	��546��6�   ���	#FFD64C4C6�   �� 5Y   
   $��Nom du produit : ��6   $��22(�6Q   $��656,184,59,371.4q�6_    6,   �� $ TName��6_   �� 5Z   
   -   5        $
 TName��5Z   )   ���	#FFF3F3F3#��[ 68   $ Ex : Oignons��6]   $��1q�6p   $��20(�6�   $��60��6�   $��656,219,76,311.4q�6�   �� 5[   
   -   5        $
 BAdd��5[      $��Ajouter le produit��62   $
��Left=�6O   $��49��6j   $��689,419,0,0q�6v   $	��Top=�6�   $	��322��6�   �� 5\   
   -   5        $ BActu��5\      $%��Actualiser StockMin et StockMax��64   $
��Left=�6^   $��49��6y   $��
639,93,0,0q�6�   $	��Top=�6�   $	��422��6�   5]      5^      