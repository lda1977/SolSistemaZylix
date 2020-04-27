namespace SistemaZylix
{
    partial class FrmArquivo
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
            this.SArq = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SArq
            // 
            this.SArq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SArq.Location = new System.Drawing.Point(12, 12);
            this.SArq.Name = "SArq";
            this.SArq.Size = new System.Drawing.Size(258, 208);
            this.SArq.TabIndex = 0;
            this.SArq.Text = "";
            // 
            // FrmArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 232);
            this.Controls.Add(this.SArq);
            this.Name = "FrmArquivo";
            this.Text = "Saida do Arquivo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox SArq;
    }
}