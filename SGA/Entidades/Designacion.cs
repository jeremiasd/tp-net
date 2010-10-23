using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academia.Entidades
{
    public class Designacion
    {
        private int id_persona;
        private int id_materia;
        private DateTime fecha_inicio;
        private int id_cargo;
        private Curso curso;
        private Cargo cargo;
        private Profesor profesor;

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

        public int Id_materia
        {
            get
            {
                return id_materia;
            }
            set
            {
                id_materia = value;
            }
        }

        public DateTime Fecha_inicio
        {
            get
            {
                return fecha_inicio;
            }
            set
            {
                fecha_inicio = value;
            }
        }

        public int Id_cargo
        {
            get
            {
                return id_cargo;
            }
            set
            {
                id_cargo = value;
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

        public Profesor Profesor
        {
            get
            {
                return profesor;
            }
            set
            {
                profesor = value;
            }
        }

        public Cargo Cargo
        {
            get
            {
                return cargo;
            }
            set
            {
                cargo = value;
            }
        }
        #endregion Propiedades
    }
}
