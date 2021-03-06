﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaZylix
{
    public partial class FrmMainForm : Form
    {
        /* Variavel que vai */
        private Form _objForm;
        public FrmMainForm()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void msOpenCloseForm_Click(object sender, EventArgs e)
        {
            /* Metodo para fechar o formulario */
            Close();
        }

        private void Close_ButtonClick(object sender, EventArgs e)
        {
            /* Metodo para fechar o formulario */
            Close();
        }

        private void msOpenAccuMateFrom_Click(object sender, EventArgs e)
        {
            _objForm?.Close();

            _objForm = new FrmAccuMateForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            }; /* Obrigatorio um ponto e virgula caso contrario ERRO */

            pnlBaseForm.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void msOpenReportForm_Click(object sender, EventArgs e)
        {
            _objForm?.Close();

            _objForm = new FrmRepotForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            }; /* Obrigatorio um ponto e virgula caso contrario ERRO */

            pnlBaseForm.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void msOpenTransForm_Click(object sender, EventArgs e)
        {
            _objForm?.Close();

            _objForm = new FrmTransForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            }; /* Obrigatorio um ponto e virgula caso contrario ERRO */

            pnlBaseForm.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void msOpenEqForm_Click(object sender, EventArgs e)
        {
            _objForm?.Close();

            _objForm = new FrmEqForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            }; /* Obrigatorio um ponto e virgula caso contrario ERRO */

            pnlBaseForm.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void msOpenDriverForm_Click(object sender, EventArgs e)
        {
            _objForm?.Close();

            _objForm = new FrmDriverForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            }; /* Obrigatorio um ponto e virgula caso contrario ERRO */

            pnlBaseForm.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /* Configurando hora e data pelo sistema para aparecer na barra de status */
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            /* Listas de String e int */
            List<int>    _objid = new List<int>();
            List<int>    _objDe = new List<int>();
            List<string> _objVa = new List<string>();
            List<string> _objCo = new List<string>();
            /* Estrutura responsavel pela abertura de estruturas */
            /* Leitura de um arquivo Txt usando using */
            using (StreamReader reader = new StreamReader(@"C:\SistemaZylix\SolSistemaZylix\dados.txt"))
            { 
            }
        }
    }
}
