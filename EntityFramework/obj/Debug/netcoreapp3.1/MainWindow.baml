   M S B A M L   `   `   `  ����J  FEntityFramework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EntityFrameworkEntityFramework  5   	        EntityFramework.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:EntityFramework     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $	��.3* �6   �� 5      $��2* �6   �� 5      $��1* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ 
btnFiltrar��5      $��Filtrar��6)   $��8q�6;   $��	24,0,24,0q�6F   �� 5      -   5         ��Name$ 	cbFiltres��5      $��8q�6*   $	��150��65   .@�5      �� $��Per Categoria��6   �� 5      $��Per Country��6   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgPelis��5      $��1��6$   $��8q�61   �� 5   
   -   5         ��Name$ tbDescripcio��5      $��2��6(   $��8q�65    �� 
IsReadOnly$
 True��6@   5      5      