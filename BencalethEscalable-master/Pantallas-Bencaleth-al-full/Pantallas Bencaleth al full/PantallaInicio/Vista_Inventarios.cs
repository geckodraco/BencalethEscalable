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
    public partial class Vista_Inventarios : Form
    {
        public Vista_Inventarios()
        {
            InitializeComponent();
        }

        InventarioGeneral donaciones;
        InventarioTerapia terapia;

        private void SelectPantalla()
        {
            switch (Cbb_Mantenimiento.SelectedIndex)
            {
                //Donaciones
                case 0:
                    donaciones.mostrarInventario(dataGridView1);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                //Terapia Fisica
                case 1:
                    terapia.mostrarInventario(dataGridView1);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                default:
                    break;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //new Inventarios().Show();
            //this.Close();
            Herramientas.AbrirNuevoForm(new Inventarios());
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Herramientas.AbrirNuevoForm(new Menu());
        }

        private void Vista_Inventarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Herramientas.CerrarPrograma();
        }

        private void Cbb_Mantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectPantalla();
        }

        private void Vista_Inventarios_Load(object sender, EventArgs e)
        {
            donaciones = new InventarioGeneral();
            terapia = new InventarioTerapia();
            Cbb_Mantenimiento.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
