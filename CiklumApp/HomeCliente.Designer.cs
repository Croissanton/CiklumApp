namespace CiklumApp
{
    partial class HomeCliente
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.bNotificaciones = new System.Windows.Forms.Button();
            this.citasGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.bModificar = new System.Windows.Forms.Button();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.bAñadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.citasGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar1.Location = new System.Drawing.Point(365, 175);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label1.Location = new System.Drawing.Point(289, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 78);
            this.label1.TabIndex = 9;
            this.label1.Text = "BIENVENIDO";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // bNotificaciones
            // 
            this.bNotificaciones.Location = new System.Drawing.Point(857, 55);
            this.bNotificaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bNotificaciones.Name = "bNotificaciones";
            this.bNotificaciones.Size = new System.Drawing.Size(120, 54);
            this.bNotificaciones.TabIndex = 11;
            this.bNotificaciones.Text = "Notificaciones";
            this.bNotificaciones.UseVisualStyleBackColor = true;
            this.bNotificaciones.Click += new System.EventHandler(this.bNotificaciones_Click);
            // 
            // citasGridView
            // 
            this.citasGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.citasGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.citasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fecha,
            this.Duracion,
            this.Nombre,
            this.Tipo});
            this.citasGridView.Location = new System.Drawing.Point(304, 534);
            this.citasGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.citasGridView.Name = "citasGridView";
            this.citasGridView.RowHeadersWidth = 51;
            this.citasGridView.Size = new System.Drawing.Size(465, 298);
            this.citasGridView.TabIndex = 13;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.MinimumWidth = 6;
            this.Duracion.Name = "Duracion";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(445, 423);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tus citas:";
            // 
            // bModificar
            // 
            this.bModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bModificar.Location = new System.Drawing.Point(552, 860);
            this.bModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(165, 54);
            this.bModificar.TabIndex = 40;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // cbMenu
            // 
            this.cbMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(0, 0);
            this.cbMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(1045, 44);
            this.cbMenu.TabIndex = 41;
            this.cbMenu.SelectedIndexChanged += new System.EventHandler(this.cbMenu_SelectedIndexChanged);
            // 
            // bAñadir
            // 
            this.bAñadir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bAñadir.Location = new System.Drawing.Point(334, 860);
            this.bAñadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(165, 54);
            this.bAñadir.TabIndex = 42;
            this.bAñadir.Text = "Añadir";
            this.bAñadir.UseVisualStyleBackColor = true;
            this.bAñadir.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // HomeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 1055);
            this.Controls.Add(this.bAñadir);
            this.Controls.Add(this.cbMenu);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.citasGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bNotificaciones);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeCliente";
            ((System.ComponentModel.ISupportInitialize)(this.citasGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button bNotificaciones;
        private System.Windows.Forms.DataGridView citasGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.Button bAñadir;
    }
}