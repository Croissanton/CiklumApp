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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTRENADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label1.Location = new System.Drawing.Point(603, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(731, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tus citas:";
            // 
            // citasGridView
            // 
            this.citasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ENTRENADOR,
            this.ID_CLIENTE,
            this.FECHA,
            this.HORA});
            this.citasGridView.Location = new System.Drawing.Point(461, 255);
            this.citasGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.citasGridView.Name = "citasGridView";
            this.citasGridView.RowHeadersWidth = 51;
            this.citasGridView.Size = new System.Drawing.Size(691, 438);
            this.citasGridView.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // ENTRENADOR
            // 
            this.ENTRENADOR.HeaderText = "ENTRENADOR";
            this.ENTRENADOR.MinimumWidth = 6;
            this.ENTRENADOR.Name = "ENTRENADOR";
            this.ENTRENADOR.Width = 125;
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.HeaderText = "ID_CLIENTE";
            this.ID_CLIENTE.MinimumWidth = 6;
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.Width = 125;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.MinimumWidth = 6;
            this.FECHA.Name = "FECHA";
            this.FECHA.Width = 125;
            // 
            // HORA
            // 
            this.HORA.HeaderText = "HORA";
            this.HORA.MinimumWidth = 6;
            this.HORA.Name = "HORA";
            this.HORA.Width = 125;
            // 
            // bHome
            // 
            this.bHome.Location = new System.Drawing.Point(91, 230);
            this.bHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(199, 74);
            this.bHome.TabIndex = 4;
            this.bHome.Text = "HOME";
            this.bHome.UseVisualStyleBackColor = true;
            // 
            // bEjercicios
            // 
            this.bEjercicios.Location = new System.Drawing.Point(91, 363);
            this.bEjercicios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEjercicios.Name = "bEjercicios";
            this.bEjercicios.Size = new System.Drawing.Size(199, 71);
            this.bEjercicios.TabIndex = 5;
            this.bEjercicios.Text = "EJERCICIOS";
            this.bEjercicios.UseVisualStyleBackColor = true;
            this.bEjercicios.Click += new System.EventHandler(this.bEjercicios_Click);
            // 
            // bClientes
            // 
            this.bClientes.Location = new System.Drawing.Point(91, 502);
            this.bClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(199, 68);
            this.bClientes.TabIndex = 6;
            this.bClientes.Text = "CLIENTES";
            this.bClientes.UseVisualStyleBackColor = true;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bSesiones
            // 
            this.bSesiones.Location = new System.Drawing.Point(91, 642);
            this.bSesiones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bSesiones.Name = "bSesiones";
            this.bSesiones.Size = new System.Drawing.Size(199, 73);
            this.bSesiones.TabIndex = 7;
            this.bSesiones.Text = "SESIONES";
            this.bSesiones.UseVisualStyleBackColor = true;
            this.bSesiones.Click += new System.EventHandler(this.bSesiones_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1377, 255);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(1431, 561);
            this.bSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(199, 74);
            this.bSalir.TabIndex = 9;
            this.bSalir.Text = "SALIR";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1853, 912);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.bSesiones);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bEjercicios);
            this.Controls.Add(this.bHome);
            this.Controls.Add(this.citasGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTRENADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
        private System.Windows.Forms.Button bSalir;
    }
}

