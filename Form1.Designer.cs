namespace TallerSoftware2
{
    partial class TablaValidaciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablaValidaciones));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcularServicio = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCostodelServicio = new System.Windows.Forms.TextBox();
            this.txtNumerodeDocumento = new System.Windows.Forms.TextBox();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.cbxTipodeDocumento = new System.Windows.Forms.ComboBox();
            this.cbxRango = new System.Windows.Forms.ComboBox();
            this.erpMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(209, 356);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(88, 40);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero de Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rango";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Costo del Servicio";
            // 
            // btnCalcularServicio
            // 
            this.btnCalcularServicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalcularServicio.BackgroundImage")));
            this.btnCalcularServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularServicio.ForeColor = System.Drawing.Color.White;
            this.btnCalcularServicio.Location = new System.Drawing.Point(33, 356);
            this.btnCalcularServicio.Name = "btnCalcularServicio";
            this.btnCalcularServicio.Size = new System.Drawing.Size(119, 40);
            this.btnCalcularServicio.TabIndex = 7;
            this.btnCalcularServicio.Text = "Calcular Servicio";
            this.btnCalcularServicio.UseVisualStyleBackColor = true;
            this.btnCalcularServicio.Click += new System.EventHandler(this.btnCalcularServicio_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(353, 356);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(198, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtCostodelServicio
            // 
            this.txtCostodelServicio.Location = new System.Drawing.Point(195, 292);
            this.txtCostodelServicio.Name = "txtCostodelServicio";
            this.txtCostodelServicio.Size = new System.Drawing.Size(197, 20);
            this.txtCostodelServicio.TabIndex = 10;
            // 
            // txtNumerodeDocumento
            // 
            this.txtNumerodeDocumento.Location = new System.Drawing.Point(195, 167);
            this.txtNumerodeDocumento.Name = "txtNumerodeDocumento";
            this.txtNumerodeDocumento.Size = new System.Drawing.Size(198, 20);
            this.txtNumerodeDocumento.TabIndex = 11;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemenino.Location = new System.Drawing.Point(195, 119);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(89, 19);
            this.rbtnFemenino.TabIndex = 12;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.Location = new System.Drawing.Point(312, 119);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(91, 19);
            this.rbtnMasculino.TabIndex = 13;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // cbxTipodeDocumento
            // 
            this.cbxTipodeDocumento.FormattingEnabled = true;
            this.cbxTipodeDocumento.Location = new System.Drawing.Point(198, 70);
            this.cbxTipodeDocumento.Name = "cbxTipodeDocumento";
            this.cbxTipodeDocumento.Size = new System.Drawing.Size(198, 21);
            this.cbxTipodeDocumento.TabIndex = 14;
            // 
            // cbxRango
            // 
            this.cbxRango.FormattingEnabled = true;
            this.cbxRango.Location = new System.Drawing.Point(195, 239);
            this.cbxRango.Name = "cbxRango";
            this.cbxRango.Size = new System.Drawing.Size(198, 21);
            this.cbxRango.TabIndex = 15;
            // 
            // erpMensaje
            // 
            this.erpMensaje.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TablaValidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(509, 443);
            this.Controls.Add(this.cbxRango);
            this.Controls.Add(this.cbxTipodeDocumento);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.txtNumerodeDocumento);
            this.Controls.Add(this.txtCostodelServicio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCalcularServicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "TablaValidaciones";
            this.Text = "Tabla de Validaciones(Registro)";
            this.Load += new System.EventHandler(this.TablaValidaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCostodelServicio;
        private System.Windows.Forms.TextBox txtNumerodeDocumento;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.ComboBox cbxTipodeDocumento;
        private System.Windows.Forms.ComboBox cbxRango;
        private System.Windows.Forms.ErrorProvider erpMensaje;
        private System.Windows.Forms.Button btnCalcularServicio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

