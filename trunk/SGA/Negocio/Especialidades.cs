using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academia.Negocio
{
    public class Especialidades
    {
        public Datos.Especialidades oEspecialidadesDatos { get; set; }

        public Especialidades()
        {
            oEspecialidadesDatos = new Academia.Datos.Especialidades();
        }

        public Entidades.Colecciones.Especialidades getAll()
        {
            return oEspecialidadesDatos.getAll();
        }

        public Academia.Entidades.Colecciones.Especialidades getOne(int id_especialidad)
        {
            return oEspecialidadesDatos.getOne(id_especialidad);
        }

        public int add(Entidades.Especialidad esp)
        {
            return oEspecialidadesDatos.add(esp);
        }

        public void Delete(int id_especialidad)
        {
            oEspecialidadesDatos.Delete(id_especialidad);
        }


       
    }
}