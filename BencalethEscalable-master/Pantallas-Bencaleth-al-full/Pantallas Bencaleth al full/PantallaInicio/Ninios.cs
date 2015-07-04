using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PantallaInicio.BencalethDataSetTableAdapters;

namespace PantallaInicio
{
    public class Ninios : Personas
    {
        QueriesTableAdapter BDninios = new QueriesTableAdapter();

        private string _Codigo_Persona;
        public override string Codigo_Persona
        {
            get
            {
                return _Codigo_Persona;
            }
            set
            {
                _Codigo_Persona = value;
            }
        }

        private string _Responsable;
        public string Responsable
        {
            get
            {
                return _Responsable;
            }
            set
            {
                _Responsable = value;
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

        private string _Genero;
        public string Genero
        {
            get
            {
                return _Genero;
            }
            set
            {
                _Genero = value;
            }
        }

        private DateTime _Defuncion;
        public DateTime Defuncion
        {
            get
            {
                return _Defuncion;
            }
            set
            {
                _Defuncion = value;
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

        private object ValueCombobox = null;

        public override void ingresarDatos(Control controles)
        {
            this.Codigo_Persona = controles.Parent.Controls["txt_idniños"].Text;
            this.Nombre = controles.Parent.Controls["txt_nomniños"].Text;
            this.Apellido = controles.Parent.Controls["txt_apellido"].Text;
            this.Genero = Herramientas.determinarCualRadioButtonEsGenero(controles);
            System.DateTime? naci = Convert.ToDateTime(controles.Parent.Controls["fech_niños"].Text);
            System.DateTime? ingreso = Convert.ToDateTime(controles.Parent.Controls["fech_ingre"].Text);
            this.Responsable = ((ComboBox)controles.Parent.Controls["comboboxResponsablesComboBox"]).SelectedValue.ToString();

            if (!Herramientas.HayCamposNull(controles))
            {
                try
                {
                    BDninios.Insert_Niños(this.Codigo_Persona, this.Nombre, this.Apellido, this.Genero, naci, ingreso, this.Responsable);
                    MessageBox.Show("Ingresado");

                    controles.Parent.Controls["txt_idniños"].Text = "";
                    controles.Parent.Controls["txt_nomniños"].Text = "";
                    controles.Parent.Controls["txt_apellido"].Text = "";
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
            this.Codigo_Persona = controles.Parent.Controls["txt_idniños"].Text;
            this.Nombre = controles.Parent.Controls["txt_nomniños"].Text;
            this.Apellido = controles.Parent.Controls["txt_apellido"].Text;
            this.Genero = Herramientas.determinarCualRadioButtonEsGenero(controles);
            System.DateTime? naci = Convert.ToDateTime(controles.Parent.Controls["fech_niños"].Text);
            System.DateTime? ingreso = Convert.ToDateTime(controles.Parent.Controls["fech_ingre"].Text);
            this.Responsable = ((ComboBox)controles.Parent.Controls["comboboxResponsablesComboBox"]).SelectedValue.ToString();

            if (!Herramientas.HayCamposNull(controles))
            {
                try
                {
                    BDninios.Update_Ninos2(this.Codigo_Persona, this.Nombre, this.Apellido, this.Genero, naci, ingreso, this.Responsable);
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
                BDninios.Delete_Ninos(ID);
            }
        }

        public override void mostrarDatos(DataGridView dtgrdvw, TextBox txtbBuscado)
        {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.BuscarSelect_NinosTableAdapter tblAdptEmp = new BuscarSelect_NinosTableAdapter();

            if (!(string.IsNullOrEmpty(txtbBuscado.Text)))
            {
                if (((RadioButton)txtbBuscado.Parent.Controls["rdbtnID"]).Checked)
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Ninos, txtbBuscado.Text, null);
                }
                else
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Ninos, null, txtbBuscado.Text);
                }
            }
            else
            {
                tblAdptEmp.Fill(dtset.BuscarSelect_Ninos, null, null);
            }

            dtgrdvw.DataSource = dtset.BuscarSelect_Ninos.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "Identidad";
            dtgrdvw.Columns[1].HeaderText = "Nombre";
            dtgrdvw.Columns[2].HeaderText = "Apellidos";
            dtgrdvw.Columns[3].HeaderText = "Género";
            dtgrdvw.Columns[4].HeaderText = "Fecha de Nacimiento";
            dtgrdvw.Columns[5].HeaderText = "Fecha de Ingreso";
            dtgrdvw.Columns[6].HeaderText = "Encargado";
            dtgrdvw.Update();
        }

        public void ConseguirDatosToUpdate(Control controles, DataGridViewRow fila) {
            controles.Parent.Controls["txt_idniños"].Text = fila.Cells[0].Value.ToString();
            controles.Parent.Controls["txt_nomniños"].Text = fila.Cells[1].Value.ToString();
            controles.Parent.Controls["txt_apellido"].Text = fila.Cells[2].Value.ToString();

            if (fila.Cells[3].Value.ToString() == "Femenino")
            {
                ((RadioButton)controles.Parent.Controls["radio_mas_Niños"]).Checked = false;
                ((RadioButton)controles.Parent.Controls["radio_fem_Niños"]).Checked = true;
            }
            else
            {
                ((RadioButton)controles.Parent.Controls["radio_mas_Niños"]).Checked = true;
                ((RadioButton)controles.Parent.Controls["radio_fem_Niños"]).Checked = false;
            }
            
            controles.Parent.Controls["fech_niños"].Text = fila.Cells[4].Value.ToString();
            controles.Parent.Controls["fech_ingre"].Text = fila.Cells[5].Value.ToString();

            //((ComboBox)controles.Parent.Controls["comboboxResponsablesComboBox"]).SelectedValue = fila.Cells[6].Value;
            this.ValueCombobox = BDninios.GetIDToComboBoxResponsable_Empleados(fila.Cells[6].Value.ToString());
        }

        public void FixComboBox(Control controles)
        {
            //invocar en el load de la clase
            if (ValueCombobox != null)
            {
                ((ComboBox)controles.Parent.Controls["comboboxResponsablesComboBox"]).SelectedValue = this.ValueCombobox;
                this.ValueCombobox = null;
            }
        }
    }
}
