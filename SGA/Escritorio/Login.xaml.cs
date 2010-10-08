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
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            this.ShowDialog();
        }

        private void lblOlvideContraseña_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Usted es un usuario muy descuidado, por favor haga memoria\n" +
            "Si no la recuerda comuniquese con el administrador del sistema para gestionar su nueva clave");
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
