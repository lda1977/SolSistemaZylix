using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
