   M S B A M L   `   `   `  ����H  DLaboratornaia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LaboratornaiaLaboratornaia  5   	       Laboratornaia.UpdateTable   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Laboratornaia     5   	     � Title$%  Отчёт обновления��5   	   $
��1000��6"   $
��1360��60    � WindowStartupLocation$ CenterScreen=�6=   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ oldTable��5
         AutoGenerateColumns .     
IsReadOnly .    CanUserAddRows .  $
��Left=�6j   $	��430��6�   $��	10,35,0,0q�6�   $	��Top=�6�   $
��1332��6�      CanUserResizeRows .     CanUserDeleteRows .     	RowHeight$	 100Q�6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *Id+6U     5      $
 Описание��6%   $	 500 67    6C   �� *Description+   ElementStyle 5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$
 Wrap=�6=   6L   5      5        5      $
 Источник��6%   $	 100 67    6C   �� *Source+ 5      �� 5      " ��6    .�5      ��  � ��$
 Wrap=�6=   6L   5      5        5      $6
 0Объект воздействия угрозы��6%   $	 170 6H    6T   �� *Target+ 5      �� 5      " ��6    .�5      ��  � ��$
 Wrap=�6=   6L   5      5!        5"      $=
 7Нарушение конфиденциальности��6%   $	 200 6K    6W   �� *Confidentiality+6}     5#      $/
 )Нарушение целостности��6%   $	 150 6D    6P   �� *	Integrity+6p     5$      $/
 )Нарушение доступности��6%   $	 150 6D    6P   �� *Availability+6s   5&      �� 5'   
   $��Было��6   $
��Left=�6   $��10,0,0,0q�6:   $	��Top=�6L   $��20(�6d   $��35��6r   �� 5(   
   $��
Стало��6   $
��Left=�6    $��	0,486,0,0q�6;   $	��Top=�6N   $��20(�6f   $��36��6t     5)   
   -   5        $ newTable��5)       .   .  .  $
��Left=�6j   $	��430��6�   $��
10,527,0,0q�6�   $	��Top=�6�   $
��1332��6�    .   .  $	 100Q�6�   	 5*        5+      $
 Id��6%   $ 50 61    6<   �� *Id+  5,      $
 Описание��6%   $	 500 67    6C   �� *Description+ 5-      �� 5.      " ��6    .�5/      ��  � ��$
 Wrap=�6=   50      52        53      $
 Источник��6%   $	 100 67    6C   �� *Source+ 54      �� 55      " ��6    .�56      ��  � ��$
 Wrap=�6=   57      59        5:      $6
 0Объект воздействия угрозы��6%   $	 170 6H    6T   �� *Target+ 5;      �� 5<      " ��6    .�5=      ��  � ��$
 Wrap=�6=   5>      5@        5A      $=
 7Нарушение конфиденциальности��6%   $	 200 6K    6W   �� *Confidentiality+  5B      $/
 )Нарушение целостности��6%   $	 150 6D    6P   �� *	Integrity+  5C      $/
 )Нарушение доступности��6%   $	 150 6D    6P   �� *Availability+5E      5F      5G      