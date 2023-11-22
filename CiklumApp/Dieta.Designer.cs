namespace CiklumApp
{
    partial class Dieta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bSesiones = new System.Windows.Forms.Button();
            this.bClientes = new System.Windows.Forms.Button();
            this.bEjercicios = new System.Windows.Forms.Button();
            this.bHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(515, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 37;
            this.label2.Text = "Dieta del cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label1.Location = new System.Drawing.Point(530, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 63);
            this.label1.TabIndex = 36;
            this.label1.Text = "DIETA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(355, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 420);
            this.dataGridView1.TabIndex = 35;
            // 
            // bSesiones
            // 
            this.bSesiones.Location = new System.Drawing.Point(146, 554);
            this.bSesiones.Name = "bSesiones";
            this.bSesiones.Size = new System.Drawing.Size(156, 43);
            this.bSesiones.TabIndex = 34;
            this.bSesiones.Text = "SESIONES";
            this.bSesiones.UseVisualStyleBackColor = true;
            // 
            // bClientes
            // 
            this.bClientes.Location = new System.Drawing.Point(146, 438);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(156, 43);
            this.bClientes.TabIndex = 33;
            this.bClientes.Text = "CLIENTES";
            this.bClientes.UseVisualStyleBackColor = true;
            // 
            // bEjercicios
            // 
            this.bEjercicios.Location = new System.Drawing.Point(146, 318);
            this.bEjercicios.Name = "bEjercicios";
            this.bEjercicios.Size = new System.Drawing.Size(156, 43);
            this.bEjercicios.TabIndex = 32;
            this.bEjercicios.Text = "EJERCICIOS";
            this.bEjercicios.UseVisualStyleBackColor = true;
            // 
            // bHome
            // 
            this.bHome.Location = new System.Drawing.Point(146, 212);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(156, 43);
            this.bHome.TabIndex = 31;
            this.bHome.Text = "HOME";
            this.bHome.UseVisualStyleBackColor = true;
            // 
            // Dieta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 663);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bSesiones);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bEjercicios);
            this.Controls.Add(this.bHome);
            this.Name = "Dieta";
            this.Text = "Dieta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bSesiones;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bEjercicios;
        private System.Windows.Forms.Button bHome;
    }
}