using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academia.Entidades
{
    public class Especialidad
    {
        private int id_especialidad;
        private string desc_especialidad;

        #region Propiedades
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

        public string Desc_especialidad
        {
            get
            {
                return desc_especialidad;
            }
            set
            {
                desc_especialidad = value;
            }
        }
        #endregion

    }
}
