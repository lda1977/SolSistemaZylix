namespace SistemaZylix
{
    partial class FrmMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.msOpenForms = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpenAccuMateFrom = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpenSep01 = new System.Windows.Forms.ToolStripSeparator();
            this.msOpenReportForm = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpenTransForm = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpenSep02 = new System.Windows.Forms.ToolStripSeparator();
            this.msOpenEqForm = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpenDriverForm = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpenSep03 = new System.Windows.Forms.ToolStripSeparator();
            this.msOpenCloseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton5 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton6 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton7 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton8 = new System.Windows.Forms.ToolStripSplitButton();
            this.Close = new System.Windows.Forms.ToolStripSplitButton();
            this.pnlBaseForm = new System.Windows.Forms.Panel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.msMainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlBaseForm.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.msMainMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 25);
            this.panel1.TabIndex = 0;
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msOpenForms});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(776, 24);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // msOpenForms
            // 
            this.msOpenForms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msOpenAccuMateFrom,
            this.msOpenSep01,
            this.msOpenReportForm,
            this.msOpenTransForm,
            this.msOpenSep02,
            this.msOpenEqForm,
            this.msOpenDriverForm,
            this.msOpenSep03,
            this.msOpenCloseForm});
            this.msOpenForms.Name = "msOpenForms";
            this.msOpenForms.Size = new System.Drawing.Size(50, 20);
            this.msOpenForms.Text = "Menu";
            // 
            // msOpenAccuMateFrom
            // 
            this.msOpenAccuMateFrom.Image = ((System.Drawing.Image)(resources.GetObject("msOpenAccuMateFrom.Image")));
            this.msOpenAccuMateFrom.Name = "msOpenAccuMateFrom";
            this.msOpenAccuMateFrom.Size = new System.Drawing.Size(188, 22);
            this.msOpenAccuMateFrom.Text = "AccuMate Config File";
            this.msOpenAccuMateFrom.ToolTipText = "Launches a news Documents";
            this.msOpenAccuMateFrom.Click += new System.EventHandler(this.msOpenAccuMateFrom_Click);
            // 
            // msOpenSep01
            // 
            this.msOpenSep01.Name = "msOpenSep01";
            this.msOpenSep01.Size = new System.Drawing.Size(185, 6);
            // 
            // msOpenReportForm
            // 
            this.msOpenReportForm.Image = ((System.Drawing.Image)(resources.GetObject("msOpenReportForm.Image")));
            this.msOpenReportForm.Name = "msOpenReportForm";
            this.msOpenReportForm.Size = new System.Drawing.Size(188, 22);
            this.msOpenReportForm.Text = "Report Configuration";
            this.msOpenReportForm.ToolTipText = "Launch configurable report editor to create custom reports";
            this.msOpenReportForm.Click += new System.EventHandler(this.msOpenReportForm_Click);
            // 
            // msOpenTransForm
            // 
            this.msOpenTransForm.Image = ((System.Drawing.Image)(resources.GetObject("msOpenTransForm.Image")));
            this.msOpenTransForm.Name = "msOpenTransForm";
            this.msOpenTransForm.Size = new System.Drawing.Size(188, 22);
            this.msOpenTransForm.Text = "Translation";
            this.msOpenTransForm.ToolTipText = "Launch tool to aid in creating language translations";
            this.msOpenTransForm.Click += new System.EventHandler(this.msOpenTransForm_Click);
            // 
            // msOpenSep02
            // 
            this.msOpenSep02.Name = "msOpenSep02";
            this.msOpenSep02.Size = new System.Drawing.Size(185, 6);
            // 
            // msOpenEqForm
            // 
            this.msOpenEqForm.Image = ((System.Drawing.Image)(resources.GetObject("msOpenEqForm.Image")));
            this.msOpenEqForm.Name = "msOpenEqForm";
            this.msOpenEqForm.Size = new System.Drawing.Size(188, 22);
            this.msOpenEqForm.Text = "Equation Set";
            this.msOpenEqForm.Click += new System.EventHandler(this.msOpenEqForm_Click);
            // 
            // msOpenDriverForm
            // 
            this.msOpenDriverForm.Image = ((System.Drawing.Image)(resources.GetObject("msOpenDriverForm.Image")));
            this.msOpenDriverForm.Name = "msOpenDriverForm";
            this.msOpenDriverForm.Size = new System.Drawing.Size(188, 22);
            this.msOpenDriverForm.Text = "Driver Database";
            this.msOpenDriverForm.ToolTipText = "Open the Database editor to allow entry of a list of driver IDs for user with ID " +
    "card validation";
            this.msOpenDriverForm.Click += new System.EventHandler(this.msOpenDriverForm_Click);
            // 
            // msOpenSep03
            // 
            this.msOpenSep03.Name = "msOpenSep03";
            this.msOpenSep03.Size = new System.Drawing.Size(185, 6);
            // 
            // msOpenCloseForm
            // 
            this.msOpenCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("msOpenCloseForm.Image")));
            this.msOpenCloseForm.Name = "msOpenCloseForm";
            this.msOpenCloseForm.Size = new System.Drawing.Size(188, 22);
            this.msOpenCloseForm.Text = "Exit";
            this.msOpenCloseForm.ToolTipText = "Fechar - Exit- Close";
            this.msOpenCloseForm.Click += new System.EventHandler(this.msOpenCloseForm_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(65, 65);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3,
            this.toolStripSplitButton4,
            this.toolStripSplitButton5,
            this.toolStripSplitButton6,
            this.toolStripSplitButton7,
            this.toolStripSplitButton8,
            this.Close});
            this.statusStrip1.Location = new System.Drawing.Point(0, 25);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(776, 71);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(81, 69);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ToolTipText = "Abrir arquivos - Open Files";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(81, 69);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            this.toolStripSplitButton2.ToolTipText = "Copiar - Copy";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(81, 69);
            this.toolStripSplitButton3.Text = "toolStripSplitButton3";
            this.toolStripSplitButton3.ToolTipText = "Colar - Cut";
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(81, 69);
            this.toolStripSplitButton4.Text = "toolStripSplitButton4";
            this.toolStripSplitButton4.ToolTipText = "Documents";
            // 
            // toolStripSplitButton5
            // 
            this.toolStripSplitButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton5.Image")));
            this.toolStripSplitButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton5.Name = "toolStripSplitButton5";
            this.toolStripSplitButton5.Size = new System.Drawing.Size(81, 69);
            this.toolStripSplitButton5.Text = "toolStripSplitButton5";
            this.toolStripSplitButton5.ToolTipText = "Configure Document Options for AccuMate";
            // 
            // toolStripSplitButton6
            // 
            this.toolStripSplitButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton6.Image")));
            this.toolStripSplitButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton6.Name = "toolStripSplitButton6";
            this.toolStripSplitButton6.Size = new System.Drawing.Size(81, 69);
            this.toolStripSplitButton6.Text = "toolStripSplitButton6";
            this.toolStripSplitButton6.ToolTipText = "Gerar Relatório";
            // 
            // toolStripSplitButton7
            // 
            this.toolStripSplitButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton7.Image")));
            this.toolStripSplitButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton7.Name = "toolStripSplitButton7";
            this.toolStripSplitButton7.Size = new System.Drawing.Size(81, 69);
            this.toolStripSplitButton7.Text = "toolStripSplitButton7";
            this.toolStripSplitButton7.ToolTipText = "Retry communications with AccuLoad";
            // 
            // toolStripSplitButton8
            // 
            this.toolStripSplitButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton8.Image")));
            this.toolStripSplitButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton8.Name = "toolStripSplitButton8";
            this.toolStripSplitButton8.Size = new System.Drawing.Size(81, 69);
            this.toolStripSplitButton8.Text = "toolStripSplitButton8";
            this.toolStripSplitButton8.ToolTipText = "Pull non-reseltable totalizer values";
            // 
            // Close
            // 
            this.Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(81, 69);
            this.Close.Text = "Fechar - Close - Exit";
            this.Close.ButtonClick += new System.EventHandler(this.Close_ButtonClick);
            // 
            // pnlBaseForm
            // 
            this.pnlBaseForm.BackColor = System.Drawing.Color.Silver;
            this.pnlBaseForm.Controls.Add(this.statusStrip2);
            this.pnlBaseForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBaseForm.Location = new System.Drawing.Point(0, 96);
            this.pnlBaseForm.Name = "pnlBaseForm";
            this.pnlBaseForm.Size = new System.Drawing.Size(776, 357);
            this.pnlBaseForm.TabIndex = 2;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip2.Location = new System.Drawing.Point(0, 335);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(410, 22);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(157, 17);
            this.toolStripStatusLabel1.Text = "Bem vindo ao Systema Zyliz ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 453);
            this.Controls.Add(this.pnlBaseForm);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "FrmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlBaseForm.ResumeLayout(false);
            this.pnlBaseForm.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem msOpenForms;
        private System.Windows.Forms.ToolStripMenuItem msOpenAccuMateFrom;
        private System.Windows.Forms.ToolStripSeparator msOpenSep01;
        private System.Windows.Forms.ToolStripMenuItem msOpenReportForm;
        private System.Windows.Forms.ToolStripMenuItem msOpenTransForm;
        private System.Windows.Forms.ToolStripSeparator msOpenSep02;
        private System.Windows.Forms.ToolStripMenuItem msOpenEqForm;
        private System.Windows.Forms.ToolStripMenuItem msOpenDriverForm;
        private System.Windows.Forms.ToolStripSeparator msOpenSep03;
        private System.Windows.Forms.ToolStripMenuItem msOpenCloseForm;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton5;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton6;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton7;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton8;
        private System.Windows.Forms.ToolStripSplitButton Close;
        private System.Windows.Forms.Panel pnlBaseForm;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
    }
}