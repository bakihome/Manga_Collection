   M S B A M L   `   `   `  ����F  BWeebTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WeebTracker.ViewWeebTracker.View  5   	   #    WeebTracker.View.DetailWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WeebTracker.View     5   	     � Title$  DetailWindow��5   	   $	��450��6   $	��800��6+   .��5	      � $��20q�6    � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   �� $��0��6   $��0��6"   .+�5      �� $��Hauptinformationen��6   $��16(�62   $
��Bold"�6@   $��0,0,0,10q�6R   �� 5       �� Orientation$ 
Horizontal=�6   $��0,0,0,5q�62   .+�5      �� $	��120��6   $��Titel (deu):��6(   �� 5      -   5         ��Name$ TxtDetailTitelDeutsch��5      $��	One Piece��6;   $��SemiBold"�6L   5      �� 5      $ 
Horizontal=�6   $��0,0,0,5q�62   .+�5      �� $	��120��6   $��Titel (jap):��6(   �� 5      -   5        $ TxtDetailTitelJapanisch��5      $��ワンピース��6=   $��SemiBold"�6J   5      �� 5      $ 
Horizontal=�6   $��0,0,0,5q�62   .+�5      �� $	��120��6   $��Autor / Dir.:��6(   �� 5      -   5        $ TxtDetailAutorDirektor��5      $��Eiichiro Oda��6<   $��SemiBold"�6P   5      �� 5       $ 
Horizontal=�6   $��0,0,0,15q�62   .+�5!      �� $	��120��6   $��Abgeschlossen:��6(   �� 5"      -   5         ��Name$ ChkDetailAbgeschlossen��5"       d� 	IsChecked$ FalseY�6;   ${�False��6M   5#      �� 5$      $��Volumes / Staffeln��6   $��14(�5%      $
��Bold"�6   $��0,0,0,5q�6,   �� 5&      -   5         ��Name$ 
LstVolumes��5&      $	��186��5'   
   $��Center=�5)   
   $��Center=�5*   
   $	��148��6,   .@�5+      �� .��6   Band 16&   �� 5,      .��6   Band 26&   �� 5-      .��6   Band 36&   �� 5.      .��6   Band 46&   5/      50      �� 51   
   $��0��6   $��1��6"   $��20,0,0,0q�62   .+�52      �� -   5         ��Name$ ImgCover��52      $	��185��53      $	��180��54      $��Uniform=�55      $��0,0,0,10q�56      �� 57      $��Volume-Details��6   $��16(�6.   $
��Bold"�6<   $��0,0,0,10q�6N   �� 58      $ 
Horizontal=�6   $��0,0,0,5q�62   .+�59      �� $	��120��6   $��Name:��6(   �� 5:      -   5        $ 
TxtVolName��5:      $	��–��60   $��SemiBold"�69   5;      �� 5<      $ 
Horizontal=�6   $��0,0,0,5q�62   .+�5=      �� $	��120��6   $��Kapitel/Episoden:��6(   �� 5>      -   5        $ TxtVolCount��5>      $	��–��61   $��SemiBold"�6:   5?      �� 5@      $ 
Horizontal=�6   $��0,0,0,5q�62   .+�5A      �� $	��120��6   $��Erstausgabe:��6(   �� 5B      -	   5        $ ChkErstAusgabe��5B      ${�False��63   5C      �� 5D      $ 
Horizontal=�6   $��0,0,0,5q�62   .+�5E      �� $	��120��6   $��Menge:��6(   �� 5F      -
   5        $ 
TxtVolDate��5F      $	��–��60   $��SemiBold"�69   5G      �� 5H      $ 
Horizontal=�6   $��0,0,0,15q�62   .+�5I      �� $	��120��6   $��Einkaufspreis:��6(   �� 5J      -   5        $ TxtVolExtra��5J      $	��–��61   $��SemiBold"�6:   5K      �� 5L      -   5        $��Volume bearbeiten��5L      $	��150��5M      $
��Left=�5N      5O      5P      �� 5Q   
   $��1��6   $��0��6"   $��2��62   $ 
Horizontal=�5R      $
��Left=�6.   $��0,15,0,0q�6I   .+�5S      �� -   5        $��Info bearbeiten��5S      $	��120��5T      $��0,0,10,0q�5U      5V      �� 5W      -   5        $��Neue Volume/Season��5W      $	��150��5X      5Y      5Z      5[      5\      