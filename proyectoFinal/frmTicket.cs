using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using BarcodeLib;
using ClsVentasA;

namespace proyectoFinal
{
    public partial class frmTicket : Form
    {
        public string idSeg { get; set; }
        public string Ori { get; set; }
        public String Fc { get; set; }

        public frmTicket()
        {
            InitializeComponent();
        }

      
        private void ImprimirPagina(object sender, PrintPageEventArgs e)
        {
            // El objeto Graphics es donde dibuja todo el contenido.
            Graphics g = e.Graphics;

            // 'y' es nuestro cursor vertical. Lo iremos incrementando para bajar a la siguiente línea.
            int y = 40;
            int margen = 50; // Margen lateral para el contenido.
            int anchoPagina = e.PageBounds.Width;
            int centroPagina = anchoPagina / 2;

            // Usar 'using' asegura que los recursos pesados como fuentes y plumas se liberen
            // de la memoria automáticamente al finalizar el bloque, evitando fugas de memoria.
            using (Font fuenteAerolinea = new Font("Segoe UI", 20, FontStyle.Bold))
            using (Font fuenteTitulo = new Font("Segoe UI Semibold", 16, FontStyle.Bold))
            using (Font fuenteEtiqueta = new Font("Segoe UI", 9, FontStyle.Bold))
            using (Font fuenteValor = new Font("Segoe UI", 12))
            using (Font fuenteGrande = new Font("Segoe UI", 22, FontStyle.Bold))
            using (Pen separadorPen = new Pen(Color.Black, 2))
            {
                Brush pincel = Brushes.Black;

                // StringFormat nos permite controlar la alineación del texto (izquierda, centro, derecha).
                StringFormat formatoCentrado = new StringFormat { Alignment = StringAlignment.Center };
                StringFormat formatoIzquierdo = new StringFormat { Alignment = StringAlignment.Near };
                StringFormat formatoDerecho = new StringFormat { Alignment = StringAlignment.Far };

                g.DrawString("ITSUR AIRLINE", fuenteAerolinea, pincel, centroPagina, y, formatoCentrado);
                y += 50; // Aumentamos 'y' para movernos hacia abajo en el ticket.

                g.DrawString("PASE DE ABORDAR / BOARDING PASS", fuenteTitulo, pincel, centroPagina, y, formatoCentrado);
                y += 50;

                // --- Función local para reutilizar código ---
                // Dibuja una etiqueta y su valor correspondiente en una posición específica.
                // 'x' es la coordenada horizontal, 'yPos' es la vertical.
                void DibujarCampo(string etiqueta, string valor, int x, int yPos)
                {
                    g.DrawString(etiqueta.ToUpper(), fuenteEtiqueta, Brushes.Gray, x, yPos);
                    g.DrawString(valor, fuenteValor, pincel, x, yPos + 18); // El valor se dibuja un poco más abajo.
                }
                // --- Fin de la función local ---

                // Dibujamos los campos de pasajero y asiento en dos columnas.
                DibujarCampo("Pasajero / Passenger", lblPasajero.Text.ToUpper(), margen, y);
                DibujarCampo("Asiento / Seat", lblAsiento.Text, centroPagina, y);

                y += 70;
                // Dibuja una línea horizontal para separar secciones.
                g.DrawLine(separadorPen, margen, y, anchoPagina - margen, y);
                y += 20;

                // Muestra el origen y destino con un ícono de avión en medio.
                g.DrawString(Ori, fuenteGrande, pincel, margen, y, formatoIzquierdo);
                g.DrawString("✈", new Font("Segoe UI Symbol", 22), pincel, centroPagina, y, formatoCentrado);
                g.DrawString(lblDestino.Text, fuenteGrande, pincel, anchoPagina - margen, y, formatoDerecho);
                y += 50;

                // Calculamos las posiciones horizontales para una maquetación de 3 columnas.
                int xCol1 = margen;
                int xCol2 = centroPagina - 40; // Un poco a la izquierda del centro.
                int xCol3 = anchoPagina - margen - 100; // Cerca del borde derecho.

                DibujarCampo("Vuelo / Flight", lblVuelo.Text, xCol1, y);
                DibujarCampo("Fecha / Date", lblFecha.Text, xCol2, y);
                DibujarCampo("Hora / Time", lblHora.Text, xCol3, y);

                y += 80;

                // --- Generación del código de barras ---
                Barcode codigoBarras = new Barcode
                {
                    IncludeLabel = true, // Muestra el texto (idSeg) debajo del código.
                    Alignment = AlignmentPositions.CENTER,
                    LabelFont = new Font("Segoe UI", 10)
                };

                // El código de barras se genera como una imagen en memoria.
                using (Image img = codigoBarras.Encode(TYPE.CODE128, idSeg, Color.Black, Color.White, 350, 100))
                {
                    // Calculamos la posición 'x' para centrar la imagen del código de barras.
                    int xCentrado = (anchoPagina - img.Width) / 2;
                    g.DrawImage(img, xCentrado, y);
                }
                // --- Fin del código de barras ---

                y += 120;
                g.DrawString("Gracias por volar con nosotros.", new Font("Segoe UI Italic", 9), Brushes.Gray, centroPagina, y, formatoCentrado);
            }
        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            clsVentas venta = new clsVentas();
            ticket ticket = venta.ObtenerTicketPorId(idSeg);

            if (ticket != null)
            {
                lblVuelo.Text = ticket.NumeroVuelo;
                lblOrigen.Text = Ori;
                lblDestino.Text = ticket.Destino;
                lblHora.Text = ticket.HoraSalida.ToString(@"hh\:mm");
                // Formato de fecha personalizado para "DÍA MES AÑO"
                lblFecha.Text = ticket.fechaVuelo.ToString("dd MMM yyyy").ToUpper();
                lblPasajero.Text = ticket.Pasajero;
                lblAsiento.Text = ticket.NumeroAsiento;
                // Formato de moneda local.
                lblTotal.Text = ticket.Costo.ToString("C");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            // Asignamos el método que dibujará el contenido al evento PrintPage.
            pd.PrintPage += new PrintPageEventHandler(ImprimirPagina);
            // Se define un tamaño de papel personalizado para que el ticket no ocupe una hoja A4 completa.
            pd.DefaultPageSettings.PaperSize = new PaperSize("Ticket", 450, 700);

            // PrintPreviewDialog muestra una vista previa de cómo se verá el documento impreso.
            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = pd,
                Width = 800,
                Height = 600,
                StartPosition = FormStartPosition.CenterScreen
            };
            preview.ShowDialog();
            this.Close();
        }
    }
}