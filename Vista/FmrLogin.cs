using System.Runtime.InteropServices;
using Vista;

namespace Login
{
    public partial class FmrLogin : Form
    {
        #region Redondeo de formulario
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,          //x-coordinate of upper-left corner
            int nTopRect,           //y-coordinate of upper-left corner
            int nRightRect,         //x-coordinate of lower-right corner
            int nBottomRect,        //y-coordinate of lower-right corner
            int nWidhtEllipse,      //heigth of ellipse
            int nHeightEllipse      //widht of ellipse
        );
        #endregion

        public FmrLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmdAcceder_Click(object sender, EventArgs e)
        {
            //if(TxtUsuario.Text != string.Empty && TxtPass.Text != string.Empty)
            //{
                UserModel user = new UserModel();
                //var validLogin=user.LoginUser(TxtUsuario.Text, TxtPass.Text);
                var validLogin = true;
                if (validLogin)
                {
                    FmrPrincipal principal = new FmrPrincipal();
                    principal.Show();
                    this.Hide();
                }
                else 
                {
                    msgError("Usuario y/o contraseña incorrecta, porfavor vuelve a intentarlo.");
                    TxtUsuario.Text = string.Empty;
                    TxtPass.Text = string.Empty;
                    TxtUsuario.Focus();
                }
            //}
            //else
            //{
            //    msgError("Ingrese todos los datos requeridos; Usuario y Contraseña.");
            //}
        }

        private void msgError(string msg)
        {
            LblError.Text = msg;
            LblError.Visible = true;
        }

        //PLACEHOLDER
        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = string.Empty;
                TxtUsuario.ForeColor = Color.LightGray;
            }
        }
    }
}
