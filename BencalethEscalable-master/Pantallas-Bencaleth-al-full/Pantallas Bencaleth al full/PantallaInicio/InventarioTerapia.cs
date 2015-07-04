using PantallaInicio.BencalethDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaInicio
{
    class InventarioTerapia:Inventario
    {
        //variables
        private string _strResponsable;
        public string strResponsable
        {
            get { return _strResponsable; }

            set { _strResponsable = value; }
        }

        //funciones
        public override void IngresarProducto(Control lisControls) { }

        public override void EditarProducto(Control lisControls) { }

        public override void EliminarProducto(string strIDPa) { }

        public override void mostrarInventario(DataGridView dtgrdvw) {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.SelectTerapiaFisicaTableAdapter tblAdptEmp = new SelectTerapiaFisicaTableAdapter();

            tblAdptEmp.Fill(dtset.SelectTerapiaFisica);

            dtgrdvw.DataSource = dtset.SelectTerapiaFisica.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "ID";
            dtgrdvw.Columns[1].HeaderText = "Descripción";
            dtgrdvw.Columns[2].HeaderText = "Cantidad";
            dtgrdvw.Columns[3].HeaderText = "Responsable";
            dtgrdvw.Update();
        }
    }
}
