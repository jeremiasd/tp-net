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
    /// Lógica de interacción para GrdEspecialidades.xaml
    /// </summary>
    public partial class GrdEspecialidades : Window
    {
        public Academia.Entidades.Colecciones.Especialidades oEspecialidades { get; set; }

        public GrdEspecialidades()
        {
            InitializeComponent();
        }

        public void cargarGrilla()
        {
            Academia.Negocio.Especialidades oEspecialidadesNegocio = new Academia.Negocio.Especialidades();
            this.oEspecialidades = oEspecialidadesNegocio.getAll();
            this.grdEsp.ItemsSource = this.oEspecialidades;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cargarGrilla();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Academia.Negocio.Especialidades oEspecialidadesNegocio = new Academia.Negocio.Especialidades();
           // oEspecialidadesNegocio.Delete(grdEsp.SelectedIndex + 1);
            cargarGrilla();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            //Adrian: Ver que parametros pasar al constructor
            ABM_Especialidades oABM = new ABM_Especialidades(Convert.ToInt32(grdEsp.SelectedIndex) + 1, "modificar");
            oABM.ShowDialog();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            //Adrian: Ver que parametros pasar al constructor
            ABM_Especialidades oABM = new ABM_Especialidades(grdEsp.Items.Count, "agregar");
            oABM.ShowDialog();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void grdEsp_GotFocus(object sender, RoutedEventArgs e)
        {
            btnEliminar.IsEnabled = true;
            btnModificar.IsEnabled = true;
        }
    }
}
