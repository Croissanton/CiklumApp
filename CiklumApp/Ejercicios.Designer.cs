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
            this.dgvEjercicios = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duración = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vídeo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Privacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bAñadir = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercicios)).BeginInit();
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
            // dgvEjercicios
            // 
            this.dgvEjercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEjercicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Tipo,
            this.Duración,
            this.Descripción,
            this.Vídeo,
            this.Privacidad});
            this.dgvEjercicios.Location = new System.Drawing.Point(323, 184);
            this.dgvEjercicios.Name = "dgvEjercicios";
            this.dgvEjercicios.RowHeadersWidth = 51;
            this.dgvEjercicios.Size = new System.Drawing.Size(644, 245);
            this.dgvEjercicios.TabIndex = 12;
            this.dgvEjercicios.DoubleClick += new System.EventHandler(this.dgvEjercicios_DoubleClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 125;
            // 
            // Duración
            // 
            this.Duración.HeaderText = "Duración";
            this.Duración.MinimumWidth = 6;
            this.Duración.Name = "Duración";
            this.Duración.Width = 125;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            this.Descripción.Width = 125;
            // 
            // Vídeo
            // 
            this.Vídeo.HeaderText = "Vídeo";
            this.Vídeo.MinimumWidth = 6;
            this.Vídeo.Name = "Vídeo";
            this.Vídeo.Width = 125;
            // 
            // Privacidad
            // 
            this.Privacidad.HeaderText = "Privacidad";
            this.Privacidad.MinimumWidth = 6;
            this.Privacidad.Name = "Privacidad";
            this.Privacidad.Width = 125;
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
            // bAñadir
            // 
            this.bAñadir.Location = new System.Drawing.Point(332, 464);
            this.bAñadir.Margin = new System.Windows.Forms.Padding(2);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(124, 44);
            this.bAñadir.TabIndex = 17;
            this.bAñadir.Text = "Añadir";
            this.bAñadir.UseVisualStyleBackColor = true;
            this.bAñadir.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(485, 464);
            this.bBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(131, 43);
            this.bBorrar.TabIndex = 18;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // Ejercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bAñadir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEjercicios);
            this.Controls.Add(this.bSesiones);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bEjercicios);
            this.Controls.Add(this.bHome);
            this.Name = "Ejercicios";
            this.Text = "Ejercicios";
            this.Load += new System.EventHandler(this.Ejercicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSesiones;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bEjercicios;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.DataGridView dgvEjercicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duración;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vídeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Privacidad;
        private System.Windows.Forms.Button bAñadir;
        private System.Windows.Forms.Button bBorrar;
    }
}