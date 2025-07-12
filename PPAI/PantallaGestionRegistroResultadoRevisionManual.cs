using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI
{
    public partial class PantallaGestionRegistroResultadoRevisionManual : Form
    {
        public EventoSismico seleccionEventoSismicoSeleccionado;
        public PantallaGestionRegistroResultadoRevisionManual()
        {
            InitializeComponent();
        }



        private void seleccionarOpciónRegistrarResultadoDeRevisiónManual(object sender, EventArgs e)
        {
            HabilitarVentana();
            var gestor = new GestorRegistroResultadoRevisionManual();
            var eventos = gestor.buscarSismosAutoDetectadosNoRevisados();

            gestor.buscarSismosAutoDetectadosPendienteDeRevision(eventos);


            gestor.ordenarEventosSismicosPorFechaYHora(eventos);
            mostrarEventosSismicosEncontradosOrdenados(eventos);
            solicitarSeleccionEventoSismico();

        }
        private void HabilitarVentana()
        {
            boton_opcion.Visible = false;
            dgvDatosEventos.Visible = true;
        }
        private void mostrarEventosSismicosEncontradosOrdenados(List<EventoSismico> eventos)
        {
            dgvDatosEventos.DataSource = eventos.OrderBy(ev => ev.FechaHoraOcurrencia).ToList();

            // Configurar columnas para formatear fecha y demás si quieres
            dgvDatosEventos.Columns["FechaHoraOcurrencia"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

            // Opcional: cambiar títulos de columnas o visibilidad
            dgvDatosEventos.Columns["LatitudEpicentro"].HeaderText = "Lat Epicentro";
            dgvDatosEventos.Columns["LongitudEpicentro"].HeaderText = "Long Epicentro";
            dgvDatosEventos.Columns["ValorMagnitud"].HeaderText = "Magnitud";

            dgvDatosEventos.Columns["FechaHoraFin"].Visible = false;
            dgvDatosEventos.Columns["Estado"].Visible = false;
            dgvDatosEventos.Columns["CambioEstado"].Visible = false;
            dgvDatosEventos.Columns["clasificacionSismo"].Visible = false;
            dgvDatosEventos.Columns["origenDeGeneracion"].Visible = false;
            dgvDatosEventos.Columns["alcanceSismo"].Visible = false;
        }
        private void solicitarSeleccionEventoSismico()
        {
            //esta bien que requiera interaccion de usuario?
            lblSeleccionarEvento.Text = "Seleccionar un evento sismico";
        }

        private void tomarSeleccionEventoSismico(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDatosEventos.CurrentRow != null)
            {
                seleccionEventoSismicoSeleccionado = dgvDatosEventos.CurrentRow.DataBoundItem as EventoSismico;
                var gestor = new GestorRegistroResultadoRevisionManual();
                gestor.tomarSeleccionEventoSismico(seleccionEventoSismicoSeleccionado);



            }


        }
        public void mostrarDatosEventoSismicoSeleccionado(EventoSismico evento)
        {


            // Armamos un mensaje con los datos del evento
            string mensaje = $"Clasificación: {evento.clasificacionSismo?.nombre ?? "Sin datos"}\n" +
                             $"Origen de Generación: {evento.origenDeGeneracion?.descripcion ?? "Sin datos"}\n" +
                             $"Alcance: {evento.alcanceSismo.alcance}";

            // Mostramos el mensaje
            MessageBox.Show(mensaje, "Datos del Evento Sísmico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GestorRegistroResultadoRevisionManual gestor = new GestorRegistroResultadoRevisionManual();
            gestor.obtenerValoresAlcanzadosDeSeriesTemporales(evento);

        }
        public void habilitarOpcionVisualizacionMapaConEstacionesSismologicasInvolucradas(string rutaImagen)
        {
            // Primer mensaje informativo
            // Crear un nuevo formulario
            Form imagenForm = new Form();
            imagenForm.Text = "Imagen del Sismo";
            imagenForm.Size = new Size(800, 600);

            // Crear el PictureBox
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile("C:\\Users\\pablo\\Desktop\\sismo.jpg");
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Ajustar imagen al tamaño del PictureBox
            pictureBox.Dock = DockStyle.Fill;

            // Agregar el PictureBox al formulario
            imagenForm.Controls.Add(pictureBox);

            // Mostrar el formulario
            imagenForm.ShowDialog(); // o Show() si no querés bloquear el form actual

            // Segundo mensaje de confirmación
            var resultado = MessageBox.Show(
                "¿Querés visualizar el evento sísmico en el mapa?",
                "Confirmar visualización",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("ERROR");      
            }
            else
            {
                tomarSeleccionDeNoVisualizacion();
            }
        }

        public void tomarSeleccionDeNoVisualizacion()
        {
            consultarModificacionDatos();
        }
        public void consultarModificacionDatos()
        {
            var resultadoModificacion = MessageBox.Show(
                "¿Querés modificar los siguientes datos del evento sísmico?\n- Magnitud\n- Alcance\n- Origen de generación",
                "Modificar datos del evento sísmico",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultadoModificacion == DialogResult.Yes)
            {
                // Lógica para habilitar modificación
                MessageBox.Show("Error");
            }
            else
            {
                tomarSeleccionDeNoModificacion();
            }
        }
        public void tomarSeleccionDeNoModificacion() 
        {
            
            solicitarConfirmarRechazarRevisarEvento();
        }
        public void solicitarConfirmarRechazarRevisarEvento()
        {
            var resultado = MessageBox.Show(
                "Seleccioná una acción para el evento sísmico:\n\nSí = Confirmar evento\nNo = Rechazar evento\nCancelar = Solicitar revisión a experto",
                "Acción requerida",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            switch (resultado)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Se confirmó el evento." +
                        "Estado del evento sismico: Confirmado");
                    Estado estado = new Estado("Confirmado", "EventoSismico");
                    break;

                case DialogResult.No:
                    tomarSeleccionRechazo();
                    break;

                case DialogResult.Cancel:
                    MessageBox.Show("Se solicitó revisión a un experto." +
                        "Estado del evento sismico: Derivado a experto");
                   estado = new Estado("Derivado a experto", "EventoSismico");
                    break;
            }
        }

        public void tomarSeleccionRechazo()
        {
            MessageBox.Show("El evento sísmico ha sido rechazado.");
            GestorRegistroResultadoRevisionManual gestor = new GestorRegistroResultadoRevisionManual();
            EventoSismico seleccionado = new EventoSismico();
            gestor.validarDatosEvento(seleccionado);

        }

        private void PantallaGestionRegistroResultadoRevisionManual_Load(object sender, EventArgs e)
        {

        }
    }
}