using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaInicio
{
    class HorasVoluntarios
    {
        //variables
        private int _intHorasIni;
        public string intHorasIni
        {
            get { return _intHorasIni.ToString(); }

            set
            {
                if (Herramientas.IsNumeric(value))
                    _intHorasIni = Convert.ToInt16(value);
            }
        }

        private int _intHorasFin;
        public string intHorasFin
        {
            get { return _intHorasFin.ToString(); }

            set
            {
                if (Herramientas.IsNumeric(value))
                    _intHorasFin = Convert.ToInt16(value);
            }
        }

        private int _intHorasTot;
        public string intHorasTot
        {
            get { return _intHorasTot.ToString(); }

            set
            {
                if (Herramientas.IsNumeric(value))
                    _intHorasTot = Convert.ToInt16(value);
            }
        }

        //funciones
        public void CalcularHoras() {
            intHorasTot = (Convert.ToInt16(intHorasFin)-Convert.ToInt16(intHorasIni)).ToString();
        }
    }
}
