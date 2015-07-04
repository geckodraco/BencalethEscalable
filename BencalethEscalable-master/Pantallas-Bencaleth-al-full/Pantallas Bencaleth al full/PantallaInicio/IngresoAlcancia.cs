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
    public partial class IngresoAlcancia : Form
    {
        Alcancias alcancia;
        Boolean boolModoActualizar;

        public IngresoAlcancia()
        {
            InitializeComponent();
            alcancia = new Alcancias();
            boolModoActualizar = false;

            textBox1.ReadOnly = false;
        }

        public IngresoAlcancia(DataGridViewRow fila)
        {
            InitializeComponent();
            alcancia = new Alcancias();

            alcancia.ConseguirDatosToUpdate(txtbDes,fila);
            boolModoActualizar = true;

            textBox1.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Herramientas.NingunCaracterEspecial(textBox1);
            errorProvider1.Clear();
        }

        private void btn_save_Alcancias_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Falta llenar campos vacios");
            }
            if (string.IsNullOrEmpty(txtbDes.Text))
            {
                errorProvider2.SetError(txtbDes, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txtbDir.Text))
            {
                errorProvider3.SetError(txtbDir, "Falta llenar Campo");
            }
            else
            {
                if (boolModoActualizar)
                {
                    alcancia.actualizarDatos(txtbDes);
                }
                else
                {
                    alcancia.ingresarDatos(textBox1);
                }
            }
        }

        private void txtbDir_TextChanged(object sender, EventArgs e)
        {
            txtbDir.Text = Herramientas.NingunEspacioInicial(txtbDir.Text);
            errorProvider3.Clear();
        }

        private void txtbDes_TextChanged(object sender, EventArgs e)
        {
            txtbDes.Text = Herramientas.NingunEspacioInicial(txtbDes.Text);
            errorProvider2.Clear();
        }

        private void IngresoAlcancia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bencalethDataSet.MostrarRecurencias' Puede moverla o quitarla según sea necesario.
            this.mostrarRecurenciasTableAdapter.Fill(this.bencalethDataSet.MostrarRecurencias);

            alcancia.FixComboBox(txtbDes);
        }

        private void mostrarRecurenciasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(mostrarRecurenciasComboBox.SelectedText);
        }

        private void txtbTel_TextChanged(object sender, EventArgs e)
        {
            txtbTel.Text = Herramientas.SoloNumeros(txtbTel);
        }

        private void masktxtbTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
