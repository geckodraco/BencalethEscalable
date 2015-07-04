using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PantallaInicio
{
    public abstract class Personas
    {
        private int _Codigo_Persona;
        public virtual string Codigo_Persona
        {
            get
            {
                return _Codigo_Persona.ToString();
            }
            set
            {
                if (Herramientas.IsNumeric(value))
                    _Codigo_Persona = Convert.ToInt16(value);
            }
        }

       private string _Nombre;
       public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value;
         }
        }

       public DateTime _Fecha_Nacimiento;
         public DateTime  Fecha_Nacimiento
        {
            get
            {
                return _Fecha_Nacimiento;
            }
            set
            {
                _Fecha_Nacimiento = value;
         }
        }
        public abstract void ingresarDatos(Control controles);
        public abstract void actualizarDatos(Control controles);
        public abstract void DeleteDatos(string ID);
        public abstract void mostrarDatos(DataGridView dtgrdvw,TextBox txtbBuscado);
    }
}
