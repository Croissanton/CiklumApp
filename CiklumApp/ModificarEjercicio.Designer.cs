namespace CiklumApp
{
    partial class ModificarEjercicio
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbEnlace = new System.Windows.Forms.TextBox();
            this.tbDuracion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPrivado = new System.Windows.Forms.CheckBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(248, 35);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(145, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(248, 80);
            this.tbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(145, 20);
            this.tbTipo.TabIndex = 1;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(248, 180);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(145, 20);
            this.tbDescripcion.TabIndex = 2;
            // 
            // tbEnlace
            // 
            this.tbEnlace.Location = new System.Drawing.Point(248, 229);
            this.tbEnlace.Margin = new System.Windows.Forms.Padding(2);
            this.tbEnlace.Name = "tbEnlace";
            this.tbEnlace.Size = new System.Drawing.Size(145, 20);
            this.tbEnlace.TabIndex = 3;
            // 
            // tbDuracion
            // 
            this.tbDuracion.Location = new System.Drawing.Point(248, 128);
            this.tbDuracion.Margin = new System.Windows.Forms.Padding(2);
            this.tbDuracion.Name = "tbDuracion";
            this.tbDuracion.Size = new System.Drawing.Size(145, 20);
            this.tbDuracion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del ejercicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Duración";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enlace del vídeo";
            // 
            // cbPrivado
            // 
            this.cbPrivado.AutoSize = true;
            this.cbPrivado.Location = new System.Drawing.Point(248, 284);
            this.cbPrivado.Margin = new System.Windows.Forms.Padding(2);
            this.cbPrivado.Name = "cbPrivado";
            this.cbPrivado.Size = new System.Drawing.Size(62, 17);
            this.cbPrivado.TabIndex = 11;
            this.cbPrivado.Text = "Privado";
            this.cbPrivado.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(472, 314);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(67, 28);
            this.bCancelar.TabIndex = 15;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAplicar
            // 
            this.bAplicar.Location = new System.Drawing.Point(396, 314);
            this.bAplicar.Margin = new System.Windows.Forms.Padding(2);
            this.bAplicar.Name = "bAplicar";
            this.bAplicar.Size = new System.Drawing.Size(72, 28);
            this.bAplicar.TabIndex = 14;
            this.bAplicar.Text = "Aplicar";
            this.bAplicar.UseVisualStyleBackColor = true;
            this.bAplicar.Click += new System.EventHandler(this.bAplicar_Click);
            // 
            // ModificarEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAplicar);
            this.Controls.Add(this.cbPrivado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDuracion);
            this.Controls.Add(this.tbEnlace);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.tbNombre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarEjercicio";
            this.Text = "ModificarEjercicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbEnlace;
        private System.Windows.Forms.TextBox tbDuracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbPrivado;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAplicar;
    }
}