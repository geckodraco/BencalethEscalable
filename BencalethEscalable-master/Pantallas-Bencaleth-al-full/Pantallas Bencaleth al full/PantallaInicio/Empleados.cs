using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PantallaInicio.BencalethDataSetTableAdapters;

namespace PantallaInicio
{
    class Empleados:Personas
    {
        QueriesTableAdapter BDPersonas = new QueriesTableAdapter();
        public string Id;
 
        private string _Direccion;

       public string Direccion
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

       private string _Apellido;
       public string Apellido
       {
           get
           {
               return _Apellido;
           }
           set
           {
               _Apellido = value;
           }
       }

      
      

        private DateTime _Fecha_de_Contratacion;
         public DateTime  Fecha_de_Contratacion
        {
            get
            {
                return _Fecha_de_Contratacion;
            }
            set
            {
                _Fecha_de_Contratacion = value;
         }
        }

         private DateTime _Fecha_de_Nacimiento;
         public DateTime Fecha_de_Nacimiento
         {
             get
             {
                 return _Fecha_de_Nacimiento;
             }
             set
             {
                 _Fecha_de_Nacimiento = value;
             }
         }
         private string _Cargo;
         public string Cargo
        {
            get
            {
                return _Cargo;
            }
            set
            {
                _Cargo = value;
         }
        }

