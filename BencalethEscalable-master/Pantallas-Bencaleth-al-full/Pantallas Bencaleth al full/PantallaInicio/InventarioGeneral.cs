using PantallaInicio.BencalethDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaInicio
{
    class InventarioGeneral:Inventario
    {
        //variables
        private int _intMonto;
        public string intMonto
        {
            get { return _intMonto.ToString(); }

            set {if(Herramientas.IsNumeric(value))
                _intMonto = Convert.ToInt16(value); }
        }

        //funciones
        public override void IngresarProducto(Control lisControls) { }

        public override void EditarProducto(Control lisControls) { }

        public override void EliminarProducto(string strIDPa) { }

        public override void mostrarInventario(DataGridView dtgrdvw) {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.SelectDonacionesTableAdapter tblAdptEmp = new SelectDonacionesTableAdapter();

            tblAdptEmp.Fill(dtset.SelectDonaciones);

            dtgrdvw.DataSource = dtset.SelectDonaciones.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "ID";
            dtgrdvw.Columns[1].HeaderText = "Descripción";
            dtgrdvw.Columns[2].HeaderText = "Cantidad";
            dtgrdvw.Columns[3].HeaderText = "Donante";
            dtgrdvw.Update();
        }
    }
}
