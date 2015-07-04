using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PantallaInicio.BencalethDataSetTableAdapters;

namespace PantallaInicio
{
    class Log
    {
        public static QueriesTableAdapter bd = new QueriesTableAdapter();

        public static string sesion;

        public static int aprobado = 0;
        public static int intentosActuales = 0;
        public static int intentosMax = 5;
        public static string NombreBlock = "";
        public static string IngresoUsuario(string nombre, string contraseña, string confirmacion, int cargo)
        {
            if (contraseña == confirmacion)
            {
                try
                {
                    bd.uspInsertUsuarios(nombre, contraseña, cargo);
                }
                catch (SqlException e)
                {
                    switch (e.Number)
                    {
                        case 2627:
                            return "El Nombre de usuario ya esta en uso.";
                            break;
                        default:
                            throw;
                    }

                }
                aprobado = 1;
                return "El usuario se agrego correctamente.";

            }
            else
            {
                return "Las Contraseñas son diferentes.";

            }

        }

        public static int? Validacion(string user, string pwd)
        {
            int? res = null;
            bd.ValidacionLogin(user, pwd, ref res);
            if (res == 0) { Bloqueo(user); }
            if (res == 1) { intentosActuales = 0; }

            return res;
        }

        public static void Bloqueo(string user)
        {
            int? Resultado = null;
            bd.loginblock(user, ref Resultado);
            if (Resultado == 1)
            {
                intentosActuales++;
                NombreBlock = user;

            }  
        }

        public static string Block(string user)
        {
            bd.block(user);
            return ("El usuario " + user + " a sido bloqueado,  por favor contacte a la administracion para mas informacion.");
        }

        public static string cambioContraseña(string comboUsuario, string contraseñaNew, string confirm)
        {

            if (contraseñaNew == confirm)
            {

                bd.Update_Contra_Usuarios2(comboUsuario, contraseñaNew);
                aprobado = 1;
                return "La contraseña se cambio exitosamente.";

            }
            else
            {
                aprobado = 0;
                return "Las contraseñas no coinciden";
            }



        }

        public static int? Cargo(string nombre) {
            int? cargo = 0;
            bd.CargoUsuario(nombre,ref cargo);

            return cargo;
        }
    }
}
