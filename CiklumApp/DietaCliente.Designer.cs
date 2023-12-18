namespace CiklumApp
{
    partial class DietaCliente
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
            this.cbMenu.Size = new System.Drawing.Size(784, 37);
            this.cbMenu.TabIndex = 43;
            // 
            // DietaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 861);
            this.Controls.Add(this.cbMenu);
            this.Name = "DietaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DietaCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMenu;
    }
}