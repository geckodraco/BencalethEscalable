using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace PantallaInicio
{
    class EventoANotificar
    {
        //variables
        string strAsunto;
        string strAutor;
        string strTipo;
        string strFecha;
        string strID;
        int intTipo;

        //Constructor
        public EventoANotificar(string asu, string aut, string tipo, string fech, string ID, int intTip)
        {
            this.strAsunto = asu;
            this.strAutor = aut;
            this.strTipo = tipo;
            this.strFecha = fech;
            this.strID = ID;
            this.intTipo = intTip;
        }

        public string campo1 { get { return strAsunto; } set { strAsunto = value; } }
        public string campo2 { get { return strAutor; } set { strAutor = value; } }
        public string campo3 { get { return strTipo; } set { strTipo = value; } }
        public string campo4 { get { return strFecha; } set { strFecha = value; } }
        public string campo5 { get { return strID; } set { strID = value; } }

        public int Tipo { get { return intTipo; } set { } }
        //public void estoy() { MessageBox.Show("estoy" + strID, "estoy"); }
    }
}
