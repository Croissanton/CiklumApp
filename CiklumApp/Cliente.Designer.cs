namespace CiklumApp
{
    partial class lCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bSesiones = new System.Windows.Forms.Button();
            this.bClientes = new System.Windows.Forms.Button();
            this.bEjercicios = new System.Windows.Forms.Button();
            this.bHome = new System.Windows.Forms.Button();
            this.bRutina = new System.Windows.Forms.Button();
            this.bSesion = new System.Windows.Forms.Button();
            this.dgvSesion = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRutinas = new System.Windows.Forms.DataGridView();
            this.RutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rutina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutinas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(282, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 31);
            this.label1.TabIndex = 40;
            this.label1.Text = "Sesiones con el Cliente:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(763, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 31);
            this.label3.TabIndex = 42;
            this.label3.Text = "Rutina del Cliente:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label2.Location = new System.Drawing.Point(254, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 63);
            this.label2.TabIndex = 43;
            this.label2.Text = "NOMBRE DEL CLIENTE";
            // 
            // bSesiones
            // 
            this.bSesiones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSesiones.Location = new System.Drawing.Point(33, 528);
            this.bSesiones.Name = "bSesiones";
            this.bSesiones.Size = new System.Drawing.Size(156, 43);
            this.bSesiones.TabIndex = 47;
            this.bSesiones.Text = "SESIONES";
            this.bSesiones.UseVisualStyleBackColor = true;
            this.bSesiones.Click += new System.EventHandler(this.bSesiones_Click);
            // 
            // bClientes
            // 
            this.bClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bClientes.Location = new System.Drawing.Point(33, 412);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(156, 43);
            this.bClientes.TabIndex = 46;
            this.bClientes.Text = "CLIENTES";
            this.bClientes.UseVisualStyleBackColor = true;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bEjercicios
            // 
            this.bEjercicios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bEjercicios.Location = new System.Drawing.Point(33, 292);
            this.bEjercicios.Name = "bEjercicios";
            this.bEjercicios.Size = new System.Drawing.Size(156, 43);
            this.bEjercicios.TabIndex = 45;
            this.bEjercicios.Text = "EJERCICIOS";
            this.bEjercicios.UseVisualStyleBackColor = true;
            this.bEjercicios.Click += new System.EventHandler(this.bEjercicios_Click);
            // 
            // bHome
            // 
            this.bHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bHome.Location = new System.Drawing.Point(33, 186);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(156, 43);
            this.bHome.TabIndex = 44;
            this.bHome.Text = "HOME";
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // bRutina
            // 
            this.bRutina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bRutina.Location = new System.Drawing.Point(808, 556);
            this.bRutina.Name = "bRutina";
            this.bRutina.Size = new System.Drawing.Size(156, 43);
            this.bRutina.TabIndex = 48;
            this.bRutina.Text = "Ver Rutina";
            this.bRutina.UseVisualStyleBackColor = true;
            this.bRutina.Click += new System.EventHandler(this.bRutina_Click);
            // 
            // bSesion
            // 
            this.bSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSesion.Location = new System.Drawing.Point(356, 556);
            this.bSesion.Name = "bSesion";
            this.bSesion.Size = new System.Drawing.Size(156, 43);
            this.bSesion.TabIndex = 49;
            this.bSesion.Text = "Ver Sesion";
            this.bSesion.UseVisualStyleBackColor = true;
            this.bSesion.Click += new System.EventHandler(this.bSesion_Click);
            // 
            // dgvSesion
            // 
            this.dgvSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSesion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Sesion});
            this.dgvSesion.Location = new System.Drawing.Point(243, 223);
            this.dgvSesion.Name = "dgvSesion";
            this.dgvSesion.Size = new System.Drawing.Size(386, 315);
            this.dgvSesion.TabIndex = 50;
            this.dgvSesion.Click += new System.EventHandler(this.dgvSesion_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Sesion
            // 
            this.Sesion.HeaderText = "Sesion";
            this.Sesion.Name = "Sesion";
            // 
            // dgvRutinas
            // 
            this.dgvRutinas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRutinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RutID,
            this.Rutina});
            this.dgvRutinas.Location = new System.Drawing.Point(701, 223);
            this.dgvRutinas.Name = "dgvRutinas";
            this.dgvRutinas.Size = new System.Drawing.Size(398, 314);
            this.dgvRutinas.TabIndex = 51;
            this.dgvRutinas.Click += new System.EventHandler(this.dgvRutinas_Click);
            // 
            // RutID
            // 
            this.RutID.HeaderText = "ID";
            this.RutID.Name = "RutID";
            this.RutID.Visible = false;
            // 
            // Rutina
            // 
            this.Rutina.HeaderText = "Rutina";
            this.Rutina.Name = "Rutina";
            // 
            // lCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 683);
            this.Controls.Add(this.dgvRutinas);
            this.Controls.Add(this.dgvSesion);
            this.Controls.Add(this.bSesion);
            this.Controls.Add(this.bRutina);
            this.Controls.Add(this.bSesiones);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bEjercicios);
            this.Controls.Add(this.bHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "lCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.lCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSesiones;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bEjercicios;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.Button bRutina;
        private System.Windows.Forms.Button bSesion;
        private System.Windows.Forms.DataGridView dgvSesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sesion;
        private System.Windows.Forms.DataGridView dgvRutinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rutina;
    }
}