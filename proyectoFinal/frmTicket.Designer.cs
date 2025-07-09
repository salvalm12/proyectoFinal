namespace proyectoFinal
{
    partial class frmTicket
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVuelo = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAsiento = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPasajero = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlTicket = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAirline = new System.Windows.Forms.Label();
            this.lblBoardingPass = new System.Windows.Forms.Label();
            this.pnlTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(264, 750);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(281, 62);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "IMPRIMIR / CERRAR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(34, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "VUELO";
            // 
            // lblVuelo
            // 
            this.lblVuelo.AutoSize = true;
            this.lblVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lblVuelo.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelo.ForeColor = System.Drawing.Color.White;
            this.lblVuelo.Location = new System.Drawing.Point(32, 275);
            this.lblVuelo.Name = "lblVuelo";
            this.lblVuelo.Size = new System.Drawing.Size(50, 38);
            this.lblVuelo.TabIndex = 2;
            this.lblVuelo.Text = "---";
            // 
            // lblDestino
            // 
            this.lblDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.ForeColor = System.Drawing.Color.White;
            this.lblDestino.Location = new System.Drawing.Point(286, 150);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(204, 68);
            this.lblDestino.TabIndex = 4;
            this.lblDestino.Text = "---";
            this.lblDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(291, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "DESTINO";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(32, 375);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 38);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label6.Location = new System.Drawing.Point(34, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "FECHA";
            // 
            // lblAsiento
            // 
            this.lblAsiento.AutoSize = true;
            this.lblAsiento.BackColor = System.Drawing.Color.Transparent;
            this.lblAsiento.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento.ForeColor = System.Drawing.Color.White;
            this.lblAsiento.Location = new System.Drawing.Point(412, 362);
            this.lblAsiento.Name = "lblAsiento";
            this.lblAsiento.Size = new System.Drawing.Size(85, 65);
            this.lblAsiento.TabIndex = 10;
            this.lblAsiento.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label8.Location = new System.Drawing.Point(418, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "ASIENTO";
            // 
            // lblPasajero
            // 
            this.lblPasajero.AutoSize = true;
            this.lblPasajero.BackColor = System.Drawing.Color.Transparent;
            this.lblPasajero.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasajero.ForeColor = System.Drawing.Color.White;
            this.lblPasajero.Location = new System.Drawing.Point(32, 181);
            this.lblPasajero.Name = "lblPasajero";
            this.lblPasajero.Size = new System.Drawing.Size(50, 38);
            this.lblPasajero.TabIndex = 8;
            this.lblPasajero.Text = "---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label10.Location = new System.Drawing.Point(34, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 28);
            this.label10.TabIndex = 7;
            this.label10.Text = "PASAJERO";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(577, 181);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(140, 40);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "---";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(587, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "TOTAL PAGO";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(212, 375);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(50, 38);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(214, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "HORA";
            // 
            // lblOrigen
            // 
            this.lblOrigen.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigen.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.ForeColor = System.Drawing.Color.White;
            this.lblOrigen.Location = new System.Drawing.Point(496, 150);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(204, 68);
            this.lblOrigen.TabIndex = 16;
            this.lblOrigen.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.label7.Location = new System.Drawing.Point(502, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "ORIGEN";
            // 
            // pnlTicket
            // 
            this.pnlTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.pnlTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTicket.Controls.Add(this.panel1);
            this.pnlTicket.Controls.Add(this.lblTotal);
            this.pnlTicket.Controls.Add(this.label10);
            this.pnlTicket.Controls.Add(this.lblPasajero);
            this.pnlTicket.Controls.Add(this.label3);
            this.pnlTicket.Controls.Add(this.label1);
            this.pnlTicket.Controls.Add(this.lblVuelo);
            this.pnlTicket.Controls.Add(this.lblHora);
            this.pnlTicket.Controls.Add(this.label6);
            this.pnlTicket.Controls.Add(this.label5);
            this.pnlTicket.Controls.Add(this.lblFecha);
            this.pnlTicket.Controls.Add(this.lblAsiento);
            this.pnlTicket.Controls.Add(this.label8);
            this.pnlTicket.Location = new System.Drawing.Point(45, 125);
            this.pnlTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTicket.Name = "pnlTicket";
            this.pnlTicket.Size = new System.Drawing.Size(720, 574);
            this.pnlTicket.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 12);
            this.panel1.TabIndex = 16;
            // 
            // lblAirline
            // 
            this.lblAirline.AutoSize = true;
            this.lblAirline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblAirline.Location = new System.Drawing.Point(39, 28);
            this.lblAirline.Name = "lblAirline";
            this.lblAirline.Size = new System.Drawing.Size(195, 32);
            this.lblAirline.TabIndex = 18;
            this.lblAirline.Text = "ITSUR AIRLINES";
            // 
            // lblBoardingPass
            // 
            this.lblBoardingPass.AutoSize = true;
            this.lblBoardingPass.Font = new System.Drawing.Font("Segoe UI Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoardingPass.ForeColor = System.Drawing.Color.White;
            this.lblBoardingPass.Location = new System.Drawing.Point(35, 62);
            this.lblBoardingPass.Name = "lblBoardingPass";
            this.lblBoardingPass.Size = new System.Drawing.Size(389, 61);
            this.lblBoardingPass.TabIndex = 19;
            this.lblBoardingPass.Text = "PASE DE ABORDAR";
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(810, 1015);
            this.Controls.Add(this.lblBoardingPass);
            this.Controls.Add(this.lblAirline);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.pnlTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "frmTicket";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pase de Abordar";
            this.Load += new System.EventHandler(this.frmTicket_Load);
            this.pnlTicket.ResumeLayout(false);
            this.pnlTicket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVuelo;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAsiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPasajero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlTicket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAirline;
        private System.Windows.Forms.Label lblBoardingPass;
    }
}