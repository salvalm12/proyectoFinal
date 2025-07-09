namespace proyectoFinal
{
    partial class frmPuntoVenta
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.dtgAsiento = new System.Windows.Forms.DataGridView();
            this.pnlPasajero = new System.Windows.Forms.Panel();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVenta = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblAsiento = new System.Windows.Forms.Label();
            this.lblHoraR = new System.Windows.Forms.Label();
            this.lblFechaR = new System.Windows.Forms.Label();
            this.lblDestinoR = new System.Windows.Forms.Label();
            this.lblOrigenR = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errOrigen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errName = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTituloVuelo = new System.Windows.Forms.Label();
            this.lblTituloAsiento = new System.Windows.Forms.Label();
            this.lblTituloPasajero = new System.Windows.Forms.Label();
            this.pnlVuelo = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsiento)).BeginInit();
            this.pnlPasajero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).BeginInit();
            this.pnlVuelo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxDestino
            // 
            this.cbxDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.cbxDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDestino.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxDestino.ForeColor = System.Drawing.Color.White;
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(141, 100);
            this.cbxDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(292, 40);
            this.cbxDestino.TabIndex = 1;
            this.cbxDestino.SelectedIndexChanged += new System.EventHandler(this.cbxDestino_SelectedIndexChanged);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.lblDestino.Location = new System.Drawing.Point(22, 108);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(90, 28);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.lblOrigen.Location = new System.Drawing.Point(22, 32);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(81, 28);
            this.lblOrigen.TabIndex = 2;
            this.lblOrigen.Text = "Origen:";
            // 
            // txtOrigen
            // 
            this.txtOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOrigen.ForeColor = System.Drawing.Color.White;
            this.txtOrigen.Location = new System.Drawing.Point(141, 25);
            this.txtOrigen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(292, 39);
            this.txtOrigen.TabIndex = 0;
            this.txtOrigen.Leave += new System.EventHandler(this.txtOrigen_Leave);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.lblHora.Location = new System.Drawing.Point(22, 258);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(63, 28);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.lblFecha.Location = new System.Drawing.Point(22, 182);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(71, 28);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFecha.ForeColor = System.Drawing.Color.White;
            this.txtFecha.Location = new System.Drawing.Point(141, 175);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(292, 39);
            this.txtFecha.TabIndex = 2;
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHora.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHora.ForeColor = System.Drawing.Color.White;
            this.txtHora.Location = new System.Drawing.Point(141, 250);
            this.txtHora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(292, 39);
            this.txtHora.TabIndex = 3;
            // 
            // dtgAsiento
            // 
            this.dtgAsiento.AllowUserToAddRows = false;
            this.dtgAsiento.AllowUserToDeleteRows = false;
            this.dtgAsiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAsiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.dtgAsiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgAsiento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgAsiento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAsiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgAsiento.ColumnHeadersHeight = 40;
            this.dtgAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAsiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgAsiento.EnableHeadersVisualStyles = false;
            this.dtgAsiento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.dtgAsiento.Location = new System.Drawing.Point(529, 125);
            this.dtgAsiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgAsiento.Name = "dtgAsiento";
            this.dtgAsiento.ReadOnly = true;
            this.dtgAsiento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAsiento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgAsiento.RowHeadersVisible = false;
            this.dtgAsiento.RowHeadersWidth = 51;
            this.dtgAsiento.RowTemplate.Height = 35;
            this.dtgAsiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAsiento.Size = new System.Drawing.Size(472, 750);
            this.dtgAsiento.TabIndex = 5;
            // 
            // pnlPasajero
            // 
            this.pnlPasajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.pnlPasajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPasajero.Controls.Add(this.lblPrecioFinal);
            this.pnlPasajero.Controls.Add(this.lblPrecioBase);
            this.pnlPasajero.Controls.Add(this.label9);
            this.pnlPasajero.Controls.Add(this.btnVenta);
            this.pnlPasajero.Controls.Add(this.lblTotal);
            this.pnlPasajero.Controls.Add(this.label7);
            this.pnlPasajero.Controls.Add(this.txtNombre);
            this.pnlPasajero.Controls.Add(this.lblAsiento);
            this.pnlPasajero.Controls.Add(this.lblHoraR);
            this.pnlPasajero.Controls.Add(this.lblFechaR);
            this.pnlPasajero.Controls.Add(this.lblDestinoR);
            this.pnlPasajero.Controls.Add(this.lblOrigenR);
            this.pnlPasajero.Controls.Add(this.label6);
            this.pnlPasajero.Controls.Add(this.label5);
            this.pnlPasajero.Controls.Add(this.label4);
            this.pnlPasajero.Controls.Add(this.label3);
            this.pnlPasajero.Controls.Add(this.label2);
            this.pnlPasajero.Controls.Add(this.label1);
            this.pnlPasajero.ForeColor = System.Drawing.Color.White;
            this.pnlPasajero.Location = new System.Drawing.Point(1035, 125);
            this.pnlPasajero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPasajero.Name = "pnlPasajero";
            this.pnlPasajero.Size = new System.Drawing.Size(484, 812);
            this.pnlPasajero.TabIndex = 6;
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.lblPrecioFinal.Location = new System.Drawing.Point(202, 658);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(248, 35);
            this.lblPrecioFinal.TabIndex = 18;
            this.lblPrecioFinal.Text = "$0.00";
            this.lblPrecioFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioBase.ForeColor = System.Drawing.Color.White;
            this.lblPrecioBase.Location = new System.Drawing.Point(202, 282);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(248, 29);
            this.lblPrecioBase.TabIndex = 17;
            this.lblPrecioBase.Text = "$0.00";
            this.lblPrecioBase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label9.Location = new System.Drawing.Point(22, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 28);
            this.label9.TabIndex = 16;
            this.label9.Text = "Precio Base:";
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnVenta.Location = new System.Drawing.Point(28, 725);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(428, 62);
            this.btnVenta.TabIndex = 2;
            this.btnVenta.Text = "CONFIRMAR VENTA";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.lblTotal.Location = new System.Drawing.Point(202, 658);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(248, 35);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label7.Location = new System.Drawing.Point(22, 658);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "TOTAL FINAL:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(28, 425);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(427, 93);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lblAsiento
            // 
            this.lblAsiento.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento.ForeColor = System.Drawing.Color.White;
            this.lblAsiento.Location = new System.Drawing.Point(202, 232);
            this.lblAsiento.Name = "lblAsiento";
            this.lblAsiento.Size = new System.Drawing.Size(248, 29);
            this.lblAsiento.TabIndex = 10;
            this.lblAsiento.Text = "---";
            this.lblAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHoraR
            // 
            this.lblHoraR.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraR.ForeColor = System.Drawing.Color.White;
            this.lblHoraR.Location = new System.Drawing.Point(202, 182);
            this.lblHoraR.Name = "lblHoraR";
            this.lblHoraR.Size = new System.Drawing.Size(248, 29);
            this.lblHoraR.TabIndex = 9;
            this.lblHoraR.Text = "---";
            this.lblHoraR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaR
            // 
            this.lblFechaR.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaR.ForeColor = System.Drawing.Color.White;
            this.lblFechaR.Location = new System.Drawing.Point(202, 132);
            this.lblFechaR.Name = "lblFechaR";
            this.lblFechaR.Size = new System.Drawing.Size(248, 29);
            this.lblFechaR.TabIndex = 8;
            this.lblFechaR.Text = "---";
            this.lblFechaR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDestinoR
            // 
            this.lblDestinoR.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinoR.ForeColor = System.Drawing.Color.White;
            this.lblDestinoR.Location = new System.Drawing.Point(202, 82);
            this.lblDestinoR.Name = "lblDestinoR";
            this.lblDestinoR.Size = new System.Drawing.Size(248, 29);
            this.lblDestinoR.TabIndex = 7;
            this.lblDestinoR.Text = "---";
            this.lblDestinoR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrigenR
            // 
            this.lblOrigenR.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigenR.ForeColor = System.Drawing.Color.White;
            this.lblOrigenR.Location = new System.Drawing.Point(202, 32);
            this.lblOrigenR.Name = "lblOrigenR";
            this.lblOrigenR.Size = new System.Drawing.Size(248, 29);
            this.lblOrigenR.TabIndex = 6;
            this.lblOrigenR.Text = "---";
            this.lblOrigenR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label6.Location = new System.Drawing.Point(22, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre del Pasajero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(22, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Asientos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(22, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(22, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen:";
            // 
            // errOrigen
            // 
            this.errOrigen.ContainerControl = this;
            // 
            // errName
            // 
            this.errName.ContainerControl = this;
            // 
            // lblTituloVuelo
            // 
            this.lblTituloVuelo.AutoSize = true;
            this.lblTituloVuelo.Font = new System.Drawing.Font("Segoe UI Light", 22F);
            this.lblTituloVuelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTituloVuelo.Location = new System.Drawing.Point(34, 38);
            this.lblTituloVuelo.Name = "lblTituloVuelo";
            this.lblTituloVuelo.Size = new System.Drawing.Size(468, 60);
            this.lblTituloVuelo.TabIndex = 12;
            this.lblTituloVuelo.Text = "1. SELECCIONAR VUELO";
            // 
            // lblTituloAsiento
            // 
            this.lblTituloAsiento.AutoSize = true;
            this.lblTituloAsiento.Font = new System.Drawing.Font("Segoe UI Light", 22F);
            this.lblTituloAsiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTituloAsiento.Location = new System.Drawing.Point(519, 38);
            this.lblTituloAsiento.Name = "lblTituloAsiento";
            this.lblTituloAsiento.Size = new System.Drawing.Size(374, 60);
            this.lblTituloAsiento.TabIndex = 13;
            this.lblTituloAsiento.Text = "2. ELEGIR ASIENTO";
            // 
            // lblTituloPasajero
            // 
            this.lblTituloPasajero.AutoSize = true;
            this.lblTituloPasajero.Font = new System.Drawing.Font("Segoe UI Light", 22F);
            this.lblTituloPasajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTituloPasajero.Location = new System.Drawing.Point(1025, 38);
            this.lblTituloPasajero.Name = "lblTituloPasajero";
            this.lblTituloPasajero.Size = new System.Drawing.Size(553, 60);
            this.lblTituloPasajero.TabIndex = 14;
            this.lblTituloPasajero.Text = "3. DATOS Y CONFIRMACIÓN";
            // 
            // pnlVuelo
            // 
            this.pnlVuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.pnlVuelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVuelo.Controls.Add(this.btnAceptar);
            this.pnlVuelo.Controls.Add(this.lblOrigen);
            this.pnlVuelo.Controls.Add(this.cbxDestino);
            this.pnlVuelo.Controls.Add(this.lblDestino);
            this.pnlVuelo.Controls.Add(this.txtOrigen);
            this.pnlVuelo.Controls.Add(this.lblHora);
            this.pnlVuelo.Controls.Add(this.txtHora);
            this.pnlVuelo.Controls.Add(this.lblFecha);
            this.pnlVuelo.Controls.Add(this.txtFecha);
            this.pnlVuelo.Location = new System.Drawing.Point(45, 125);
            this.pnlVuelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlVuelo.Name = "pnlVuelo";
            this.pnlVuelo.Size = new System.Drawing.Size(461, 412);
            this.pnlVuelo.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(141, 325);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(292, 62);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "BUSCAR ASIENTOS";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1555, 979);
            this.Controls.Add(this.pnlVuelo);
            this.Controls.Add(this.lblTituloPasajero);
            this.Controls.Add(this.lblTituloAsiento);
            this.Controls.Add(this.lblTituloVuelo);
            this.Controls.Add(this.pnlPasajero);
            this.Controls.Add(this.dtgAsiento);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPuntoVenta";
            this.Opacity = 0.95D;
            this.Text = "Punto de Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPuntoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsiento)).EndInit();
            this.pnlPasajero.ResumeLayout(false);
            this.pnlPasajero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).EndInit();
            this.pnlVuelo.ResumeLayout(false);
            this.pnlVuelo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.DataGridView dtgAsiento;
        private System.Windows.Forms.Panel pnlPasajero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblAsiento;
        private System.Windows.Forms.Label lblHoraR;
        private System.Windows.Forms.Label lblFechaR;
        private System.Windows.Forms.Label lblDestinoR;
        private System.Windows.Forms.Label lblOrigenR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.ErrorProvider errOrigen;
        private System.Windows.Forms.ErrorProvider errName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Label lblTituloVuelo;
        private System.Windows.Forms.Label lblTituloAsiento;
        private System.Windows.Forms.Label lblTituloPasajero;
        private System.Windows.Forms.Panel pnlVuelo;
    }
}