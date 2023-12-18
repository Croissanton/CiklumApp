namespace CiklumApp
{
    partial class SesionCliente
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
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.dgvSesiones = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repeticiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bRutina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesiones)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMenu
            // 
            this.cbMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(0, 0);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(1094, 37);
            this.cbMenu.TabIndex = 44;
            this.cbMenu.SelectedIndexChanged += new System.EventHandler(this.cbMenu_SelectedIndexChanged);
            // 
            // dgvSesiones
            // 
            this.dgvSesiones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSesiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSesiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Repeticiones,
            this.Series});
            this.dgvSesiones.Location = new System.Drawing.Point(232, 190);
            this.dgvSesiones.Name = "dgvSesiones";
            this.dgvSesiones.RowHeadersWidth = 51;
            this.dgvSesiones.Size = new System.Drawing.Size(732, 301);
            this.dgvSesiones.TabIndex = 49;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label1.Location = new System.Drawing.Point(449, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 63);
            this.label1.TabIndex = 50;
            this.label1.Text = "SESION";
            // 
            // bRutina
            // 
            this.bRutina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bRutina.Location = new System.Drawing.Point(491, 562);
            this.bRutina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bRutina.Name = "bRutina";
            this.bRutina.Size = new System.Drawing.Size(156, 43);
            this.bRutina.TabIndex = 48;
            this.bRutina.Text = "ATRÁS";
            this.bRutina.UseVisualStyleBackColor = true;
            this.bRutina.Click += new System.EventHandler(this.bRutina_Click);
            // 
            // SesionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 857);
            this.Controls.Add(this.dgvSesiones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRutina);
            this.Controls.Add(this.cbMenu);
            this.Name = "SesionCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SesionCliente";
            this.Load += new System.EventHandler(this.SesionCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.DataGridView dgvSesiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repeticiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Series;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRutina;
    }
}