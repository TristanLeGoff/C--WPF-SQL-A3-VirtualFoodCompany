   M S B A M L   `   `   `  ����F  BProjet Cook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Projet_CookProjet_Cook  5      #    Projet_Cook.PageCreateCommand   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Projet_Cook     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  PageCreateCommand��5
       � 	Resources 5         myHeaderStyle  MaterialDesignFlatButton �� BasedOn �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value  	myLBStyle  MaterialDesignGridViewItem  placeHolder	 �� 
TargetType
 ��Name K� ZIndex �� Path �� RelativeSource �� Mode �� UpdateSourceTrigger
 � Tag �� TextWrapping �� Binding �� Source%  System.Windows.Markup.Reference �� Value��%�  &	        7  &	     7  &	 z    7���� 5   
   8   " ��6Z   .�5      ��  � {� .  6*    5      P� 5       � {� .  . �5      ��  � �� �	#FF1C653463   �� 5       � �� �	#DDFFFFFF63   �� 5       �@J�Opacity$ 1Q�60   5      5      �� 5   
   " ��6"   8   .�5      ��  � ��$ Center=�6;   �� 5       � �� �	#FFE9E1DF6+    5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �	#FFD3EED663   �� 5       �@J�Opacity$ 1Q�60   5      P� 5       �@��
IsSelected . . �5       ��  � �� �	#FF6CC87A63   5!      5#      �� 5$   
   " ��6$   8   .�5%      ��  � �� 5&      �� 5'      "	 ��6&   .R�5(      � .+�5)      �� $
 
textSource��5-   "   
������ $ 2��5/   "   $��10,5,5,5q�50   "   ��5)   &   �� $
 Text� �� *TemplatedParent+$ TwoWay=�$ PropertyChanged=�50   "   �� 52      #��z 6&   #��z��6C   $ 1��6m   $
 Wrap=�6~   .��6�   ��53   "   �� 54   &   " ��6,   .�55   *   ��  � ��
 ���� 6G   �� 56   *    � �� �	#FFBFBFBF6H   �� 57   *    � ��$ 20,13,10,10q�6D   �� 58   *    � ��$ 21(�6E    5:   *   �� 5;   .    6:   �� $
 Text�   *
textSource+  6y   .a�5<   2   ��  � �� �	#FFA3A3A36O   �� 5=   2    �@��TextWrapping$
 Wrap=�6Q   5>   /   5@   '   .��5A   1   5B      5C      5D      5F      5G      5H      .��5J      � .+�5K   
   �� $��UniformToFill=�6   $
��Left=�6*   $	��613��6E   $	��Top=�6R   $
��1120��6j   $��background.png��6w   $y�Visible=�6�   $��0,0,0,-23.4q�6�   �� 5L   
   $��Créer une recette��6    �� TextAlignment$ Center=�6-   $��0,10,0,0q�6D   $��Center=�6V   $	��Top=�6s   $��40(�6�   $
��Bold"�6�   �� 5M   
   ���	#FF939393$��1q�6)    �� CornerRadius$ 5��6=   $��795,80,20,122.4q�6N   ._�5N      �� -   5         ��Name$ 	LVProduce��5N      #��[ 6+   $��Disabled=�6[   $��-0.8,0.2,-1,0.2q�6�    �� SelectionMode$ Multiple=�6�    �� View 5O      �� 5P      ! �� ColumnHeaderContainerStyle# [  6    .P�5Q      �� $��Liste des produits��6)    �� Width$	 200��6E    �� DisplayMemberBinding 6Q   �� *Name+$ TwoWay=��� 5R      $	 100��6)   $��Nécessaire��65    �� CellTemplate 5S      �� 5T   "   .R�5U   &   �� .+�5V   *   ��  ��Name$ CheckBox��63    d� 	IsChecked 6E   ��  ��   �� AncestorType$  ListViewItemL�$ 
IsSelected�5W   '   5X   #   5Z      5[      5]      5^      �� 5_   
   $��Titre de la recette : ��6   $��22(�6V   $��96,71,793,484.4q�6d   ! �� Target! 61   �� " �� ElementName$" TName��6d   �� 5`   
   -   5        $
 TName��5`   )   ���	#FFF3F3F3#��[ 68   $5 /Entrez un titre de recette ex: Boeuf Bourgignon��6]   $��1q�6�   $��20(�6�   $��60��6�   $��96,106,413,424.4q�6�   �� 5a   
   -   5        # ��Name$# BValider��5a      $��Créer recette��6:   $
��Left=�6R   $��62��6m   $��456,496,0,0q�6y   $	��Top=�6�   $	��251��6�   �� 5b   
   $"��Description de la recette : ��6   $��22(�6\   $��96,166,720,389.4q�6j   ! 67   �� $" TName��6j   �� 5c   
   -   5        $
 TDescription��5c   )   ���	#FFF3F3F3#��[ 6?   $C =Ex: Plat composé de boeuf, cuit dans le vin avec des oignons��6d   $��1q�6�   $��20(�6�   $��96,201,413,222.4q�6�   $
 Wrap=�6�   �� 5d   
   $��Type de la recette : ��6   $��22(�6U   $��96,373,793,182.4q�6c   ! 60   �� $" TName��6c   �� 5e   
   -   5        $
 TType��5e   )   ���	#FFF3F3F3#��[ 68   $ Ex: Végetarien��6]   $��1q�6r   $��20(�6�   $��60��6�   $��96,408,749,122.4q�6�   �� 5f   
   $��Prix de la recette : ��6   $��22(�6U   $��432,373,457,182.4q�6c   ! 60   �� $" TName��6c   �� 5g   
   -   5        $
 TPrice��5g   )   ���	#FFF3F3F3#��[ 69   $ 	Ex: 10.00��6^   $��1q�6n   $��20(�6�   $��60��6�   $��432,408,413,122.4q�6�   �� 5h   
   -   5        $ ��Name$$ TError��5h      $
��Left=�6$   $��61��6?   $��746,499,0,0q�6K   $
��Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��361��6�   
���  ��$��18(�6�   5i      5j      