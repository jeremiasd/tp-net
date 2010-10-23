using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academia.Entidades
{
    public abstract class Persona
    {
        private int id_persona;
        private string tipo_documento;
        private string nro_documento;
        private string nombre;
        private string apellido;
        private string telefono;
        private string direccion;
        private string usuario;
        private string clave;
        private DateTime fecha_nacimiento;
        private int edad;

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

        public string Tipo_documento
        {
            get
            {
                return tipo_documento;
            }
            set
            {
                tipo_documento = value;
            }
        }

        public string Nro_documento
        {
            get
            {
                return nro_documento;
            }
            set
            {
                nro_documento = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }
            set
            {
                clave = value;
            }
        }

        public DateTime Fecha_nacimiento
        {
            get
            {
                return fecha_nacimiento;
            }
            set
            {
                fecha_nacimiento = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (DateTime.Today.Month > fecha_nacimiento.Month)
                {
                    edad = DateTime.Today.Year - fecha_nacimiento.Year;
                }
                else if (DateTime.Today.Month == fecha_nacimiento.Month)
                {
                    if (DateTime.Today.Day > fecha_nacimiento.Day)
                    {
                        edad = DateTime.Today.Year - fecha_nacimiento.Year;
                    }
                    else
                    {
                        edad = DateTime.Today.Year - fecha_nacimiento.Year - 1;
                    }
                }
                else
                {
                    edad = DateTime.Today.Year - fecha_nacimiento.Year - 1;
                }

            }
        }
        #endregion Propiedades
    }
}
