   M S B A M L   `   `   `  ����H  DLaboratornaia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LaboratornaiaLaboratornaia  5   	       Laboratornaia.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Laboratornaia     5   	     � Title$  Угрозы��5   	   $��928.2��6   $	��700��6&    � 
ResizeMode$ NoResize=�63    � WindowStartupLocation$ CenterScreen=�6I   .��5	      � .+�5
   
   �� -   5         ��Name$ DownloadButton��5
      $��Скачать файл��6)   $��
10,583,0,0q�6@   $��15(�6T   $��42��6z   $	��Top=�6�   $
��Left=�6�   $	��245��6�   
�������6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	mainTable��5         
IsReadOnly .    AutoGenerateColumns .  $��10,10,9.6,124.4q�6S      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6l      	RowHeight$ 33Q�6|    � 	Resources 5      )  #System.Windows.Controls.DataGridRow	 �� 
TargetType��%E   '        �� 5      "	  6   .�5      -   5        5      5      
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width$ 30 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *
ThreatID+   	CellStyle 5      �� 5      .�5      ��  �� Property � �� �� Value$ Center=�6U   5      5        5      $+ %Наименование угрозы��6%    6B   �� *Naming+6_   5      �� 5   
   -   5        $ updateFileButton��5      $'��!Обновление данных��6+   $��656,583,0,0q�6G   $��15(�6\   $��42��6j   $	��Top=�6v   $
��Left=�6�   $	��256��6�   
����� �6�   �� 5   
   -   5        $ savingButton��5      $%��Сохранение файла��6'   $��369,583,0,0q�6B   $��15(�6W   $��42��6�   $	��Top=�6�   $
��Left=�6�   $	��166��6�   
������6�   �� 5   
   -   5        $ previousButton��5      $��<��6)   $��Center=�68   $��0,0,846.6,105.4q�6U   $��Bottom=�6n   $��75��6�   6�   �� 5   
   -   5        $ 
nextButton��5      $��>��6%   $��Center=�64   $��837,0,9.6,100.4q�6Q   $��Bottom=�6j   $��75��6�   6�   �� 5    
   -   5         ��Name$ pageNumberText��5       $��Страница��6(   $��Center=�6;   $��Bottom=�6X   $��390,0,461.6,94.4q�6s   $��70��6�   �� 5!   
   $
��Left=�6   $��235,646,0,0q�6/   $
��Wrap=�6D   $���{чтобы получить полную информацию об угрозе - дважды кликните на неё��6X   $	��Top=�6�   $��24��6�   $	��430��6�   5"      5#      