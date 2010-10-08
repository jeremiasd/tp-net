using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academia.Negocio
{
    public class VistaEspecialidades
    {
        public Academia.Entidades.Especialidades ListaEspecialidades { get; set; }
        public Boolean PermiteEditar { get; set; }

        public VistaEspecialidades(Entidades.Especialidades listaEsp)
        {
            this.ListaEspecialidades = listaEsp;
        }
    }
}
