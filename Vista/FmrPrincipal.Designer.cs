namespace Vista
{
    partial class FmrPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrPrincipal));
            panel1 = new Panel();
            panel2 = new Panel();
            CmdLogout = new Button();
            label3 = new Label();
            label2 = new Label();
            CmdBaseDatos = new Button();
            CmdMinistros = new Button();
            CmdMayordomias = new Button();
            panel3 = new Panel();
            PnlCentral = new Panel();
            DmBaseDatos = new Controls.DropdwonMenu(components);
            iglesiaToolStripMenuItem = new ToolStripMenuItem();
            sectorToolStripMenuItem = new ToolStripMenuItem();
            gradoMinisterialToolStripMenuItem = new ToolStripMenuItem();
            gradoDeInstrucciónToolStripMenuItem = new ToolStripMenuItem();
            paisToolStripMenuItem = new ToolStripMenuItem();
            regionToolStripMenuItem = new ToolStripMenuItem();
            provinciaToolStripMenuItem = new ToolStripMenuItem();
            distritoToolStripMenuItem = new ToolStripMenuItem();
            estadoCivilToolStripMenuItem = new ToolStripMenuItem();
            cargoToolStripMenuItem = new ToolStripMenuItem();
            DmMayordomias = new Controls.DropdwonMenu(components);
            DmMinistros = new Controls.DropdwonMenu(components);
            ministrosToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            DmBaseDatos.SuspendLayout();
            DmMinistros.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 64, 107);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1584, 34);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(53, 64, 107);
            panel2.Controls.Add(CmdLogout);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CmdBaseDatos);
            panel2.Controls.Add(CmdMinistros);
            panel2.Controls.Add(CmdMayordomias);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 727);
            panel2.TabIndex = 1;
            // 
            // CmdLogout
            // 
            CmdLogout.Dock = DockStyle.Bottom;
            CmdLogout.FlatAppearance.BorderColor = Color.White;
            CmdLogout.FlatStyle = FlatStyle.Flat;
            CmdLogout.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            CmdLogout.ForeColor = Color.White;
            CmdLogout.Location = new Point(0, 684);
            CmdLogout.Name = "CmdLogout";
            CmdLogout.Size = new Size(206, 43);
            CmdLogout.TabIndex = 6;
            CmdLogout.Text = "Cerrar sesión";
            CmdLogout.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(4, 636);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(198, 15);
            label3.TabIndex = 5;
            label3.Text = "Junta Ejecutiva Regional - Ayacucho";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 618);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 15);
            label2.TabIndex = 4;
            label2.Text = "Asambleas de Dios del Perú";
            // 
            // CmdBaseDatos
            // 
            CmdBaseDatos.Cursor = Cursors.Hand;
            CmdBaseDatos.Dock = DockStyle.Top;
            CmdBaseDatos.FlatAppearance.BorderColor = Color.White;
            CmdBaseDatos.FlatStyle = FlatStyle.Flat;
            CmdBaseDatos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            CmdBaseDatos.ForeColor = Color.White;
            CmdBaseDatos.Location = new Point(0, 273);
            CmdBaseDatos.Name = "CmdBaseDatos";
            CmdBaseDatos.Size = new Size(206, 43);
            CmdBaseDatos.TabIndex = 4;
            CmdBaseDatos.Text = "Base de datos";
            CmdBaseDatos.UseVisualStyleBackColor = true;
            CmdBaseDatos.Click += CmdBaseDatos_Click;
            // 
            // CmdMinistros
            // 
            CmdMinistros.Cursor = Cursors.Hand;
            CmdMinistros.Dock = DockStyle.Top;
            CmdMinistros.FlatAppearance.BorderColor = Color.White;
            CmdMinistros.FlatStyle = FlatStyle.Flat;
            CmdMinistros.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            CmdMinistros.ForeColor = Color.White;
            CmdMinistros.Location = new Point(0, 230);
            CmdMinistros.Name = "CmdMinistros";
            CmdMinistros.Size = new Size(206, 43);
            CmdMinistros.TabIndex = 3;
            CmdMinistros.Text = "Ministros";
            CmdMinistros.UseVisualStyleBackColor = true;
            CmdMinistros.Click += CmdMinistros_Click;
            // 
            // CmdMayordomias
            // 
            CmdMayordomias.Cursor = Cursors.Hand;
            CmdMayordomias.Dock = DockStyle.Top;
            CmdMayordomias.FlatAppearance.BorderColor = Color.White;
            CmdMayordomias.FlatStyle = FlatStyle.Flat;
            CmdMayordomias.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            CmdMayordomias.ForeColor = Color.White;
            CmdMayordomias.Location = new Point(0, 187);
            CmdMayordomias.Name = "CmdMayordomias";
            CmdMayordomias.Size = new Size(206, 43);
            CmdMayordomias.TabIndex = 2;
            CmdMayordomias.Text = "Mayordomias";
            CmdMayordomias.UseVisualStyleBackColor = true;
            CmdMayordomias.Click += CmdMayordomias_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(53, 64, 107);
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 187);
            panel3.TabIndex = 2;
            // 
            // PnlCentral
            // 
            PnlCentral.BackgroundImage = (Image)resources.GetObject("PnlCentral.BackgroundImage");
            PnlCentral.BackgroundImageLayout = ImageLayout.Zoom;
            PnlCentral.Dock = DockStyle.Fill;
            PnlCentral.Location = new Point(206, 34);
            PnlCentral.Name = "PnlCentral";
            PnlCentral.Size = new Size(1378, 727);
            PnlCentral.TabIndex = 2;
            // 
            // DmBaseDatos
            // 
            DmBaseDatos.IsMainMenu = false;
            DmBaseDatos.Items.AddRange(new ToolStripItem[] { iglesiaToolStripMenuItem, sectorToolStripMenuItem, gradoMinisterialToolStripMenuItem, gradoDeInstrucciónToolStripMenuItem, paisToolStripMenuItem, regionToolStripMenuItem, provinciaToolStripMenuItem, distritoToolStripMenuItem, estadoCivilToolStripMenuItem, cargoToolStripMenuItem });
            DmBaseDatos.MenuItemHieght = 25;
            DmBaseDatos.MenuItemTextColor = Color.DimGray;
            DmBaseDatos.Name = "DmBaseDatos";
            DmBaseDatos.PrimaryColor = Color.MediumSlateBlue;
            DmBaseDatos.Size = new Size(185, 224);
            // 
            // iglesiaToolStripMenuItem
            // 
            iglesiaToolStripMenuItem.Name = "iglesiaToolStripMenuItem";
            iglesiaToolStripMenuItem.Size = new Size(184, 22);
            iglesiaToolStripMenuItem.Text = "Iglesia";
            iglesiaToolStripMenuItem.Click += iglesiaToolStripMenuItem_Click;
            // 
            // sectorToolStripMenuItem
            // 
            sectorToolStripMenuItem.Name = "sectorToolStripMenuItem";
            sectorToolStripMenuItem.Size = new Size(184, 22);
            sectorToolStripMenuItem.Text = "Sector";
            sectorToolStripMenuItem.Click += sectorToolStripMenuItem_Click;
            // 
            // gradoMinisterialToolStripMenuItem
            // 
            gradoMinisterialToolStripMenuItem.Name = "gradoMinisterialToolStripMenuItem";
            gradoMinisterialToolStripMenuItem.Size = new Size(184, 22);
            gradoMinisterialToolStripMenuItem.Text = "Grado Ministerial";
            gradoMinisterialToolStripMenuItem.Click += LoadGradoMinisterial;
            // 
            // gradoDeInstrucciónToolStripMenuItem
            // 
            gradoDeInstrucciónToolStripMenuItem.Name = "gradoDeInstrucciónToolStripMenuItem";
            gradoDeInstrucciónToolStripMenuItem.Size = new Size(184, 22);
            gradoDeInstrucciónToolStripMenuItem.Text = "Grado de instrucción";
            gradoDeInstrucciónToolStripMenuItem.Click += gradoDeInstrucciónToolStripMenuItem_Click;
            // 
            // paisToolStripMenuItem
            // 
            paisToolStripMenuItem.Name = "paisToolStripMenuItem";
            paisToolStripMenuItem.Size = new Size(184, 22);
            paisToolStripMenuItem.Text = "Pais";
            paisToolStripMenuItem.Click += paisToolStripMenuItem_Click;
            // 
            // regionToolStripMenuItem
            // 
            regionToolStripMenuItem.Name = "regionToolStripMenuItem";
            regionToolStripMenuItem.Size = new Size(184, 22);
            regionToolStripMenuItem.Text = "Region";
            regionToolStripMenuItem.Click += regionToolStripMenuItem_Click;
            // 
            // provinciaToolStripMenuItem
            // 
            provinciaToolStripMenuItem.Name = "provinciaToolStripMenuItem";
            provinciaToolStripMenuItem.Size = new Size(184, 22);
            provinciaToolStripMenuItem.Text = "Provincia";
            provinciaToolStripMenuItem.Click += provinciaToolStripMenuItem_Click;
            // 
            // distritoToolStripMenuItem
            // 
            distritoToolStripMenuItem.Name = "distritoToolStripMenuItem";
            distritoToolStripMenuItem.Size = new Size(184, 22);
            distritoToolStripMenuItem.Text = "Distrito";
            distritoToolStripMenuItem.Click += distritoToolStripMenuItem_Click;
            // 
            // estadoCivilToolStripMenuItem
            // 
            estadoCivilToolStripMenuItem.Name = "estadoCivilToolStripMenuItem";
            estadoCivilToolStripMenuItem.Size = new Size(184, 22);
            estadoCivilToolStripMenuItem.Text = "Estado Civil";
            estadoCivilToolStripMenuItem.Click += estadoCivilToolStripMenuItem_Click;
            // 
            // cargoToolStripMenuItem
            // 
            cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            cargoToolStripMenuItem.Size = new Size(184, 22);
            cargoToolStripMenuItem.Text = "Cargo";
            cargoToolStripMenuItem.Click += cargoToolStripMenuItem_Click;
            // 
            // DmMayordomias
            // 
            DmMayordomias.IsMainMenu = false;
            DmMayordomias.MenuItemHieght = 25;
            DmMayordomias.MenuItemTextColor = Color.DimGray;
            DmMayordomias.Name = "DmMayordomias";
            DmMayordomias.PrimaryColor = Color.MediumSlateBlue;
            DmMayordomias.Size = new Size(61, 4);
            // 
            // DmMinistros
            // 
            DmMinistros.IsMainMenu = false;
            DmMinistros.Items.AddRange(new ToolStripItem[] { ministrosToolStripMenuItem });
            DmMinistros.MenuItemHieght = 25;
            DmMinistros.MenuItemTextColor = Color.DimGray;
            DmMinistros.Name = "DmMinistros";
            DmMinistros.PrimaryColor = Color.MediumSlateBlue;
            DmMinistros.Size = new Size(181, 48);
            // 
            // ministrosToolStripMenuItem
            // 
            ministrosToolStripMenuItem.Name = "ministrosToolStripMenuItem";
            ministrosToolStripMenuItem.Size = new Size(180, 22);
            ministrosToolStripMenuItem.Text = "Ministros";
            
            // 
            // FmrPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1584, 761);
            Controls.Add(PnlCentral);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimumSize = new Size(950, 600);
            Name = "FmrPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FmrPrincipal_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            DmBaseDatos.ResumeLayout(false);
            DmMinistros.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button CmdBaseDatos;
        private Button CmdMinistros;
        private Button CmdMayordomias;
        private Panel PnlCentral;
        private Label label3;
        private Label label2;
        private Button CmdLogout;
        private Controls.DropdwonMenu DmBaseDatos;
        private ToolStripMenuItem iglesiaToolStripMenuItem;
        private ToolStripMenuItem sectorToolStripMenuItem;
        private ToolStripMenuItem gradoMinisterialToolStripMenuItem;
        private ToolStripMenuItem gradoDeInstrucciónToolStripMenuItem;
        private Controls.DropdwonMenu DmMayordomias;
        private Controls.DropdwonMenu DmMinistros;
        private ToolStripMenuItem paisToolStripMenuItem;
        private ToolStripMenuItem regionToolStripMenuItem;
        private ToolStripMenuItem provinciaToolStripMenuItem;
        private ToolStripMenuItem distritoToolStripMenuItem;
        private ToolStripMenuItem estadoCivilToolStripMenuItem;
        private ToolStripMenuItem cargoToolStripMenuItem;
        private ToolStripMenuItem ministrosToolStripMenuItem;
    }
}
