using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PantallaInicio.BencalethDataSetTableAdapters;

namespace PantallaInicio
{
    public class Voluntarios:Personas
    {
        QueriesTableAdapter BDVoluntario = new QueriesTableAdapter();

        private int _Codigo_Voluntarios;
        public override string Codigo_Persona
        {
            get
            {
                return _Codigo_Voluntarios.ToString ();
            }
            set
            {
                if (Herramientas.IsNumeric(value))
                    _Codigo_Voluntarios = Convert.ToInt32 (value);
            }
        }


        private string _Nombre;

        public string nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value;
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

        public DateTime  _Fecha_Inicio;
        public DateTime  Fecha_Inicio
        {
            get
            {
                return _Fecha_Inicio;
            }
            set
            {
                _Fecha_Inicio = value;
         }
        }    

        private string _Estudios;
        public string Estudios
        {
            get
            {
                return _Estudios;
            }
            set
            {
                _Estudios = value;
         }
        }

        public Decimal Mensualidad;

        private string _Informacion;
        public string Informacion
        {
            get
            {
                return _Informacion;
            }
            set
            {
                _Informacion = value;
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

        private  String _Horas;
        public String  Horas
        {
            get
            {
                return _Horas;
            }
            set
            {
                _Horas= value;
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

        private string _Pais;
        public string Pais
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

        private string _Pasaporte;
        public string Pasaporte
        {
            get
            {
                return _Pasaporte;
            }
            set
            {
                    _Pasaporte = value;
            }
        }

        public override void ingresarDatos(Control controles) {
            
            this.Codigo_Persona=controles.Parent.Controls["txt_Id_Voluntarios"].Text;
            this.Nombre = controles.Parent.Controls["txt_Nom_Voluntarios"].Text;
            this.Apellido = controles.Parent.Controls["txt_Apelli_Voluntarios"].Text;
            this.Genero = Herramientas.determinarCualRadioButtonEsGenero(controles);
            System .DateTime? Fecha_Nacimiento =Convert.ToDateTime(controles.Parent.Controls["date_Fn_Voluntarios"].Text);
            System .DateTime?  Fecha_Inicio =Convert.ToDateTime (controles.Parent.Controls["date_FI_Voluntarios"].Text);
            //decimal? Mensual = 5 ;// Convert.ToDecimal(controles.Parent.Controls["txtbMensualidad"].Text);
            this.Telefono = controles.Parent.Controls["txt_Tel_Voluntarios"].Text;
            this.Correo = controles.Parent.Controls["txt_Email_Voluntarios"].Text;
            this.Horas  = controles.Parent.Controls["txtHoras"].Text;
            this.Informacion = controles.Parent.Controls["txt_Info_Voluntarios"].Text;

            if (!Herramientas.HayCamposNull(controles))
            {
                try
                {
                    BDVoluntario.Insert2_Voluntarios(Codigo_Persona, Nombre, Apellido, Genero, Fecha_Nacimiento, Fecha_Inicio, _Telefono, Correo, Horas, Informacion);
                    MessageBox.Show("Ingresado");

                    controles.Parent.Controls["txt_Id_Voluntarios"].Text = "";
                    controles.Parent.Controls["txt_Nom_Voluntarios"].Text = "";
                    controles.Parent.Controls["txt_Apelli_Voluntarios"].Text = "";
                    controles.Parent.Controls["date_Fn_Voluntarios"].Text = "";
                    controles.Parent.Controls["date_FI_Voluntarios"].Text = "";
                    controles.Parent.Controls["txt_Iden_Voluntarios"].Text = "";
                    controles.Parent.Controls["txt_Tel_Voluntarios"].Text = "";
                    controles.Parent.Controls["txt_Email_Voluntarios"].Text = "";
                    controles.Parent.Controls["txtHoras"].Text = "";
                    controles.Parent.Controls["txt_Info_Voluntarios"].Text = "";
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
            this.Codigo_Persona = controles.Parent.Controls["txt_Id_Voluntarios"].Text;
            this.Nombre = controles.Parent.Controls["txt_Nom_Voluntarios"].Text;
            this.Apellido = controles.Parent.Controls["txt_Apelli_Voluntarios"].Text;
            this.Genero = Herramientas.determinarCualRadioButtonEsGenero(controles);
            System.DateTime? Fecha_Nacimiento = Convert.ToDateTime(controles.Parent.Controls["date_Fn_Voluntarios"].Text);
            System.DateTime? Fecha_Inicio = Convert.ToDateTime(controles.Parent.Controls["date_FI_Voluntarios"].Text);
            decimal? Mensual = Convert.ToDecimal(controles.Parent.Controls["txtbMensualidad"].Text);
            this.Telefono = controles.Parent.Controls["txt_Tel_Voluntarios"].Text;
            this.Correo = controles.Parent.Controls["txt_Email_Voluntarios"].Text;
            this.Horas = controles.Parent.Controls["txtHoras"].Text;
            this.Informacion = controles.Parent.Controls["txt_Info_Voluntarios"].Text;

            if (!Herramientas.HayCamposNull(controles))
            {
                try
                {
                    BDVoluntario.Update2_Voluntarios(Codigo_Persona, Nombre, Apellido, Genero, Fecha_Nacimiento, Fecha_Inicio, _Telefono, Correo, Horas, Informacion);
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
                BDVoluntario.Delete_Voluntarios(ID);
            }
        }

        public override void mostrarDatos(DataGridView dtgrdvw, TextBox txtbBuscado) {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.BuscarSelect_VoluntariosTableAdapter tblAdptEmp = new BuscarSelect_VoluntariosTableAdapter();

            if (!(string.IsNullOrEmpty(txtbBuscado.Text)))
            {
                if (((RadioButton)txtbBuscado.Parent.Controls["rdbtnID"]).Checked)
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Voluntarios, txtbBuscado.Text, null);
                }
                else
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Voluntarios, null, txtbBuscado.Text);
                }
            }
            else
            {
                tblAdptEmp.Fill(dtset.BuscarSelect_Voluntarios, null, null);
            }

            dtgrdvw.DataSource = dtset.BuscarSelect_Voluntarios.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "ID";
            dtgrdvw.Columns[1].HeaderText = "Nombre";
            dtgrdvw.Columns[2].HeaderText = "Apellidos";
            dtgrdvw.Columns[3].HeaderText = "Género";
            dtgrdvw.Columns[4].HeaderText = "Fecha de Nacimiento";
            dtgrdvw.Columns[5].HeaderText = "Fecha de Inicio";
            dtgrdvw.Columns[6].HeaderText = "Teléfono";
            dtgrdvw.Columns[7].HeaderText = "Correo Electrónico";
            dtgrdvw.Columns[8].HeaderText = "Horas";
            dtgrdvw.Columns[9].HeaderText = "Información";
            dtgrdvw.Update();
        }

        public void ConseguirDatosToUpdate(Control controles, DataGridViewRow fila) {
            controles.Parent.Controls["txt_Id_Voluntarios"].Text = fila.Cells[0].Value.ToString();
            controles.Parent.Controls["txt_Nom_Voluntarios"].Text = fila.Cells[1].Value.ToString();
            controles.Parent.Controls["txt_Apelli_Voluntarios"].Text = fila.Cells[2].Value.ToString();

            if (fila.Cells[3].Value.ToString() == "Femenino")
            {
                ((RadioButton)controles.Parent.Controls["radio_mas_Voluntarios"]).Checked = false;
                ((RadioButton)controles.Parent.Controls["radio_fem_Voluntarios"]).Checked = true;
            }
            else
            {
                ((RadioButton)controles.Parent.Controls["radio_mas_Voluntarios"]).Checked = true;
                ((RadioButton)controles.Parent.Controls["radio_fem_Voluntarios"]).Checked = false;
            }

            controles.Parent.Controls["date_Fn_Voluntarios"].Text = fila.Cells[4].Value.ToString();
            controles.Parent.Controls["date_FI_Voluntarios"].Text = fila.Cells[5].Value.ToString();

            //controles.Parent.Controls["txtbMensualidad"].Text = fila.Cells[6].Value.ToString();
            controles.Parent.Controls["txt_Tel_Voluntarios"].Text = fila.Cells[6].Value.ToString();
            controles.Parent.Controls["txt_Email_Voluntarios"].Text = fila.Cells[7].Value.ToString();
            controles.Parent.Controls["txtHoras"].Text = fila.Cells[8].Value.ToString();
            controles.Parent.Controls["txt_Info_Voluntarios"].Text = fila.Cells[9].Value.ToString();
        }

        public void PagarMensualidad(Control ctrls)
        {
            this.Codigo_Persona = ctrls.Parent.Controls["txt_Id_Voluntarios"].Text;
            BDVoluntario.setVoluntarioPago(this.Codigo_Persona,100);
            MessageBox.Show("Se ingreso el registro de pago");
        }
    }
}
