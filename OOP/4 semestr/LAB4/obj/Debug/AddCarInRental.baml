   M S B A M L   `   `   `  ����?  ;LAB4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LAB4LAB4  5   	       LAB4.AddCarInRental   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:LAB4     5   	   -   5          � Title$'  !Додати автомобіль��5   	   $��261.333��6#   $	��320��64    � WindowStyle$ 
ToolWindow=�6@    � WindowStartupLocation$ CenterScreen=�6Y    � 
ResizeMode$ NoResize=�6~   ��5	      �� 5
   
    �� ImageSource$6 0Black Background Hole - 2560x1600 by Freeman.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ Car_ComboBox��5      $��166,14,22,0q�6)   $��23��6>   $	��Top=�6J    �� SelectedIndex$ 0��6b   �� 5   
   -   5         ��Name$ NumberOfCar_TextBox��5      $
��Left=�6/   $��23��6J    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��113��6�   $��168,118,0,0q�6�   	 �� TextAlignment$	 Center=�6�   �� 5   
   -   5        $ Price_TextBox��5      $
��Left=�6)   $��23��6D   $
 Wrap=�6P   $	��Top=�6d   $	��113��6|   $��168,156,0,0q�6�   $	 Center=�6�   
 J� RenderTransformOrigin$
 0.478,0.507&�6�   �� 5   
   -   5        $ RentalPeriod_TextBox��5      $
��Left=�60   $��23��6K   $
 Wrap=�6W   $	��Top=�6k   $��82��6�   $��
199,84,0,0q�6�   $	 Center=�6�   �� 5   
   -   5         ��Name$ 
SaveButton��5      $��Зберегти��6%   $
��Left=�68   $	��Top=�6S   $��75��6k   $��
83,197,0,0q�6v   $
��Bold"�6�   6�   �� 5   
   -   5        $ CancelButton��5      $��Скасувати��6'   $
��Left=�6;   $	��Top=�6V   $��75��6n   $��164,197,0,0q�6y   $
��Bold"�6�   6�   �� 5   
   $,��&Дата початку прокату��6   $
��Left=�6/   $	��Top=�6J   $��	16,48,0,0q�6b   
�������$	��131��6�   �� 5   
   $2��,Вартість прокату ($/добу)��6   $
��Left=�64   $	��Top=�6O   $��
16,153,0,0q�6g   
�������6{   �� 5   
   $9��3Тривалість прокату (в добах)��6   $
��Left=�67   $	��Top=�6R   $��	16,81,0,0q�6j   $	��169��6}   
�������6�   �� 5   
   $%��Номер автомобіля��6   $
��Left=�6+   $	��Top=�6F   $��
16,115,0,0q�6^   
�������6r   �� 5   
   $)��#Оберіть автомобіль��6   $
��Left=�6-   $	��Top=�6H   $��	16,14,0,0q�6`   
�������6s   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ StartDate_DatePicker��5      $
��Left=�63   $	��Top=�6N   $��
164,50,0,0q�6f   $	��117��6z      SelectedDateFormat$ Short=�6�      IsTodayHighlighted .    Text$ Choose date��6�   5      5      