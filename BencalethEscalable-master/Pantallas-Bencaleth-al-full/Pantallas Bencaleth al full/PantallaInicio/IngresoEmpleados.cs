using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;

namespace PantallaInicio
{
    public partial class IngresoEmpleados : Form    
    {
        Empleados empleado;
        Boolean boolModoActualizar;

        public IngresoEmpleados()
        {
            InitializeComponent();
            empleado = new Empleados();

            this.date_FechN_Emple.Value = new DateTime((DateTime.Now.Year - 18), 1, 1);
            this.date_FechN_Emple.Update();

            boolModoActualizar = false;

            txt_Id_Emple.ReadOnly = false;
        }

        public IngresoEmpleados(DataGridViewRow fila)
        {
            InitializeComponent();
            empleado = new Empleados();

            empleado.ConseguirDatosToUpdate(txt_Apelli_Emple, fila);
            boolModoActualizar = true;

            txt_Id_Emple.ReadOnly = true;
        }

        private void btn_save_Emple_Click(object sender, EventArgs e)
        {
            //empleado.ingresarDatos(txt_Nom_Emple);
            if (string.IsNullOrEmpty(txt_Id_Emple.Text))
            {
                errorProvider1.SetError(txt_Id_Emple, "Falta llenar campos vacios");
            }
            if (string.IsNullOrEmpty(txt_Nom_Emple.Text))
            {
                errorProvider2.SetError(txt_Nom_Emple, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_Apelli_Emple.Text))
            {
                errorProvider3.SetError(txt_Apelli_Emple, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_Tel_Emple.Text))
            {
                errorProvider4.SetError(txt_Tel_Emple, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_Email_Emple.Text))
            {
                errorProvider5.SetError(txt_Email_Emple, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_Dir_Emple.Text))
            {
                errorProvider6.SetError(txt_Dir_Emple, "Falta llenar Campo");
            }
            else
                {

            if(boolModoActualizar){
                empleado.actualizarDatos(txt_Nom_Emple);
            }else{
                empleado.ingresarDatos(txt_Nom_Emple);
               
            }
                }
        }

        private void txt_Id_Emple_TextChanged(object sender, EventArgs e)
        {
            txt_Id_Emple.Text = Herramientas.SoloNumeros(txt_Id_Emple);
            errorProvider1.Clear();
            
        }

        private void txt_Nom_Emple_TextChanged(object sender, EventArgs e)
        {
             txt_Nom_Emple.Text = Herramientas.SoloLetrasYEspaciosSec(txt_Nom_Emple);
             errorProvider2.Clear();
        }

        private void txt_Apelli_Emple_TextChanged(object sender, EventArgs e)
        {
            txt_Apelli_Emple.Text = Herramientas.SoloLetrasYEspaciosSec(txt_Apelli_Emple);
            errorProvider3.Clear();
        }

        private void date_FechN_Emple_ValueChanged(object sender, EventArgs e)
        {
            
           
        
        }

        private void Date_FechIn_Emple_ValueChanged(object sender, EventArgs e)
        {
           
        
        }

        private void txt_Tel_Emple_TextChanged(object sender, EventArgs e)
        {
            txt_Tel_Emple.Text=Herramientas.SoloNumeros(txt_Tel_Emple);
            errorProvider4.Clear();
        }

        private void txt_Email_Emple_TextChanged(object sender, EventArgs e)
        {
            txt_Email_Emple.Text=Herramientas.NingunEspacioEnBlanco(txt_Email_Emple);
            errorProvider5.Clear();

        }

        private void txt_Dir_Emple_TextChanged(object sender, EventArgs e)
        {
            txt_Dir_Emple.Text = Herramientas.NingunEspacioInicial(txt_Dir_Emple.Text);
            errorProvider6.Clear();
        }

        private void txt_Iden_Emple_TextChanged(object sender, EventArgs e)
        {
            //txt_Iden_Emple.Text = Herramientas.SoloNumeros(txt_Iden_Emple);
        }




        public static bool validarEmail(string email)
        {
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                { return true; }
                else
                { return false; }

            }
            else
            { return false; }
        }
        private void txt_Email_Emple_Leave(object sender, EventArgs e)
        {
            if (validarEmail(txt_Email_Emple.Text))
            {

            }
            else
            {
                MessageBox.Show("Direccion de correo electronico no valida el correo debe terner un formato nombre@dominio.com");
                txt_Email_Emple.Text = "";
            }

        }

        private void date_FechN_Emple_Leave(object sender, EventArgs e)
        {
            int anoActual, anoIntroducido;

            anoActual = Convert.ToInt32(DateTime.Today.Year);
            anoIntroducido = date_FechN_Emple.Value.Year;
            while ((anoActual - anoIntroducido) < 18)
            {

                if ((anoActual - anoIntroducido) < 18)
                {
                    MessageBox.Show("no cumple el requisito de edad minima", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    break;
                }

            }

            //if ((anoActual - anoIntroducido) >= 18)
            //{
            //    MessageBox.Show("cumple el requisito de edad minima tiene 16 año o ese año los cumple", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            

        }

        private void IngresoEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bencalethDataSet.Combobox_CargoTipo' Puede moverla o quitarla según sea necesario.
            this.combobox_CargoTipoTableAdapter.Fill(this.bencalethDataSet.Combobox_CargoTipo);
            empleado.FixComboBox(txt_Apelli_Emple);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radio_fem_Emple_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_mas_Emple_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void combobox_CargoTipoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
