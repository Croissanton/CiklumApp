namespace CiklumApp
{
    partial class Notificaciones
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
            this.lbNotificaciones = new System.Windows.Forms.ListBox();
            this.bRechazar = new System.Windows.Forms.Button();
            this.bAcceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNotificaciones
            // 
            this.lbNotificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotificaciones.FormattingEnabled = true;
            this.lbNotificaciones.HorizontalScrollbar = true;
            this.lbNotificaciones.ItemHeight = 20;
            this.lbNotificaciones.Location = new System.Drawing.Point(0, 0);
            this.lbNotificaciones.Name = "lbNotificaciones";
            this.lbNotificaciones.Size = new System.Drawing.Size(685, 286);
            this.lbNotificaciones.TabIndex = 0;
            this.lbNotificaciones.SelectedIndexChanged += new System.EventHandler(this.lbNotificaciones_SelectedIndexChanged);
            // 
            // bRechazar
            // 
            this.bRechazar.AutoSize = true;
            this.bRechazar.Location = new System.Drawing.Point(462, 345);
            this.bRechazar.Name = "bRechazar";
            this.bRechazar.Size = new System.Drawing.Size(97, 45);
            this.bRechazar.TabIndex = 2;
            this.bRechazar.Text = "Rechazar";
            this.bRechazar.UseVisualStyleBackColor = true;
            this.bRechazar.Click += new System.EventHandler(this.bRechazar_Click);
            // 
            // bAcceptar
            // 
            this.bAcceptar.AutoSize = true;
            this.bAcceptar.Location = new System.Drawing.Point(239, 345);
            this.bAcceptar.Name = "bAcceptar";
            this.bAcceptar.Size = new System.Drawing.Size(97, 45);
            this.bAcceptar.TabIndex = 1;
            this.bAcceptar.Text = "Acceptar";
            this.bAcceptar.UseVisualStyleBackColor = true;
            this.bAcceptar.Click += new System.EventHandler(this.bAcceptar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbNotificaciones);
            this.panel1.Location = new System.Drawing.Point(53, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 286);
            this.panel1.TabIndex = 3;
            // 
            // Notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bRechazar);
            this.Controls.Add(this.bAcceptar);
            this.Name = "Notificaciones";
            this.Text = "Notificaciones";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNotificaciones;
        private System.Windows.Forms.Button bRechazar;
        private System.Windows.Forms.Button bAcceptar;
        private System.Windows.Forms.Panel panel1;
    }
}