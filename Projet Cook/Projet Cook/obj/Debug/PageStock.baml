   M S B A M L   `   `   `  ����F  BProjet Cook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Projet_CookProjet_Cook  5          Projet_Cook.PageStock   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Projet_Cook     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  	PageStock��5
       � 	Resources 5         myHeaderStyle  MaterialDesignFlatButton �� BasedOn �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value  	myLBStyle  MaterialDesignGridViewItem��%�  &	        7  &	     7  �� 5   
   8   " ��6Z   .�5      ��  � {� .  6*    5      P� 5       � {� .  . �5      ��  � �� �	#FF1C653463   �� 5       � �� �	#DDFFFFFF63   �� 5       �@J�Opacity$ 1Q�60   5      5      �� 5   
   " ��6"   8   .�5      ��  � ��$ Center=�6;   �� 5       � �� �	#FFE9E1DF6+    5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �	#FFD3EED663   �� 5       �@J�Opacity$ 1Q�60   5      P� 5       �@��
IsSelected . . �5       ��  � �� �	#FF6CC87A63   5!      5#      5%      .��5&      � .+�5'   
   �� $��UniformToFill=�6   $
��Left=�6*   $	��613��6E   $	��Top=�6R   $
��1120��6j   $��background.png��6w   $y�Visible=�6�   $��0,0,0,-23.4q�6�   �� 5(   
   ���	#FF939393$��1q�6)   	 �� CornerRadius$	 5��6=   $��20,45,545,51q�6N   ._�5)      �� -   5        
 ��Name$
 	LVproduce��5)      #��[ 6+   $��Disabled=�6[   $��0.2,0.2,-0.8,-0.2q�6�    �� View 5*      �� 5+      ! �� ColumnHeaderContainerStyle# [  6    .P�5,      �� $��Nom du produit��6)    �� Width$	 300��6A    �� DisplayMemberBinding 6M   �� *Name+ �� Mode$ TwoWay=��� 5-      $��Fournisseur��6)   $	 150��6>    6J   �� *
Supplier+$ TwoWay=��� 5.      $��Stock��6)   $	 100��68    6D   �� *Stock+$ TwoWay=�5/      51      52      �� 53   
   -   5         ��Name$ LVAddProduce��53   t   $
��Left=�6   $��43��6/   $��620,199,0,0q�6;   $	��Top=�6P   $	��259��6h    �� DisplayMemberPath$
 Name��6�    �� SelectedValuePath$
 Name��54      ���	#FFD9D9D9)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ -- Produits --��6;   $
��10,8q�6k   $��20(�6z    �� MaxDropDownHeight$ 300px��6�   �� 55   
   -   5         ��Name$ BCommandAll��55      $9��3Commander les produits qui ne sont plus disponibles��6@   $
��Left=�6~   $��
621,45,0,0q�6�   $	��Top=�6�   $	��375��6�   $��49��6�   �� 56   
   $2��,Selectionnez un produit à réapprovisionner��6   $
��Left=�6E   $��621,172,0,0q�6`   $	��Top=�6u   $	��267��6�   $��33��6�   $��13(�6�   �� 57   
   -   5         ��Name$ 	TQuantity��57      ���	#FFD9D9D9$
��Left=�6<   $��42��6W   $��920,201,0,0q�6c    �� TextWrapping$
 Wrap=�6x   $�� ��6�   $	��Top=�6�   $��55��6�   $��1q�6�   ���	#FFD9D9D9 �� TextAlignment$ Center=�6�   $��20(�6�   �� 58   
   $��	Quantité��6   $
��Left=�6#   $��917,172,0,0q�6>   $	��Top=�6S   $��76��6k   $��33��6v   $��13(�6�   �� 59   
   -   5        $ BCommand��59      $��	Commander��6:   $
��Left=�6N   $��714,271,0,0q�6i   $	��Top=�6~   $	��208��6�   $��49��6�   �� 5:   
   -   5         ��Name$ Terror��5:      $
��Left=�6$   $��620,460,0,0q�6?   $
��Wrap=�6T   $�� ��6i   $y�Hidden=�6q   $	��Top=�6�   $��38��6�   $	��444��6�   $��18(�6�   ���	#FFFC1C1C6�   5<      5=      