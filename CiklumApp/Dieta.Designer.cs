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
            this.Desayuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MediaMañana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Merienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calorías = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSesiones = new System.Windows.Forms.Button();
            this.bClientes = new System.Windows.Forms.Button();
            this.bEjercicios = new System.Windows.Forms.Button();
            this.bHome = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(687, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 39);
            this.label2.TabIndex = 37;
            this.label2.Text = "Dieta del cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label1.Location = new System.Drawing.Point(707, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 78);
            this.label1.TabIndex = 36;
            this.label1.Text = "DIETA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desayuno,
            this.MediaMañana,
            this.Comida,
            this.Merienda,
            this.Cena,
            this.Calorías});
            this.dataGridView1.Location = new System.Drawing.Point(473, 240);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(803, 409);
            this.dataGridView1.TabIndex = 35;
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
            // bSesiones
            // 
            this.bSesiones.Location = new System.Drawing.Point(195, 682);
            this.bSesiones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bSesiones.Name = "bSesiones";
            this.bSesiones.Size = new System.Drawing.Size(208, 53);
            this.bSesiones.TabIndex = 34;
            this.bSesiones.Text = "SESIONES";
            this.bSesiones.UseVisualStyleBackColor = true;
            // 
            // bClientes
            // 
            this.bClientes.Location = new System.Drawing.Point(195, 539);
            this.bClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(208, 53);
            this.bClientes.TabIndex = 33;
            this.bClientes.Text = "CLIENTES";
            this.bClientes.UseVisualStyleBackColor = true;
            // 
            // bEjercicios
            // 
            this.bEjercicios.Location = new System.Drawing.Point(195, 391);
            this.bEjercicios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEjercicios.Name = "bEjercicios";
            this.bEjercicios.Size = new System.Drawing.Size(208, 53);
            this.bEjercicios.TabIndex = 32;
            this.bEjercicios.Text = "EJERCICIOS";
            this.bEjercicios.UseVisualStyleBackColor = true;
            // 
            // bHome
            // 
            this.bHome.Location = new System.Drawing.Point(195, 261);
            this.bHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(208, 53);
            this.bHome.TabIndex = 31;
            this.bHome.Text = "HOME";
            this.bHome.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(881, 682);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 53);
            this.button3.TabIndex = 40;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(677, 681);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 53);
            this.button2.TabIndex = 39;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 681);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 54);
            this.button1.TabIndex = 38;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Dieta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 816);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bSesiones);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bEjercicios);
            this.Controls.Add(this.bHome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Desayuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn MediaMañana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Merienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calorías;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}