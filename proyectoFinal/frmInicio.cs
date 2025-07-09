using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Abre el formulario para agregar vuelos.
        /// Si el formulario ya está abierto, lo trae al frente para evitar duplicados.
        /// </summary>
        private void agregarVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Busca si ya existe una instancia del formulario frmAgregarVuelo.
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmAgregarVuelo)
                {
                    form.BringToFront(); // Si existe, la trae al frente.
                    return; // Termina el método para no abrir una nueva.
                }
            }
            // Si no hay una instancia abierta, crea una nueva.
            frmAgregarVuelo frmAV = new frmAgregarVuelo();
            frmAV.MdiParent = this; // Establece este formulario como el padre.
            frmAV.Show(); // Muestra el formulario.
        }

        /// <summary>
        /// Abre el formulario del punto de venta.
        /// Revisa si ya hay una instancia abierta para evitar duplicados.
        /// </summary>
        private void puntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Busca si ya existe una instancia del formulario frmPuntoVenta.
            foreach (Form form in this.MdiChildren)
            {
                // NOTA: Hay un posible error aquí, debería ser 'if (form is frmPuntoVenta)'.
                if (form is frmAgregarVuelo)
                {
                    form.BringToFront();
                    return;
                }
            }
            // Si no está abierto, crea y muestra una nueva instancia.
            frmPuntoVenta frmPV = new frmPuntoVenta();
            frmPV.MdiParent = this;
            frmPV.Show();
        }

        /// <summary>
        /// Cierra la aplicación completamente.
        /// </summary>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Abre el formulario "Acerca de".
        /// Si ya está abierto, lo trae al frente.
        /// </summary>
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Itera sobre los formularios hijos para buscar una instancia de frmAcercaDe.
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmAcercaDe)
                {
                    form.BringToFront(); // Si la encuentra, la muestra.
                    return;
                }
            }
            // Si no, crea una nueva.
            frmAcercaDe frmAD = new frmAcercaDe();
            frmAD.MdiParent = this;
            frmAD.Show();
        }

        /// <summary>
        /// Se ejecuta al cargar el formulario para configurar la imagen de fondo del MDI.
        /// </summary>
        private void frmInicio_Load(object sender, EventArgs e)
        {
            // Itera sobre todos los controles del formulario.
            foreach (Control control in this.Controls)
            {
                // Busca el control 'MdiClient', que es el área de fondo de un MDI parent.
                if (control is MdiClient)
                {
                    // Establece una imagen desde los recursos del proyecto.
                    control.BackgroundImage = Properties.Resources.imgpru;
                    // Ajusta la imagen para que se estire y ocupe todo el espacio.
                    control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    break; // Termina el bucle una vez que encuentra y configura el MdiClient.
                }
            }
        }

        // --- Los siguientes métodos parecen ser duplicados o alternativos ---
        // --- para las mismas acciones, probablemente de otro menú o barra de herramientas. ---

        /// <summary>
        /// Acción alternativa para abrir el Punto de Venta.
        /// </summary>
        private void puntoVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                // NOTA: También contiene el posible error, debería ser 'if (form is frmPuntoVenta)'.
                if (form is frmAgregarVuelo)
                {
                    form.BringToFront();
                    return;
                }
            }
            frmPuntoVenta frmPV = new frmPuntoVenta();
            frmPV.MdiParent = this;
            frmPV.Show();
        }

        /// <summary>
        /// Acción alternativa para salir de la aplicación.
        /// </summary>
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Acción alternativa para abrir el formulario "Acerca de".
        /// </summary>
        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmAcercaDe)
                {
                    form.BringToFront();
                    return;
                }
            }
            frmAcercaDe frmAD = new frmAcercaDe();
            frmAD.MdiParent = this;
            frmAD.Show();
        }

        /// <summary>
        /// Acción alternativa para abrir el formulario "Agregar Vuelos".
        /// </summary>
        private void agregarVuelosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmAgregarVuelo)
                {
                    form.BringToFront();
                    return;
                }
            }
            frmAgregarVuelo frmAV = new frmAgregarVuelo();
            frmAV.MdiParent = this;
            frmAV.Show();
        }
    }
}