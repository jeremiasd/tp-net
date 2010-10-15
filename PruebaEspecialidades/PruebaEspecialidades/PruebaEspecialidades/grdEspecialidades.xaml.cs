using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Academia.Escritorio
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class grdEspecialidades : Window
    {
        public Academia.Negocio.PresentadorEspecialidades oPresentadorEspecialidades { get; set; }
        public grdEspecialidades()
        {
            InitializeComponent();
            oPresentadorEspecialidades = new Academia.Negocio.PresentadorEspecialidades();
            this.DataContext = oPresentadorEspecialidades.VistaEspecialidades;
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void grdEsp_GotFocus(object sender, RoutedEventArgs e)
        {
            oPresentadorEspecialidades.habilitarEdicion();
        }
    }
}
