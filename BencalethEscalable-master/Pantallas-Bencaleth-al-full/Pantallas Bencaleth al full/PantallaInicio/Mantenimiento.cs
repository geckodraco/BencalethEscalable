using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PantallaInicio.BencalethDataSet1TableAdapters;

namespace PantallaInicio
{
    public partial class Mantenimiento : Form
    {

        Alcancias alc;
        Padrinos pdr;
        Ninios nino;
        Empleados empl;
        Organizaciones org;
        Voluntarios volt;

        String strIdAEnviar;
        DataGridViewRow filaAEnviar=null;

        private void InicializarUserSelection() {
            try
            {
                strIdAEnviar = dataGridView1.Rows[0].Cells[0].Value.ToString();
                filaAEnviar = dataGridView1.Rows[0];
            }catch(Exception){

                strIdAEnviar = null;
                filaAEnviar = null;
            }
        }

        private void SelectPantalla() {
            switch (Cbb_Mantenimiento.SelectedIndex)
            {
                //Alcancias
                case 0:
                    alc.mostrarDatos(dataGridView1,txtbABuscar);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                //Empleados
                case 1:
                    empl.mostrarDatos(dataGridView1,txtbABuscar);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    break;
                //Empresas
                case 2:
                    org.mostrarDatos(dataGridView1,txtbABuscar);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                //Ninos
                case 3:
                    nino.mostrarDatos(dataGridView1, txtbABuscar);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                //Padrinos
                case 4:
                    pdr.mostrarDatos(dataGridView1, txtbABuscar);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    break;
                //Voluntarios
                case 5:
                    volt.mostrarDatos(dataGridView1,txtbABuscar);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    break;
                default:
                    break;
            }
            InicializarUserSelection();
            dataGridView1.AutoResizeColumns();
        }

        public Mantenimiento()
        {
            InitializeComponent();
            alc = new Alcancias();
            pdr = new Padrinos();
            nino = new Ninios();
            empl = new Empleados();
            org = new Organizaciones();
            volt = new Voluntarios();

            strIdAEnviar=null;
            filaAEnviar = null;

            dataGridView1.DataSource = null;

            Cbb_Mantenimiento.SelectedIndex = 0;
        }

        public Mantenimiento(String buscado, int cbxDesplegar)
        {
            InitializeComponent();
            alc = new Alcancias();
            pdr = new Padrinos();
            nino = new Ninios();
            empl = new Empleados();
            org = new Organizaciones();
            volt = new Voluntarios();

            strIdAEnviar = null;
            filaAEnviar = null;

            dataGridView1.DataSource = null;
            rdbtnID.Checked = true;
            Cbb_Mantenimiento.SelectedIndex = cbxDesplegar;
            txtbABuscar.Text = buscado;
            //radioButton7
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (filaAEnviar != null)
            {
                Herramientas.AbrirNuevoForm(new Registro(filaAEnviar, Cbb_Mantenimiento.SelectedIndex));
            }
            else {
                MessageBox.Show("No hay nada que enviar");
            }
        }

        private void Cbb_Mantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbABuscar.Clear();
            SelectPantalla();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            InicializarUserSelection();
        }

        private void txtbABuscar_TextChanged(object sender, EventArgs e)
        {
            txtbABuscar.Text = Herramientas.NingunCharEspecialExpEspaciosSecundarios(txtbABuscar);
            this.SelectPantalla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.DataSource != null)
            {
                strIdAEnviar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                filaAEnviar = dataGridView1.Rows[e.RowIndex];
            }
        }

        private void Mantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Herramientas.CerrarPrograma();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea borrarlo?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (filaAEnviar != null)
                {
                    switch (Cbb_Mantenimiento.SelectedIndex)
                    {
                        //Alcancias
                        case 0:
                            alc.DeleteDatos(strIdAEnviar);
                            break;
                        //Empleados
                        case 1:
                            empl.DeleteDatos(strIdAEnviar);
                            break;
                        //Empresas
                        case 2:
                            org.DeleteDatos(strIdAEnviar);
                            break;
                        //Ninos
                        case 3:
                            nino.DeleteDatos(strIdAEnviar);
                            break;
                        //Padrinos
                        case 4:
                            pdr.DeleteDatos(strIdAEnviar);
                            break;
                        //Voluntarios
                        case 5:
                            volt.DeleteDatos(strIdAEnviar);
                            break;
                        default:
                            break;
                    }
                    this.SelectPantalla();
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Herramientas.AbrirNuevoForm(new Menu());
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            txtbABuscar.Clear();
        }

        private void rdbtnID_CheckedChanged(object sender, EventArgs e)
        {
            txtbABuscar.Clear();
        }

      
    }
}
