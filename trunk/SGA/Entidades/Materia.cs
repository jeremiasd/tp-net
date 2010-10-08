using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academia.Entidades
{
    public class Materia
    {
        private int id_materia;
        private string nombre_materia;
        private int nivel;
        private bool electiva;
        private string regimen_cursado;
        private int id_plan;
        private int cant_horas_semanales;
        private int cant_horas_anuales;
        private Plan plan;

        #region Propiedades
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

        public string Nombre_materia
        {
            get
            {
                return nombre_materia;
            }
            set
            {
                nombre_materia = value;
            }
        }

        public int Nivel
        {
            get
            {
                return nivel;
            }
            set
            {
                nivel = value;
            }
        }

        public bool Electiva
        {
            get
            {
                return electiva;
            }
            set
            {
                electiva = value;
            }
        }

        public string Regimen_cursado
        {
            get
            {
                return regimen_cursado;
            }
            set
            {
                regimen_cursado = value;
            }
        }

        public int Id_plan
        {
            get
            {
                return id_plan;
            }
            set
            {
                id_plan = value;
            }
        }

        public int Cant_horas_semanales
        {
            get
            {
                return cant_horas_semanales;
            }
            set
            {
                cant_horas_semanales = value;
            }
        }

        public int Cant_horas_anuales
        {
            get
            {
                return cant_horas_anuales;
            }
            set
            {
                cant_horas_anuales = value;
            }
        }

        public Plan Plan
        {
            get
            {
                return plan;
            }
            set
            {
                plan = value;
            }
        }
        #endregion Propiedades
    }
}
