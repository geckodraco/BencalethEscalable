using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaInicio
{
    abstract class Inventario
    {
        //variables
        private string _strDescripcion;
        public string strDescripcion
        {
            get { return _strDescripcion; }

            set
            {
                _strDescripcion = value;
            }
        }

        private int _intID;
        public string intID
        {
            get { return _intID.ToString(); }

            set {if(Herramientas.IsNumeric(value)) 
                _intID = Convert.ToInt16(value); }
        }

        private int _intCantidad;
        public string intCantidad
        {
            get { return _intCantidad.ToString(); }

            set {if(Herramientas.IsNumeric(value))
                _intCantidad = Convert.ToInt16(value); }
        }

        //funciones
        public abstract void IngresarProducto(Control lisControls);

        public abstract void EditarProducto(Control lisControls);

        public abstract void EliminarProducto(string strIDPa);

        public abstract void mostrarInventario(DataGridView dtgrdvw);
    }
}
