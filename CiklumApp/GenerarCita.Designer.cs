namespace CiklumApp
{
    partial class GenerarCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.tbDuracion = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAplicar = new System.Windows.Forms.Button();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEntrenador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Duracion";
            // 
            // tbDuracion
            // 
            this.tbDuracion.Location = new System.Drawing.Point(341, 280);
            this.tbDuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDuracion.Name = "tbDuracion";
            this.tbDuracion.Size = new System.Drawing.Size(207, 22);
            this.tbDuracion.TabIndex = 31;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(443, 330);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(95, 39);
            this.bCancelar.TabIndex = 30;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAplicar
            // 
            this.bAplicar.Location = new System.Drawing.Point(341, 330);
            this.bAplicar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAplicar.Name = "bAplicar";
            this.bAplicar.Size = new System.Drawing.Size(96, 39);
            this.bAplicar.TabIndex = 29;
            this.bAplicar.Text = "Aplicar";
            this.bAplicar.UseVisualStyleBackColor = true;
            this.bAplicar.Click += new System.EventHandler(this.bAplicar_Click);
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(341, 221);
            this.tbTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(207, 22);
            this.tbTipo.TabIndex = 28;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.Location = new System.Drawing.Point(341, 162);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(207, 22);
            this.dateTimePicker.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Correo del entrenador";
            // 
            // tbEntrenador
            // 
            this.tbEntrenador.Location = new System.Drawing.Point(341, 93);
            this.tbEntrenador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEntrenador.Name = "tbEntrenador";
            this.tbEntrenador.Size = new System.Drawing.Size(207, 22);
            this.tbEntrenador.TabIndex = 34;
            // 
            // GenerarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbEntrenador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDuracion);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAplicar);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "GenerarCita";
            this.Text = "GenerarCita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDuracion;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAplicar;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEntrenador;
    }
}