         private int _Identidad;
         public string Identidad
         {
             get
             {
                 return _Identidad.ToString();
             }
             set
             {
                 if (Herramientas.IsNumeric(value))
                     _Identidad = Convert.ToInt16(value);
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

        public string _Correo;
        public string Correo
        {
            get
            {
                return _Correo;
            }
            set
            {
                _Correo = value;
            }
        }

        private object ValueCombobox = null;

        private string _strGenero;

        public override void ingresarDatos(Control controles) {
            this.Id = controles.Parent.Controls["txt_Id_Emple"].Text;
            this.Direccion = controles.Parent.Controls["txt_Dir_Emple"].Text;
            this.Nombre = controles.Parent.Controls["txt_Nom_Emple"].Text;
            this.Apellido = controles.Parent.Controls["txt_Apelli_Emple"].Text;
            System.DateTime? Naci = Convert.ToDateTime(controles.Parent.Controls["date_FechN_Emple"].Text);
            System.DateTime? Contra = Convert.ToDateTime(controles.Parent.Controls["Date_FechIn_Emple"].Text);
            this.Telefono= controles.Parent.Controls["txt_Tel_Emple"].Text;
            this.Correo= controles.Parent.Controls["txt_Email_Emple"].Text;
            this.Direccion= controles.Parent.Controls["txt_Dir_Emple"].Text;
            this._strGenero = Herramientas.determinarCualRadioButtonEsGenero(controles);
           
            string combo = ((ComboBox)controles.Parent.Controls["combobox_CargoTipoComboBox"]).SelectedValue.ToString();

            if (!Herramientas.HayCamposNull(controles))
            {
                try
                {
                    BDPersonas.Insert_Empleados(this.Id, this.Nombre, _Apellido, Naci, Contra, Direccion, _Telefono, combo, Correo,this._strGenero);
                    MessageBox.Show("Ingresado");

                    controles.Parent.Controls["txt_Id_Emple"].Text = "";
                    controles.Parent.Controls["txt_Dir_Emple"].Text = "";
                    controles.Parent.Controls["txt_Nom_Emple"].Text = "";
                    controles.Parent.Controls["txt_Apelli_Emple"].Text = "";
                    controles.Parent.Controls["txt_Tel_Emple"].Text = "";
                    controles.Parent.Controls["txt_Email_Emple"].Text = "";
                    controles.Parent.Controls["txt_Dir_Emple"].Text = "";
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

        public override void actualizarDatos(Control controles) {
            this.Id = controles.Parent.Controls["txt_Id_Emple"].Text;
            this.Direccion = controles.Parent.Controls["txt_Dir_Emple"].Text;
            this.Nombre = controles.Parent.Controls["txt_Nom_Emple"].Text;
            this.Apellido = controles.Parent.Controls["txt_Apelli_Emple"].Text;
            System.DateTime? Naci = Convert.ToDateTime(controles.Parent.Controls["date_FechN_Emple"].Text);
            System.DateTime? Contra = Convert.ToDateTime(controles.Parent.Controls["Date_FechIn_Emple"].Text);
            this.Telefono = controles.Parent.Controls["txt_Tel_Emple"].Text;
            this.Correo = controles.Parent.Controls["txt_Email_Emple"].Text;
            this.Direccion = controles.Parent.Controls["txt_Dir_Emple"].Text;
            this._strGenero = Herramientas.determinarCualRadioButtonEsGenero(controles);

            string combo = ((ComboBox)controles.Parent.Controls["combobox_CargoTipoComboBox"]).SelectedValue.ToString();

            if (!Herramientas.HayCamposNull(controles))
            {
                try
                {
                    BDPersonas.update_Empleados(this.Id, this.Nombre, _Apellido, Naci, Contra, Direccion, _Telefono, combo, Correo,this._strGenero);
                    MessageBox.Show("Actualizado");
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

        public override void DeleteDatos(string ID) { 
            if(!string.IsNullOrEmpty(ID)){
                try
                {
                    BDPersonas.Delete_Empleados(ID);
                }
                catch(SqlException) {
                    MessageBox.Show("Actualmente esta encargado a un Niño");
                }
            }
        }

        public override void mostrarDatos(DataGridView dtgrdvw, TextBox txtbBuscado) {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.BuscarSelect_EmpleadosTableAdapter tblAdptEmp = new BuscarSelect_EmpleadosTableAdapter();

            if (!(string.IsNullOrEmpty(txtbBuscado.Text)))
            {
                if (((RadioButton)txtbBuscado.Parent.Controls["rdbtnID"]).Checked)
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Empleados, txtbBuscado.Text, null);
                }
                else
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Empleados, null, txtbBuscado.Text);
                }
            }
            else
            {
                tblAdptEmp.Fill(dtset.BuscarSelect_Empleados, null, null);
            }

            dtgrdvw.DataSource = dtset.BuscarSelect_Empleados.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "ID";
            dtgrdvw.Columns[1].HeaderText = "Nombre";
            dtgrdvw.Columns[2].HeaderText = "Apellidos";
            dtgrdvw.Columns[3].HeaderText = "Género";
            dtgrdvw.Columns[4].HeaderText = "Fecha de Nacimiento";
            dtgrdvw.Columns[5].HeaderText = "Fecha de Contratación";
            dtgrdvw.Columns[6].HeaderText = "Dirección";
            dtgrdvw.Columns[7].HeaderText = "Teléfono";
            dtgrdvw.Columns[8].HeaderText = "Cargo";
            dtgrdvw.Columns[9].HeaderText = "Correo Electrónico";
            //dtgrdvw.Columns[9].HeaderText = "Género";
            dtgrdvw.Update();
        }

        public void ConseguirDatosToUpdate(Control controles, DataGridViewRow fila) {
            controles.Parent.Controls["txt_Id_Emple"].Text =fila.Cells["Id"].Value.ToString();
            controles.Parent.Controls["txt_Dir_Emple"].Text = fila.Cells["Direccion"].Value.ToString();
            controles.Parent.Controls["txt_Nom_Emple"].Text = fila.Cells["Nombre"].Value.ToString();

            controles.Parent.Controls["txt_Apelli_Emple"].Text = fila.Cells["Apellido"].Value.ToString();
            controles.Parent.Controls["txt_Tel_Emple"].Text = fila.Cells["Telefono"].Value.ToString();
            controles.Parent.Controls["txt_Email_Emple"].Text = fila.Cells["correo"].Value.ToString();

            if (fila.Cells[3].Value.ToString() == "Femenino")
            {
                ((RadioButton)controles.Parent.Controls["radio_mas_Emple"]).Checked = false;
                ((RadioButton)controles.Parent.Controls["radio_fem_Emple"]).Checked = true;
            }
            else
            {
                ((RadioButton)controles.Parent.Controls["radio_mas_Emple"]).Checked = true;
                ((RadioButton)controles.Parent.Controls["radio_fem_Emple"]).Checked = false;
            }

            controles.Parent.Controls["date_FechN_Emple"].Text = fila.Cells["Fecha_Nacimiento"].Value.ToString();
            controles.Parent.Controls["Date_FechIn_Emple"].Text = fila.Cells["Fecha_Contratacion"].Value.ToString();

            //((ComboBox)controles.Parent.Controls["combobox_CargoTipoComboBox"]).SelectedValue = fila.Cells["Cargo"].Value;
            //this.ValueCombobox = BDAlcancias.GetIDToComboBoxRecur_Alcancias(fila.Cells["Recurrencia"].Value.ToString());
            this.ValueCombobox = BDPersonas.GetIDToComboBoxCargoTipo_Empleados(fila.Cells["Cargo"].Value.ToString());
        }

        public void FixComboBox(Control controles)
        {
            //invocar en el load de la clase
            if (ValueCombobox != null)
            {
                ((ComboBox)controles.Parent.Controls["combobox_CargoTipoComboBox"]).SelectedValue = this.ValueCombobox;
                this.ValueCombobox = null;
            }
        }
    }
}
