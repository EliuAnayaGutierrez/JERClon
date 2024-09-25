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
    public partial class FmrCargo : Form
    {
        public FmrCargo()
        {
            InitializeComponent();
        }
        private void CerrarFormulario()
        {
            this.Close();
        }

        private void CmdCerrar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }
    }
}
