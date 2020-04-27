namespace SistemaZylix
{
    partial class FrmAccuMateForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("000 - System Layout");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Pulse In 01");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("100 - Pulse Inputs", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Config Directory", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Security Directory");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("100 - General Purpose");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("200 - Flow Control");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("300 - Volume Accuracy");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("400 - Temperature/Density");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("System Diretory", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("100 - General Purpose");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("200 - Flow Control");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("300 - Volume Accuracy");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("700 - Communications");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Arm 1", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Arm 2");
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pnlBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.pnlBottom.Controls.Add(this.btnCloseForm);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 418);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 32);
            this.pnlBottom.TabIndex = 0;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseForm.Location = new System.Drawing.Point(713, 6);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(75, 23);
            this.btnCloseForm.TabIndex = 0;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 418);
            this.panel1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nó-000";
            treeNode1.Text = "000 - System Layout";
            treeNode2.Name = "Nó-Pulse-01";
            treeNode2.Text = "Pulse In 01";
            treeNode3.Name = "Nó-100";
            treeNode3.Text = "100 - Pulse Inputs";
            treeNode4.Name = "Raiz1";
            treeNode4.Text = "Config Directory";
            treeNode5.Name = "Nó-Security-Directory";
            treeNode5.Text = "Security Directory";
            treeNode6.Name = "Nó-100";
            treeNode6.Text = "100 - General Purpose";
            treeNode7.Name = "Nó-200";
            treeNode7.Text = "200 - Flow Control";
            treeNode8.Name = "Nó-300";
            treeNode8.Text = "300 - Volume Accuracy";
            treeNode9.Name = "Nó-400";
            treeNode9.Text = "400 - Temperature/Density";
            treeNode10.Name = "Raiz2";
            treeNode10.Text = "System Diretory";
            treeNode11.Name = "Nó-100";
            treeNode11.Text = "100 - General Purpose";
            treeNode12.Name = "Nó-200";
            treeNode12.Text = "200 - Flow Control";
            treeNode13.Name = "Nó-300";
            treeNode13.Text = "300 - Volume Accuracy";
            treeNode14.Name = "Nó-700";
            treeNode14.Text = "700 - Communications";
            treeNode15.Name = "Raiz3";
            treeNode15.Text = "Arm 1";
            treeNode16.Name = "Raiz4";
            treeNode16.Text = "Arm 2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode10,
            treeNode15,
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(305, 409);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(314, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(483, 409);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // FrmAccuMateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBottom);
            this.Name = "FrmAccuMateForm";
            this.Text = "FrmAccuMateForm";
            this.pnlBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TreeView treeView1;
    }
}