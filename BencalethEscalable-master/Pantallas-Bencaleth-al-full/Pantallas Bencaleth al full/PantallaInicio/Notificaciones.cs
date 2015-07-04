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
    class Notificaciones
    {

        //Constructor
        public Notificaciones(DataGridView dt){
            pendientes = new List<EventoANotificar>();
            intCumpleanoRecurrencia = 30;
            intMensualidadRecurrencia = 30;
            dtgrdvw = dt;

            this.enListarAlcancias();
            this.enlistarFechasNacimientoNinos();
            this.enlistarFechasNacimientoEmpleados();
            this.enlistarFechasNacimientoPadrinos();
            this.enlistarFechasNacimientoVoluntarios();
            this.enlistarFechasMensualidadesVoluntarios();
            this.enlistarFechasMensualidadesPadrinos();
        }
        //variables
        public List<EventoANotificar> pendientes;
        private int intCumpleanoRecurrencia;
        private int intMensualidadRecurrencia;

        public DataGridView dtgrdvw;

        //funciones
        private void getAlcanciasPorTipo(String tipo,int intDias) {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.GetRecurrenciaAlcanciaTableAdapter tblAdpt = new GetRecurrenciaAlcanciaTableAdapter();

            tblAdpt.Fill(dtset.GetRecurrenciaAlcancia, intDias, tipo);

            dtgrdvw.DataSource = dtset.GetRecurrenciaAlcancia.DefaultView;
            dtgrdvw.Update();
            foreach(DataGridViewRow fila in dtgrdvw.Rows){
                pendientes.Add(new EventoANotificar("Recoger " + tipo + "mente", fila.Cells[1].Value.ToString(), "Alcancía", fila.Cells[0].Value.ToString(), fila.Cells[2].Value.ToString(),Herramientas.Alcancias));
            }
        }

        private void enListarAlcancias(){
            //para la recurrencia semanal
                this.getAlcanciasPorTipo("Semanal",7);
            //para la recurrencia mensual
                this.getAlcanciasPorTipo("Mensual",30);
            //para la recurrencia semestral
                this.getAlcanciasPorTipo("Semestral",180);
        }

        private void enlistarFechasNacimientoNinos()
        {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.GetCumpleanosNinosTableAdapter tblAdpt = new GetCumpleanosNinosTableAdapter();

            tblAdpt.Fill(dtset.GetCumpleanosNinos, intCumpleanoRecurrencia);

            dtgrdvw.DataSource = dtset.GetCumpleanosNinos.DefaultView;
            dtgrdvw.Update();

            foreach (DataGridViewRow fila in dtgrdvw.Rows)
            {
                pendientes.Add(new EventoANotificar("Cumpleaños", fila.Cells[1].Value.ToString(), "Niños", fila.Cells[0].Value.ToString(), fila.Cells[2].Value.ToString(),Herramientas.Ninos));
            }
        }

        private void enlistarFechasNacimientoEmpleados()
        {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.GetCumpleanosEmpleadosTableAdapter tblAdpt = new GetCumpleanosEmpleadosTableAdapter();

            tblAdpt.Fill(dtset.GetCumpleanosEmpleados, intCumpleanoRecurrencia);

            dtgrdvw.DataSource = dtset.GetCumpleanosEmpleados.DefaultView;
            dtgrdvw.Update();

            foreach (DataGridViewRow fila in dtgrdvw.Rows)
            {
                pendientes.Add(new EventoANotificar("Cumpleaños", fila.Cells[1].Value.ToString(), "Empleados", fila.Cells[0].Value.ToString(), fila.Cells[2].Value.ToString(),Herramientas.Empleados));
            }
        }

        private void enlistarFechasNacimientoPadrinos()
        {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.GetCumpleanosPadrinosTableAdapter tblAdpt = new GetCumpleanosPadrinosTableAdapter();

            tblAdpt.Fill(dtset.GetCumpleanosPadrinos, intCumpleanoRecurrencia);

            dtgrdvw.DataSource = dtset.GetCumpleanosPadrinos.DefaultView;
            dtgrdvw.Update();

            foreach (DataGridViewRow fila in dtgrdvw.Rows)
            {
                pendientes.Add(new EventoANotificar("Cumpleaños", fila.Cells[1].Value.ToString(), "Padrinos", fila.Cells[0].Value.ToString(), fila.Cells[2].Value.ToString(),Herramientas.Padrinos));
            }
        }

        private void enlistarFechasNacimientoVoluntarios()
        {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.GetCumpleanosVoluntariosTableAdapter tblAdpt = new GetCumpleanosVoluntariosTableAdapter();

            tblAdpt.Fill(dtset.GetCumpleanosVoluntarios, intCumpleanoRecurrencia);

            dtgrdvw.DataSource = dtset.GetCumpleanosVoluntarios.DefaultView;
            dtgrdvw.Update();

            foreach (DataGridViewRow fila in dtgrdvw.Rows)
            {
                pendientes.Add(new EventoANotificar("Cumpleaños", fila.Cells[1].Value.ToString(), "Voluntarios", fila.Cells[0].Value.ToString(), fila.Cells[2].Value.ToString(),Herramientas.Voluntarios));
            }
        }

        private void enlistarFechasBodas()
        {

        }

        private void enlistarFechasMensualidadesVoluntarios() {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.GetDeudoresVoluntariosTableAdapter tblAdpt = new GetDeudoresVoluntariosTableAdapter();

            tblAdpt.Fill(dtset.GetDeudoresVoluntarios, intMensualidadRecurrencia);

            dtgrdvw.DataSource = dtset.GetDeudoresVoluntarios.DefaultView;
            dtgrdvw.Update();

            foreach (DataGridViewRow fila in dtgrdvw.Rows)
            {
                pendientes.Add(new EventoANotificar("Pago mensualidad", fila.Cells[1].Value.ToString(), "Voluntarios", fila.Cells[0].Value.ToString(), fila.Cells[2].Value.ToString(),Herramientas.Voluntarios));
            }
        }

        private void enlistarFechasMensualidadesPadrinos()
        {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.GetDeudoresPadrinosTableAdapter tblAdpt = new GetDeudoresPadrinosTableAdapter();

            tblAdpt.Fill(dtset.GetDeudoresPadrinos, intMensualidadRecurrencia);

            dtgrdvw.DataSource = dtset.GetDeudoresPadrinos.DefaultView;
            dtgrdvw.Update();

            foreach (DataGridViewRow fila in dtgrdvw.Rows)
            {
                pendientes.Add(new EventoANotificar("Pago mensualidad", fila.Cells[1].Value.ToString(), "Padrinos", fila.Cells[0].Value.ToString(), fila.Cells[2].Value.ToString(),Herramientas.Padrinos));
            }
        }

        public Label[] mostrarLista() {
            List<Label> labels = new List<Label>();
            foreach (EventoANotificar evento in pendientes)
            {
                Label etiqueta=new Label();
                
                labels.Add(etiqueta);
            }
            
            return labels.ToArray();
        }

    }
}
