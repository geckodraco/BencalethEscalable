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

namespace PantallaInicio
{
    public partial class IngresoNiños : Form
    {
        QueriesTableAdapter var = new QueriesTableAdapter();

        Ninios ninio;
        Boolean boolModoActualizar;

        public IngresoNiños()
        {
            InitializeComponent();
            ninio = new Ninios();

            //no se edad de ninos
            this.fech_niños.Value = new DateTime((DateTime.Now.Year - 10), 1, 1);
            this.fech_niños.Update();

            boolModoActualizar = false;

            txt_idniños.ReadOnly = false;
        }

        public IngresoNiños(DataGridViewRow fila)
        {
            InitializeComponent();
            ninio = new Ninios();

            ninio.ConseguirDatosToUpdate(txt_apellido,fila);
            boolModoActualizar = true;

            txt_idniños.ReadOnly = true;
        }

        private void IngresoNiños_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bencalethDataSet.ComboboxResponsables' Puede moverla o quitarla según sea necesario.
            this.comboboxResponsablesTableAdapter.Fill(this.bencalethDataSet.ComboboxResponsables);
            ninio.FixComboBox(txt_apellido);
        }

        private void txt_nomninos_TextChanged(object sender, EventArgs e)
        {
            //txt_nomninos.Text = Herramientas.SoloLetrasYEspaciosSec(txt_nomninos);
        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {
            txt_apellido.Text = Herramientas.SoloLetrasYEspaciosSec(txt_apellido);
        }

        private void txt_responsable_TextChanged(object sender, EventArgs e)
        {
            //txt_responsable.Text = Herramientas.NingunCaracterEspecial(txt_responsable);
        }

        private void btn_saveNiños_Click(object sender, EventArgs e)
        {
            //ninio.ingresarDatos(txt_nomninos);
        }

        private void comboboxResponsablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_saveNiños_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_idniños.Text))
            {
                errorProvider1.SetError(txt_idniños, "Falta llenar campos vacios");
            }
            if (string.IsNullOrEmpty(txt_nomniños.Text))
            {
                errorProvider2.SetError(txt_nomniños, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_apellido.Text))
            {
                errorProvider3.SetError(txt_apellido, "Falta llenar Campo");
            }
            else
            {
                if (boolModoActualizar)
                {
                    ninio.actualizarDatos(txt_idniños);
                }
                else
                {
                    ninio.ingresarDatos(txt_nomniños);
                }
            }
        }

        private void txt_nomniños_TextChanged(object sender, EventArgs e)
        {
            txt_nomniños.Text = Herramientas.SoloLetrasYEspaciosSec(txt_nomniños);
            errorProvider2.Clear();
        }

        private void txt_idniños_TextChanged(object sender, EventArgs e)
        {
            txt_idniños.Text = Herramientas.SoloNumeros(txt_idniños);
            errorProvider1.Clear();
        }

        private void txt_apellido_TextChanged_1(object sender, EventArgs e)
        {
            txt_apellido.Text = Herramientas.SoloLetrasYEspaciosSec(txt_apellido);
            errorProvider3.Clear();
        }

        private void radio_mas_Niños_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
