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
    public partial class Menu : Form
    {
        Notificaciones noti = null;
        
        public Menu()
        {
            InitializeComponent();
        }

        public void UsuarioLimitado() {
            link_Newuser.Visible = false;
            link_cambiarpas.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            Herramientas.AbrirNuevoForm(new Registro());
           
        }

        private void btn_inv_Click(object sender, EventArgs e)
        {
            Herramientas.AbrirNuevoForm(new Inventarios());
        }

        private void btn_mantenimiento_Click(object sender, EventArgs e)
        {
            Herramientas.AbrirNuevoForm(new Mantenimiento());
        }

        private void link_cambiarpas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Cambio_Contraseña().ShowDialog();
        }

        private void link_Newuser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Agregar_Usuario().ShowDialog();
        }

        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Herramientas.frmPrincipal.Show();
            this.Dispose();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if(Log.Cargo(Log.sesion)==2){
                this.UsuarioLimitado();
            }

            dataGridView1.AutoGenerateColumns = false;
            noti = new Notificaciones(dataGridView2);
            dataGridView1.DataSource = noti.pendientes;
            dataGridView1.Columns[0].DataPropertyName = "campo1";
            dataGridView1.Columns[1].DataPropertyName = "campo2";
            dataGridView1.Columns[2].DataPropertyName = "campo3";
            dataGridView1.Columns[3].DataPropertyName = "campo4";
            dataGridView1.Columns[4].DataPropertyName = "campo5";
            dataGridView1.Update();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Herramientas.CerrarPrograma();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.DataSource != null)
            {
                if (MessageBox.Show("¿Esta seguro que desea verlo?", "Revisar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    String strIdAEnviar = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    Herramientas.AbrirNuevoForm(new Mantenimiento(strIdAEnviar, noti.pendientes[e.RowIndex].Tipo));
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
