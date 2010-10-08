using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Web;

namespace Utilidades
{
    public class Configuracion
    {
        #region Metodos

        private static Configuration GetConfiguracion()
        {
            string path; //Path del archivo de configuracion
            Configuration config; //Objeto configuracion
            //verificamos entorno
            if (System.Web.HttpContext.Current == null)
            {
                //windows
                path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppDomain.CurrentDomain.FriendlyName);
                //abrimos configuracion windows
                config = System.Configuration.ConfigurationManager.OpenExeConfiguration(path);
            }
            else
            {
                //web
                path = System.Web.HttpContext.Current.Request.ApplicationPath;
                //abrimos configuracion web
                config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(path);
            }
            return config;
        }

        public static string GetValue(string key)
        {
            Configuration config;
            string value;
            try
            {
                //obtengo configuracion
                config = GetConfiguracion();
                try
                {
                    //obtengo el valor
                    value = config.AppSettings.Settings[key].Value;
                }
                catch (Exception ex)
                {
                    //si no existe creo una exception (KeyNotFoundException)
                    throw new Exception(String.Format("Error: la clave '{0}' no existe en el archivo de configuracion.", key), ex);
                }
                return value;
            }
            finally
            {
                config = null;
            }
        }

        #endregion
    }
}
