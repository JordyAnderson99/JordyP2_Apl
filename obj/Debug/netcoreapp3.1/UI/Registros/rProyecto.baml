   M S B A M L   `   `   `  ����F  BJordyP2_Apl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:JordyP2_Apl.UI.RegistrosJordyP2_Apl.UI.Registros  5   	   (    "JordyP2_Apl.UI.Registros.rProyecto   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:JordyP2_Apl.UI.Registros     5   	     � Title$  Registro de Proyecto��5   	   $	��540��6&   $	��600��63   .��5
      � .+�5   
   �� $��
46,-40,0,0q�6   $��Center=�6+   $
��Left=�6F   $	��500��6b   $	��650��6n   .+�5      �� $��
ProyectoId��6   $
��15px(�6+   $��-390,125,1,1q�6;   $��SimSun-ExtB)�6Q   $��Normal$�6j   $��90��6}   �� 5      -   5         ��Name$ ProyectoIdTextBox��5      $��50��6P   $��25��6[   $��-220,-25,0,0q�6g   ��63   �� *
ProyectoId+6g   �� 5      -   5         ��Name$ BuscarButton��5      $��210,-40,0,0q�6,   $	��120��6A   $��40��6O   $��     Buscar��6]   $
��Bold"�6t   6�   �� 5      $��/Imagenes/Buscar.png��6   $��30��63   $��30��6>   $��140,-40,0,0q�6K   �� 5      $��Fecha��6   $��13.5px(�6&   $��-430,10,0,0q�68   $��SimSun-ExtB)�6M   $��Normal$�6f   $��48��6y   $��24��6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ FechaDatePicker��5      $	��160��6T   $��25��6`   $��-110,-20,0,0q�6l      SelectedDate 64   �� *Fecha+6l   �� 5      $��Descripcion��6   $
��15px(�6,   $��-390,10,1,1q�6<   $��SimSun-ExtB)�6Q   $��Normal$�6j   $��93��6}   �� 5      -   5        $ DescripcionTextBox��5      $	��160��6R   $��50��6^   $��-110,-25,0,0q�6j   ��64   �� *Descripcion+6j   �� 5       �� Orientation$ Vertical=�6   .+�5      �� $��Detalle de Proyectos��6   $��0,5,0,0q�6:   .��5      �� .+�5"      �� $��
Tipo Tarea��6    $
��15px(�67   $��-390,10,1,1q�6G   $��SimSun-ExtB)�6\   $��Normal$�6u   $��91��6�   �� 5#      -   5         ��Name$ TipoTareaComboBox��5#   #   $	��120��6c   $��25��6o   $��-350,-5,0,0q�6{    �� SelectedValue 6@   �� *	TareaId+6{   �� 5&      $��Requerimiento de la tarea��6    $
��15px(�6G   $��-20,-65,1,1q�6W   $��SimSun-ExtB)�6l   $��Normal$�6�   $	��200��6�   $��25��6�   �� 5'      -   5        $ RequerimientoTextBox��5'   "   $	��190��6b   $��25��6n   $��-20,-25,0,0q�6z   ��6B   �� *Requerimiento+6z   �� 5+      $��Tiempo(minutos)��6    $
��15px(�6=   $��300,-65,1,1q�6M   $��SimSun-ExtB)�6b   $��Normal$�6{   $	��121��6�   $��25��6�   �� 5,      -   5        $ TiempoTextBox��5,   "   $	��140��6V   $��25��6b   $��330,-25,0,0q�6n   ��6;   �� *
Cantidad+6n   �� 5/      $ 
Horizontal=�6%   .+�51      �� -   5        $ AgregarFilaButton��51   %   $��	10,10,0,0q�6@   .��52   "   �� $ 
Horizontal=�6-   .+�53   &   �� $��/Imagenes/Mas.png��6,   $��25��6G   �� 54   &   $��Agregar fila��6,   $
��Bold"�6C   55   #   56      �� 58      -	   5        $ EliminarFilaButton��58   %   $��
220,10,0,0q�6A   .��59   "   �� $ 
Horizontal=�6-   .+�5:   &   �� $��/Imagenes/Menos.png��6,   $��25��6I   �� 5;   &   $��Eliminar fila��6,   $
��Bold"�6D   5<   #   5=      5?      &   System.Windows.Controls.DataGrid  5A      -
   5          Name$ DetalleDataGrid��5A   #   	   
IsReadOnly$
	 true��6=   $	��100��6O   
   AutoGenerateColumns$
 False��6\   $��0,10,0,0q�6�   ��6x   �� *	Detalle+   Columns 5B      0  *System.Windows.Controls.DataGridTextColumn  5C   "   ,  &System.Windows.Controls.DataGridColumn   Header$         TipoId     ��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   �� *	TareaId+  5D   "   $         Tipo Tarea    ��65    6U   �� *tipo.TipoTarea+  5E   "   $* $           Requerimiento            ��65    6c   �� *Requerimiento+  5F   "   $          Tiempo         ��65    6W   �� *Tiempo+5H      5J      5K      �� 5M      $ 
Horizontal=�6   .+�5O      �� $��Tiempo Total��6   $��
330,15,0,0q�63   $
��15px(�6G   $��SimSun-ExtB)�6W   �� 5P      -   5        $ TiempoTotalTextBox��5P      $��25��6X   $��60��6d    �� 
IsReadOnly$
 True��6o   $��8,15,0,0q�6�   ��6:   �� *TiempoTotal+6�   5Q      5R      �� 5W      -   5        $ NuevoButton��5W      $��-320,20,0,0q�6+   $	��100��6@   $��40��6N   $��        Nuevo��6\   $
��Bold"�6v   6�   �� 5X      $��/Imagenes/Nuevo.png��6   $��40��62   $��40��6=   $��-380,-40,0,0q�6J   �� 5[      -   5        $ GuardarButton��5[      $��-15,-40,0,0q�6-   $	��100��6B   $��40��6P   $��        Guardar��6^   $
��Bold"�6z   6�   �� 5\      $��/Imagenes/Guardar.jpg��6   $��35��64   $��35��6?   $��-75,-40,0,0q�6L   �� 5_      -   5        $ EliminarButton��5_      $��300,-40,0,0q�6.   $	��100��6C   $��40��6Q   $��          Eliminar��6_   $
��Bold"�6~   6�   �� 5`      $��/Imagenes/Eliminar.png��6   $��40��65   $��40��6@   $��240,-40,0,0q�6M   5a      5b      5c      