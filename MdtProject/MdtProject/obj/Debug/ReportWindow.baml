   M S B A M L   `   `   `  ����E  AMdtProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MdtProject
MdtProject  5   	       MdtProject.ReportWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MdtProject     5   	     � Title$  ReportWindow��5   	   $	��600��5	   	   $	��800��6   .��5      � ��5   
   �� 5       �� ImageSource$  /medication background.jpg��6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ reportTitle��5      $��Adherence Report��6)   $��36(�5      $
��Bold"�6   
���<��
�������$��Stretch=�5      $��Center=�6.   $��20q�5       �� TextAlignment$ Center=�6   $��0��63   �� 5"   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   $��Center=�5#      $��20q�6,   $��1��68   .+�5$      �� -   5         ��Name$ exportPdfButton��5$      $��Export to PDF��6.   $��Georgia)�5%      ���	#FFBBABE0$��10q�6=   �� 5&      -   5        $ exportCsvButton��5&      $��Export to CSV��6.   $��Georgia)�5'      ���	#FFBBABE0$��10q�6=   5(      � 5+   
   $��2��6   $��20q�6   ���	#FFD96F6F 5,      �� 5-      $
��Auto �6    �� 5.      $��* �6    .+�50      �� -   5        $ 	pageTitle��50      $��Reports��6+   $��Georgia)�51      $��18(�6)   ���	#FFD96F6F
�������$��Stretch=�53      $��Center=�62    �� Padding$ 10q�54      $��0��6!   &   System.Windows.Controls.DataGrid  55      -   5          Name$ reportDataGrid��55      	   AutoGenerateColumns	 . $��10q�56      ���	#FFC8A8C9$��1��66   57      58      5:      