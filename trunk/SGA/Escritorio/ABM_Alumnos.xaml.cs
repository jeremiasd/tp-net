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
    /// Lógica de interacción para ABM_Alumnos.xaml
    /// </summary>
    public partial class ABM_Alumnos : Window
    {
        public ABM_Alumnos()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            txtAnioIngreso.Text = null;
            txtApellido.Text = null;
            txtCelular.Text = null;
            txtClave.Text = null;
            txtDireccion.Text = null;
            txtEmail.Text = null;
            txtEstadoAcademico.Text = null;
            txtFechaNac.Text = null;
            txtNombre.Text = null;
            txtNroDoc.Text = null;
            txtRepetirClave.Text = null;
            txtTelefono.Text = null;
            txtUsuario.Text = null;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
