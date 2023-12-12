namespace CiklumApp
{
    partial class ModificarCita
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAplicar = new System.Windows.Forms.Button();
            this.tbDuracion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.Location = new System.Drawing.Point(259, 90);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(259, 138);
            this.tbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(156, 20);
            this.tbTipo.TabIndex = 20;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(335, 227);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(71, 32);
            this.bCancelar.TabIndex = 22;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAplicar
            // 
            this.bAplicar.Location = new System.Drawing.Point(259, 227);
            this.bAplicar.Margin = new System.Windows.Forms.Padding(2);
            this.bAplicar.Name = "bAplicar";
            this.bAplicar.Size = new System.Drawing.Size(72, 32);
            this.bAplicar.TabIndex = 21;
            this.bAplicar.Text = "Aplicar";
            this.bAplicar.UseVisualStyleBackColor = true;
            this.bAplicar.Click += new System.EventHandler(this.bAplicar_Click);
            // 
            // tbDuracion
            // 
            this.tbDuracion.Location = new System.Drawing.Point(259, 186);
            this.tbDuracion.Margin = new System.Windows.Forms.Padding(2);
            this.tbDuracion.Name = "tbDuracion";
            this.tbDuracion.Size = new System.Drawing.Size(156, 20);
            this.tbDuracion.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Duracion";
            // 
            // ModificarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 347);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDuracion);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAplicar);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ModificarCita";
            this.Text = "ModificarCita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAplicar;
        private System.Windows.Forms.TextBox tbDuracion;
        private System.Windows.Forms.Label label4;
    }
}