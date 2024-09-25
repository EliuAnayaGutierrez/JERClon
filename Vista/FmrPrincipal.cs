using Comun;
using Vista.Controls;
using System.Runtime.InteropServices;

namespace Vista
{
    public partial class FmrPrincipal : System.Windows.Forms.Form
    {
        public FmrPrincipal()
        {
            InitializeComponent();
        }

        #region ABRIR FORMULARIOS
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;

            formulario = PnlCentral.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PnlCentral.Controls.Add(formulario);
                PnlCentral.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }

        //Para abrir a formularios

        //FORMULARIOS
        //Grado Ministerial
        private void LoadGradoMinisterial(object sender, EventArgs e)
        {
            AbrirFormulario<FmrGradoMinisterial>();
        }
        //Grado de Intruccion
        private void gradoDeInstrucciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FmrGradoInstruccion>();
        }
        //Iglesia
        private void iglesiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FmrIglesia>();
        }
        //Sector
        private void sectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FmrSector>();
        }
        //Pais
        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FmrPais>();
        }
        //Region
        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FmrRegion>();
        }
        //Provincia
        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FmrProvincia>();
        }
        //Distrito
        private void distritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FmrDistrito>();
        }
        //Estado Civil
        private void estadoCivilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FmrEstadoCivil>();
        }
        //Cargo
        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FmrCargo>();
        }
        //Para cerrar formularios
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FmrIglesia"] == null)
                CmdBaseDatos.BackColor = Color.FromArgb(53, 64, 107);
            if (Application.OpenForms["FmrSector"] == null)
                CmdBaseDatos.BackColor = Color.FromArgb(53, 64, 107);
            if (Application.OpenForms["FmrPais"] == null)
                CmdBaseDatos.BackColor = Color.FromArgb(53, 64, 107);
            if (Application.OpenForms["FmrRegion"] == null)
                CmdBaseDatos.BackColor = Color.FromArgb(53, 64, 107);
            if (Application.OpenForms["FmrProvincia"] == null)
                CmdBaseDatos.BackColor = Color.FromArgb(53, 64, 107);
            if (Application.OpenForms["Distrito"] == null)
                CmdBaseDatos.BackColor = Color.FromArgb(53, 64, 107);
            if (Application.OpenForms["FmrGradoInstruccion"] == null)
                CmdBaseDatos.BackColor = Color.FromArgb(53, 64, 107);
            if (Application.OpenForms["FmrGradoMinisterial"] == null)
                CmdBaseDatos.BackColor = Color.FromArgb(53, 64, 107);
            if (Application.OpenForms["FmrEstadoCivil"] == null)
                CmdBaseDatos.BackColor = Color.FromArgb(53, 64, 107);
            if (Application.OpenForms["FmrEstadoCivil"] == null)
                CmdBaseDatos.BackColor = Color.FromArgb(53, 64, 107);
            if (Application.OpenForms["FmrCargo"] == null)
                CmdBaseDatos.BackColor = Color.FromArgb(53, 64, 107);
            if (Application.OpenForms["FmrMinistro"] == null)
                CmdBaseDatos.BackColor = Color.FromArgb(53, 64, 107);
            //if (Application.OpenForms["FmrMinistro"] == null)
            //    CmdBaseDatos.BackColor = Color.FromArgb(53, 64, 107);

        }

        #endregion

        private void CmdMayordomias_Click(object sender, EventArgs e)
        {
            DmMayordomias.Show(CmdMayordomias, CmdMayordomias.Width, 0);
            CmdMayordomias.BackColor = Color.FromArgb(142, 187, 229);
        }

        private void CmdMinistros_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FmrMinistro>();
            //DmMinistros.Show(CmdMinistros, CmdMinistros.Width, 0);
            CmdMinistros.BackColor = Color.FromArgb(142, 187, 229);
        }

        private void CmdBaseDatos_Click(object sender, EventArgs e)
        {
            DmBaseDatos.Show(CmdBaseDatos, CmdBaseDatos.Width, 0);
            CmdBaseDatos.BackColor = Color.FromArgb(142, 187, 229);
        }

        private void FmrPrincipal_Load(object sender, EventArgs e)
        {
            DmBaseDatos.PrimaryColor = Color.OrangeRed;
            DmMayordomias.PrimaryColor = Color.OrangeRed;
            DmMinistros.PrimaryColor = Color.OrangeRed;
        }

        
    }
}
