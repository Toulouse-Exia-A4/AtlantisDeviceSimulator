namespace AtlantisDeviceSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.GatewayText = new System.Windows.Forms.TextBox();
            this.TemperatureText = new System.Windows.Forms.TextBox();
            this.LedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GatewayText
            // 
            this.GatewayText.Location = new System.Drawing.Point(261, 36);
            this.GatewayText.Multiline = true;
            this.GatewayText.Name = "GatewayText";
            this.GatewayText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.GatewayText.Size = new System.Drawing.Size(990, 126);
            this.GatewayText.TabIndex = 0;
            this.GatewayText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TemperatureText
            // 
            this.TemperatureText.Location = new System.Drawing.Point(261, 187);
            this.TemperatureText.Multiline = true;
            this.TemperatureText.Name = "TemperatureText";
            this.TemperatureText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TemperatureText.Size = new System.Drawing.Size(990, 126);
            this.TemperatureText.TabIndex = 1;
            // 
            // LedText
            // 
            this.LedText.Location = new System.Drawing.Point(261, 346);
            this.LedText.Multiline = true;
            this.LedText.Name = "LedText";
            this.LedText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LedText.Size = new System.Drawing.Size(990, 126);
            this.LedText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gateway Log";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperature Device Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LedText);
            this.Controls.Add(this.TemperatureText);
            this.Controls.Add(this.GatewayText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GatewayText;
        private System.Windows.Forms.TextBox TemperatureText;
        private System.Windows.Forms.TextBox LedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

