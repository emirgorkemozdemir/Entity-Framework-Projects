   M S B A M L   `   `   `  ����W  SWpf Entity Framework example, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Wpf_Entity_Framework_exampleWpf_Entity_Framework_example  5   	   -    'Wpf_Entity_Framework_example.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:Wpf_Entity_Framework_example     5   	   -   5          � Title$  
MainWindow��5   	   $��Bahnschrift)�63   $	��450��6L   $	��800��6Y    � AllowsTransparency .  � WindowStyle$
 None=�6   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   5      �� 5      $��3* �6   5      .+�5   
   �� ���#8D68B6$��0��6&   ._�5      �� $��Center=�6    �� Orientation$ Vertical=�66   .+�5      �� $��Center=�6   $��WPF EF EXAMPLE��65   6P   �� 5      -   5        
�������$��Öğrenci Ekle��5   2   $��0q�6I   ���#4A4A4A$��0,20,0,0q�6r   $��Center=�6�   $	��120��6�   $��30��6�   5      �� 5      
�������$��Öğrenci Düzenle��62   $��0q�6L   ���#4A4A4A$��0,20,0,0q�6u   $��Center=�6�   $	��120��6�   $��30��6�   5      �� 5       -   5         ��Name$ btnExit��5       
�������$��Çıkış yap��6D   $��0q�6X   ���#4A4A4A$��0,20,0,0q�6�   $��Center=�6�   $	��120��6�   $��30��6�    � Cursor$
 Hand��6�   5!      5$      �� 5&   
   $��1��6   ���#4A4A4A._�5'      �� $ Vertical=�6   .+�5(      �� $��0,0,0,0q�6   .+�5)      &   System.Windows.Controls.DataGrid  -   5        $��datagrid��5)   .   $��250px��6   6>   5,      �� 5.      $ 
Horizontal=�6   .+�5/      �� $��	0,0,100,0q�6!   $ Vertical=�64   .+�50      �� -   5        
�������$��Öğrenci Sil��50   :   $��0q�6P   ���#8D68B6$��0,20,0,0q�6y   $��Center=�6�   $	��120��6�   $��30��6�   54      57      �� 5;      $ 
Horizontal=�6%   .+�5<      �� $ Vertical=�6%   .+�5=      �� -   5         ��Name$ tboxName��5=   U   $��250px��6&   $
��20px��64   $��	0,10,0,10q�6B   6i   �� 5>      -   5        $ tboxSurname��5>   U   $��250px��6&   $
��20px��64   $��	0,10,0,10q�6B   6l   G� 5?      -   5         G�Name$ tboxPassword��5?   Y   $��250px��6*   $
��20px��68   $��	0,10,0,10q�6F   6q   �� 5@      -	   5        $ tboxMail��5@   U   $��250px��6&   $
��20px��64   $��	0,10,0,10q�6B   6i   �� 5A      -
   5        $ tboxSchoolNo��5A   V   $��250px��6'   $
��20px��65   $��	0,10,0,10q�6C   6n   5B      �� 5D      $ Vertical=�6%   .+�5E      �� -   5        
�������$��Öğrenci Düzenle��5E   >   $��0q�6X   ���#8D68B6$��0,20,0,0q�6�   $��Center=�6�   $	��120��6�   $��30��6�   5F      5G      5H      5O      5P      5S      5T      5U      