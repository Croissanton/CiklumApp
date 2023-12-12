namespace CiklumApp
{
    partial class Dieta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDieta = new System.Windows.Forms.DataGridView();
            this.bSesiones = new System.Windows.Forms.Button();
            this.bClientes = new System.Windows.Forms.Button();
            this.bEjercicios = new System.Windows.Forms.Button();
            this.bHome = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bAñadir = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desayuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MediaMañana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Merienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calorías = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieta)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(515, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 37;
            this.label2.Text = "Dieta del cliente:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label1.Location = new System.Drawing.Point(530, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 63);
            this.label1.TabIndex = 36;
            this.label1.Text = "DIETA";
            // 
            // dgvDieta
            // 
            this.dgvDieta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDieta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDieta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Desayuno,
            this.MediaMañana,
            this.Comida,
            this.Merienda,
            this.Cena,
            this.Calorías});
            this.dgvDieta.Location = new System.Drawing.Point(355, 195);
            this.dgvDieta.Name = "dgvDieta";
            this.dgvDieta.RowHeadersWidth = 51;
            this.dgvDieta.Size = new System.Drawing.Size(602, 332);
            this.dgvDieta.TabIndex = 35;
            this.dgvDieta.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // bSesiones
            // 
            this.bSesiones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSesiones.Location = new System.Drawing.Point(146, 554);
            this.bSesiones.Name = "bSesiones";
            this.bSesiones.Size = new System.Drawing.Size(156, 43);
            this.bSesiones.TabIndex = 34;
            this.bSesiones.Text = "SESIONES";
            this.bSesiones.UseVisualStyleBackColor = true;
            // 
            // bClientes
            // 
            this.bClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bClientes.Location = new System.Drawing.Point(146, 438);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(156, 43);
            this.bClientes.TabIndex = 33;
            this.bClientes.Text = "CLIENTES";
            this.bClientes.UseVisualStyleBackColor = true;
            // 
            // bEjercicios
            // 
            this.bEjercicios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bEjercicios.Location = new System.Drawing.Point(146, 318);
            this.bEjercicios.Name = "bEjercicios";
            this.bEjercicios.Size = new System.Drawing.Size(156, 43);
            this.bEjercicios.TabIndex = 32;
            this.bEjercicios.Text = "EJERCICIOS";
            this.bEjercicios.UseVisualStyleBackColor = true;
            // 
            // bHome
            // 
            this.bHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bHome.Location = new System.Drawing.Point(146, 212);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(156, 43);
            this.bHome.TabIndex = 31;
            this.bHome.Text = "HOME";
            this.bHome.UseVisualStyleBackColor = true;
            // 
            // bBorrar
            // 
            this.bBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bBorrar.Location = new System.Drawing.Point(508, 553);
            this.bBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(131, 43);
            this.bBorrar.TabIndex = 39;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bAñadir
            // 
            this.bAñadir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bAñadir.Location = new System.Drawing.Point(355, 553);
            this.bAñadir.Margin = new System.Windows.Forms.Padding(2);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(124, 44);
            this.bAñadir.TabIndex = 38;
            this.bAñadir.Text = "Añadir";
            this.bAñadir.UseVisualStyleBackColor = true;
            this.bAñadir.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Desayuno
            // 
            this.Desayuno.HeaderText = "Desayuno";
            this.Desayuno.MinimumWidth = 6;
            this.Desayuno.Name = "Desayuno";
            this.Desayuno.Width = 125;
            // 
            // MediaMañana
            // 
            this.MediaMañana.HeaderText = "MediaMañana";
            this.MediaMañana.MinimumWidth = 6;
            this.MediaMañana.Name = "MediaMañana";
            this.MediaMañana.Width = 125;
            // 
            // Comida
            // 
            this.Comida.HeaderText = "Comida";
            this.Comida.MinimumWidth = 6;
            this.Comida.Name = "Comida";
            this.Comida.Width = 125;
            // 
            // Merienda
            // 
            this.Merienda.HeaderText = "Merienda";
            this.Merienda.MinimumWidth = 6;
            this.Merienda.Name = "Merienda";
            this.Merienda.Width = 125;
            // 
            // Cena
            // 
            this.Cena.HeaderText = "Cena";
            this.Cena.MinimumWidth = 6;
            this.Cena.Name = "Cena";
            this.Cena.Width = 125;
            // 
            // Calorías
            // 
            this.Calorías.HeaderText = "Calorías";
            this.Calorías.MinimumWidth = 6;
            this.Calorías.Name = "Calorías";
            this.Calorías.Width = 125;
            // 
            // Dieta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 663);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bAñadir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDieta);
            this.Controls.Add(this.bSesiones);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bEjercicios);
            this.Controls.Add(this.bHome);
            this.Name = "Dieta";
            this.Text = "Dieta";
            this.Load += new System.EventHandler(this.Dieta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDieta;
        private System.Windows.Forms.Button bSesiones;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bEjercicios;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bAñadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desayuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn MediaMañana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Merienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calorías;
    }
}