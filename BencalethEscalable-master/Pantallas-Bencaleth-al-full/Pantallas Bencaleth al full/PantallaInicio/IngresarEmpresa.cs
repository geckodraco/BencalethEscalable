using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PantallaInicio.BencalethDataSetTableAdapters;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Globalization;

namespace PantallaInicio
{
  
    public partial class IngresarEmpresa : Form
    {
       Organizaciones empresa;

       QueriesTableAdapter bd = new QueriesTableAdapter();

       Boolean boolModoActualizar;

        public IngresarEmpresa()
        {
            InitializeComponent();
            empresa = new Organizaciones();
            boolModoActualizar = false;

            //txt_id_empresa.ReadOnly = false;
        }

        public IngresarEmpresa(DataGridViewRow fila)
        {
            InitializeComponent();
            empresa = new Organizaciones();

            empresa.ConseguirDatosToUpdate(txt_nom_empresa, fila);
            boolModoActualizar = true;

            txt_id_empresa.ReadOnly = true;
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

        private void IngresarEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bencalethDataSet1.combobox_empresas' Puede moverla o quitarla según sea necesario.
            this.combobox_empresasTableAdapter.Fill(this.bencalethDataSet1.combobox_empresas);

            //Herramientas.errorPro = errorProvider1;
            empresa.FixComboBox(txt_nom_empresa);
        }

        //Eventos nombre empresa
        private void txt_nom_empresa_TextChanged(object sender, EventArgs e)
         {
            txt_nom_empresa.Text = Herramientas.SoloLetrasYEspaciosSec(txt_nom_empresa);
            errorProvider1.Clear();
        }
        //eventos direccion empresa
        private void txt_dire_empresa_TextChanged(object sender, EventArgs e)
        {
            txt_dire_empresa.Text = Herramientas.NingunEspacioInicial(txt_dire_empresa.Text);
            errorProvider2.Clear();
         }

        private void txt_pasi_empresa_TextChanged(object sender, EventArgs e)
        {
            txt_pasi_empresa.Text = Herramientas.SoloLetrasYEspaciosSec(txt_pasi_empresa);
            errorProvider6.Clear();
        }

        private void txt_contac_empresa_TextChanged(object sender, EventArgs e)
        {
            txt_contac_empresa.Text = Herramientas.SoloLetrasYEspaciosSec(txt_contac_empresa);
            errorProvider3.Clear();
        }

        private void txt_tel1_empresa_TextChanged(object sender, EventArgs e)
        {
            txt_tel1_empresa.Text = Herramientas.SoloNumeros(txt_tel1_empresa);
            errorProvider4.Clear();
        }

        private void txt_tel2_empresa_TextChanged(object sender, EventArgs e)
        {
            txt_tel2_empresa.Text = Herramientas.SoloNumeros(txt_tel2_empresa);
            errorProvider5.Clear();
        }
        private void txt_email_empresa_TextChanged(object sender, EventArgs e)
        {
           
            errorProvider7.Clear();
        }
        private void combobox_empresasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  empresa.Tipo = combobox_empresasComboBox.SelectedValue.ToString();
        }
        
        private void txt_email_empresa_Leave(object sender, EventArgs e)
        {
            if (validarEmail(txt_email_empresa.Text))
            {
               
            }
            else
            {
                MessageBox.Show("Direccion de correo electronico no valida el correo debe terner un formato nombre@dominio.com");
                txt_email_empresa.Clear();
            }
        }
        private void btn_save_empresa_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_nom_empresa.Text) || string.IsNullOrEmpty(txt_dire_empresa.Text) || string.IsNullOrEmpty(txt_contac_empresa.Text) || string.IsNullOrEmpty(txt_tel1_empresa.Text) || string.IsNullOrEmpty(txt_tel2_empresa.Text) || string.IsNullOrEmpty(txt_pasi_empresa.Text) || string.IsNullOrEmpty(txt_email_empresa.Text))
            //{
            //    errorProvider1.SetError(txt_nom_empresa, "Falta llenar campos vacios");
            //}
            if (string.IsNullOrEmpty(txt_nom_empresa.Text))
            {
                errorProvider1.SetError(txt_nom_empresa, "Falta llenar campos vacios");
            }
            if (string.IsNullOrEmpty(txt_dire_empresa.Text))
            {
                errorProvider2.SetError(txt_dire_empresa, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_contac_empresa.Text))
            {
                errorProvider3.SetError(txt_contac_empresa, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_tel1_empresa.Text))
            {
                errorProvider4.SetError(txt_tel1_empresa, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_tel2_empresa.Text))
            {
                errorProvider5.SetError(txt_tel2_empresa, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_pasi_empresa.Text))
            {
                errorProvider6.SetError(txt_pasi_empresa, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_email_empresa.Text))
            {
                errorProvider7.SetError(txt_email_empresa, "Falta llenar Campo");
            }
            else
            {
                if (boolModoActualizar)
                {
                    empresa.actualizarDatos(txt_dire_empresa);
                }
                else
                {
                    empresa.ingresarDatos(txt_dire_empresa);
                    txt_nom_empresa.Clear(); txt_dire_empresa.Clear(); txt_contac_empresa.Clear(); txt_tel1_empresa.Clear(); txt_tel2_empresa.Clear(); txt_pasi_empresa.Clear(); txt_email_empresa.Clear();
                }
                
                

            }

        }

        private void txt_id_empresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
