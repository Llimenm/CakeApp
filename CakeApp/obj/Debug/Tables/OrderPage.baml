   M S B A M L   `   `   `  ����B  >CakeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CakeApp.TablesCakeApp.Tables  5          CakeApp.Tables.OrderPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:CakeApp.Tables     5        N� Title$  	OrderPage��5
       � 	Resources 5       �� 
TargetType �� Property �� Value��%|   '��       �� 5   
   " ��6   .�5      ��  � ��$
 Left=�64   �� 5       � ��$ Center=�62   5      5      .��5      � ���#b8fef3 � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��132 �6   �� 5      $	��132 �6   �� 5      $	��132 �6   �� 5      $	��132 �6   �� 5      $	��132 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ refreshTableButton��5"      $��0��5       $��0��5!       � ToolTip$9 3Обновление данных в таблице��5#      $��Center=�5$      $��Center=�5%      $��Обновить��5&      5'      �� 5)   
   -   5        $ addTableButton��5,      $��1��5*      $��0��5+      $2 ,Добавление новой строки��5-      $��Center=�5.      $��Center=�5/      $��Добавить��50      52      �� 54   
   -   5        $ deleteTableButton��57      $��2��55      $��0��56      $@ :Сохранение внесенных изменений��58      $��Center=�59      $��Center=�5:      $��Удалить��5;      5<      �� 5>   
   -   5        $ editTableButton��5A      $��3��5?      $��0��5@      $@ :Сохранение внесенных изменений��5B      $��Center=�5C      $��Center=�5D      $��Изменить��5E      5G      �� 5I   
   -   5        	 ��Name$	 listBoxForTable��5J      $��1��5K      $��0��5L      $��6��5M      ���#b8fef3��5P      �� 5Q      .R�5R      �  5S      �� 5T      $��* �6/   �� 5U      $��30 �6/   �� 5V      $��* �6/   �� 5W      $��30 �6/   �� 5X      $��* �6/    5Z      �� 5[      $��16 �6,   �� 5\      $��16 �6,   �� 5]      $��16 �6,   .+�5`      �� $��0��6$   $��0��64   ��6A   �� 
 �� Path$
 
Номер� �� StringFormat$ Номер: {0}���� 5a      $��0��6$   $��1��64   ��6A   �� $
 Дата�$  Дата заказа: {0}���� 5b      $��0��6$   $��2��64   ��6A   �� $+
 %Наименование_заказа�$ Имя заказа: {0}���� 5c      $��2��6$   $��0��64   ��6A   �� $
 Изделие�$ Изделие: {0}���� 5d      $��2��6$   $��1��64   ��6A   �� $
 Заказчик�$ Заказчик: {0}���� 5e      $��2��6$   $��2��64   ��6A   �� $1
 +Ответственный_менеджер�$ Менеджер: {0}���� 5f      $��4��6$   $��0��64   ��6A   �� $
 Стоимость�$ Стоимость: {0}���� 5g      $��4��6$   $��1��64   ��6A   �� $4
 .Плановая_дата_завершения�$9 3Плановая дата завершения: {0}���� 5h      $��4��6$   $��2��64   ��6A   �� $
 Примеры_работ�$$ Пример работы: {0}��5j      5k      5m      5n      5o      