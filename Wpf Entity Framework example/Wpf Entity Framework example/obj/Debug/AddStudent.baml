   M S B A M L   `   `   `  ����W  SWpf Entity Framework example, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Wpf_Entity_Framework_exampleWpf_Entity_Framework_example  5   	   -    'Wpf_Entity_Framework_example.AddStudent   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:Wpf_Entity_Framework_example     5   	     � Title$  
AddStudent��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   5      �� 5      $��3* �6   5      .+�5   
   �� ���#8D68B6$��0��6&   ._�5      �� $��Center=�6    �� Orientation$ Vertical=�66   .+�5      �� $��Center=�6   $��WPF EF EXAMPLE��65   6P   �� 5      
�������$��Öğrenci Ekle��62   $��0q�6I   ���#4A4A4A$��0,20,0,0q�6r   $��Center=�6�   $	��120��6�   $��30��6�   5      �� 5      
�������$��Öğrenci Sil��62   $��0q�6H   ���#4A4A4A$��0,20,0,0q�6q   $��Center=�6�   $	��120��6�   $��30��6�   5      �� 5       
�������$��Öğrenci Düzenle��62   $��0q�6L   ���#4A4A4A$��0,20,0,0q�6u   $��Center=�6�   $	��120��6�   $��30��6�   5"      �� 5$      -   5         ��Name$ btnExit��5$      
�������$��Çıkış yap��6D   $��0q�6X   ���#4A4A4A$��0,20,0,0q�6�   $��Center=�6�   $	��120��6�   $��30��6�    � Cursor$
 Hand��6�   5%      5(      �� 5*   
   $��1��6   ���#4A4A4A._�5+      �� $ Vertical=�6   .+�5,      �� -   5         ��Name$ tboxName��5,   I   $��250px��6   $
��20px��6(   $��	0,10,0,10q�66   6]   �� 5-      -   5        $ tboxSurname��5-   I   $��250px��6   $
��20px��6(   $��	0,10,0,10q�66   6`   G� 5.      -   5         G�Name$ tboxPassword��5.   M   $��250px��6   $
��20px��6,   $��	0,10,0,10q�6:   6e   �� 5/      -   5        $ tboxMail��5/   I   $��250px��6   $
��20px��6(   $��	0,10,0,10q�66   6]   �� 50      -   5        $ tboxSchoolNo��50   J   $��250px��6   $
��20px��6)   $��	0,10,0,10q�67   6b   �� 52      -   5        $��250px��52      $
��50px��6'   $��	0,10,0,10q�65   .��6]   Ekle6c   53      56      57      58      