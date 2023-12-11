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
            this.lbSesiones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRutina = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bSesiones = new System.Windows.Forms.Button();
            this.bClientes = new System.Windows.Forms.Button();
            this.bEjercicios = new System.Windows.Forms.Button();
            this.bHome = new System.Windows.Forms.Button();
            this.bRutina = new System.Windows.Forms.Button();
            this.bSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSesiones
            // 
            this.lbSesiones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSesiones.FormattingEnabled = true;
            this.lbSesiones.Location = new System.Drawing.Point(218, 223);
            this.lbSesiones.Name = "lbSesiones";
            this.lbSesiones.Size = new System.Drawing.Size(431, 316);
            this.lbSesiones.TabIndex = 39;
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
            // lbRutina
            // 
            this.lbRutina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRutina.FormattingEnabled = true;
            this.lbRutina.Location = new System.Drawing.Point(677, 223);
            this.lbRutina.Name = "lbRutina";
            this.lbRutina.Size = new System.Drawing.Size(431, 316);
            this.lbRutina.TabIndex = 41;
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
            // lCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 683);
            this.Controls.Add(this.bSesion);
            this.Controls.Add(this.bRutina);
            this.Controls.Add(this.bSesiones);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bEjercicios);
            this.Controls.Add(this.bHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRutina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSesiones);
            this.Name = "lCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.lCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbSesiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRutina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSesiones;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bEjercicios;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.Button bRutina;
        private System.Windows.Forms.Button bSesion;
    }
}