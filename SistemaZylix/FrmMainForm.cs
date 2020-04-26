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
    }
}
