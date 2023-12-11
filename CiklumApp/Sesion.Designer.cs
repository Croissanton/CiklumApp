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
            this.bBorrar = new System.Windows.Forms.Button();
            this.bAñadir = new System.Windows.Forms.Button();
            this.dgvSesiones = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreSesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrarSesion = new System.Windows.Forms.Button();
            this.añadirSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesiones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSesion
            // 
            this.dgvSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSesion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgvSesion.DoubleClick += new System.EventHandler(this.dgvSesion_DoubleClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del ejercicio";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Repeticiones
            // 
            this.Repeticiones.HeaderText = "Repeticiones/tiempo";
            this.Repeticiones.MinimumWidth = 6;
            this.Repeticiones.Name = "Repeticiones";
            // 
            // Series
            // 
            this.Series.HeaderText = "Series";
            this.Series.MinimumWidth = 6;
            this.Series.Name = "Series";
            // 
            // bSesiones
            // 
            this.bSesiones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSesiones.Location = new System.Drawing.Point(84, 464);
            this.bSesiones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bSesiones.Name = "bSesiones";
            this.bSesiones.Size = new System.Drawing.Size(156, 43);
            this.bSesiones.TabIndex = 18;
            this.bSesiones.Text = "SESIONES";
            this.bSesiones.UseVisualStyleBackColor = true;
            // 
            // bClientes
            // 
            this.bClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bClientes.Location = new System.Drawing.Point(84, 370);
            this.bClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(156, 43);
            this.bClientes.TabIndex = 17;
            this.bClientes.Text = "CLIENTES";
            this.bClientes.UseVisualStyleBackColor = true;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bEjercicios
            // 
            this.bEjercicios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bEjercicios.Location = new System.Drawing.Point(84, 272);
            this.bEjercicios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bEjercicios.Name = "bEjercicios";
            this.bEjercicios.Size = new System.Drawing.Size(156, 43);
            this.bEjercicios.TabIndex = 16;
            this.bEjercicios.Text = "EJERCICIOS";
            this.bEjercicios.UseVisualStyleBackColor = true;
            this.bEjercicios.Click += new System.EventHandler(this.bEjercicios_Click);
            // 
            // bHome
            // 
            this.bHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bHome.Location = new System.Drawing.Point(84, 186);
            this.bHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(156, 43);
            this.bHome.TabIndex = 15;
            this.bHome.Text = "HOME";
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label1.Location = new System.Drawing.Point(463, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 63);
            this.label1.TabIndex = 22;
            this.label1.Text = "SESION";
            // 
            // bBorrar
            // 
            this.bBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bBorrar.Location = new System.Drawing.Point(563, 544);
            this.bBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(131, 43);
            this.bBorrar.TabIndex = 28;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bAñadir
            // 
            this.bAñadir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bAñadir.Location = new System.Drawing.Point(415, 544);
            this.bAñadir.Margin = new System.Windows.Forms.Padding(2);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(124, 44);
            this.bAñadir.TabIndex = 27;
            this.bAñadir.Text = "Añadir";
            this.bAñadir.UseVisualStyleBackColor = true;
            this.bAñadir.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // dgvSesiones
            // 
            this.dgvSesiones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSesiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSesiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NombreSesion});
            this.dgvSesiones.Location = new System.Drawing.Point(985, 219);
            this.dgvSesiones.Name = "dgvSesiones";
            this.dgvSesiones.RowHeadersWidth = 51;
            this.dgvSesiones.Size = new System.Drawing.Size(194, 296);
            this.dgvSesiones.TabIndex = 29;
            this.dgvSesiones.Click += new System.EventHandler(this.dgvSesiones_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // NombreSesion
            // 
            this.NombreSesion.HeaderText = "Sesion";
            this.NombreSesion.MinimumWidth = 6;
            this.NombreSesion.Name = "NombreSesion";
            // 
            // borrarSesion
            // 
            this.borrarSesion.Location = new System.Drawing.Point(1029, 602);
            this.borrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.borrarSesion.Name = "borrarSesion";
            this.borrarSesion.Size = new System.Drawing.Size(124, 43);
            this.borrarSesion.TabIndex = 31;
            this.borrarSesion.Text = "Borrar";
            this.borrarSesion.UseVisualStyleBackColor = true;
            this.borrarSesion.Click += new System.EventHandler(this.borrarSesion_Click);
            // 
            // añadirSesion
            // 
            this.añadirSesion.Location = new System.Drawing.Point(1029, 544);
            this.añadirSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.añadirSesion.Name = "añadirSesion";
            this.añadirSesion.Size = new System.Drawing.Size(124, 44);
            this.añadirSesion.TabIndex = 30;
            this.añadirSesion.Text = "Añadir";
            this.añadirSesion.UseVisualStyleBackColor = true;
            this.añadirSesion.Click += new System.EventHandler(this.añadirSesion_Click);
            // 
            // Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 684);
            this.Controls.Add(this.borrarSesion);
            this.Controls.Add(this.añadirSesion);
            this.Controls.Add(this.dgvSesiones);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bAñadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSesion);
            this.Controls.Add(this.bSesiones);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bEjercicios);
            this.Controls.Add(this.bHome);
            this.Name = "Sesion";
            this.Text = "z";
            this.Load += new System.EventHandler(this.Sesion_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesiones)).EndInit();
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
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bAñadir;
        private System.Windows.Forms.DataGridView dgvSesiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSesion;
        private System.Windows.Forms.Button borrarSesion;
        private System.Windows.Forms.Button añadirSesion;
    }
}