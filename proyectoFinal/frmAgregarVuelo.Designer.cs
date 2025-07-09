namespace proyectoFinal
{
    partial class frmAgregarVuelo
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtHsalida = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblHSalida = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.errHSalida = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDestino = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errHSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.lblFecha.Location = new System.Drawing.Point(55, 124);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(149, 25);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha de Vuelo:";
            // 
            // txtHsalida
            // 
            this.txtHsalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.txtHsalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHsalida.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHsalida.ForeColor = System.Drawing.Color.White;
            this.txtHsalida.Location = new System.Drawing.Point(230, 178);
            this.txtHsalida.Name = "txtHsalida";
            this.txtHsalida.Size = new System.Drawing.Size(300, 34);
            this.txtHsalida.TabIndex = 1;
            this.txtHsalida.Leave += new System.EventHandler(this.txtHsalida_Leave);
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.txtDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestino.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDestino.ForeColor = System.Drawing.Color.White;
            this.txtDestino.Location = new System.Drawing.Point(230, 238);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(300, 34);
            this.txtDestino.TabIndex = 2;
            this.txtDestino.Leave += new System.EventHandler(this.txtDestino_Leave);
            // 
            // lblHSalida
            // 
            this.lblHSalida.AutoSize = true;
            this.lblHSalida.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.lblHSalida.Location = new System.Drawing.Point(55, 182);
            this.lblHSalida.Name = "lblHSalida";
            this.lblHSalida.Size = new System.Drawing.Size(145, 25);
            this.lblHSalida.TabIndex = 4;
            this.lblHSalida.Text = "Hora de Salida:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.lblDestino.Location = new System.Drawing.Point(55, 242);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(83, 25);
            this.lblDestino.TabIndex = 5;
            this.lblDestino.Text = "Destino:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(230, 310);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(300, 50);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "AGREGAR VUELO";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // errHSalida
            // 
            this.errHSalida.ContainerControl = this;
            // 
            // errDestino
            // 
            this.errDestino.ContainerControl = this;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.White;
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.dtpFecha.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dtpFecha.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpFecha.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(230, 118);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(300, 34);
            this.dtpFecha.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Light", 22F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(51, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(360, 50);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "REGISTRAR VUELO";
            // 
            // frmAgregarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblHSalida);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtHsalida);
            this.Controls.Add(this.lblFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarVuelo";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Vuelo";
            this.Load += new System.EventHandler(this.frmAgregarVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errHSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDestino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtHsalida;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblHSalida;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ErrorProvider errHSalida;
        private System.Windows.Forms.ErrorProvider errDestino;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblTitulo;
    }
}