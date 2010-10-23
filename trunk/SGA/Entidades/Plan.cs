using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Academia.Entidades;

namespace Academia.Entidades
{
    public class Plan
    {
        private int id_plan;
        private string desc_plan;
        private int anio_vigencia;
        private int id_especialidad;
        private Especialidad especialidad;

        #region Propiedades

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

        public string Desc_plan
        {
            get
            {
                return desc_plan;
            }
            set
            {
                desc_plan = value;
            }
        }

        public int Anio_vigencia
        {
            get
            {
                return anio_vigencia;
            }
            set
            {
                anio_vigencia = value;
            }
        }

        public int Id_especialidad
        {
            get
            {
                return id_especialidad;
            }
            set
            {
                id_especialidad = value;
            }
        }

        public Especialidad Especialidad
        {
            get
            {
                return especialidad;
            }
            set
            {
                especialidad = value;
            }
        }

        #endregion
    }
}
