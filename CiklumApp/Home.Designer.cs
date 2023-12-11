namespace CiklumApp
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.citasGridView = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bHome = new System.Windows.Forms.Button();
            this.bEjercicios = new System.Windows.Forms.Button();
            this.bClientes = new System.Windows.Forms.Button();
            this.bSesiones = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.bSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.citasGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label1.Location = new System.Drawing.Point(452, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(548, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tus citas:";
            // 
            // citasGridView
            // 
            this.citasGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.citasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Duracion,
            this.Nombre});
            this.citasGridView.Location = new System.Drawing.Point(346, 207);
            this.citasGridView.Name = "citasGridView";
            this.citasGridView.RowHeadersWidth = 51;
            this.citasGridView.Size = new System.Drawing.Size(353, 242);
            this.citasGridView.TabIndex = 2;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // bHome
            // 
            this.bHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bHome.Location = new System.Drawing.Point(68, 187);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(149, 60);
            this.bHome.TabIndex = 4;
            this.bHome.Text = "HOME";
            this.bHome.UseVisualStyleBackColor = true;
            // 
            // bEjercicios
            // 
            this.bEjercicios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bEjercicios.Location = new System.Drawing.Point(68, 295);
            this.bEjercicios.Name = "bEjercicios";
            this.bEjercicios.Size = new System.Drawing.Size(149, 58);
            this.bEjercicios.TabIndex = 5;
            this.bEjercicios.Text = "EJERCICIOS";
            this.bEjercicios.UseVisualStyleBackColor = true;
            this.bEjercicios.Click += new System.EventHandler(this.bEjercicios_Click);
            // 
            // bClientes
            // 
            this.bClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bClientes.Location = new System.Drawing.Point(68, 408);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(149, 55);
            this.bClientes.TabIndex = 6;
            this.bClientes.Text = "CLIENTES";
            this.bClientes.UseVisualStyleBackColor = true;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bSesiones
            // 
            this.bSesiones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSesiones.Location = new System.Drawing.Point(68, 522);
            this.bSesiones.Name = "bSesiones";
            this.bSesiones.Size = new System.Drawing.Size(149, 59);
            this.bSesiones.TabIndex = 7;
            this.bSesiones.Text = "SESIONES";
            this.bSesiones.UseVisualStyleBackColor = true;
            this.bSesiones.Click += new System.EventHandler(this.bSesiones_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar1.Location = new System.Drawing.Point(1033, 207);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // bSalir
            // 
            this.bSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSalir.Location = new System.Drawing.Point(1073, 456);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(149, 60);
            this.bSalir.TabIndex = 9;
            this.bSalir.Text = "SALIR";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 741);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.bSesiones);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bEjercicios);
            this.Controls.Add(this.bHome);
            this.Controls.Add(this.citasGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.citasGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView citasGridView;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.Button bEjercicios;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bSesiones;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}

