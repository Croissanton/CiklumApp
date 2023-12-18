namespace CiklumApp
{
    partial class FeedbackEntrenador
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
            this.bCancelar = new System.Windows.Forms.Button();
            this.bEnviar = new System.Windows.Forms.Button();
            this.lValoracion = new System.Windows.Forms.Label();
            this.lbValoracion = new System.Windows.Forms.ListBox();
            this.tbOpinion = new System.Windows.Forms.TextBox();
            this.lOpinion = new System.Windows.Forms.Label();
            this.lFeedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(719, 446);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(107, 44);
            this.bCancelar.TabIndex = 17;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bEnviar
            // 
            this.bEnviar.Location = new System.Drawing.Point(352, 446);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(107, 44);
            this.bEnviar.TabIndex = 16;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // lValoracion
            // 
            this.lValoracion.AutoSize = true;
            this.lValoracion.Location = new System.Drawing.Point(355, 298);
            this.lValoracion.Name = "lValoracion";
            this.lValoracion.Size = new System.Drawing.Size(60, 13);
            this.lValoracion.TabIndex = 15;
            this.lValoracion.Text = "Valoración:";
            // 
            // lbValoracion
            // 
            this.lbValoracion.FormattingEnabled = true;
            this.lbValoracion.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lbValoracion.Location = new System.Drawing.Point(559, 262);
            this.lbValoracion.Name = "lbValoracion";
            this.lbValoracion.Size = new System.Drawing.Size(61, 95);
            this.lbValoracion.TabIndex = 14;
            // 
            // tbOpinion
            // 
            this.tbOpinion.Location = new System.Drawing.Point(483, 185);
            this.tbOpinion.Name = "tbOpinion";
            this.tbOpinion.Size = new System.Drawing.Size(363, 20);
            this.tbOpinion.TabIndex = 12;
            // 
            // lOpinion
            // 
            this.lOpinion.AutoSize = true;
            this.lOpinion.Location = new System.Drawing.Point(356, 187);
            this.lOpinion.Name = "lOpinion";
            this.lOpinion.Size = new System.Drawing.Size(46, 13);
            this.lOpinion.TabIndex = 10;
            this.lOpinion.Text = "Opinión:";
            // 
            // lFeedback
            // 
            this.lFeedback.AutoSize = true;
            this.lFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lFeedback.Location = new System.Drawing.Point(536, 77);
            this.lFeedback.Name = "lFeedback";
            this.lFeedback.Size = new System.Drawing.Size(99, 25);
            this.lFeedback.TabIndex = 9;
            this.lFeedback.Text = "Feedback";
            // 
            // FeedbackEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 625);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.lValoracion);
            this.Controls.Add(this.lbValoracion);
            this.Controls.Add(this.tbOpinion);
            this.Controls.Add(this.lOpinion);
            this.Controls.Add(this.lFeedback);
            this.Name = "FeedbackEntrenador";
            this.Text = "FeedbackEntrenador";
            this.Load += new System.EventHandler(this.FeedbackEntrenador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.Label lValoracion;
        private System.Windows.Forms.ListBox lbValoracion;
        private System.Windows.Forms.TextBox tbOpinion;
        private System.Windows.Forms.Label lOpinion;
        private System.Windows.Forms.Label lFeedback;
    }
}