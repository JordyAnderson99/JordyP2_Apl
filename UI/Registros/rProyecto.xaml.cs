using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using JordyP2_Apl.BLL;
using JordyP2_Apl.Entidades;

namespace JordyP2_Apl.UI.Registros
{
    public partial class rProyecto: Window
    {
        private Proyectos proyectos = new Proyectos();
        public rProyecto()
        {
            InitializeComponent();
            this.DataContext = proyectos;

            //ComboBox de Tipotarea
            TareaIdComboBox.ItemsSource = TareasBLL.GetList(s => true);
            TareaIdComboBox.SelectedValuePath = "TareaId";
            TareaIdComboBox.DisplayMemberPath = "TipoTarea";
           
        }
        // Funcion Cagar
        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = proyectos;
        }
        //Funcion Limpiar
        private void Limpiar()
        {
            this.proyectos = new Proyectos();
            this.DataContext = proyectos;
        }
        //Funcion Validar
        private bool Validar()
        {
            bool esValidado = true;
            if (ProyectoIdTextBox.Text.Length == 0)
            {
                esValidado = false;
                MessageBox.Show("Transaccion Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValidado;
        }
        //Boton Buscar
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Proyectos encontrado = ProyectoBLL.Buscar(proyectos.ProyectoId);

            if (encontrado != null)
            {
                proyectos = encontrado;
                Cargar();
            }
            else
            {
                MessageBox.Show($"Este pedido no fue encontrado.\n\nAsegurese que existe o cree uno nuevo.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                Limpiar();
                ProyectoIdTextBox.Clear();
                ProyectoIdTextBox.Focus();
            }
        }
        
        //Boton Nuevo
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
        //Boton Guardar
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (!Validar())
                    return;

                var paso = ProyectoBLL.Guardar(this.proyectos);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Transaccion Errada", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        //Boton Eliminar
        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (ProyectoBLL.Eliminar(Utilidades.ToInt(ProyectoIdTextBox.Text)))
                {
                    Limpiar();
                    MessageBox.Show("Registro Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("No se pudo eliminar", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        
    }
}