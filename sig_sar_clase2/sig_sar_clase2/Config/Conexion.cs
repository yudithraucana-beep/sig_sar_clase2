using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;


namespace sig_sar_clase2.Config
{
    public class ConexionDB
    {
        private static string obtenerCadenaConexion()
        {

            string cadenaConexion = @"Host=localhost; 
                                     Port=5432;
                                     Database=sig_sar_clase2;
                                     Username=postgres;
                                     Password=admin123";
            return cadenaConexion;
        }   
        
            


        public static NpgsqlConnection ObtenerConexionDB()
        {
            return new NpgsqlConnection(obtenerCadenaConexion());
        }
    }
    
}
