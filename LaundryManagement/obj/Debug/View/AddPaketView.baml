   M S B A M L   `   `   `  ����L  HLaundryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:LaundryManagement.ViewLaundryManagement.View  5      )    #LaundryManagement.View.AddPaketView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:LaundryManagement.View     5      ��5      �� 5   
     �� Triggers  5      :� 5       :� RoutedEvent$ UserControl.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� TargetProperty$ Opacity�6.    W� From$	 0.0X�5   .   	 W� To$	 1.0X�5   .    g� Duration$ 0:0:0.5D�5   .   5      5      5      5      .��5      � ���#1E1F22 � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $	��100 �6   �� 5       $	��100 �6   �� 5!      $	��100 �6   �� 5"      $��80 �6   .+�5$   
   � $��0��6   .+�5%      	� $��40��6   $��40��5&      $
��Left=�5'      $	��Top=�5(      
 � Tag$ Assets/back.png��5)         HomeButtonStyle#��[  5+      $��10q�5,      ��5*      ��  �� RelativeSource �� *FindAncestor+	 �� AncestorType"	 �
 �� Path$
 DataContext.BackPagePaket�5,      �� 5.      $��Tambah Paket��6   $��24(�5/      $4��./Fonts/OpenSans-Regular.ttf #Open Sans Regular)�50      ���#DDDDDD$
��Left=�52      $	��Top=�53      $��
50,12,10,0q�54      55      � 56   
   $��1��6   .+�57      �� $��Nama Paket :��58      ���#DDDDDD$.��(Fonts/Roboto-Regular.ttf #Roboto Regular)�5:      $��18(�5;      $��10q�5<      �� 5=      -   5         ��Name$ 	namaPaket��5>        SearchBoxStyle#��[ 5@      $
��Left=�5A      $
��10,0q�5B      ��5?      �� *	PaketName+ �� UpdateSourceTrigger$ PropertyChanged=�5B      5C      � 5D   
   $��2��6   .+�5E      �� $��Satuan Paket :��5F      ���#DDDDDD$.��(Fonts/Roboto-Regular.ttf #Roboto Regular)�5H      $��18(�5I      $��10q�5J      �� 5K      -   5        $ satuanPaket��5L      #��[ 5N      $
��Left=�5O      $
��10,0q�5P      ��5M      �� *SatuanPaket+$ PropertyChanged=�5P      5Q      � 5R   
   $��3��6   .+�5S      �� $��Harga Paket :��5T      ���#DDDDDD$.��(Fonts/Roboto-Regular.ttf #Roboto Regular)�5V      $��18(�5W      $��10q�5X      �� 5Y      -   5        $ 
hargaPaket��5Z      #��[ 5]      $
��Left=�5^      $
��10,0q�5_      ��5\      �� *
HargaPaket+$ PropertyChanged=�5_      5`      � 5a   
   $��4��6   .+�5b      �� $��Tambah Paket��5c      $��40��5d      $	��120��5e        btnBlue#��[ 5f      $
��Left=�5h      $
��30,0q�5i      ��5g      �� *ButtonAddPaketCommand+5i      5j      5k      5m      