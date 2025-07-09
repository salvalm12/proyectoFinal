using ClsVentasA;
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

namespace proyectoFinal
{
    public partial class frmAgregarVuelo : Form
    {
        public frmAgregarVuelo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Se activa cuando el usuario sale del campo de texto de la hora de salida,
        /// llamando al método de validación.
        /// </summary>
        private void txtHsalida_Leave(object sender, EventArgs e)
        {
            validarHoraSalida();
        }

        /// <summary>
        /// Se activa cuando el usuario sale del campo de texto del destino,
        /// llamando al método de validación.
        /// </summary>
        private void txtDestino_Leave(object sender, EventArgs e)
        {
            ValidarDestino();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Agregar".
        /// Valida todos los campos y, si son correctos, crea y guarda un nuevo vuelo.
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verifica que todas las validaciones sean correctas.
            if (ValidarTodo())
            {
                clsVentas venta = new clsVentas();
                vuelos vuelo = new vuelos();
                Random rnd = new Random();

                // Genera un precio y un ID aleatorios para el nuevo vuelo.
                double precio = rnd.Next(1500, 6000);
                int id = rnd.Next(0, 1000);

                // Obtiene los datos de los controles del formulario.
                string FSalida, HSalida, destino;
                destino = txtDestino.Text;
                HSalida = txtHsalida.Text;
                FSalida = dtpFecha.Value.ToString("yyyy/MM/dd"); // Formatea la fecha.

                // Crea un número de vuelo único combinando partes del destino, hora y fecha.
                string numeroVuelo = destino.Substring(0, 3) + HSalida.Substring(0, 2) + FSalida.Substring(2, 2) + FSalida.Substring(5, 2) + FSalida.Substring(8, 2); ;

                // Asigna los valores al objeto 'vuelo'.
                vuelo.id = id;
                vuelo.NumeroVuelo = numeroVuelo;
                vuelo.fechaVuelo = dtpFecha.Value;
                vuelo.HoraSalida = TimeSpan.Parse(HSalida);
                vuelo.Destino = destino;
                vuelo.precio = precio;

                // Llama al método para insertar el vuelo en la base de datos.
                venta.InsertarVuelo(vuelo);
                MessageBox.Show("El vuelo fue agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor revisar que se lleno todo correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region funciones

        /// <summary>
        /// Valida que la hora de salida tenga el formato HH:mm:ss usando una expresión regular.
        /// Muestra un error si el formato es incorrecto o el campo está vacío.
        /// </summary>
        public void validarHoraSalida()
        {
            String patron = @"^([01]\d|2[0-3]):[0-5]\d:[0-5]\d$";
            if (String.IsNullOrEmpty(txtHsalida.Text) == true)
            {
                txtHsalida.Focus();
                errHSalida.SetError(txtHsalida, "No debe dejar esta celda vacia");
            }
            else if (!Regex.IsMatch(txtHsalida.Text, patron))
            {
                txtHsalida.Focus();
                errHSalida.SetError(txtHsalida, "Tiene que tener el formato HH:mm:ss como por ejemplo 01:30:00");
            }
            else
            {
                // Si la validación es exitosa, limpia el mensaje de error.
                errHSalida.Clear();
            }
        }

        /// <summary>
        /// Valida que el destino sea un texto de entre 3 y 50 caracteres.
        /// </summary>
        public void ValidarDestino()
        {
            String patron = "[A-Za-z ]{3,50}";
            if (String.IsNullOrEmpty(txtDestino.Text) == true)
            {
                txtDestino.Focus();
                errDestino.SetError(txtDestino, "No debe dejar esta celda vacia");
            }
            else if (!Regex.IsMatch(txtDestino.Text, patron))
            {
                txtDestino.Focus();
                errDestino.SetError(txtDestino, "Tiene que tener entre 3 y 50 caracteres");
            }
            else
            {
                errDestino.Clear();
            }
        }

        /// <summary>
        /// Función booleana para una validación rápida del destino.
        /// </summary>
        /// <returns>True si el destino es válido, de lo contrario False.</returns>
        public bool VDestino()
        {
            string patron = @"^[A-Za-z ]{3,50}$";
            return !string.IsNullOrEmpty(txtDestino.Text) && Regex.IsMatch(txtDestino.Text, patron);
        }

        /// <summary>
        /// Función booleana para una validación rápida de la hora de salida.
        /// </summary>
        /// <returns>True si la hora es válida, de lo contrario False.</returns>
        public bool VHSalida()
        {
            string patron = @"^([01]\d|2[0-3]):[0-5]\d:[0-5]\d$";
            return !string.IsNullOrEmpty(txtHsalida.Text) && Regex.IsMatch(txtHsalida.Text, patron);
        }

        /// <summary>
        /// Comprueba si todos los campos requeridos del formulario son válidos.
        /// </summary>
        /// <returns>True si todas las validaciones individuales son exitosas.</returns>
        public bool ValidarTodo()
        {
            if (VDestino() && VHSalida())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        private void frmAgregarVuelo_Load(object sender, EventArgs e)
        {
            
        }
    }
}