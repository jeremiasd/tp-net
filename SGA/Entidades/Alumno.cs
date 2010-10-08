using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Academia.Entidades;

namespace Academia.Entidades
{
    public class Alumno : Persona
    {
        private string legajo;
        private int anio_inicio;
        private string estado_academico;
        private int id_especialidad;
        private Especialidad especialidad;

        #region Propiedades
        public string Legajo
        {
            get
            {
                return legajo;
            }
            set
            {
                legajo = value;
            }
        }

        public int Anio_inicio
        {
            get
            {
                return anio_inicio;
            }
            set
            {
                anio_inicio = value;
            }
        }

        public string Estado_academico
        {
            get
            {
                return estado_academico;
            }
            set
            {
                estado_academico = value;
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
        #endregion Propiedades


    }
}
