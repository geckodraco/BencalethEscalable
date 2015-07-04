using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaInicio
{
    public partial class Cambio_Contraseña : Form
    {
        public Cambio_Contraseña()
        {
            InitializeComponent();
        }

        private void Cambio_Contraseña_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bencalethDataSet.MostarUsuarios' Puede moverla o quitarla según sea necesario.
            this.mostarUsuariosTableAdapter.Fill(this.bencalethDataSet.MostarUsuarios);

        }

        private void btn_Acep_Click(object sender, EventArgs e)
        {
            


        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txt_Newpassw_TextChanged(object sender, EventArgs e)
        {
            txt_Newpassw.Text = Herramientas.NingunCaracterEspecial(txt_Newpassw);
        }

        private void txt_Confimpassw_TextChanged(object sender, EventArgs e)
        {
            txt_Confimpassw.Text = Herramientas.NingunCaracterEspecial(txt_Confimpassw);
        }

        private void btn_Acep_Click_1(object sender, EventArgs e)
        {
            bool boolPuedeCambiar = true;
            bool boolEstanVacios = false;
            //Cambio de contraseña evento click
            if ((string.IsNullOrEmpty(txt_Newpassw.Text) || string.IsNullOrEmpty(txt_Confimpassw.Text)) && (!Herramientas.cumpleCaracterMinimos(txt_Newpassw, 8)) && (!Herramientas.cumpleCaracterMinimos(txt_Confimpassw, 8)))
            {
                MessageBox.Show("No se pueden dejar campos vacios.");
                boolPuedeCambiar = false;
                boolEstanVacios = true;
            }

            if ((!Herramientas.cumpleCaracterMinimos(txt_Confimpassw, 8)) && (!Herramientas.cumpleCaracterMinimos(txt_Newpassw, 8)) && (!boolEstanVacios))
            {
                MessageBox.Show("Se ocupa un minimo de 8 caracteres para una contraseña válida");
                boolPuedeCambiar = false;
            }

            if (boolPuedeCambiar)
            {
                MessageBox.Show(Log.cambioContraseña(mostarUsuariosComboBox.SelectedValue.ToString(), txt_Newpassw.Text, txt_Confimpassw.Text));
                if (Log.aprobado == 1) { this.Close(); Log.aprobado = 0; }
            }
            //termina
        }

        private void txt_Newpassw_TextChanged_1(object sender, EventArgs e)
        {
            Herramientas.NingunEspacioEnBlanco(txt_Newpassw);
        }

        private void txt_Confimpassw_TextChanged_1(object sender, EventArgs e)
        {
            Herramientas.NingunEspacioEnBlanco(txt_Confimpassw);
        }

        private void txt_Newpassw_Leave(object sender, EventArgs e)
        {
            
        }

        private void txt_Confimpassw_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
