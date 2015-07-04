using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PantallaInicio.BencalethDataSetTableAdapters;

namespace PantallaInicio
{
    public class Padrinos:Personas
    {
        QueriesTableAdapter BDpadrinos = new QueriesTableAdapter();

        public Decimal Mensualidad;

        private string _Codigo_Padrino;
        public override string Codigo_Persona
        {
            get
            {
                return _Codigo_Padrino;
            }
            set
            {
                _Codigo_Padrino = value;
            }
        }

        private string _Identidad;

        private DateTime _Fecha_Cobro;
        public DateTime Fecha_Cobro
        {
            get
            {
                return _Fecha_Cobro;
            }
            set
            {
                _Fecha_Cobro = value;
         }
        }

        private DateTime _Fecha_Bodas;
        public DateTime Fecha_Bodas
        {
            get
            {
                return _Fecha_Bodas;
            }
            set
            {
                _Fecha_Bodas = value;
            }
        }

      private string _Correo;
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

      private string _Direccion;
      public string Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                _Direccion= value;
         }
        }

        private string _Telefono;

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

        public override void ingresarDatos(Control controles) {
            this.Codigo_Persona = controles.Parent.Controls["txt_Id_Padrinos"].Text;
            this.Nombre = controles.Parent.Controls["txt_Nom_padrinos"].Text;
            this.Apellido = controles.Parent.Controls["txt_apellido_padrinos"].Text;
            this.Genero = Herramientas.determinarCualRadioButtonEsGenero(controles);
            System.DateTime? Fecha_Nacimiento = Convert.ToDateTime(controles.Parent.Controls["ddate_Fn_padrinos"].Text);
            System.DateTime? Fecha_Inicio = Convert.ToDateTime(controles.Parent.Controls["date_Fi_padrinos"].Text);
            this.Mensualidad = string.IsNullOrEmpty(controles.Parent.Controls["txt_Mens_Padrinos"].Text.ToString()) ? 0 : Convert.ToDecimal(controles.Parent.Controls["txt_Mens_Padrinos"].Text.ToString());
            this._Identidad = controles.Parent.Controls["txt_iden_padrinos"].Text;
            this._Telefono = controles.Parent.Controls["txt_Tel_Padrinos"].Text;
            this.Correo = controles.Parent.Controls["txt_Email_Padrinos"].Text;
            this._Direccion = controles.Parent.Controls["txtbDireccion"].Text;

            if (!Herramientas.HayCamposNull(controles))
            {
                try
                {
                    BDpadrinos.Insert_Padrinos2(this.Codigo_Persona, this.Nombre, this.Apellido, this.Genero, Fecha_Nacimiento, Fecha_Inicio, this._Identidad, this._Telefono, this.Correo, this.Mensualidad, this._Direccion);
                    
                    MessageBox.Show("Ingresado");

                    controles.Parent.Controls["txt_Id_Padrinos"].Text = "";
                    controles.Parent.Controls["txt_Nom_padrinos"].Text = "";
                    controles.Parent.Controls["txt_apellido_padrinos"].Text = "";
                    controles.Parent.Controls["txt_Mens_Padrinos"].Text = "";
                    controles.Parent.Controls["txt_iden_padrinos"].Text = "";
                    controles.Parent.Controls["txt_Email_Padrinos"].Text = "";
                    controles.Parent.Controls["txt_Tel_Padrinos"].Text = "";
                    controles.Parent.Controls["txtbDireccion"].Text = "";
                }
                catch (SqlException e)
                {
                    switch(e.Number){
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
            this.Codigo_Persona = controles.Parent.Controls["txt_Id_Padrinos"].Text;
            this.Nombre = controles.Parent.Controls["txt_Nom_padrinos"].Text;
            this.Apellido = controles.Parent.Controls["txt_apellido_padrinos"].Text;
            this.Genero = Herramientas.determinarCualRadioButtonEsGenero(controles);
            System.DateTime? Fecha_Nacimiento = Convert.ToDateTime(controles.Parent.Controls["ddate_Fn_padrinos"].Text);
            System.DateTime? Fecha_Inicio = Convert.ToDateTime(controles.Parent.Controls["date_Fi_padrinos"].Text);
            this.Mensualidad = string.IsNullOrEmpty(controles.Parent.Controls["txt_Mens_Padrinos"].Text.ToString()) ? 0 : Convert.ToDecimal(controles.Parent.Controls["txt_Mens_Padrinos"].Text.ToString());
            this._Identidad = controles.Parent.Controls["txt_iden_padrinos"].Text;
            this._Telefono = controles.Parent.Controls["txt_Tel_Padrinos"].Text;
            this.Correo = controles.Parent.Controls["txt_Email_Padrinos"].Text;
            this._Direccion = controles.Parent.Controls["txtbDireccion"].Text;

            if (!(Herramientas.HayCamposNull(controles)))
            {
                try
                {
                    BDpadrinos.Update_Padrinos2(this.Codigo_Persona, this.Nombre, this.Apellido, this.Genero, Fecha_Nacimiento, Fecha_Inicio, this._Identidad, this._Telefono, this.Correo, this.Mensualidad, this._Direccion);
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
                BDpadrinos.Delete_Padrinos2(ID);
            }
        }

        public override void mostrarDatos(DataGridView dtgrdvw, TextBox txtbBuscado)
        {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.BuscarSelect_PadrinosTableAdapter tblAdptEmp = new BuscarSelect_PadrinosTableAdapter();

            if (!(string.IsNullOrEmpty(txtbBuscado.Text)))
            {
                if (((RadioButton)txtbBuscado.Parent.Controls["rdbtnID"]).Checked)
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Padrinos, txtbBuscado.Text, null);
                }
                else
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Padrinos, null, txtbBuscado.Text);
                }
            }
            else {
                tblAdptEmp.Fill(dtset.BuscarSelect_Padrinos, null, null);
            }

            dtgrdvw.DataSource = dtset.BuscarSelect_Padrinos.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "ID";
            dtgrdvw.Columns[1].HeaderText = "Nombre";
            dtgrdvw.Columns[2].HeaderText = "Apellidos";
            dtgrdvw.Columns[3].HeaderText = "Género";
            dtgrdvw.Columns[4].HeaderText = "Dirección";
            dtgrdvw.Columns[5].HeaderText = "Fecha de Nacimiento";
            dtgrdvw.Columns[6].HeaderText = "Fecha de Inicio";
            dtgrdvw.Columns[7].HeaderText = "Identidad";
            dtgrdvw.Columns[8].HeaderText = "Teléfono";
            dtgrdvw.Columns[9].HeaderText = "Correo Electrónico";
            dtgrdvw.Columns[10].HeaderText = "Monto";
            dtgrdvw.Update();
        }

        public void ConseguirDatosToUpdate(Control controles,DataGridViewRow fila)
        {
            //MessageBox.Show(fila.Cells[0].Value.ToString());

            controles.Parent.Controls["txt_Id_Padrinos"].Text = fila.Cells[0].Value.ToString();
            controles.Parent.Controls["txt_Nom_padrinos"].Text = fila.Cells[1].Value.ToString();
            controles.Parent.Controls["txt_apellido_padrinos"].Text = fila.Cells[2].Value.ToString();

            if (fila.Cells[3].Value.ToString() == "Femenino")
            {
                ((RadioButton)controles.Parent.Controls["radio_mas_Padrinos"]).Checked = false;
                ((RadioButton)controles.Parent.Controls["radio_fem_Padrinos"]).Checked = true;
            }
            else
            {
                ((RadioButton)controles.Parent.Controls["radio_mas_Padrinos"]).Checked = true;
                ((RadioButton)controles.Parent.Controls["radio_fem_Padrinos"]).Checked = false;
            }

            controles.Parent.Controls["txtbDireccion"].Text = fila.Cells[4].Value.ToString();
            controles.Parent.Controls["ddate_Fn_padrinos"].Text = fila.Cells[5].Value.ToString();
            controles.Parent.Controls["date_Fi_padrinos"].Text = fila.Cells[6].Value.ToString();
            controles.Parent.Controls["txt_iden_padrinos"].Text = fila.Cells[7].Value.ToString();
            controles.Parent.Controls["txt_Tel_Padrinos"].Text = fila.Cells[8].Value.ToString();
            controles.Parent.Controls["txt_Email_Padrinos"].Text = fila.Cells[9].Value.ToString();
            //controles.Parent.Controls["txt_Mens_Padrinos"].Text = Convert.ToInt32(fila.Cells["Monto"].Value.ToString()).ToString();
            string palabra = fila.Cells["Monto"].Value.ToString();
            palabra = palabra.Remove(palabra.IndexOf(","));
            controles.Parent.Controls["txt_Mens_Padrinos"].Text = palabra;
        }

        public void PagarMensualidad(Control ctrls) {
            this.Codigo_Persona = ctrls.Parent.Controls["txt_Id_Padrinos"].Text;
            this.Mensualidad = string.IsNullOrEmpty(ctrls.Parent.Controls["txt_Mens_Padrinos"].Text.ToString()) ? 0 : Convert.ToDecimal(ctrls.Parent.Controls["txt_Mens_Padrinos"].Text.ToString());
            BDpadrinos.setPadrinoPago(this.Codigo_Persona, this.Mensualidad);
            MessageBox.Show("Se ingreso el registro de pago");
        }
    }
}
