using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academia.Entidades
{
    public class Inscripcion
    {
        private int id_persona;
        private int id_curso;
        private DateTime fecha_hora_inscripcion;
        private Curso curso;
        private Alumno alumno;

        #region Propiedades
        public int Id_persona
        {
            get
            {
                return id_persona;
            }
            set
            {
                id_persona = value;
            }
        }

        public int Id_curso
        {
            get
            {
                return id_curso;
            }
            set
            {
                id_curso = value;
            }
        }

        public DateTime Fecha_hora_inscripcion
        {
            get
            {
                return fecha_hora_inscripcion;
            }
            set
            {
                fecha_hora_inscripcion = value;
            }
        }


        public Curso Curso
        {
            get
            {
                return curso;
            }
            set
            {
                curso = value;
            }
        }


        public Alumno Alumno
        {
            get
            {
                return alumno;
            }
            set
            {
                alumno = value;
            }
        }
        #endregion
    }
}
