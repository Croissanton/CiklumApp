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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repeticiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSesiones = new System.Windows.Forms.Button();
            this.bClientes = new System.Windows.Forms.Button();
            this.bEjercicios = new System.Windows.Forms.Button();
            this.bHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Repeticiones,
            this.Series});
            this.dataGridView1.Location = new System.Drawing.Point(489, 265);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(768, 370);
            this.dataGridView1.TabIndex = 19;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del ejercicio";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Repeticiones
            // 
            this.Repeticiones.HeaderText = "Repeticiones/tiempo";
            this.Repeticiones.MinimumWidth = 6;
            this.Repeticiones.Name = "Repeticiones";
            this.Repeticiones.Width = 125;
            // 
            // Series
            // 
            this.Series.HeaderText = "Series";
            this.Series.MinimumWidth = 6;
            this.Series.Name = "Series";
            this.Series.Width = 125;
            // 
            // bSesiones
            // 
            this.bSesiones.Location = new System.Drawing.Point(149, 703);
            this.bSesiones.Margin = new System.Windows.Forms.Padding(4);
            this.bSesiones.Name = "bSesiones";
            this.bSesiones.Size = new System.Drawing.Size(208, 53);
            this.bSesiones.TabIndex = 18;
            this.bSesiones.Text = "SESIONES";
            this.bSesiones.UseVisualStyleBackColor = true;
            // 
            // bClientes
            // 
            this.bClientes.Location = new System.Drawing.Point(149, 560);
            this.bClientes.Margin = new System.Windows.Forms.Padding(4);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(208, 53);
            this.bClientes.TabIndex = 17;
            this.bClientes.Text = "CLIENTES";
            this.bClientes.UseVisualStyleBackColor = true;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bEjercicios
            // 
            this.bEjercicios.Location = new System.Drawing.Point(149, 412);
            this.bEjercicios.Margin = new System.Windows.Forms.Padding(4);
            this.bEjercicios.Name = "bEjercicios";
            this.bEjercicios.Size = new System.Drawing.Size(208, 53);
            this.bEjercicios.TabIndex = 16;
            this.bEjercicios.Text = "EJERCICIOS";
            this.bEjercicios.UseVisualStyleBackColor = true;
            this.bEjercicios.Click += new System.EventHandler(this.bEjercicios_Click);
            // 
            // bHome
            // 
            this.bHome.Location = new System.Drawing.Point(149, 282);
            this.bHome.Margin = new System.Windows.Forms.Padding(4);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(208, 53);
            this.bHome.TabIndex = 15;
            this.bHome.Text = "HOME";
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label1.Location = new System.Drawing.Point(617, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 78);
            this.label1.TabIndex = 22;
            this.label1.Text = "SESION";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Sesion1",
            "Sesion2",
            "Sesion3"});
            this.listBox1.Location = new System.Drawing.Point(1328, 265);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 372);
            this.listBox1.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(897, 671);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 53);
            this.button4.TabIndex = 29;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(693, 670);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 53);
            this.button5.TabIndex = 28;
            this.button5.Text = "Borrar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(489, 670);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 54);
            this.button6.TabIndex = 27;
            this.button6.Text = "Añadir";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 842);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bSesiones);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bEjercicios);
            this.Controls.Add(this.bHome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sesion";
            this.Text = "z";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bSesiones;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bEjercicios;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repeticiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Series;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}