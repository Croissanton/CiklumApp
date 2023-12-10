namespace CiklumApp
{
    partial class Ejercicios
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
            this.bSesiones = new System.Windows.Forms.Button();
            this.bClientes = new System.Windows.Forms.Button();
            this.bEjercicios = new System.Windows.Forms.Button();
            this.bHome = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duración = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vídeo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Privacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bAñadirEjercicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bSesiones
            // 
            this.bSesiones.Location = new System.Drawing.Point(77, 542);
            this.bSesiones.Name = "bSesiones";
            this.bSesiones.Size = new System.Drawing.Size(156, 43);
            this.bSesiones.TabIndex = 11;
            this.bSesiones.Text = "SESIONES";
            this.bSesiones.UseVisualStyleBackColor = true;
            this.bSesiones.Click += new System.EventHandler(this.bSesiones_Click);
            // 
            // bClientes
            // 
            this.bClientes.Location = new System.Drawing.Point(77, 426);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(156, 43);
            this.bClientes.TabIndex = 10;
            this.bClientes.Text = "CLIENTES";
            this.bClientes.UseVisualStyleBackColor = true;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bEjercicios
            // 
            this.bEjercicios.Location = new System.Drawing.Point(77, 306);
            this.bEjercicios.Name = "bEjercicios";
            this.bEjercicios.Size = new System.Drawing.Size(156, 43);
            this.bEjercicios.TabIndex = 9;
            this.bEjercicios.Text = "EJERCICIOS";
            this.bEjercicios.UseVisualStyleBackColor = true;
            // 
            // bHome
            // 
            this.bHome.Location = new System.Drawing.Point(77, 200);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(156, 43);
            this.bHome.TabIndex = 8;
            this.bHome.Text = "HOME";
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Tipo,
            this.Duración,
            this.Descripción,
            this.Vídeo,
            this.Privacidad});
            this.dataGridView1.Location = new System.Drawing.Point(332, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 420);
            this.dataGridView1.TabIndex = 12;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Duración
            // 
            this.Duración.HeaderText = "Duración";
            this.Duración.Name = "Duración";
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            // 
            // Vídeo
            // 
            this.Vídeo.HeaderText = "Vídeo";
            this.Vídeo.Name = "Vídeo";
            // 
            // Privacidad
            // 
            this.Privacidad.HeaderText = "Privacidad";
            this.Privacidad.Name = "Privacidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label1.Location = new System.Drawing.Point(415, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 63);
            this.label1.TabIndex = 15;
            this.label1.Text = "EJERCICIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(398, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lista de ejercicios disponibles:";
            // 
            // bAñadirEjercicio
            // 
            this.bAñadirEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bAñadirEjercicio.Location = new System.Drawing.Point(1000, 200);
            this.bAñadirEjercicio.Name = "bAñadirEjercicio";
            this.bAñadirEjercicio.Size = new System.Drawing.Size(36, 36);
            this.bAñadirEjercicio.TabIndex = 17;
            this.bAñadirEjercicio.Text = "+";
            this.bAñadirEjercicio.UseVisualStyleBackColor = true;
            // 
            // Ejercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.bAñadirEjercicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bSesiones);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bEjercicios);
            this.Controls.Add(this.bHome);
            this.Name = "Ejercicios";
            this.Text = "Ejercicios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSesiones;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bEjercicios;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duración;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vídeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Privacidad;
        private System.Windows.Forms.Button bAñadirEjercicio;
    }
}