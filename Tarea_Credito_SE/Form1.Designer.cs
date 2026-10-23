namespace Tarea_Credito_SE  
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.chkEmpleoPermanente = new System.Windows.Forms.CheckBox();
            this.chkAtrasos = new System.Windows.Forms.CheckBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtHistorial = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(119, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Datos del solicitante";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(20, 50);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(102, 13);
            this.lblIngresos.TabIndex = 1;
            this.lblIngresos.Text = "Ingreso mensual (L):";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(20, 230);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(103, 13);
            this.lblCapacidad.TabIndex = 2;
            this.lblCapacidad.Text = "Capacidad de pago:";
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(20, 285);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(92, 13);
            this.lblHistorial.TabIndex = 3;
            this.lblHistorial.Text = "Historial crediticio:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(20, 340);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(80, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Tipo de cliente:";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(20, 395);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(89, 13);
            this.lblCredito.TabIndex = 5;
            this.lblCredito.Text = "Crédito asignado:";
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Location = new System.Drawing.Point(20, 450);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(104, 13);
            this.lblPlazo.TabIndex = 6;
            this.lblPlazo.Text = "Plazo recomendado:";
            // 
            // chkEmpleoPermanente
            // 
            this.chkEmpleoPermanente.AutoSize = true;
            this.chkEmpleoPermanente.Location = new System.Drawing.Point(20, 110);
            this.chkEmpleoPermanente.Name = "chkEmpleoPermanente";
            this.chkEmpleoPermanente.Size = new System.Drawing.Size(149, 17);
            this.chkEmpleoPermanente.TabIndex = 1;
            this.chkEmpleoPermanente.Text = "Tiene empleo permanente";
            this.chkEmpleoPermanente.UseVisualStyleBackColor = true;
            // 
            // chkAtrasos
            // 
            this.chkAtrasos.AutoSize = true;
            this.chkAtrasos.Location = new System.Drawing.Point(20, 140);
            this.chkAtrasos.Name = "chkAtrasos";
            this.chkAtrasos.Size = new System.Drawing.Size(258, 17);
            this.chkAtrasos.TabIndex = 2;
            this.chkAtrasos.Text = "Tiene atrasos frecuentes en préstamos anteriores";
            this.chkAtrasos.UseVisualStyleBackColor = true;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(20, 180);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(150, 32);
            this.btnEvaluar.TabIndex = 3;
            this.btnEvaluar.Text = "Evaluar solicitud";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(185, 180);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 32);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtIngresos
            // 
            this.txtIngresos.Location = new System.Drawing.Point(20, 72);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(200, 20);
            this.txtIngresos.TabIndex = 5;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(20, 252);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.ReadOnly = true;
            this.txtCapacidad.Size = new System.Drawing.Size(520, 20);
            this.txtCapacidad.TabIndex = 6;
            // 
            // txtHistorial
            // 
            this.txtHistorial.Location = new System.Drawing.Point(20, 307);
            this.txtHistorial.Name = "txtHistorial";
            this.txtHistorial.ReadOnly = true;
            this.txtHistorial.Size = new System.Drawing.Size(520, 20);
            this.txtHistorial.TabIndex = 7;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(20, 362);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(520, 20);
            this.txtCliente.TabIndex = 8;
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(20, 417);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.ReadOnly = true;
            this.txtCredito.Size = new System.Drawing.Size(520, 20);
            this.txtCredito.TabIndex = 9;
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(20, 472);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.ReadOnly = true;
            this.txtPlazo.Size = new System.Drawing.Size(520, 20);
            this.txtPlazo.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 514);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.lblPlazo);
            this.Controls.Add(this.chkEmpleoPermanente);
            this.Controls.Add(this.chkAtrasos);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtIngresos);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtHistorial);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.txtPlazo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Experto - Análisis de Solicitudes de Crédito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.CheckBox chkEmpleoPermanente;
        private System.Windows.Forms.CheckBox chkAtrasos;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtHistorial;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.TextBox txtPlazo;
    }
}