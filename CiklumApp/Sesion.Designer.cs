namespace CiklumApp
{
    partial class Sesion
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
            this.dgvSesion = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repeticiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSesiones = new System.Windows.Forms.Button();
            this.bClientes = new System.Windows.Forms.Button();
            this.bEjercicios = new System.Windows.Forms.Button();
            this.bHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bModificar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bAñadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSesion
            // 
            this.dgvSesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSesion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Repeticiones,
            this.Series});
            this.dgvSesion.Location = new System.Drawing.Point(367, 215);
            this.dgvSesion.Name = "dgvSesion";
            this.dgvSesion.RowHeadersWidth = 51;
            this.dgvSesion.Size = new System.Drawing.Size(576, 301);
            this.dgvSesion.TabIndex = 19;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del ejercicio";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Repeticiones
            // 
            this.Repeticiones.HeaderText = "Repeticiones/tiempo";
            this.Repeticiones.MinimumWidth = 6;
            this.Repeticiones.Name = "Repeticiones";
            this.Repeticiones.Width = 125;
            // 
            // Series
            // 
            this.Series.HeaderText = "Series";
            this.Series.MinimumWidth = 6;
            this.Series.Name = "Series";
            this.Series.Width = 125;
            // 
            // bSesiones
            // 
            this.bSesiones.Location = new System.Drawing.Point(112, 571);
            this.bSesiones.Name = "bSesiones";
            this.bSesiones.Size = new System.Drawing.Size(156, 43);
            this.bSesiones.TabIndex = 18;
            this.bSesiones.Text = "SESIONES";
            this.bSesiones.UseVisualStyleBackColor = true;
            // 
            // bClientes
            // 
            this.bClientes.Location = new System.Drawing.Point(112, 455);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(156, 43);
            this.bClientes.TabIndex = 17;
            this.bClientes.Text = "CLIENTES";
            this.bClientes.UseVisualStyleBackColor = true;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bEjercicios
            // 
            this.bEjercicios.Location = new System.Drawing.Point(112, 335);
            this.bEjercicios.Name = "bEjercicios";
            this.bEjercicios.Size = new System.Drawing.Size(156, 43);
            this.bEjercicios.TabIndex = 16;
            this.bEjercicios.Text = "EJERCICIOS";
            this.bEjercicios.UseVisualStyleBackColor = true;
            this.bEjercicios.Click += new System.EventHandler(this.bEjercicios_Click);
            // 
            // bHome
            // 
            this.bHome.Location = new System.Drawing.Point(112, 229);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(156, 43);
            this.bHome.TabIndex = 15;
            this.bHome.Text = "HOME";
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label1.Location = new System.Drawing.Point(463, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 63);
            this.label1.TabIndex = 22;
            this.label1.Text = "SESION";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Sesion1",
            "Sesion2",
            "Sesion3"});
            this.listBox1.Location = new System.Drawing.Point(996, 215);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 303);
            this.listBox1.TabIndex = 23;
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(673, 545);
            this.bModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(131, 43);
            this.bModificar.TabIndex = 29;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(520, 544);
            this.bBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(131, 43);
            this.bBorrar.TabIndex = 28;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            // 
            // bAñadir
            // 
            this.bAñadir.Location = new System.Drawing.Point(367, 544);
            this.bAñadir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(124, 44);
            this.bAñadir.TabIndex = 27;
            this.bAñadir.Text = "Añadir";
            this.bAñadir.UseVisualStyleBackColor = true;
            // 
            // Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 684);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bAñadir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSesion);
            this.Controls.Add(this.bSesiones);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bEjercicios);
            this.Controls.Add(this.bHome);
            this.Name = "Sesion";
            this.Text = "z";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSesion;
        private System.Windows.Forms.Button bSesiones;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bEjercicios;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repeticiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Series;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bAñadir;
    }
}