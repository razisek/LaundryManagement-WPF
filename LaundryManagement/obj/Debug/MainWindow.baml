   M S B A M L   `   `   `  ����L  HLaundryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:LaundryManagement.ViewModelLaundryManagement.ViewModel  5   	   "    LaundryManagement.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   >d2http://schemas.microsoft.com/expression/blend/2008    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8vm)clr-namespace:LaundryManagement.ViewModel     5   	   -   5          �Name$  DashboardWindow��5   	    � Title$ Laundry Management��5	   	   $	��580��5
   	   $	��930��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      5  /LaundryManagement.ViewModel.NavigationViewModel  5   
   .��5      � .+�5   
   �� ���#ECF0F1 �� CornerRadius$ 10��6&   �� 5   
   ���#151618���#FFFFFF$	��580��5      $��
0,0,-0.4,0q�5      $ 10��5      5      � 5    
    � ColumnDefinitions 5!      �� 5"      $��25 �6#   �� 5#      $	��180 �6#   �� 5$      $��40 �6#   �� 5%      $	��660 �6#   �� 5&      $��25 �6#   	 � RowDefinitions	 5)      �� 5*      $��0 �6    �� 5+      $��80 �6    �� 5,      $��55 �6    �� 5-      $	��370 �6    �� 5.      $��0 �6    .+�51      � $��1��6   $��1��52      $��2��6#   $��0.2,61.2,39.8,19.6q�67   $��2��6S   .+�54      �� $��/Assets/logo.png��6   $	��180��62   $��50��6>   55      � 57      $��3��6   $��1��58      $��0,10,0,0q�59      	 5:      �� 5;      $
��202* �6$   �� 5<      $
��159* �6$   .+�5?      �� $��
0,0,0,-0.6q�6H   $��2��6\   ��6   �� *SourceCollection+��5@      �� 5A      .R�5B      �� .+�5C   "   	�    MenuButtonStyle#��[  5G   .   
 	� 	GroupName$
 	MenuGroup��5H   .   ��5C   .   �� *
MenuName+
 � Tag 5D   .   �� *	MenuImage+��5E   .   �� *
MenuName+��5F   .   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� Path$ DataContext.MenuCommand�5H   .   5I      5J      5L      5M      � 5N      $��2��6   $��3��5O      $��2��5P      
������ .+�5S      �� -   5         ��Name$ Pages��5S   !   $��0,-15,0,-42.6q�5T   G   ��6!   �� *SelectedViewModel+6G   5U      5V      �� 5X   
     CloseButton#��[ 5Y      ��5Z      �� *CloseAppCommand+��5[      ��  �� ElementName$ DashboardWindow�� � 	Resources 5\       �� 
TargetType �� Property �� Value��%_   '��       �� 5]      " ��6   .�5^      ��  �@��CornerRadius$ 20��65   5_      5`      5a      �� 5c   
     MinimizeButton#��[ 5d      ��5e      �� *MinimizeAppCommand+��5f      �� $ DashboardWindow�� 5g      ��%_   '��       �� 5h      " ��6   .�5i      ��  �@��CornerRadius$ 20��65   5j      5k      5l      5m      5n      