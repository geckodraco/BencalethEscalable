using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaInicio
{
    class Herramientas
    {
        //avisar a los comaneros del maxlenght

        public static int intPositionCursor=0;

        public static Form frmPrincipal=null;

        public static Form frmAnterior=null;

        public static Form frmActual=null;

        //variables para el split container
        public static Form frmContAnterior = null;

        public static Form frmContActual = null;

        public static void initProgramaGestionForms(Form frmPrl, Form frmAct) {
            Herramientas.frmPrincipal = frmPrl;
            Herramientas.frmActual = frmAct;
            Herramientas.frmAnterior = null;

            frmActual.Show();
            frmPrincipal.Hide();
        }

        public static void CerrarPrograma() {
            //Herramientas.frmActual.Close();
            Herramientas.frmActual.Dispose();
            Herramientas.frmPrincipal.Dispose();
        }

        public static void AbrirNuevoForm(Form frmNueva) {
            Herramientas.frmAnterior = Herramientas.frmActual;
            Herramientas.frmActual = frmNueva;
            frmActual.Show();
            frmAnterior.Dispose();
        }

        public static void AbrirEnContainerNewForm(Form frmNueva,Panel pnlContenedor)
        {
            
            Herramientas.frmContAnterior = Herramientas.frmContActual;
            Herramientas.frmContActual = frmNueva;

            if (frmContAnterior != null)
            {
                frmContAnterior.Close();
                frmContAnterior.Dispose();
            }

            frmContActual.TopLevel = false;
            pnlContenedor.Controls.Add(frmContActual);
            frmContActual.Show();
            frmContActual.BringToFront();

            //ventanaP = new IngresoPadrinos(fila);
            //ventanaP.TopLevel = false;
            //splitContainer1.Panel1.Controls.Add(ventanaP);
            //ventanaP.Show();
            //ventanaP.BringToFront();

        }

        public static Boolean HayCamposNull(Control ctrls) { 
            Boolean respuesta=false;

            foreach(Control ctrl in ctrls.Parent.Controls){
                if(ctrl is TextBox){
                    if (string.IsNullOrEmpty(ctrl.Text.ToString()) && (!((TextBox)ctrl).ReadOnly))
                    {
                        //MessageBox.Show("No se pueden dejar campos vacios");
                        //return true;
                        Herramientas.PintarErrores(ctrl);
                        respuesta = true;
                    }
                }
            }

            //return false;
            if (respuesta)
            {
                MessageBox.Show("No se pueden dejar campos vacios");
                return true;
            }
            else
                return false;
        }

        public static ErrorProvider errorPro=null;

        public static void LimpiarErrores()
        {
            if (errorPro != null)
            {
                errorPro.Clear();
            }
        }

        //public static void LimpiarErroresCtrl(Control ctrl)
        //{
        //    //((TextBox)ctrl).Clear();
        //}

        public static void PintarErrores(Control ctrl) {
            //errorPro.Clear();
            if(errorPro!=null){
                errorPro.SetError(ctrl, "No se pueden dejar campos vacios");
            }
        }

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        public static String determinarCualRadioButtonEsGenero(Control ctrl)
        {
            String strTagRegresar = "";
            foreach (Control revisando in ctrl.Parent.Controls)
            {
                if (revisando is RadioButton)
                {
                    if (((RadioButton)revisando).Checked)
                    {
                        if (revisando.Tag.ToString() == "f")
                        {
                            strTagRegresar = "Femenino";
                        }
                        else
                            strTagRegresar = "Masculino";
                    }
                }
            }

            return strTagRegresar;
        }

        public static Boolean EsSuficienteLarga(String strPalabra,int intLargoDeseado){
            if (strPalabra.Length < intLargoDeseado)
            {
                return false;
            }else
                return true;
        }

        public static void EstablecerPosicionCursor(Control ctrlTratar) {
            Herramientas.intPositionCursor = ((TextBox)ctrlTratar).SelectionStart;
            if (Herramientas.intPositionCursor - 1 < 0)
            {
                Herramientas.intPositionCursor = 0;
            }
            else
            {
                Herramientas.intPositionCursor = Herramientas.intPositionCursor - 1;
            }
            ((TextBox)ctrlTratar).SelectionStart = Herramientas.intPositionCursor;
        }

        public static void RegularPosicionCursor(Control ctrlTratar)
        {
            //info para evitar que el cursor se ponga al inicio de la oracion y se confuda con las oraciones de otros controles
            //se sugierre su uso conjunto con la funcion EstablecerPosicionCursor
            if (((TextBox)ctrlTratar).SelectionStart == 0 && ((TextBox)ctrlTratar).TextLength > 0)
            {
                ((TextBox)ctrlTratar).SelectionStart = intPositionCursor;
            }
            //end info
        }

        public static String NingunEspacioInicial(String strRegresar)
        {
            if (strRegresar.IndexOf(" ") == 0)
            {
                strRegresar = strRegresar.Remove(strRegresar.IndexOf(" "), 1);
                Herramientas.intPositionCursor = 0;
            }

            return strRegresar;
        }

        public static String SoloLetrasYEspaciosSec(Control ctrlRegresar) {
            String strRegresar = ctrlRegresar.Text;

            strRegresar = Herramientas.NingunCharEspecialExpEspaciosSecundarios(ctrlRegresar);

            foreach(Char chRevisando in strRegresar.ToCharArray()){
                if (chRevisando != ' '){
                    if (!Char.IsLetter(chRevisando)){
                        strRegresar = strRegresar.Replace(chRevisando.ToString(), "");
                        Herramientas.EstablecerPosicionCursor(ctrlRegresar);
                    }
                }
            }
            Herramientas.RegularPosicionCursor(ctrlRegresar);

            return strRegresar;
        }

        public static String SoloLetras(Control ctrlRegresar)
        {
            String strRegresar = ctrlRegresar.Text;

            foreach (Char chRevisando in strRegresar.ToCharArray())
            {
                if (!Char.IsLetter(chRevisando))
                {
                    strRegresar = strRegresar.Replace(chRevisando.ToString(), "");
                    Herramientas.EstablecerPosicionCursor(ctrlRegresar);
                }
            }
            Herramientas.RegularPosicionCursor(ctrlRegresar);

            return strRegresar;
        }

        public static String NingunEspacioEnBlanco(Control ctrlRegresar)
        {
            String strRegresar = ctrlRegresar.Text;

            foreach (Char chRevisando in strRegresar.ToCharArray())
            {
                if (chRevisando==' ')
                {
                    strRegresar = strRegresar.Replace(chRevisando.ToString(), "");
                    Herramientas.EstablecerPosicionCursor(ctrlRegresar);
                }
            }
            Herramientas.RegularPosicionCursor(ctrlRegresar);

            return strRegresar;
        }

        public static String SoloNumeros(Control ctrlRegresar)
        {
            String strRegresar = ctrlRegresar.Text;

            foreach (Char chRevisando in strRegresar.ToCharArray())
            {
                if (!Char.IsDigit(chRevisando))
                {
                    strRegresar = strRegresar.Replace(chRevisando.ToString(), "");
                    Herramientas.EstablecerPosicionCursor(ctrlRegresar);
                }
            }
            Herramientas.RegularPosicionCursor(ctrlRegresar);

            return strRegresar;
        }

        public static String NingunCaracterEspecial(Control ctrlRegresar)
        {
            String strRegresar = ctrlRegresar.Text;

            foreach (Char chRevisando in strRegresar.ToCharArray())
            {
                if (!Char.IsLetterOrDigit(chRevisando))
                {
                    strRegresar = strRegresar.Replace(chRevisando.ToString(), "");
                    Herramientas.EstablecerPosicionCursor(ctrlRegresar);
                }
            }
            Herramientas.RegularPosicionCursor(ctrlRegresar);

            return strRegresar;
        }

        public static String NingunCharEspecialExpEspaciosSecundarios(Control ctrlRegresar)
        {
            String strRegresar = ctrlRegresar.Text;

            strRegresar = Herramientas.NingunEspacioInicial(strRegresar);

            foreach (Char chRevisando in strRegresar.ToCharArray())
            {
                if (chRevisando!=' ')
                {
                    if (!Char.IsLetterOrDigit(chRevisando))
                    {
                        strRegresar = strRegresar.Replace(chRevisando.ToString(), "");
                        Herramientas.EstablecerPosicionCursor(ctrlRegresar);
                    }
                }
            }
            Herramientas.RegularPosicionCursor(ctrlRegresar);

            return strRegresar;
        }

        public static int Alcancias = 0;
        public static int Empleados = 1;
        public static int Empresas = 2;
        public static int Ninos = 3;
        public static int Padrinos = 4;
        public static int Voluntarios = 5;

        public static bool cumpleCaracterMinimos(TextBox txtbRevisar, int intMinCarateres) {
            if (txtbRevisar.Text.Length >= intMinCarateres)
                return true;
            else
                return false;
        }
    }
}
