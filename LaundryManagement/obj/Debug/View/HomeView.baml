   M S B A M L   `   `   `  ����L  HLaundryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:LaundryManagement.ViewLaundryManagement.View  5      I)clr-namespace:LaundryManagement.ViewModelLaundryManagement.ViewModel  5      %    LaundryManagement.View.HomeView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:LaundryManagement.View     5      @
navigation)clr-namespace:LaundryManagement.ViewModel     5      ��5      �� 5   
     �� Triggers  5      :� 5       :� RoutedEvent$ UserControl.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� TargetProperty$ Opacity�6.    W� From$	 0.0X�5   .   	 W� To$	 1.0X�5   .    g� Duration$ 0:0:0.5D�5   .   5      5      5      5      .��5      � ���#1E1F22 � ColumnDefinitions 5   
   �� 5      $	��215 �6   �� 5       $	��215 �6   �� 5!      $	��215 �6   .+�5#   
   �� $
��Home��6   $��24(�5$      $4��./Fonts/OpenSans-Regular.ttf #Open Sans Regular)�5%      ���#DDDDDD$
��Left=�5'      $	��Top=�5(      $��20,10q�5)      � 5*   
   $��0��6   .+�5+      �� 
������� �� CornerRadius$ 20��5-      $	��100��5.      $	��150��5/       � DataContext 5,      �� 	 �� RelativeSource	 �� 
 �� AncestorType$
 UserControlL� �� Path$ DataContext�._�50      � .+�51      �� $��Jumlah Paket��6    $
��Left=�52      $��15(�53      ���#323334$��SemiBold"�55      $4��./Fonts/OpenSans-Regular.ttf #Open Sans Regular)�56      $��15, 20, 0, 0q�57      �� 59      $
��Left=�5:      $��30(�5;      $
��Bold"�5<      ���#000000$4��./Fonts/OpenSans-Regular.ttf #Open Sans Regular)�5>      $��30, 50, 0, 0q�5?      ��59       �� *
JmlPaket+5?      5@      5A      5B      � 5C   
   $��1��6   .+�5D      �� 
�������$ 20��5F      $	��100��5G      $	��150��5H       5E      �� 	 �� $
 UserControlL�$ DataContext�._�5I      � .+�5J      �� $��Jumlah Pelanggan��6    $
��Left=�5K      $��15(�5L      ���#323334$��SemiBold"�5N      $4��./Fonts/OpenSans-Regular.ttf #Open Sans Regular)�5O      $��15, 20, 0, 0q�5P      �� 5R      $
��Left=�5S      $��30(�5T      $
��Bold"�5U      ���#000000$4��./Fonts/OpenSans-Regular.ttf #Open Sans Regular)�5W      $��30, 50, 0, 0q�5X      ��5R       �� *JmlPelanggan+5X      5Y      5Z      5[      � 5\   
   $��2��6   .+�5]      �� 
�������$ 20��5_      $	��100��5`      $	��150��5a       5^      �� 	 �� $
 UserControlL�$ DataContext�._�5b      � .+�5c      �� $��Jumlah Transaksi��6    $
��Left=�5d      $��15(�5e      ���#323334$��SemiBold"�5g      $4��./Fonts/OpenSans-Regular.ttf #Open Sans Regular)�5h      $��15, 20, 0, 0q�5i      �� 5k      $
��Left=�5l      $��30(�5m      $
��Bold"�5n      ���#000000$4��./Fonts/OpenSans-Regular.ttf #Open Sans Regular)�5p      $��30, 50, 0, 0q�5q      ��5k       �� *JmlTransaksi+5q      5r      5s      5t      5u      5w      