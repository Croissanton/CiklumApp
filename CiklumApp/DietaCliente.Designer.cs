namespace CiklumApp
{
    partial class DietaCliente
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
            this.lDieta = new System.Windows.Forms.Label();
            this.dgvDieta = new System.Windows.Forms.DataGridView();
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
            // cbMenu
            // 
            this.cbMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(0, 0);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(1321, 37);
            this.cbMenu.TabIndex = 43;
            this.cbMenu.SelectedIndexChanged += new System.EventHandler(this.cbMenu_SelectedIndexChanged);
            // 
            // lDieta
            // 
            this.lDieta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lDieta.AutoSize = true;
            this.lDieta.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.lDieta.Location = new System.Drawing.Point(550, 72);
            this.lDieta.Name = "lDieta";
            this.lDieta.Size = new System.Drawing.Size(186, 63);
            this.lDieta.TabIndex = 44;
            this.lDieta.Text = "DIETA";
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
            this.dgvDieta.Location = new System.Drawing.Point(167, 178);
            this.dgvDieta.Name = "dgvDieta";
            this.dgvDieta.RowHeadersWidth = 51;
            this.dgvDieta.Size = new System.Drawing.Size(906, 332);
            this.dgvDieta.TabIndex = 45;
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
            // DietaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 578);
            this.Controls.Add(this.dgvDieta);
            this.Controls.Add(this.lDieta);
            this.Controls.Add(this.cbMenu);
            this.Name = "DietaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DietaCliente";
            this.Load += new System.EventHandler(this.DietaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.Label lDieta;
        private System.Windows.Forms.DataGridView dgvDieta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desayuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn MediaMañana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Merienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calorías;
    }
}