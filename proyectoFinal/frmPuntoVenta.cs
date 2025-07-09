using ClsVentasA;
using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace proyectoFinal
{
    public partial class frmPuntoVenta : Form
    {
        public frmPuntoVenta()
        {
            InitializeComponent();
        }

        #region funciones

        /// <summary>
        /// Valida el campo de texto del nombre usando expresiones regulares.
        /// Muestra un mensaje de error si el campo está vacío o no cumple con el formato.
        /// </summary>
        public void ValidandoName()
        {
            String patron = "[A-Za-z ]{3,50}";
            // Valida si el campo de texto está vacío.
            if (String.IsNullOrEmpty(txtNombre.Text) == true)
            {
                txtNombre.Focus();
                errName.SetError(txtNombre, "No debe dejar esta celda vacia");
            }
            // Valida si el texto no coincide con el patrón (letras y espacios, de 3 a 50 caracteres).
            else if (!Regex.IsMatch(txtNombre.Text, patron))
            {
                txtNombre.Focus();
                errName.SetError(txtNombre, "Tiene que tener entre 3 y 30 caracteres");
            }
            else
            {
                // Si la validación es correcta, limpia el ícono de error.
                errName.Clear();
            }
        }

        /// <summary>
        /// Valida el campo de texto del origen de manera similar a la validación del nombre.
        /// </summary>
        public void ValidandoOrigen()
        {
            String patron = "[A-Za-z ]{3,50}";
            if (String.IsNullOrEmpty(txtOrigen.Text) == true)
            {
                txtOrigen.Focus();
                errOrigen.SetError(txtOrigen, "No debe dejar esta celda vacia");
            }
            else if (!Regex.IsMatch(txtOrigen.Text, patron))
            {
                txtOrigen.Focus();
                errOrigen.SetError(txtOrigen, "Tiene que tener entre 3 y 30 caracteres");
            }
            else
            {
                errOrigen.Clear();
            }
        }

        /// <summary>
        /// Función de validación booleana simplificada para el nombre.
        /// </summary>
        /// <returns>Verdadero si el nombre es válido, de lo contrario falso.</returns>
        public bool VName()
        {
            string patron = @"^[A-Za-z ]{3,50}$";
            return !string.IsNullOrEmpty(txtNombre.Text) && Regex.IsMatch(txtNombre.Text, patron);
        }

        /// <summary>
        /// Genera un ID de ticket único combinando partes del vuelo, nombre, asiento y un número aleatorio.
        /// </summary>
        /// <returns>Una cadena de texto con el ID del ticket.</returns>
        private string GenerarID(string Nvuelo, string nombre, string numeroAsiento)
        {
            // Combina subcadenas de los datos para crear una base para el ID.
            string parteClave = Nvuelo.Substring(0, 3);
            string parteNombre = nombre.Substring(0, 3);
            string parteAsiento = numeroAsiento.ToString();
            // Agrega un número aleatorio para asegurar unicidad.
            Random ran = new Random();
            int seg = ran.Next(300, 9999);
            return parteClave + parteNombre + parteAsiento + seg.ToString();
        }

        /// <summary>
        /// Procesa la inserción de tickets para una lista de pasajeros y asientos seleccionados.
        /// </summary>
        private void InsertarTicketsPorPasajeros(List<string> nombresPasajeros)
        {
            // Obtiene solo las celdas de asiento que han sido seleccionadas.
            var celdas = dtgAsiento.SelectedCells
                .Cast<DataGridViewCell>()
                .Where(c => !string.IsNullOrWhiteSpace(c.Value?.ToString()))
                .OrderBy(c => c.RowIndex * 10 + c.ColumnIndex)
                .ToList();

            // Valida que el número de pasajeros coincida con el número de asientos.
            if (celdas.Count != nombresPasajeros.Count)
            {
                MessageBox.Show("La cantidad de pasajeros no coincide con la cantidad de asientos seleccionados.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idVuelo = (int)cbxDestino.SelectedValue;
            clsVentas venta = new clsVentas();
            vuelos vl = venta.ObtenervueloPorId(idVuelo);

            // Itera sobre cada pasajero y su asiento correspondiente para crear un ticket.
            for (int i = 0; i < celdas.Count; i++)
            {
                string asiento = celdas[i].Value.ToString();
                string nombre = nombresPasajeros[i];

                // Crea un nuevo objeto 'ticket' con toda la información.
                ticket t = new ticket
                {
                    id = GenerarID(vl.NumeroVuelo, nombre, asiento),
                    NumeroVuelo = vl.NumeroVuelo,
                    fechaVuelo = vl.fechaVuelo,
                    HoraSalida = vl.HoraSalida,
                    Destino = vl.Destino,
                    Origen = lblOrigenR.Text,
                    Pasajero = nombre,
                    NumeroAsiento = asiento,
                    Estado = false, // El estado inicial es 'no chequeado'.
                    Costo = vl.precio
                };

                // Llama al método para insertar el ticket en la base de datos.
                venta.InsertarTicket(t);

                // Abre un formulario de ticket individual para visualizar o imprimir.
                frmTicket fT = new frmTicket();
                fT.idSeg = t.id;
                fT.Ori = lblOrigenR.Text;
                fT.Ori = t.fechaVuelo.ToString("yyyy/MM/dd");
                fT.Show();
            }

            MessageBox.Show("Se registraron correctamente " + nombresPasajeros.Count + " tickets.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        /// <summary>
        /// Se ejecuta al cargar el formulario para inicializar componentes.
        /// </summary>
        private void frmPuntoVenta_Load(object sender, EventArgs e)
        {
            clsVentas ventas = new clsVentas();
            // Deshabilita campos que se llenan automáticamente.
            txtFecha.Enabled = false;
            txtHora.Enabled = false;
            // Oculta el panel de resumen de la venta hasta que sea necesario.
            pnlPasajero.Visible = false;

            // Carga los destinos de vuelos disponibles en el ComboBox.
            cbxDestino.DataSource = ventas.ObtenerVuelos();
            cbxDestino.DisplayMember = "Destino";
            cbxDestino.ValueMember = "id";

            // Permite múltiples líneas y una barra de scroll en el campo de nombres.
            txtNombre.Multiline = true;
            txtNombre.ScrollBars = ScrollBars.Vertical;
        }

        /// <summary>
        /// Se activa al cambiar la selección en el ComboBox de destinos.
        /// </summary>
        private void cbxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Valida que se haya seleccionado un ítem válido.
            if (cbxDestino.SelectedValue is int idSeleccionado)
            {
                clsVentas ventas = new clsVentas();
                // Obtiene y muestra los detalles del vuelo seleccionado (precio, fecha, hora).
                vuelos vl = ventas.ObtenervueloPorId(idSeleccionado);
                DateTime Fecha = ventas.ObtenerFechaVueloPorId(idSeleccionado);
                TimeSpan Hora = ventas.ObtenerHoraSalidaPorId(idSeleccionado);
                lblPrecioBase.Text = vl.precio.ToString();
                txtFecha.Text = Fecha.ToString("yyyy/MM/dd");
                txtHora.Text = Hora.ToString(@"hh\:mm\:ss");

                // Carga y muestra el mapa de asientos para el vuelo seleccionado.
                List<string> asientos = ventas.ObtenerAsientosOcupadosPorNumeroVuelo(ventas.ObtenerNumeroVuelo(idSeleccionado));
                ventas.CargarAsientos(dtgAsiento, asientos);
            }
        }

        /// <summary>
        /// Maneja el clic en el botón "Aceptar" para mostrar el resumen de la compra.
        /// </summary>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int asientosSeleccionados = dtgAsiento.SelectedCells.Count;

            // Valida que los campos principales estén llenos y se haya seleccionado al menos un asiento.
            if ((!string.IsNullOrWhiteSpace(txtOrigen.Text)) && (!string.IsNullOrWhiteSpace(txtFecha.Text)) && (dtgAsiento.CurrentCell != null))
            {
                pnlPasajero.Visible = true; // Muestra el panel de resumen.
                clsVentas ventas = new clsVentas();
                if (cbxDestino.SelectedValue is int idSeleccionado)
                {
                    List<string> valores = new List<string>();

                    foreach (DataGridViewCell celda in dtgAsiento.SelectedCells)
                    {
                        if (celda.Value != null)
                            valores.Add(celda.Value.ToString());
                    }

                    string resultado = string.Join(", ", valores);
                    vuelos vl = ventas.ObtenervueloPorId(idSeleccionado);
                    DateTime Fecha = ventas.ObtenerFechaVueloPorId(idSeleccionado);
                    TimeSpan Hora = ventas.ObtenerHoraSalidaPorId(idSeleccionado);

                    // Llena las etiquetas del panel de resumen con los datos de la venta.
                    lblDestinoR.Text = cbxDestino.Text;
                    lblFechaR.Text = Fecha.ToString("yyyy/MM/dd");
                    lblHoraR.Text = Hora.ToString(@"hh\:mm\:ss");
                    lblOrigenR.Text = txtOrigen.Text;
                    lblAsiento.Text = resultado;
                    // Calcula y muestra el precio total.
                    double total = vl.precio * asientosSeleccionados;
                    lblPrecioFinal.Text = total.ToString();
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Llama a la función de validación cuando el usuario sale del campo de texto del nombre.
        /// </summary>
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            ValidandoName();
        }

        /// <summary>
        /// Llama a la función de validación cuando el usuario sale del campo de texto del origen.
        /// </summary>
        private void txtOrigen_Leave(object sender, EventArgs e)
        {
            ValidandoOrigen();
        }

        /// <summary>
        /// Finaliza la venta al hacer clic en el botón "Realizar Venta".
        /// </summary>
        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                // Convierte el texto multilinea de nombres en una lista de strings.
                List<string> nombres = txtNombre.Text
                    .Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => n.Trim())
                    .Where(n => !string.IsNullOrWhiteSpace(n))
                    .ToList();

                if (nombres.Count == 0)
                {
                    MessageBox.Show("Ingresa al menos un nombre en el área de pasajeros.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Valida que el número de asientos coincida con el número de pasajeros.
                if (dtgAsiento.SelectedCells.Count != nombres.Count)
                {
                    MessageBox.Show("La cantidad de asientos seleccionados no coincide con los pasajeros ingresados.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Si todo es correcto, procede a insertar los tickets.
                InsertarTicketsPorPasajeros(nombres);

                // Limpia el formulario para una nueva venta.
                txtNombre.Clear();
                txtOrigen.Clear();
                txtFecha.Clear();
                txtHora.Clear();
                lblAsiento.Text = "";
                lblPrecioFinal.Text = "";
                pnlPasajero.Visible = false;
            }
            else
            {
                MessageBox.Show("Por favor revise que se llenaron todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}