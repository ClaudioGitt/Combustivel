   M S B A M L   `   `   `  ����N  JMeuCombustivel.VIEW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MeuCombustivelMeuCombustivel  5   	       MeuCombustivel.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MeuCombustivel     5   	   -   5          � Title$  
MainWindow��5   	   $	��600��6   $	��500��6)   .��5	      � -   5         �Name$ combustivelGrid��5	       � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5      $��0* �6   �� 5      $��0* �6   �� 5      $��0* �6   �� 5      .+�5   
   �� -   5         ��Name$ btnCalcular��5      $��Calcular��6&   $��
37,375,0,0q�69   $��30��6M   $��98��6Y   $
��Left=�6d   $	��Top=�6   $��5��6�   6�   �� 5   
   -   5         ��Name$ labelAutomovel��5      $��Modelo/Automóvel��6(   $
��Left=�6C   $��	37,49,0,0q�6^   $	��Top=�6q   $��5��6�   �� 5   
   -   5        $ labelTipoCombustivel��5      $��Tipo de Combustivel��6.   $
��Left=�6L   $��
188,49,0,0q�6g   $	��Top=�6{   $��5��6�   �� 5   
   -   5         ��Name$ txtCarro��5      $��5��6$   $
��Left=�68   $��	26,80,0,0q�6S    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ txtCombustivel��5      $��5��6*   $
��Left=�6>   $��
187,80,0,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ labelConsumo��5      $��Consumo/Litro��6&   $��5��6>   $
��Left=�6R   $��
37,120,0,0q�6m   $	��Top=�6�   �� 5   
   -	   5        $ labeldistancia��5      $��	Distancia��6(   $��5��6<   $
��Left=�6P   $��209,120,0,0q�6k   $	��Top=�6�   �� 5   
   -
   5        $ 
txtConsumo��5      $��5��6&   $
��Left=�6:   $��
26,166,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5   
   -   5        $ txtDistancia��5      $��5��6(   $
��Left=�6<   $��187,166,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   &   System.Windows.Controls.DataGrid  5   
   5      5      