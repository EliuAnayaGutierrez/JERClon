using Vista.Controls;

namespace Login
{
    partial class FmrLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrLogin));
            panel1 = new Panel();
            LblError = new Label();
            CmdAcceder = new ButtonCircular();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblUsuario = new Label();
            TxtPass = new TextBox();
            TxtUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 64, 107);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(LblError);
            panel1.Controls.Add(CmdAcceder);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(TxtPass);
            panel1.Controls.Add(TxtUsuario);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 692);
            panel1.TabIndex = 0;
            // 
            // LblError
            // 
            LblError.AutoSize = true;
            LblError.Font = new Font("Open Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblError.ForeColor = Color.Red;
            LblError.Location = new Point(70, 573);
            LblError.Margin = new Padding(4, 0, 4, 0);
            LblError.Name = "LblError";
            LblError.Size = new Size(69, 15);
            LblError.TabIndex = 8;
            LblError.Text = "Contraseña:";
            LblError.Visible = false;
            // 
            // CmdAcceder
            // 
            CmdAcceder.BackColor = Color.FromArgb(255, 136, 58);
            CmdAcceder.FlatAppearance.BorderSize = 0;
            CmdAcceder.FlatStyle = FlatStyle.Flat;
            CmdAcceder.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CmdAcceder.ForeColor = Color.White;
            CmdAcceder.Location = new Point(162, 623);
            CmdAcceder.Name = "CmdAcceder";
            CmdAcceder.Size = new Size(150, 40);
            CmdAcceder.TabIndex = 3;
            CmdAcceder.Text = "Acceder";
            CmdAcceder.UseVisualStyleBackColor = false;
            CmdAcceder.Click += CmdAcceder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(155, 316);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(169, 31);
            label3.TabIndex = 6;
            label3.Text = "AYACUCHO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(188, 260);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 50);
            label2.TabIndex = 5;
            label2.Text = "JER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 485);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 4;
            label1.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Open Sans", 12F);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(70, 417);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(74, 23);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario:";
            // 
            // TxtPass
            // 
            TxtPass.BackColor = Color.FromArgb(89, 101, 133);
            TxtPass.BorderStyle = BorderStyle.FixedSingle;
            TxtPass.Font = new Font("Open Sans", 8.25F);
            TxtPass.ForeColor = Color.White;
            TxtPass.Location = new Point(70, 519);
            TxtPass.Margin = new Padding(4, 3, 4, 3);
            TxtPass.Name = "TxtPass";
            TxtPass.PasswordChar = '*';
            TxtPass.Size = new Size(326, 22);
            TxtPass.TabIndex = 2;
            // 
            // TxtUsuario
            // 
            TxtUsuario.BackColor = Color.FromArgb(89, 101, 133);
            TxtUsuario.BorderStyle = BorderStyle.FixedSingle;
            TxtUsuario.Font = new Font("Open Sans", 8.25F);
            TxtUsuario.ForeColor = Color.White;
            TxtUsuario.Location = new Point(70, 449);
            TxtUsuario.Margin = new Padding(4, 3, 4, 3);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(326, 22);
            TxtUsuario.TabIndex = 1;
            TxtUsuario.Leave += TxtUsuario_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 58);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FmrLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 692);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FmrLogin";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ButtonCircular btnAcceder;
        private ButtonCircular btnClose;
        private ButtonCircular CmdAcceder;
        private TextBox TxtUsuario;
        private Label LblError;
    }
}

