namespace CiklumApp
{
    partial class PerfilEntrenador
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
            this.tbEspecialidad = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lPeso = new System.Windows.Forms.Label();
            this.lAltura = new System.Windows.Forms.Label();
            this.lApellidos = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lNombreEntrenador = new System.Windows.Forms.Label();
            this.pbFotoEntrenador = new System.Windows.Forms.PictureBox();
            this.lIMC = new System.Windows.Forms.Label();
            this.tbHorario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEntrenador)).BeginInit();
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
            this.cbMenu.Size = new System.Drawing.Size(1084, 37);
            this.cbMenu.TabIndex = 42;
            this.cbMenu.SelectedIndexChanged += new System.EventHandler(this.cbMenu_SelectedIndexChanged);
            // 
            // tbEspecialidad
            // 
            this.tbEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEspecialidad.Location = new System.Drawing.Point(248, 439);
            this.tbEspecialidad.Name = "tbEspecialidad";
            this.tbEspecialidad.ReadOnly = true;
            this.tbEspecialidad.Size = new System.Drawing.Size(175, 20);
            this.tbEspecialidad.TabIndex = 66;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCorreo.Location = new System.Drawing.Point(248, 399);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.ReadOnly = true;
            this.tbCorreo.Size = new System.Drawing.Size(175, 20);
            this.tbCorreo.TabIndex = 65;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellidos.Location = new System.Drawing.Point(248, 358);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.ReadOnly = true;
            this.tbApellidos.Size = new System.Drawing.Size(175, 20);
            this.tbApellidos.TabIndex = 64;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.Location = new System.Drawing.Point(248, 322);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(175, 20);
            this.tbNombre.TabIndex = 63;
            // 
            // lPeso
            // 
            this.lPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPeso.AutoSize = true;
            this.lPeso.Location = new System.Drawing.Point(138, 442);
            this.lPeso.Name = "lPeso";
            this.lPeso.Size = new System.Drawing.Size(70, 13);
            this.lPeso.TabIndex = 61;
            this.lPeso.Text = "Especialidad:";
            // 
            // lAltura
            // 
            this.lAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lAltura.AutoSize = true;
            this.lAltura.Location = new System.Drawing.Point(138, 402);
            this.lAltura.Name = "lAltura";
            this.lAltura.Size = new System.Drawing.Size(41, 13);
            this.lAltura.TabIndex = 60;
            this.lAltura.Text = "Correo:";
            // 
            // lApellidos
            // 
            this.lApellidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lApellidos.AutoSize = true;
            this.lApellidos.Location = new System.Drawing.Point(138, 361);
            this.lApellidos.Name = "lApellidos";
            this.lApellidos.Size = new System.Drawing.Size(52, 13);
            this.lApellidos.TabIndex = 59;
            this.lApellidos.Text = "Apellidos:";
            // 
            // lNombre
            // 
            this.lNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(138, 325);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 58;
            this.lNombre.Text = "Nombre:";
            // 
            // lNombreEntrenador
            // 
            this.lNombreEntrenador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNombreEntrenador.AutoSize = true;
            this.lNombreEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lNombreEntrenador.Location = new System.Drawing.Point(265, 155);
            this.lNombreEntrenador.Name = "lNombreEntrenador";
            this.lNombreEntrenador.Size = new System.Drawing.Size(181, 25);
            this.lNombreEntrenador.TabIndex = 57;
            this.lNombreEntrenador.Text = "lNombreEntrenador";
            // 
            // pbFotoEntrenador
            // 
            this.pbFotoEntrenador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFotoEntrenador.Image = global::CiklumApp.Properties.Resources.deswn27_69d5ec99_e25d_4313_bdf4_b259d963a120;
            this.pbFotoEntrenador.Location = new System.Drawing.Point(74, 114);
            this.pbFotoEntrenador.Name = "pbFotoEntrenador";
            this.pbFotoEntrenador.Size = new System.Drawing.Size(169, 122);
            this.pbFotoEntrenador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoEntrenador.TabIndex = 56;
            this.pbFotoEntrenador.TabStop = false;
            // 
            // lIMC
            // 
            this.lIMC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lIMC.AutoSize = true;
            this.lIMC.Location = new System.Drawing.Point(138, 480);
            this.lIMC.Name = "lIMC";
            this.lIMC.Size = new System.Drawing.Size(44, 13);
            this.lIMC.TabIndex = 62;
            this.lIMC.Text = "Horario:";
            // 
            // tbHorario
            // 
            this.tbHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHorario.Location = new System.Drawing.Point(248, 477);
            this.tbHorario.Name = "tbHorario";
            this.tbHorario.ReadOnly = true;
            this.tbHorario.Size = new System.Drawing.Size(175, 20);
            this.tbHorario.TabIndex = 67;
            // 
            // PerfilEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 861);
            this.Controls.Add(this.tbHorario);
            this.Controls.Add(this.tbEspecialidad);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lIMC);
            this.Controls.Add(this.lPeso);
            this.Controls.Add(this.lAltura);
            this.Controls.Add(this.lApellidos);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.lNombreEntrenador);
            this.Controls.Add(this.pbFotoEntrenador);
            this.Controls.Add(this.cbMenu);
            this.Name = "PerfilEntrenador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerfilEntrenador";
            this.Load += new System.EventHandler(this.PerfilEntrenador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEntrenador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.TextBox tbEspecialidad;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lPeso;
        private System.Windows.Forms.Label lAltura;
        private System.Windows.Forms.Label lApellidos;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lNombreEntrenador;
        private System.Windows.Forms.PictureBox pbFotoEntrenador;
        private System.Windows.Forms.Label lIMC;
        private System.Windows.Forms.TextBox tbHorario;
    }
}