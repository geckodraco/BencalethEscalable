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
    public partial class Inventarios : Form
    {
        QueriesTableAdapter BDI = new QueriesTableAdapter();
        public Inventarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Show_Invs_Click(object sender, EventArgs e)
        {
            //new Vista_Inventarios().Show();
            //this.Close();
            Herramientas.AbrirNuevoForm(new Vista_Inventarios());
        }

        private void txt_Id_Invd_TextChanged(object sender, EventArgs e)
        {
            txt_Id_Invd.Text = Herramientas.SoloNumeros(txt_Id_Invd);
        }

        private void txt_Des_Invd_TextChanged(object sender, EventArgs e)
        {
            txt_Des_Invd.Text = Herramientas.NingunEspacioInicial(txt_Des_Invd.Text);
        }

        private void txt_Can_Invd_TextChanged(object sender, EventArgs e)
        {
            txt_Can_Invd.Text = Herramientas.SoloNumeros(txt_Can_Invd);
        }

        private void txt_id_InvF_TextChanged(object sender, EventArgs e)
        {
            txt_id_InvF.Text = Herramientas.SoloNumeros(txt_id_InvF);
        }

        private void txt_Des_Invf_TextChanged(object sender, EventArgs e)
        {
            txt_Des_Invf.Text = Herramientas.NingunEspacioInicial(txt_Des_Invf.Text);
        }

        private void txt_Can_Invf_TextChanged(object sender, EventArgs e)
        {
            txt_Can_Invf.Text = Herramientas.SoloNumeros(txt_Can_Invf);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Id_Invd.Text) || string.IsNullOrEmpty(txt_Des_Invd.Text) || string.IsNullOrEmpty(txt_Can_Invd.Text))
            {
                MessageBox.Show("Faltan Campos que llenar");
            }

            else
            {
                BDI.Insert_inven_Donaciones(Convert.ToInt32(txt_Id_Invd.Text), txt_Des_Invd.Text, txt_Can_Invd.Text, combobox_nomempresaComboBox.SelectedValue.ToString());
                MessageBox.Show("ingresado");
                txt_Id_Invd.Clear(); txt_Des_Invd.Clear(); txt_Can_Invd.Clear();
            }
        }

        private void Inventarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Herramientas.CerrarPrograma();
        }

        private void Inventarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bencalethDataSet.ComboboxResponsables' Puede moverla o quitarla según sea necesario.
            this.comboboxResponsablesTableAdapter.Fill(this.bencalethDataSet.ComboboxResponsables);
            // TODO: esta línea de código carga datos en la tabla 'bencalethDataSet.combobox_nomempresa' Puede moverla o quitarla según sea necesario.
            this.combobox_nomempresaTableAdapter.Fill(this.bencalethDataSet.combobox_nomempresa);

        }

        private void btn_save_InTF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id_InvF.Text) || string.IsNullOrEmpty(txt_Des_Invf.Text) || string.IsNullOrEmpty(txt_Can_Invf.Text))
            {
                MessageBox.Show("Faltan Campos que llenar");
            }

            else
            {
                BDI.Insert_inven_Terapia(Convert.ToInt16(txt_id_InvF.Text), txt_Des_Invf.Text, txt_Can_Invf.Text,comboboxResponsablesComboBox.SelectedValue.ToString());
                MessageBox.Show("ingresado");
                txt_id_InvF.Clear(); txt_Des_Invf.Clear(); txt_Can_Invf.Clear();
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Herramientas.AbrirNuevoForm(new Menu());
        }
    }
}
