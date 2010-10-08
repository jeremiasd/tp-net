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
    /// Lógica de interacción para ABM_Especialidades.xaml
    /// </summary>
    public partial class ABM_Especialidades : Window
    {
        public Entidades.Especialidad oEsp { get; set; }
        protected string modo;
        protected Negocio.Especialidades nEsp;

        public ABM_Especialidades(int id, string modo)
        {
            nEsp = new Negocio.Especialidades();
            InitializeComponent();
            oEsp = new Entidades.Especialidad();
            this.DataContext = oEsp;

            
           
            if (modo == "agregar")
            {
                this.Title = "Agregar una nueva especialidad";
                oEsp.Id_especialidad = id;
            }
            else //modo == "modificar"
            {
                this.Title = "Modificar Especialidad";
                oEsp.Id_especialidad = id;
            }
        }





        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Academia.Negocio.Especialidades oEspecialidad = new Academia.Negocio.Especialidades();

            if (modo == "agregar")
            {
                oEspecialidad.add(this.oEsp);
            }


        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
