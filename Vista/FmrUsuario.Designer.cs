namespace Vista
{
    partial class FmrUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrUsuario));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            CmdCerrar = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Grupo01 = new GroupBox();
            TxtCorreoUsuario = new TextBox();
            TxtContraseñaUsuario = new TextBox();
            TxtUsuario = new TextBox();
            CmdReporteUsuario = new Button();
            CmdLimpiarUsuario = new Button();
            CmdEliminarUsuario = new Button();
            CmdActualizarUsuario = new Button();
            CmdNuevoUsuario = new Button();
            DgvIglesia = new DataGridView();
            label8 = new Label();
            TxtBuscarUsuario = new TextBox();
            groupBox1 = new GroupBox();
            CmbTipoIdRolUsuario = new ComboBox();
            CmbTipoIdMinistroUsuario = new ComboBox();
            CmdIdMinistro = new Button();
            CmdIdRol = new Button();
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).BeginInit();
            Grupo01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvIglesia).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CmdCerrar
            // 
            CmdCerrar.BackgroundImage = (Image)resources.GetObject("CmdCerrar.BackgroundImage");
            CmdCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            CmdCerrar.Cursor = Cursors.Hand;
            CmdCerrar.Location = new Point(22, 9);
            CmdCerrar.Margin = new Padding(4, 3, 4, 3);
            CmdCerrar.Name = "CmdCerrar";
            CmdCerrar.Size = new Size(21, 21);
            CmdCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            CmdCerrar.TabIndex = 76;
            CmdCerrar.TabStop = false;
            CmdCerrar.Click += CmdCerrar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(401, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 29);
            label1.TabIndex = 111;
            label1.Text = "USUARIO";
            // 
            // label7
            // 
            label7.Font = new Font("Open Sans", 9F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(22, 50);
            label7.Name = "label7";
            label7.Size = new Size(70, 16);
            label7.TabIndex = 152;
            label7.Text = "Id :";
            // 
            // label2
            // 
            label2.Font = new Font("Open Sans", 9F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 80);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 153;
            label2.Text = "Usuario :";
            // 
            // label3
            // 
            label3.Font = new Font("Open Sans", 9F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(22, 110);
            label3.Name = "label3";
            label3.Size = new Size(89, 16);
            label3.TabIndex = 154;
            label3.Text = "Contraseña :";
            // 
            // label4
            // 
            label4.Font = new Font("Open Sans", 9F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(22, 140);
            label4.Name = "label4";
            label4.Size = new Size(89, 16);
            label4.TabIndex = 155;
            label4.Text = "Correo :";
            // 
            // label5
            // 
            label5.Font = new Font("Open Sans", 9F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(376, 76);
            label5.Name = "label5";
            label5.Size = new Size(70, 16);
            label5.TabIndex = 156;
            label5.Text = "Id Ministro:";
            // 
            // label6
            // 
            label6.Font = new Font("Open Sans", 9F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(376, 140);
            label6.Name = "label6";
            label6.Size = new Size(70, 16);
            label6.TabIndex = 157;
            label6.Text = "Id Rol:";
            // 
            // Grupo01
            // 
            Grupo01.Controls.Add(TxtCorreoUsuario);
            Grupo01.Controls.Add(TxtContraseñaUsuario);
            Grupo01.Controls.Add(TxtUsuario);
            Grupo01.Location = new Point(117, 56);
            Grupo01.Name = "Grupo01";
            Grupo01.Size = new Size(178, 112);
            Grupo01.TabIndex = 0;
            Grupo01.TabStop = false;
            // 
            // TxtCorreoUsuario
            // 
            TxtCorreoUsuario.Font = new Font("Open Sans", 9F);
            TxtCorreoUsuario.Location = new Point(6, 81);
            TxtCorreoUsuario.Name = "TxtCorreoUsuario";
            TxtCorreoUsuario.Size = new Size(166, 24);
            TxtCorreoUsuario.TabIndex = 2;
            // 
            // TxtContraseñaUsuario
            // 
            TxtContraseñaUsuario.Font = new Font("Open Sans", 9F);
            TxtContraseñaUsuario.Location = new Point(6, 50);
            TxtContraseñaUsuario.Name = "TxtContraseñaUsuario";
            TxtContraseñaUsuario.Size = new Size(166, 24);
            TxtContraseñaUsuario.TabIndex = 1;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Font = new Font("Open Sans", 9F);
            TxtUsuario.Location = new Point(6, 17);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(166, 24);
            TxtUsuario.TabIndex = 0;
            // 
            // CmdReporteUsuario
            // 
            CmdReporteUsuario.Cursor = Cursors.Hand;
            CmdReporteUsuario.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdReporteUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteUsuario.FlatStyle = FlatStyle.Flat;
            CmdReporteUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdReporteUsuario.ForeColor = Color.Black;
            CmdReporteUsuario.Image = (Image)resources.GetObject("CmdReporteUsuario.Image");
            CmdReporteUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            CmdReporteUsuario.Location = new Point(698, 187);
            CmdReporteUsuario.Name = "CmdReporteUsuario";
            CmdReporteUsuario.Size = new Size(159, 40);
            CmdReporteUsuario.TabIndex = 10;
            CmdReporteUsuario.Text = "REPORTE";
            CmdReporteUsuario.UseVisualStyleBackColor = true;
            // 
            // CmdLimpiarUsuario
            // 
            CmdLimpiarUsuario.Cursor = Cursors.Hand;
            CmdLimpiarUsuario.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarUsuario.FlatStyle = FlatStyle.Flat;
            CmdLimpiarUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdLimpiarUsuario.ForeColor = Color.Black;
            CmdLimpiarUsuario.Image = (Image)resources.GetObject("CmdLimpiarUsuario.Image");
            CmdLimpiarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            CmdLimpiarUsuario.Location = new Point(528, 187);
            CmdLimpiarUsuario.Name = "CmdLimpiarUsuario";
            CmdLimpiarUsuario.Size = new Size(159, 40);
            CmdLimpiarUsuario.TabIndex = 9;
            CmdLimpiarUsuario.Text = "LIMPIAR";
            CmdLimpiarUsuario.UseVisualStyleBackColor = true;
            // 
            // CmdEliminarUsuario
            // 
            CmdEliminarUsuario.Cursor = Cursors.Hand;
            CmdEliminarUsuario.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdEliminarUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarUsuario.FlatStyle = FlatStyle.Flat;
            CmdEliminarUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdEliminarUsuario.ForeColor = Color.Black;
            CmdEliminarUsuario.Image = (Image)resources.GetObject("CmdEliminarUsuario.Image");
            CmdEliminarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            CmdEliminarUsuario.Location = new Point(358, 187);
            CmdEliminarUsuario.Name = "CmdEliminarUsuario";
            CmdEliminarUsuario.Size = new Size(159, 40);
            CmdEliminarUsuario.TabIndex = 8;
            CmdEliminarUsuario.Text = "ELIMINAR";
            CmdEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // CmdActualizarUsuario
            // 
            CmdActualizarUsuario.Cursor = Cursors.Hand;
            CmdActualizarUsuario.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdActualizarUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarUsuario.FlatStyle = FlatStyle.Flat;
            CmdActualizarUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdActualizarUsuario.ForeColor = Color.Black;
            CmdActualizarUsuario.Image = (Image)resources.GetObject("CmdActualizarUsuario.Image");
            CmdActualizarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            CmdActualizarUsuario.Location = new Point(188, 187);
            CmdActualizarUsuario.Name = "CmdActualizarUsuario";
            CmdActualizarUsuario.Size = new Size(159, 40);
            CmdActualizarUsuario.TabIndex = 7;
            CmdActualizarUsuario.Text = "ACTUALIZAR";
            CmdActualizarUsuario.UseVisualStyleBackColor = true;
            // 
            // CmdNuevoUsuario
            // 
            CmdNuevoUsuario.Cursor = Cursors.Hand;
            CmdNuevoUsuario.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdNuevoUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoUsuario.FlatStyle = FlatStyle.Flat;
            CmdNuevoUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdNuevoUsuario.ForeColor = Color.Black;
            CmdNuevoUsuario.Image = (Image)resources.GetObject("CmdNuevoUsuario.Image");
            CmdNuevoUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            CmdNuevoUsuario.Location = new Point(22, 187);
            CmdNuevoUsuario.Name = "CmdNuevoUsuario";
            CmdNuevoUsuario.Size = new Size(159, 40);
            CmdNuevoUsuario.TabIndex = 6;
            CmdNuevoUsuario.Text = "NUEVO";
            CmdNuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // DgvIglesia
            // 
            DgvIglesia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvIglesia.DefaultCellStyle = dataGridViewCellStyle2;
            DgvIglesia.Location = new Point(40, 252);
            DgvIglesia.Name = "DgvIglesia";
            DgvIglesia.Size = new Size(813, 222);
            DgvIglesia.TabIndex = 192;
            // 
            // label8
            // 
            label8.Font = new Font("Open Sans", 9F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(655, 108);
            label8.Name = "label8";
            label8.Size = new Size(70, 16);
            label8.TabIndex = 193;
            label8.Text = "Buscar :";
            // 
            // TxtBuscarUsuario
            // 
            TxtBuscarUsuario.Font = new Font("Open Sans", 9F);
            TxtBuscarUsuario.Location = new Point(718, 105);
            TxtBuscarUsuario.Name = "TxtBuscarUsuario";
            TxtBuscarUsuario.Size = new Size(166, 24);
            TxtBuscarUsuario.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CmbTipoIdRolUsuario);
            groupBox1.Controls.Add(CmbTipoIdMinistroUsuario);
            groupBox1.Location = new Point(452, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(178, 112);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // CmbTipoIdRolUsuario
            // 
            CmbTipoIdRolUsuario.Font = new Font("Open Sans", 9F);
            CmbTipoIdRolUsuario.FormattingEnabled = true;
            CmbTipoIdRolUsuario.Location = new Point(6, 80);
            CmbTipoIdRolUsuario.Name = "CmbTipoIdRolUsuario";
            CmbTipoIdRolUsuario.Size = new Size(166, 25);
            CmbTipoIdRolUsuario.TabIndex = 4;
            // 
            // CmbTipoIdMinistroUsuario
            // 
            CmbTipoIdMinistroUsuario.Font = new Font("Open Sans", 9F);
            CmbTipoIdMinistroUsuario.FormattingEnabled = true;
            CmbTipoIdMinistroUsuario.Location = new Point(6, 15);
            CmbTipoIdMinistroUsuario.Name = "CmbTipoIdMinistroUsuario";
            CmbTipoIdMinistroUsuario.Size = new Size(166, 25);
            CmbTipoIdMinistroUsuario.TabIndex = 3;
            // 
            // CmdIdMinistro
            // 
            CmdIdMinistro.BackColor = Color.Transparent;
            CmdIdMinistro.BackgroundImage = (Image)resources.GetObject("CmdIdMinistro.BackgroundImage");
            CmdIdMinistro.BackgroundImageLayout = ImageLayout.Zoom;
            CmdIdMinistro.Cursor = Cursors.Hand;
            CmdIdMinistro.FlatAppearance.BorderColor = Color.White;
            CmdIdMinistro.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CmdIdMinistro.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CmdIdMinistro.FlatStyle = FlatStyle.Flat;
            CmdIdMinistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdIdMinistro.ForeColor = Color.Transparent;
            CmdIdMinistro.Location = new Point(636, 68);
            CmdIdMinistro.Name = "CmdIdMinistro";
            CmdIdMinistro.Size = new Size(31, 27);
            CmdIdMinistro.TabIndex = 194;
            CmdIdMinistro.TextAlign = ContentAlignment.MiddleRight;
            CmdIdMinistro.TextImageRelation = TextImageRelation.TextBeforeImage;
            CmdIdMinistro.UseVisualStyleBackColor = false;
            // 
            // CmdIdRol
            // 
            CmdIdRol.BackColor = Color.Transparent;
            CmdIdRol.BackgroundImage = (Image)resources.GetObject("CmdIdRol.BackgroundImage");
            CmdIdRol.BackgroundImageLayout = ImageLayout.Zoom;
            CmdIdRol.Cursor = Cursors.Hand;
            CmdIdRol.FlatAppearance.BorderColor = Color.White;
            CmdIdRol.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CmdIdRol.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CmdIdRol.FlatStyle = FlatStyle.Flat;
            CmdIdRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdIdRol.ForeColor = Color.Transparent;
            CmdIdRol.Location = new Point(636, 137);
            CmdIdRol.Name = "CmdIdRol";
            CmdIdRol.Size = new Size(31, 27);
            CmdIdRol.TabIndex = 195;
            CmdIdRol.TextAlign = ContentAlignment.MiddleRight;
            CmdIdRol.TextImageRelation = TextImageRelation.TextBeforeImage;
            CmdIdRol.UseVisualStyleBackColor = false;
            // 
            // FmrUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 529);
            Controls.Add(CmdIdRol);
            Controls.Add(CmdIdMinistro);
            Controls.Add(TxtBuscarUsuario);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(CmdReporteUsuario);
            Controls.Add(CmdLimpiarUsuario);
            Controls.Add(CmdEliminarUsuario);
            Controls.Add(CmdActualizarUsuario);
            Controls.Add(CmdNuevoUsuario);
            Controls.Add(DgvIglesia);
            Controls.Add(Grupo01);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(CmdCerrar);
            Name = "FmrUsuario";
            Text = "FmrUsuario";
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).EndInit();
            Grupo01.ResumeLayout(false);
            Grupo01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvIglesia).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal PictureBox CmdCerrar;
        private Label label1;
        private Label label7;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox Grupo01;
        private TextBox TxtCorreoUsuario;
        private TextBox TxtContraseñaUsuario;
        private TextBox TxtUsuario;
        private Button CmdReporteUsuario;
        private Button CmdLimpiarUsuario;
        private Button CmdEliminarUsuario;
        private Button CmdActualizarUsuario;
        private Button CmdNuevoUsuario;
        private DataGridView DgvIglesia;
        private Label label8;
        private TextBox TxtBuscarUsuario;
        private GroupBox groupBox1;
        private ComboBox CmbTipoIdRolUsuario;
        private ComboBox CmbTipoIdMinistroUsuario;
        private Button CmdIdMinistro;
        private Button CmdIdRol;
    }
}