namespace CiklumApp
{
    partial class Entrenadores
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
            this.dgvEntrenadores = new System.Windows.Forms.DataGridView();
            this.bPerfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).BeginInit();
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
            this.cbMenu.Size = new System.Drawing.Size(1113, 37);
            this.cbMenu.TabIndex = 42;
            this.cbMenu.SelectedIndexChanged += new System.EventHandler(this.cbMenu_SelectedIndexChanged);
            // 
            // dgvEntrenadores
            // 
            this.dgvEntrenadores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEntrenadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrenadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellidos,
            this.Especialidad});
            this.dgvEntrenadores.Location = new System.Drawing.Point(354, 250);
            this.dgvEntrenadores.Name = "dgvEntrenadores";
            this.dgvEntrenadores.Size = new System.Drawing.Size(394, 304);
            this.dgvEntrenadores.TabIndex = 49;
            this.dgvEntrenadores.Click += new System.EventHandler(this.dgvEntrenadores_Click);
            // 
            // bPerfil
            // 
            this.bPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bPerfil.Location = new System.Drawing.Point(803, 298);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(98, 23);
            this.bPerfil.TabIndex = 48;
            this.bPerfil.Text = "Ir al perfil";
            this.bPerfil.UseVisualStyleBackColor = true;
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label1.Location = new System.Drawing.Point(312, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 63);
            this.label1.TabIndex = 43;
            this.label1.Text = "ENTRENADORES";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            // 
            // Entrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 861);
            this.Controls.Add(this.dgvEntrenadores);
            this.Controls.Add(this.bPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMenu);
            this.Name = "Entrenadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrenadores";
            this.Load += new System.EventHandler(this.Entrenadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.DataGridView dgvEntrenadores;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
    }
}