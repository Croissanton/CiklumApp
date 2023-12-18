namespace CiklumApp
{
    partial class PerfilCliente
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
            this.pbFotoCliente = new System.Windows.Forms.PictureBox();
            this.lNombreCliente = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lApellidos = new System.Windows.Forms.Label();
            this.lAltura = new System.Windows.Forms.Label();
            this.lPeso = new System.Windows.Forms.Label();
            this.lIMC = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.tbIMC = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEntrenadoresAsignados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.cbMenu.Size = new System.Drawing.Size(1031, 37);
            this.cbMenu.TabIndex = 42;
            this.cbMenu.SelectedIndexChanged += new System.EventHandler(this.cbMenu_SelectedIndexChanged);
            // 
            // pbFotoCliente
            // 
            this.pbFotoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFotoCliente.Image = global::CiklumApp.Properties.Resources.deswn27_69d5ec99_e25d_4313_bdf4_b259d963a120;
            this.pbFotoCliente.Location = new System.Drawing.Point(50, 78);
            this.pbFotoCliente.Name = "pbFotoCliente";
            this.pbFotoCliente.Size = new System.Drawing.Size(169, 122);
            this.pbFotoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoCliente.TabIndex = 43;
            this.pbFotoCliente.TabStop = false;
            // 
            // lNombreCliente
            // 
            this.lNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNombreCliente.AutoSize = true;
            this.lNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lNombreCliente.Location = new System.Drawing.Point(241, 119);
            this.lNombreCliente.Name = "lNombreCliente";
            this.lNombreCliente.Size = new System.Drawing.Size(146, 25);
            this.lNombreCliente.TabIndex = 44;
            this.lNombreCliente.Text = "lNombreCliente";
            // 
            // lNombre
            // 
            this.lNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(114, 289);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 45;
            this.lNombre.Text = "Nombre:";
            // 
            // lApellidos
            // 
            this.lApellidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lApellidos.AutoSize = true;
            this.lApellidos.Location = new System.Drawing.Point(114, 325);
            this.lApellidos.Name = "lApellidos";
            this.lApellidos.Size = new System.Drawing.Size(52, 13);
            this.lApellidos.TabIndex = 46;
            this.lApellidos.Text = "Apellidos:";
            // 
            // lAltura
            // 
            this.lAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lAltura.AutoSize = true;
            this.lAltura.Location = new System.Drawing.Point(114, 366);
            this.lAltura.Name = "lAltura";
            this.lAltura.Size = new System.Drawing.Size(37, 13);
            this.lAltura.TabIndex = 47;
            this.lAltura.Text = "Altura:";
            // 
            // lPeso
            // 
            this.lPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPeso.AutoSize = true;
            this.lPeso.Location = new System.Drawing.Point(114, 406);
            this.lPeso.Name = "lPeso";
            this.lPeso.Size = new System.Drawing.Size(34, 13);
            this.lPeso.TabIndex = 48;
            this.lPeso.Text = "Peso:";
            // 
            // lIMC
            // 
            this.lIMC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lIMC.AutoSize = true;
            this.lIMC.Location = new System.Drawing.Point(114, 444);
            this.lIMC.Name = "lIMC";
            this.lIMC.Size = new System.Drawing.Size(26, 13);
            this.lIMC.TabIndex = 49;
            this.lIMC.Text = "IMC";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.Location = new System.Drawing.Point(224, 286);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(175, 20);
            this.tbNombre.TabIndex = 50;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellidos.Location = new System.Drawing.Point(224, 322);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.ReadOnly = true;
            this.tbApellidos.Size = new System.Drawing.Size(175, 20);
            this.tbApellidos.TabIndex = 51;
            // 
            // tbAltura
            // 
            this.tbAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAltura.Location = new System.Drawing.Point(224, 363);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(175, 20);
            this.tbAltura.TabIndex = 52;
            // 
            // tbPeso
            // 
            this.tbPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPeso.Location = new System.Drawing.Point(224, 403);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(175, 20);
            this.tbPeso.TabIndex = 53;
            // 
            // tbIMC
            // 
            this.tbIMC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIMC.Location = new System.Drawing.Point(224, 441);
            this.tbIMC.Name = "tbIMC";
            this.tbIMC.ReadOnly = true;
            this.tbIMC.Size = new System.Drawing.Size(175, 20);
            this.tbIMC.TabIndex = 54;
            // 
            // bGuardar
            // 
            this.bGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bGuardar.Location = new System.Drawing.Point(269, 491);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(79, 31);
            this.bGuardar.TabIndex = 55;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apellidos,
            this.Nombre});
            this.dataGridView1.Location = new System.Drawing.Point(533, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 168);
            this.dataGridView1.TabIndex = 56;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // lEntrenadoresAsignados
            // 
            this.lEntrenadoresAsignados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lEntrenadoresAsignados.AutoSize = true;
            this.lEntrenadoresAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lEntrenadoresAsignados.Location = new System.Drawing.Point(529, 250);
            this.lEntrenadoresAsignados.Name = "lEntrenadoresAsignados";
            this.lEntrenadoresAsignados.Size = new System.Drawing.Size(189, 20);
            this.lEntrenadoresAsignados.TabIndex = 57;
            this.lEntrenadoresAsignados.Text = "Entrenadores Asignados:";
            // 
            // PerfilCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 578);
            this.Controls.Add(this.lEntrenadoresAsignados);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tbIMC);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.tbAltura);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lIMC);
            this.Controls.Add(this.lPeso);
            this.Controls.Add(this.lAltura);
            this.Controls.Add(this.lApellidos);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.lNombreCliente);
            this.Controls.Add(this.pbFotoCliente);
            this.Controls.Add(this.cbMenu);
            this.Name = "PerfilCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerfilCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.PictureBox pbFotoCliente;
        private System.Windows.Forms.Label lNombreCliente;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lApellidos;
        private System.Windows.Forms.Label lAltura;
        private System.Windows.Forms.Label lPeso;
        private System.Windows.Forms.Label lIMC;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.TextBox tbIMC;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Label lEntrenadoresAsignados;
    }
}