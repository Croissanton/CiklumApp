namespace CiklumApp
{
    partial class Sesion
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
            this.bEliminarSesion = new System.Windows.Forms.Button();
            this.bAnadirSesion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bSesiones = new System.Windows.Forms.Button();
            this.bClientes = new System.Windows.Forms.Button();
            this.bEjercicios = new System.Windows.Forms.Button();
            this.bHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bEliminarSesion
            // 
            this.bEliminarSesion.Location = new System.Drawing.Point(928, 271);
            this.bEliminarSesion.Name = "bEliminarSesion";
            this.bEliminarSesion.Size = new System.Drawing.Size(98, 23);
            this.bEliminarSesion.TabIndex = 21;
            this.bEliminarSesion.Text = "Eliminar Sesión";
            this.bEliminarSesion.UseVisualStyleBackColor = true;
            // 
            // bAnadirSesion
            // 
            this.bAnadirSesion.Location = new System.Drawing.Point(928, 229);
            this.bAnadirSesion.Name = "bAnadirSesion";
            this.bAnadirSesion.Size = new System.Drawing.Size(98, 23);
            this.bAnadirSesion.TabIndex = 20;
            this.bAnadirSesion.Text = "Añadir Sesión";
            this.bAnadirSesion.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(367, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 420);
            this.dataGridView1.TabIndex = 19;
            // 
            // bSesiones
            // 
            this.bSesiones.Location = new System.Drawing.Point(112, 571);
            this.bSesiones.Name = "bSesiones";
            this.bSesiones.Size = new System.Drawing.Size(156, 43);
            this.bSesiones.TabIndex = 18;
            this.bSesiones.Text = "SESIONES";
            this.bSesiones.UseVisualStyleBackColor = true;
            // 
            // bClientes
            // 
            this.bClientes.Location = new System.Drawing.Point(112, 455);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(156, 43);
            this.bClientes.TabIndex = 17;
            this.bClientes.Text = "CLIENTES";
            this.bClientes.UseVisualStyleBackColor = true;
            // 
            // bEjercicios
            // 
            this.bEjercicios.Location = new System.Drawing.Point(112, 335);
            this.bEjercicios.Name = "bEjercicios";
            this.bEjercicios.Size = new System.Drawing.Size(156, 43);
            this.bEjercicios.TabIndex = 16;
            this.bEjercicios.Text = "EJERCICIOS";
            this.bEjercicios.UseVisualStyleBackColor = true;
            // 
            // bHome
            // 
            this.bHome.Location = new System.Drawing.Point(112, 229);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(156, 43);
            this.bHome.TabIndex = 15;
            this.bHome.Text = "HOME";
            this.bHome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label1.Location = new System.Drawing.Point(463, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 63);
            this.label1.TabIndex = 22;
            this.label1.Text = "SESIONES";
            // 
            // Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEliminarSesion);
            this.Controls.Add(this.bAnadirSesion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bSesiones);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bEjercicios);
            this.Controls.Add(this.bHome);
            this.Name = "Sesion";
            this.Text = "Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEliminarSesion;
        private System.Windows.Forms.Button bAnadirSesion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bSesiones;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bEjercicios;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.Label label1;
    }
}