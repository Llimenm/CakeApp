   M S B A M L   `   `   `  ����B  >CakeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CakeAppCakeApp  5   	       CakeApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CakeApp     5   	   -   5          � Title$  CakeApp��5   	   $	��600��5	   	   $	��800��5
   	   $	��600��5   	   $	��800��5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	    � Icon$ cake.png��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � ���#b8fef3 � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $	��266 �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $	��20* �6   �� 5      $	��10* �6   �� 5      $	��40* �6   .+�5   
   �� $��1��5      $��0��5      ���#b965c6$��32(�5!      $��Right=�5"      $��Bottom=�5#      $��0,0,5,13q�5$      Login5&      �� 5'   
   $��2��5(      $��0��5)      ���#b965c6$��32(�5+      $��Right=�5,      $	��Top=�5-      $��0,13,5,0q�5.      
Password50      �� 51   
   -   5         ��Name$ Login_TextBox��52      $��1��53      $��1��54      $	��240��55      $��40��56      ���#b965c6$
��Left=�58      $��Bottom=�59      $��13q�5:      $��32(�5;       �� TextAlignment$
 Left=�5<      ���#a4adee.��5>   '   5?      G� 5@   
   -   5         G�Name$ PasswordBox��5A      $��2��5B      $��1��5C      $	��240��5D      $��40��5E      ���#b965c6$
��Left=�5G      $	��Top=�5H      $��13q�5I      $��32(�5J      ���#a4adee5L      �� 5M   
   -   5        	 ��Name$	 Login_button��5N      $��1��5O      $��3��5P      $	��Top=�5Q      $
��Left=�5R      $��7q�5S      .��63   Login5U      �� 5V   
   -   5        $	 Registration_button��5W      $��1��5X      $��3��5Y      ���#a4adee���#b965c6$��40��5\      $	��122��5]      $��20(�5^      $	��Top=�5_      $��Right=�5`      $��7q�5a      .��6:   Registration5c      5d      5e      