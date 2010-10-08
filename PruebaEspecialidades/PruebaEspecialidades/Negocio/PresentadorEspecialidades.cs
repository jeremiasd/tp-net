using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academia.Negocio
{
    public class PresentadorEspecialidades
    {
        public Academia.Negocio.VistaEspecialidades VistaEspecialidades { get; set; }

        public PresentadorEspecialidades()
        {
            Academia.Datos.EspecialidadDatos dEspecialidades = new Academia.Datos.EspecialidadDatos();

            this.VistaEspecialidades = new Negocio.VistaEspecialidades(dEspecialidades.getAll());
        }
    }
}
