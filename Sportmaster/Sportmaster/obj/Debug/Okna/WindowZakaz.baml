   M S B A M L   `   `   `  ����F  BSportmaster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Sportmaster.OknaSportmaster.Okna  5   	   "    Sportmaster.Okna.WindowZakaz   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Sportmaster.Okna     5   	     � Title$  
Заказ��5   	   $	��450��6   $	��800��6$   $	��450��60   $	��800��6@   $	��450��6O   $	��800��6_    � WindowStyle$
 None=�6n   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��51* �6   �� 5      $	��51* �6   �� 5      $
��327* �6   �� 5      $	��51* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��326,5q�6.   $��Center=�6=   $��Center=�6Z   .+�5      �� $��Спортмастер��6   $��Center=�6+   $��Center=�6H   $��5q�6c   �� 5      $(��"/Resursi\Logotip\Снимок4.PNG��6   $��Center=�6:   $��Center=�6W   $��5q�6r   5      �� 5   
   -   5         ��Name$ btNazad��5      $��
Назад��6"   $��1��62   $��Right=�6?   $��Center=�6[   6v   �� 5   
   -   5         ��Name$ lbTovar��5      $��2��6   ��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $	��100 �6/   �� 5      $	��300 �6/   �� 5      $��* �6/   .+�5      �� ��6    �� *Foto+�� 5      $ Vertical=�6%   $��1��6<   .+�5       �� ��6(   �� *
Nazvanie+ �� StringFormat$ Название: {0}���� 5!      ��6(   �� *
Opisanie+$ Описание: {0}���� 5"      ��6(   �� *Proizvoditel.Nazvanie+$% Производитель: {0}���� 5#      ��6(   �� *Cena+$ Цена: {0} руб.��5$      �� 5%      $ btUdalenieIzZakaza��6!   -   5        $��2��5%   =   $$��Удалить из заказ��6M   6h   5&      5'      5)      �� 5*   
   $ Vertical=�6   $��3��6,   .+�5+      �� -   5         ��Name$ tbSumma��5+      $
��Left=�6)   $��Center=�6D   �� 5,      -   5        $ 
btSohranit��5,      $#��Сохранить заказ��6)   $��Right=�6C   $��Center=�6_   6z   5-      5.      5/      