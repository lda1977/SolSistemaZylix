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
    public partial class FrmSphash : Form
    {
        public FrmSphash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /* si o progressBar1 no ponto valuer for menor que 100 */
            if (progressBar1.Value < 100)
            {
                /* progressBar1 no ponto valuer vai se incrementado de 2 ate chegar a 100 */
                progressBar1.Value = progressBar1.Value + 2;
            }
            else 
            {
                /* A hora que estiver cheio o progressBar1 então chama a application FrmMainForm */
                timer1.Enabled = false;
                FrmMainForm _objtfrm = new FrmMainForm();
                _objtfrm.Show();
                this.Visible = false;
            } /* Fim if */
        }
    }
}
