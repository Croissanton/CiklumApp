namespace CiklumApp
{
    partial class FeedbackSesion
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
            this.lFeedback = new System.Windows.Forms.Label();
            this.lOpinion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOpinion = new System.Windows.Forms.TextBox();
            this.tbVideo = new System.Windows.Forms.TextBox();
            this.lbValoracion = new System.Windows.Forms.ListBox();
            this.lValoracion = new System.Windows.Forms.Label();
            this.bEnviar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lFeedback
            // 
            this.lFeedback.AutoSize = true;
            this.lFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lFeedback.Location = new System.Drawing.Point(541, 85);
            this.lFeedback.Name = "lFeedback";
            this.lFeedback.Size = new System.Drawing.Size(99, 25);
            this.lFeedback.TabIndex = 0;
            this.lFeedback.Text = "Feedback";
            // 
            // lOpinion
            // 
            this.lOpinion.AutoSize = true;
            this.lOpinion.Location = new System.Drawing.Point(361, 195);
            this.lOpinion.Name = "lOpinion";
            this.lOpinion.Size = new System.Drawing.Size(46, 13);
            this.lOpinion.TabIndex = 1;
            this.lOpinion.Text = "Opinión:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vídeo (opcional):";
            // 
            // tbOpinion
            // 
            this.tbOpinion.Location = new System.Drawing.Point(488, 193);
            this.tbOpinion.Name = "tbOpinion";
            this.tbOpinion.Size = new System.Drawing.Size(363, 20);
            this.tbOpinion.TabIndex = 3;
            // 
            // tbVideo
            // 
            this.tbVideo.Location = new System.Drawing.Point(488, 224);
            this.tbVideo.Name = "tbVideo";
            this.tbVideo.Size = new System.Drawing.Size(363, 20);
            this.tbVideo.TabIndex = 4;
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
            this.lbValoracion.Location = new System.Drawing.Point(558, 272);
            this.lbValoracion.Name = "lbValoracion";
            this.lbValoracion.Size = new System.Drawing.Size(61, 95);
            this.lbValoracion.TabIndex = 5;
            // 
            // lValoracion
            // 
            this.lValoracion.AutoSize = true;
            this.lValoracion.Location = new System.Drawing.Point(354, 308);
            this.lValoracion.Name = "lValoracion";
            this.lValoracion.Size = new System.Drawing.Size(60, 13);
            this.lValoracion.TabIndex = 6;
            this.lValoracion.Text = "Valoración:";
            // 
            // bEnviar
            // 
            this.bEnviar.Location = new System.Drawing.Point(357, 454);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(107, 44);
            this.bEnviar.TabIndex = 7;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(724, 454);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(107, 44);
            this.bCancelar.TabIndex = 8;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // FeedbackSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 546);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.lValoracion);
            this.Controls.Add(this.lbValoracion);
            this.Controls.Add(this.tbVideo);
            this.Controls.Add(this.tbOpinion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lOpinion);
            this.Controls.Add(this.lFeedback);
            this.Name = "FeedbackSesion";
            this.Text = "FeedbackSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lFeedback;
        private System.Windows.Forms.Label lOpinion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOpinion;
        private System.Windows.Forms.TextBox tbVideo;
        private System.Windows.Forms.ListBox lbValoracion;
        private System.Windows.Forms.Label lValoracion;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.Button bCancelar;
    }
}