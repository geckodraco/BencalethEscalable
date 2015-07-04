using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PantallaInicio.BencalethDataSetTableAdapters;
namespace PantallaInicio
{
    public class Organizaciones
    {
        public static QueriesTableAdapter BD = new QueriesTableAdapter();

        private string _nombre_empresa;
        public string nombre_empresa
        {
            get
            {
                return _nombre_empresa;
            }

            set
            {
                _nombre_empresa = value;
            }
        }

        private int _Codigo_Org;
        public string Codigo_Persona
        {
            get
            {
                return _Codigo_Org.ToString();
            }
            set
            {
                if (Herramientas.IsNumeric(value))
                    _Codigo_Org = Convert.ToInt16(value);
            }
        }

        private int _Tipo;
        public string Tipo
        {
            get
            {
                return _Tipo.ToString();
            }
            set
            {
                if (Herramientas.IsNumeric(value))
                    _Tipo = Convert.ToInt16(value);
            }
        }

        private string _Direccion;
        public string  Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                _Direccion = value;
            }
        }

        private int _Telefono;
        public string Telefono
        {
            get
            {
                return _Telefono.ToString();
            }
            set
            {
                if (Herramientas.IsNumeric(value))
                    _Telefono = Convert.ToInt32(value);
            }
        }

        private int _Telefono2;
        public string Telefono2
        {
            get
            {
                return _Telefono2.ToString();
            }
            set
            {
                if (Herramientas.IsNumeric(value))
                    _Telefono2 = Convert.ToInt32(value);
            }
        }


      private string _Otros;
      public string Otros
        {
            get
            {
                return _Otros;
            }
            set
            {
                _Otros = value;
            }
        }

       private string _Contacto;
       public string Contacto
       {
           get
           {
               return _Contacto;
           }
           set
           {
               _Contacto = value;
           }
       }

        private  string _Pais;
        public string  Pais
        {
            get
            {
                return _Pais;
            }
            set
            {
                _Pais = value;
            }
        }

        private string _email;
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public static void Ingreso_Empresas(string nombre, string tipo_empresa, string direccion, string contacto, string tel1, string tel2, string email, string pais)
        {
           
        }

        private object ValueCombobox = null;
       
        public void ingresarDatos(Control controles) {
            this.nombre_empresa=controles.Parent.Controls["txt_nom_empresa"].Text;
            this.Direccion=controles.Parent.Controls["txt_dire_empresa"].Text;
            this.Pais=controles.Parent.Controls["txt_pasi_empresa"].Text;
            this.Contacto=controles.Parent.Controls["txt_contac_empresa"].Text;
            this.Telefono=controles.Parent.Controls["txt_tel1_empresa"].Text;
            this.Telefono2=controles.Parent.Controls["txt_tel2_empresa"].Text;
            this.email=controles.Parent.Controls["txt_email_empresa"].Text;

            string combo = ((ComboBox)controles.Parent.Controls["combobox_empresasComboBox"]).SelectedValue.ToString();

            if (!Herramientas.HayCamposNull(controles))
            {
                try
                {
                    BD.Insert_Empresas(this.nombre_empresa, combo, this.Direccion, this.Telefono, this.Telefono2, this.Pais, this.Contacto, this.email);
                    MessageBox.Show("Ingresado");

                    controles.Parent.Controls["txt_nom_empresa"].Text = "";
                    controles.Parent.Controls["txt_dire_empresa"].Text = "";
                    controles.Parent.Controls["txt_pasi_empresa"].Text = "";
                    controles.Parent.Controls["txt_contac_empresa"].Text = "";
                    controles.Parent.Controls["txt_tel1_empresa"].Text = "";
                    controles.Parent.Controls["txt_tel2_empresa"].Text = "";
                    controles.Parent.Controls["txt_email_empresa"].Text = "";
                }
                catch (SqlException e)
                {
                    switch (e.Number)
                    {
                        case 2627:
                            MessageBox.Show("ID ya existente");
                            break;
                        default:
                            MessageBox.Show("No hay conexion con la base de datos");
                            break;
                    }
                }
            }
          
            
        }

        public void actualizarDatos(Control controles) {
            string idEmp = controles.Parent.Controls["txt_id_empresa"].Text;
            this.nombre_empresa = controles.Parent.Controls["txt_nom_empresa"].Text;
            this.Direccion = controles.Parent.Controls["txt_dire_empresa"].Text;
            this.Pais = controles.Parent.Controls["txt_pasi_empresa"].Text;
            this.Contacto = controles.Parent.Controls["txt_contac_empresa"].Text;
            this.Telefono = controles.Parent.Controls["txt_tel1_empresa"].Text;
            this.Telefono2 = controles.Parent.Controls["txt_tel2_empresa"].Text;
            this.email = controles.Parent.Controls["txt_email_empresa"].Text;

            string combo = ((ComboBox)controles.Parent.Controls["combobox_empresasComboBox"]).SelectedValue.ToString();

            if (!Herramientas.HayCamposNull(controles))
            {
                try
                {
                    BD.Update_Empresas(idEmp, this.nombre_empresa, combo, this.Direccion, this.Contacto, this.Telefono, this.Telefono2, this.Pais, this.email);
                    MessageBox.Show("Ha sido actualizado");
                }
                catch (SqlException e)
                {
                    switch (e.Number)
                    {
                        case 2627:
                            MessageBox.Show("ID ya existente");
                            break;
                        default:
                            MessageBox.Show("No hay conexion con la base de datos");
                            break;
                    }
                }
            }
        }

        public void DeleteDatos(string ID) {
            if(!string.IsNullOrEmpty(ID)){
                BD.Delete_Empresas(Convert.ToInt32(ID));
            }
        }

        public void mostrarDatos(DataGridView dtgrdvw, TextBox txtbBuscado)
        {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.BuscarSelect_EmpresasTableAdapter tblAdptEmp = new BuscarSelect_EmpresasTableAdapter();

            if (!(string.IsNullOrEmpty(txtbBuscado.Text)))
            {
                if (((RadioButton)txtbBuscado.Parent.Controls["rdbtnID"]).Checked)
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Empresas, txtbBuscado.Text, null);
                }
                else
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Empresas, null, txtbBuscado.Text);
                }
            }
            else
            {
                tblAdptEmp.Fill(dtset.BuscarSelect_Empresas, null, null);
            }

            dtgrdvw.DataSource = dtset.BuscarSelect_Empresas.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "ID";
            dtgrdvw.Columns[1].HeaderText = "Nombre";
            dtgrdvw.Columns[2].HeaderText = "Tipo de Empresa";
            dtgrdvw.Columns[3].HeaderText = "Dirección";
            dtgrdvw.Columns[4].HeaderText = "Contacto";
            dtgrdvw.Columns[5].HeaderText = "Teléfono 1";
            dtgrdvw.Columns[6].HeaderText = "Teléfono 2";
            dtgrdvw.Columns[7].HeaderText = "País";
            dtgrdvw.Columns[8].HeaderText = "Correo Electrónico";
            dtgrdvw.Update();
        }

        public void ConseguirDatosToUpdate(Control controles, DataGridViewRow fila) {
            controles.Parent.Controls["txt_id_empresa"].Text = fila.Cells["Id"].Value.ToString();
            controles.Parent.Controls["txt_nom_empresa"].Text = fila.Cells["Nombre"].Value.ToString();

            //((ComboBox)controles.Parent.Controls["combobox_empresasComboBox"]).SelectedValue = fila.Cells["Tipo_Empresa"].Value;
            this.ValueCombobox = BD.GetIDToComboBoxTipoEmpr_Empresas(fila.Cells[2].Value.ToString());

            controles.Parent.Controls["txt_dire_empresa"].Text = fila.Cells["Direccion"].Value.ToString();
            controles.Parent.Controls["txt_pasi_empresa"].Text = fila.Cells["Pais"].Value.ToString();;
            controles.Parent.Controls["txt_contac_empresa"].Text = fila.Cells["Contacto"].Value.ToString();
            controles.Parent.Controls["txt_tel1_empresa"].Text = fila.Cells["Telefono1"].Value.ToString();
            controles.Parent.Controls["txt_tel2_empresa"].Text = fila.Cells["Telefono2"].Value.ToString();
            controles.Parent.Controls["txt_email_empresa"].Text = fila.Cells["Email"].Value.ToString();
        }

        public void FixComboBox(Control controles)
        {
            //invocar en el load de la clase
            if (ValueCombobox != null)
            {
                ((ComboBox)controles.Parent.Controls["combobox_empresasComboBox"]).SelectedValue = this.ValueCombobox;
                this.ValueCombobox = null;
            }
        }
    }
}
