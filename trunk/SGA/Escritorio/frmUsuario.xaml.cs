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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Academia.Escritorio;

namespace Escritorio
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class frmUsuario : Window
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        //Evento que cierra la ventana principal
        void archivoSalirMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void archivoIngresarMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Login nuevoIngreso = new Login();
        }

    }
}
