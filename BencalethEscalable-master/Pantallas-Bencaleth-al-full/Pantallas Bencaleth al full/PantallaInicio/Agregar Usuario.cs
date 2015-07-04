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
    public partial class Agregar_Usuario : Form
    {
        public Agregar_Usuario()
        {
            InitializeComponent();
        }

        private void Agregar_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bencalethDataSet.mostarCargo' Puede moverla o quitarla según sea necesario.
            this.mostarCargoTableAdapter.Fill(this.bencalethDataSet.mostarCargo);

        }

        private void btn_Acep_Adduseer_Click(object sender, EventArgs e)
        {
            bool boolPuedeCambiar = true;
            bool boolUsuarioValido = true;
            if (string.IsNullOrEmpty(txt_Nom_Adduser.Text) || string.IsNullOrEmpty(txt_Pass_Adduser.Text) || string.IsNullOrEmpty(txt_Confir_Adduser.Text))
            {
                MessageBox.Show("No se pueden dejar campos vacios."); 
                boolPuedeCambiar = false;
            }
            else
            {
                if (!Herramientas.cumpleCaracterMinimos(txt_Nom_Adduser, 8))
                {
                    MessageBox.Show("Se ocupa un minimo de 8 caracteres para un usuario válido");
                    boolUsuarioValido = false;
                    boolPuedeCambiar = false;
                }

                if ((!Herramientas.cumpleCaracterMinimos(txt_Confir_Adduser, 8)) && (!Herramientas.cumpleCaracterMinimos(txt_Pass_Adduser, 8)) && boolUsuarioValido)
                {
                    MessageBox.Show("Se ocupa un minimo de 8 caracteres para una contraseña válida");
                    boolPuedeCambiar = false;
                }
                
            }

            if (boolPuedeCambiar)
            {
                MessageBox.Show(Log.IngresoUsuario(txt_Nom_Adduser.Text, txt_Pass_Adduser.Text, txt_Confir_Adduser.Text, Convert.ToInt32(mostarCargoComboBox.SelectedValue)));
                if (Log.aprobado == 1)
                { this.Close(); Log.aprobado = 0; }
            }
        }

        private void txt_Nom_Adduser_TextChanged(object sender, EventArgs e)
        {
            txt_Nom_Adduser.Text = Herramientas.NingunEspacioEnBlanco(txt_Nom_Adduser);
            txt_Nom_Adduser.Text = Herramientas.SoloLetrasYEspaciosSec(txt_Nom_Adduser);
            txt_Nom_Adduser.Text = Herramientas.NingunCharEspecialExpEspaciosSecundarios(txt_Nom_Adduser);
           

        }

        private void txt_Pass_Adduser_TextChanged(object sender, EventArgs e)
        {
            txt_Pass_Adduser.Text = Herramientas.NingunEspacioEnBlanco(txt_Pass_Adduser);
            txt_Pass_Adduser.Text = Herramientas.NingunCharEspecialExpEspaciosSecundarios(txt_Pass_Adduser);

        }

        private void txt_Confir_Adduser_TextChanged(object sender, EventArgs e)
        {
            txt_Confir_Adduser.Text = Herramientas.NingunEspacioEnBlanco(txt_Confir_Adduser);
            txt_Confir_Adduser.Text = Herramientas.NingunCharEspecialExpEspaciosSecundarios(txt_Confir_Adduser);
        }
    
        
        private void btn_Cancel_Adduser_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
