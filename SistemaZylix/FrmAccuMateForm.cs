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
    public partial class FrmAccuMateForm : Form
    {
        public FrmAccuMateForm()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            /* Fechando o form AccuMate */
            Close();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            /* Trabalhando com árvore(raiz) e suas folhas(nós) */
            /* para imprimir no lado direito (RichTextBox1) */
            if (e.Node.Name == "Raiz1")
            {
                richTextBox1.Text = "ID";
            }
            else 
            {
                if (e.Node.Name == "Nó-000") {
                    richTextBox1.Text = "ID = 001";
                }
            }/* Fim do primeiro if */
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
