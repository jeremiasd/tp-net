using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academia.Entidades
{
    public class Curso
    {
        private int id_curso;
        private string comision;
        private string aula;
        private int cupo;
        private string turno;
        private int id_materia;
        private int anio_cursado;
        private Materia materia;

        #region Propiedades

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

        public string Comision
        {
            get
            {
                return comision;
            }
            set
            {
                comision = value;
            }
        }

        public string Aula
        {
            get
            {
                return aula;
            }
            set
            {
                aula = value;
            }
        }

        public int Cupo
        {
            get
            {
                return cupo;
            }
            set
            {
                cupo = value;
            }
        }

        public string Turno
        {
            get
            {
                return turno;
            }
            set
            {
                turno = value;
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

        public int Anio_cursado
        {
            get
            {
                return anio_cursado;
            }
            set
            {
                anio_cursado = value;
            }
        }


        public Materia Materia
        {
            get
            {
                return materia;
            }
            set
            {
                materia = value;
            }
        }
        #endregion
    }
}
