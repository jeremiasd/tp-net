using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academia.Entidades
{
    public class Cargo
    {
        private int id_cargo;
        private string desc_cargo;

        #region Propiedades
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

        public string Desc_cargo
        {
            get
            {
                return desc_cargo;
            }
            set
            {
                desc_cargo = value;
            }
        }
        #endregion Propiedades
    }
}
