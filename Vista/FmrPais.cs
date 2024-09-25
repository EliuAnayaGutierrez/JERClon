using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FmrPais : Form
    {
        public FmrPais()
        {
            InitializeComponent();
        }
        private void CerraFormulario()
        {
            this.Close();
        }
        private void CmdCerrar_Click(object sender, EventArgs e)
        {
            CerraFormulario();
        }
    }
}
