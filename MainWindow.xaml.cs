using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using JordyP2_Apl.UI.Registros;
using JordyP2_Apl.UI.Consulta;

namespace JordyP2_Apl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegistroProyectoButton_Click(object sender, RoutedEventArgs e){
            rProyecto rProyecto = new rProyecto();
            rProyecto.Show();
        }

        private void ConsultaProyectoButton_Click(object sender, RoutedEventArgs e){
           cProyecto cProyecto = new cProyecto();
            cProyecto.Show();
        }
    }
}
