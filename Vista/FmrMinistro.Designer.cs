namespace Vista
{
    partial class FmrMinistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrMinistro));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            CmdCerrar = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label13 = new Label();
            label16 = new Label();
            label17 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            DgvMinistro = new DataGridView();
            TxtCodigoMinistro = new TextBox();
            Grupo02 = new GroupBox();
            CmbTipoConyugeCKMinistro = new ComboBox();
            DtpFechaIngresoADPMinistro = new DateTimePicker();
            CmbTipoIglesiaMinistro = new ComboBox();
            TxtTiempoMinMinistro = new TextBox();
            TxtHijosMinistro = new TextBox();
            TxtConyugeMinistroSC = new TextBox();
            CmbTipoDistritoMinistro = new ComboBox();
            CmbTipoProvinciaMinistro = new ComboBox();
            CmbTipoRegionMinistro = new ComboBox();
            TxtCorreoMinistro = new TextBox();
            TxtDireccionMinistro = new TextBox();
            TxtMovil02Ministro = new TextBox();
            label25 = new Label();
            label21 = new Label();
            label14 = new Label();
            label12 = new Label();
            label27 = new Label();
            label29 = new Label();
            label19 = new Label();
            CmdReporteMinistro = new Button();
            CmdLimpiarMinistro = new Button();
            CmdEliminarMinistro = new Button();
            CmdActualizarMinistro = new Button();
            CmdNuevoMinistro = new Button();
            label20 = new Label();
            label31 = new Label();
            Grupo01 = new GroupBox();
            DtpFechaNacMinistro = new DateTimePicker();
            CmbEstadoCivilMinistro = new ComboBox();
            CmbTipoSexo = new ComboBox();
            TxtMovil01Ministro = new TextBox();
            TxtTelefonoMinistro = new TextBox();
            TxtDniPasapMinistro = new TextBox();
            textBox3 = new TextBox();
            TxtApMaternoMinistro = new TextBox();
            TxtApPaternoMinistro = new TextBox();
            TxtNombreMinistro = new TextBox();
            pictureBox1 = new PictureBox();
            label36 = new Label();
            label37 = new Label();
            CbConyugeMinistro = new CheckBox();
            button2 = new Button();
            BtnAgregarFoto = new Button();
            button14 = new Button();
            Grupo03 = new GroupBox();
            CmbGradoMinMinistro = new ComboBox();
            CmbTipoPastoreaMinistro = new ComboBox();
            CmdRegion = new Button();
            CmdProvincia = new Button();
            CmdDistrito = new Button();
            CmdConyuge = new Button();
            CmdIglesia = new Button();
            CmdGradoMinisterial = new Button();
            TxtBuscarMinistro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvMinistro).BeginInit();
            Grupo02.SuspendLayout();
            Grupo01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Grupo03.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(531, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 35);
            label1.TabIndex = 107;
            label1.Text = "MINISTRO";
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
            CmdCerrar.TabIndex = 108;
            CmdCerrar.TabStop = false;
            CmdCerrar.Click += CmdCerrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans", 9F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(22, 110);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 118;
            label3.Text = "Nombres :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 9F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 140);
            label2.Name = "label2";
            label2.Size = new Size(106, 17);
            label2.TabIndex = 119;
            label2.Text = "Apellido Paterno :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Open Sans", 9F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(22, 170);
            label4.Name = "label4";
            label4.Size = new Size(110, 17);
            label4.TabIndex = 120;
            label4.Text = "Apellido Materno :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Open Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(22, 80);
            label5.Name = "label5";
            label5.Size = new Size(53, 17);
            label5.TabIndex = 121;
            label5.Text = "Codigo :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Open Sans", 9F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(415, 110);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 122;
            label6.Text = "Correo :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Open Sans", 9F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(22, 200);
            label7.Name = "label7";
            label7.Size = new Size(138, 17);
            label7.TabIndex = 123;
            label7.Text = "DNI/Pasaporte/Carnet :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Open Sans", 9F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(22, 260);
            label8.Name = "label8";
            label8.Size = new Size(42, 17);
            label8.TabIndex = 124;
            label8.Text = "Edad :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Open Sans", 9F);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(22, 290);
            label9.Name = "label9";
            label9.Size = new Size(41, 17);
            label9.TabIndex = 125;
            label9.Text = "Sexo :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Open Sans", 9F);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(22, 320);
            label10.Name = "label10";
            label10.Size = new Size(78, 17);
            label10.TabIndex = 126;
            label10.Text = "Estado Civil :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Open Sans", 9F);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(22, 353);
            label13.Name = "label13";
            label13.Size = new Size(60, 17);
            label13.TabIndex = 129;
            label13.Text = "Telefono:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Open Sans", 9F);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(415, 380);
            label16.Name = "label16";
            label16.Size = new Size(118, 17);
            label16.TabIndex = 132;
            label16.Text = "Tiempo Ministerial :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Open Sans", 9F);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(415, 290);
            label17.Name = "label17";
            label17.Size = new Size(39, 17);
            label17.TabIndex = 133;
            label17.Text = "Hijos:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Open Sans", 9F);
            label22.ForeColor = SystemColors.ActiveCaptionText;
            label22.Location = new Point(22, 384);
            label22.Name = "label22";
            label22.Size = new Size(61, 17);
            label22.TabIndex = 143;
            label22.Text = "Movil 01 :";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Open Sans", 9F);
            label23.ForeColor = SystemColors.ActiveCaptionText;
            label23.Location = new Point(415, 80);
            label23.Name = "label23";
            label23.Size = new Size(61, 17);
            label23.TabIndex = 144;
            label23.Text = "Movil 02 :";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Open Sans", 9F);
            label24.ForeColor = SystemColors.ActiveCaptionText;
            label24.Location = new Point(829, 260);
            label24.Name = "label24";
            label24.Size = new Size(111, 17);
            label24.TabIndex = 145;
            label24.Text = "Grado Ministerial :";
            // 
            // DgvMinistro
            // 
            DgvMinistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvMinistro.DefaultCellStyle = dataGridViewCellStyle2;
            DgvMinistro.Location = new Point(40, 535);
            DgvMinistro.Name = "DgvMinistro";
            DgvMinistro.Size = new Size(817, 222);
            DgvMinistro.TabIndex = 146;
            // 
            // TxtCodigoMinistro
            // 
            TxtCodigoMinistro.Font = new Font("Open Sans", 9F);
            TxtCodigoMinistro.Location = new Point(6, 20);
            TxtCodigoMinistro.Name = "TxtCodigoMinistro";
            TxtCodigoMinistro.Size = new Size(166, 24);
            TxtCodigoMinistro.TabIndex = 1;
            // 
            // Grupo02
            // 
            Grupo02.Controls.Add(CmbTipoConyugeCKMinistro);
            Grupo02.Controls.Add(DtpFechaIngresoADPMinistro);
            Grupo02.Controls.Add(CmbTipoIglesiaMinistro);
            Grupo02.Controls.Add(TxtTiempoMinMinistro);
            Grupo02.Controls.Add(TxtHijosMinistro);
            Grupo02.Controls.Add(TxtConyugeMinistroSC);
            Grupo02.Controls.Add(CmbTipoDistritoMinistro);
            Grupo02.Controls.Add(CmbTipoProvinciaMinistro);
            Grupo02.Controls.Add(CmbTipoRegionMinistro);
            Grupo02.Controls.Add(TxtCorreoMinistro);
            Grupo02.Controls.Add(TxtDireccionMinistro);
            Grupo02.Controls.Add(TxtMovil02Ministro);
            Grupo02.Location = new Point(573, 53);
            Grupo02.Name = "Grupo02";
            Grupo02.Size = new Size(178, 359);
            Grupo02.TabIndex = 12;
            Grupo02.TabStop = false;
            // 
            // CmbTipoConyugeCKMinistro
            // 
            CmbTipoConyugeCKMinistro.Font = new Font("Open Sans", 9F);
            CmbTipoConyugeCKMinistro.FormattingEnabled = true;
            CmbTipoConyugeCKMinistro.Location = new Point(-71, 199);
            CmbTipoConyugeCKMinistro.Name = "CmbTipoConyugeCKMinistro";
            CmbTipoConyugeCKMinistro.Size = new Size(166, 25);
            CmbTipoConyugeCKMinistro.TabIndex = 18;
            // 
            // DtpFechaIngresoADPMinistro
            // 
            DtpFechaIngresoADPMinistro.Location = new Point(6, 290);
            DtpFechaIngresoADPMinistro.Name = "DtpFechaIngresoADPMinistro";
            DtpFechaIngresoADPMinistro.Size = new Size(166, 23);
            DtpFechaIngresoADPMinistro.TabIndex = 21;
            // 
            // CmbTipoIglesiaMinistro
            // 
            CmbTipoIglesiaMinistro.Font = new Font("Open Sans", 9F);
            CmbTipoIglesiaMinistro.FormattingEnabled = true;
            CmbTipoIglesiaMinistro.Location = new Point(6, 260);
            CmbTipoIglesiaMinistro.Name = "CmbTipoIglesiaMinistro";
            CmbTipoIglesiaMinistro.Size = new Size(166, 25);
            CmbTipoIglesiaMinistro.TabIndex = 20;
            // 
            // TxtTiempoMinMinistro
            // 
            TxtTiempoMinMinistro.Font = new Font("Open Sans", 9F);
            TxtTiempoMinMinistro.Location = new Point(6, 320);
            TxtTiempoMinMinistro.Name = "TxtTiempoMinMinistro";
            TxtTiempoMinMinistro.Size = new Size(166, 24);
            TxtTiempoMinMinistro.TabIndex = 22;
            // 
            // TxtHijosMinistro
            // 
            TxtHijosMinistro.Font = new Font("Open Sans", 9F);
            TxtHijosMinistro.Location = new Point(6, 230);
            TxtHijosMinistro.Name = "TxtHijosMinistro";
            TxtHijosMinistro.Size = new Size(166, 24);
            TxtHijosMinistro.TabIndex = 19;
            // 
            // TxtConyugeMinistroSC
            // 
            TxtConyugeMinistroSC.Font = new Font("Open Sans", 9F);
            TxtConyugeMinistroSC.Location = new Point(6, 200);
            TxtConyugeMinistroSC.Name = "TxtConyugeMinistroSC";
            TxtConyugeMinistroSC.Size = new Size(166, 24);
            TxtConyugeMinistroSC.TabIndex = 18;
            // 
            // CmbTipoDistritoMinistro
            // 
            CmbTipoDistritoMinistro.Font = new Font("Open Sans", 9F);
            CmbTipoDistritoMinistro.FormattingEnabled = true;
            CmbTipoDistritoMinistro.Location = new Point(6, 140);
            CmbTipoDistritoMinistro.Name = "CmbTipoDistritoMinistro";
            CmbTipoDistritoMinistro.Size = new Size(166, 25);
            CmbTipoDistritoMinistro.TabIndex = 16;
            // 
            // CmbTipoProvinciaMinistro
            // 
            CmbTipoProvinciaMinistro.Font = new Font("Open Sans", 9F);
            CmbTipoProvinciaMinistro.FormattingEnabled = true;
            CmbTipoProvinciaMinistro.Location = new Point(6, 110);
            CmbTipoProvinciaMinistro.Name = "CmbTipoProvinciaMinistro";
            CmbTipoProvinciaMinistro.Size = new Size(166, 25);
            CmbTipoProvinciaMinistro.TabIndex = 15;
            // 
            // CmbTipoRegionMinistro
            // 
            CmbTipoRegionMinistro.Font = new Font("Open Sans", 9F);
            CmbTipoRegionMinistro.FormattingEnabled = true;
            CmbTipoRegionMinistro.Location = new Point(6, 80);
            CmbTipoRegionMinistro.Name = "CmbTipoRegionMinistro";
            CmbTipoRegionMinistro.Size = new Size(166, 25);
            CmbTipoRegionMinistro.TabIndex = 14;
            // 
            // TxtCorreoMinistro
            // 
            TxtCorreoMinistro.Font = new Font("Open Sans", 9F);
            TxtCorreoMinistro.Location = new Point(6, 50);
            TxtCorreoMinistro.Name = "TxtCorreoMinistro";
            TxtCorreoMinistro.Size = new Size(166, 24);
            TxtCorreoMinistro.TabIndex = 13;
            // 
            // TxtDireccionMinistro
            // 
            TxtDireccionMinistro.Font = new Font("Open Sans", 9F);
            TxtDireccionMinistro.Location = new Point(6, 170);
            TxtDireccionMinistro.Name = "TxtDireccionMinistro";
            TxtDireccionMinistro.Size = new Size(166, 24);
            TxtDireccionMinistro.TabIndex = 17;
            // 
            // TxtMovil02Ministro
            // 
            TxtMovil02Ministro.Font = new Font("Open Sans", 9F);
            TxtMovil02Ministro.Location = new Point(6, 20);
            TxtMovil02Ministro.Name = "TxtMovil02Ministro";
            TxtMovil02Ministro.Size = new Size(166, 24);
            TxtMovil02Ministro.TabIndex = 12;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Open Sans", 9F);
            label25.ForeColor = SystemColors.ActiveCaptionText;
            label25.Location = new Point(829, 230);
            label25.Name = "label25";
            label25.Size = new Size(64, 17);
            label25.TabIndex = 150;
            label25.Text = "Pastorea :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Open Sans", 9F);
            label21.ForeColor = SystemColors.ActiveCaptionText;
            label21.Location = new Point(415, 260);
            label21.Name = "label21";
            label21.Size = new Size(63, 17);
            label21.TabIndex = 155;
            label21.Text = "Conyuge :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Open Sans", 9F);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(415, 230);
            label14.Name = "label14";
            label14.Size = new Size(67, 17);
            label14.TabIndex = 152;
            label14.Text = "Direccion :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Open Sans", 9F);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(22, 230);
            label12.Name = "label12";
            label12.Size = new Size(114, 17);
            label12.TabIndex = 151;
            label12.Text = "Fecha Nacimiento :";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Open Sans", 9F);
            label27.ForeColor = SystemColors.ActiveCaptionText;
            label27.Location = new Point(415, 320);
            label27.Name = "label27";
            label27.Size = new Size(50, 17);
            label27.TabIndex = 158;
            label27.Text = "Iglesia :";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Open Sans", 9F);
            label29.ForeColor = SystemColors.ActiveCaptionText;
            label29.Location = new Point(415, 200);
            label29.Name = "label29";
            label29.Size = new Size(55, 17);
            label29.TabIndex = 160;
            label29.Text = "Distrito :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Open Sans", 9F);
            label19.ForeColor = SystemColors.ActiveCaptionText;
            label19.Location = new Point(22, 50);
            label19.Name = "label19";
            label19.Size = new Size(24, 17);
            label19.TabIndex = 162;
            label19.Text = "Id :";
            // 
            // CmdReporteMinistro
            // 
            CmdReporteMinistro.Cursor = Cursors.Hand;
            CmdReporteMinistro.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdReporteMinistro.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteMinistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteMinistro.FlatStyle = FlatStyle.Flat;
            CmdReporteMinistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdReporteMinistro.ForeColor = Color.Black;
            CmdReporteMinistro.Image = (Image)resources.GetObject("CmdReporteMinistro.Image");
            CmdReporteMinistro.ImageAlign = ContentAlignment.MiddleLeft;
            CmdReporteMinistro.Location = new Point(698, 473);
            CmdReporteMinistro.Name = "CmdReporteMinistro";
            CmdReporteMinistro.Size = new Size(159, 40);
            CmdReporteMinistro.TabIndex = 31;
            CmdReporteMinistro.Text = "REPORTE";
            CmdReporteMinistro.UseVisualStyleBackColor = true;
            // 
            // CmdLimpiarMinistro
            // 
            CmdLimpiarMinistro.Cursor = Cursors.Hand;
            CmdLimpiarMinistro.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarMinistro.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarMinistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarMinistro.FlatStyle = FlatStyle.Flat;
            CmdLimpiarMinistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdLimpiarMinistro.ForeColor = Color.Black;
            CmdLimpiarMinistro.Image = (Image)resources.GetObject("CmdLimpiarMinistro.Image");
            CmdLimpiarMinistro.ImageAlign = ContentAlignment.MiddleLeft;
            CmdLimpiarMinistro.Location = new Point(528, 473);
            CmdLimpiarMinistro.Name = "CmdLimpiarMinistro";
            CmdLimpiarMinistro.Size = new Size(159, 40);
            CmdLimpiarMinistro.TabIndex = 30;
            CmdLimpiarMinistro.Text = "LIMPIAR";
            CmdLimpiarMinistro.UseVisualStyleBackColor = true;
            // 
            // CmdEliminarMinistro
            // 
            CmdEliminarMinistro.Cursor = Cursors.Hand;
            CmdEliminarMinistro.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdEliminarMinistro.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarMinistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarMinistro.FlatStyle = FlatStyle.Flat;
            CmdEliminarMinistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdEliminarMinistro.ForeColor = Color.Black;
            CmdEliminarMinistro.Image = (Image)resources.GetObject("CmdEliminarMinistro.Image");
            CmdEliminarMinistro.ImageAlign = ContentAlignment.MiddleLeft;
            CmdEliminarMinistro.Location = new Point(358, 473);
            CmdEliminarMinistro.Name = "CmdEliminarMinistro";
            CmdEliminarMinistro.Size = new Size(159, 40);
            CmdEliminarMinistro.TabIndex = 29;
            CmdEliminarMinistro.Text = "ELIMINAR";
            CmdEliminarMinistro.UseVisualStyleBackColor = true;
            // 
            // CmdActualizarMinistro
            // 
            CmdActualizarMinistro.Cursor = Cursors.Hand;
            CmdActualizarMinistro.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdActualizarMinistro.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarMinistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarMinistro.FlatStyle = FlatStyle.Flat;
            CmdActualizarMinistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdActualizarMinistro.ForeColor = Color.Black;
            CmdActualizarMinistro.Image = (Image)resources.GetObject("CmdActualizarMinistro.Image");
            CmdActualizarMinistro.ImageAlign = ContentAlignment.MiddleLeft;
            CmdActualizarMinistro.Location = new Point(188, 473);
            CmdActualizarMinistro.Name = "CmdActualizarMinistro";
            CmdActualizarMinistro.Size = new Size(159, 40);
            CmdActualizarMinistro.TabIndex = 28;
            CmdActualizarMinistro.Text = "ACTUALIZAR";
            CmdActualizarMinistro.UseVisualStyleBackColor = true;
            // 
            // CmdNuevoMinistro
            // 
            CmdNuevoMinistro.Cursor = Cursors.Hand;
            CmdNuevoMinistro.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdNuevoMinistro.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoMinistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoMinistro.FlatStyle = FlatStyle.Flat;
            CmdNuevoMinistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdNuevoMinistro.ForeColor = Color.Black;
            CmdNuevoMinistro.Image = (Image)resources.GetObject("CmdNuevoMinistro.Image");
            CmdNuevoMinistro.ImageAlign = ContentAlignment.MiddleLeft;
            CmdNuevoMinistro.Location = new Point(22, 473);
            CmdNuevoMinistro.Name = "CmdNuevoMinistro";
            CmdNuevoMinistro.Size = new Size(159, 40);
            CmdNuevoMinistro.TabIndex = 27;
            CmdNuevoMinistro.Text = "NUEVO";
            CmdNuevoMinistro.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Open Sans", 9F);
            label20.ForeColor = SystemColors.ActiveCaptionText;
            label20.Location = new Point(415, 170);
            label20.Name = "label20";
            label20.Size = new Size(68, 17);
            label20.TabIndex = 176;
            label20.Text = "Provincia  :";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Open Sans", 9F);
            label31.ForeColor = SystemColors.ActiveCaptionText;
            label31.Location = new Point(415, 140);
            label31.Name = "label31";
            label31.Size = new Size(55, 17);
            label31.TabIndex = 177;
            label31.Text = "Region  :";
            // 
            // Grupo01
            // 
            Grupo01.Controls.Add(DtpFechaNacMinistro);
            Grupo01.Controls.Add(CmbEstadoCivilMinistro);
            Grupo01.Controls.Add(CmbTipoSexo);
            Grupo01.Controls.Add(TxtMovil01Ministro);
            Grupo01.Controls.Add(TxtTelefonoMinistro);
            Grupo01.Controls.Add(TxtDniPasapMinistro);
            Grupo01.Controls.Add(textBox3);
            Grupo01.Controls.Add(TxtApMaternoMinistro);
            Grupo01.Controls.Add(TxtApPaternoMinistro);
            Grupo01.Controls.Add(TxtNombreMinistro);
            Grupo01.Controls.Add(TxtCodigoMinistro);
            Grupo01.Location = new Point(188, 53);
            Grupo01.Name = "Grupo01";
            Grupo01.Size = new Size(178, 359);
            Grupo01.TabIndex = 0;
            Grupo01.TabStop = false;
            // 
            // DtpFechaNacMinistro
            // 
            DtpFechaNacMinistro.Location = new Point(6, 173);
            DtpFechaNacMinistro.Name = "DtpFechaNacMinistro";
            DtpFechaNacMinistro.Size = new Size(166, 23);
            DtpFechaNacMinistro.TabIndex = 6;
            // 
            // CmbEstadoCivilMinistro
            // 
            CmbEstadoCivilMinistro.Font = new Font("Open Sans", 9F);
            CmbEstadoCivilMinistro.FormattingEnabled = true;
            CmbEstadoCivilMinistro.Location = new Point(6, 263);
            CmbEstadoCivilMinistro.Name = "CmbEstadoCivilMinistro";
            CmbEstadoCivilMinistro.Size = new Size(166, 25);
            CmbEstadoCivilMinistro.TabIndex = 9;
            // 
            // CmbTipoSexo
            // 
            CmbTipoSexo.Font = new Font("Open Sans", 9F);
            CmbTipoSexo.FormattingEnabled = true;
            CmbTipoSexo.Location = new Point(6, 233);
            CmbTipoSexo.Name = "CmbTipoSexo";
            CmbTipoSexo.Size = new Size(166, 25);
            CmbTipoSexo.TabIndex = 8;
            // 
            // TxtMovil01Ministro
            // 
            TxtMovil01Ministro.Font = new Font("Open Sans", 9F);
            TxtMovil01Ministro.Location = new Point(6, 324);
            TxtMovil01Ministro.Name = "TxtMovil01Ministro";
            TxtMovil01Ministro.Size = new Size(166, 24);
            TxtMovil01Ministro.TabIndex = 11;
            // 
            // TxtTelefonoMinistro
            // 
            TxtTelefonoMinistro.Font = new Font("Open Sans", 9F);
            TxtTelefonoMinistro.Location = new Point(6, 294);
            TxtTelefonoMinistro.Name = "TxtTelefonoMinistro";
            TxtTelefonoMinistro.Size = new Size(166, 24);
            TxtTelefonoMinistro.TabIndex = 10;
            // 
            // TxtDniPasapMinistro
            // 
            TxtDniPasapMinistro.Font = new Font("Open Sans", 9F);
            TxtDniPasapMinistro.Location = new Point(6, 143);
            TxtDniPasapMinistro.Name = "TxtDniPasapMinistro";
            TxtDniPasapMinistro.Size = new Size(166, 24);
            TxtDniPasapMinistro.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Open Sans", 9F);
            textBox3.Location = new Point(6, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 24);
            textBox3.TabIndex = 7;
            // 
            // TxtApMaternoMinistro
            // 
            TxtApMaternoMinistro.Font = new Font("Open Sans", 9F);
            TxtApMaternoMinistro.Location = new Point(6, 112);
            TxtApMaternoMinistro.Name = "TxtApMaternoMinistro";
            TxtApMaternoMinistro.Size = new Size(166, 24);
            TxtApMaternoMinistro.TabIndex = 4;
            // 
            // TxtApPaternoMinistro
            // 
            TxtApPaternoMinistro.Font = new Font("Open Sans", 9F);
            TxtApPaternoMinistro.Location = new Point(6, 81);
            TxtApPaternoMinistro.Name = "TxtApPaternoMinistro";
            TxtApPaternoMinistro.Size = new Size(166, 24);
            TxtApPaternoMinistro.TabIndex = 3;
            // 
            // TxtNombreMinistro
            // 
            TxtNombreMinistro.Font = new Font("Open Sans", 9F);
            TxtNombreMinistro.Location = new Point(6, 50);
            TxtNombreMinistro.Name = "TxtNombreMinistro";
            TxtNombreMinistro.Size = new Size(166, 24);
            TxtNombreMinistro.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(952, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 119);
            pictureBox1.TabIndex = 432;
            pictureBox1.TabStop = false;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Open Sans", 9F);
            label36.ForeColor = SystemColors.ActiveCaptionText;
            label36.Location = new Point(415, 350);
            label36.Name = "label36";
            label36.Size = new Size(142, 17);
            label36.TabIndex = 1011;
            label36.Text = "Fecha de ingreso LADP :";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Open Sans", 9F);
            label37.ForeColor = SystemColors.ActiveCaptionText;
            label37.Location = new Point(884, 486);
            label37.Name = "label37";
            label37.Size = new Size(53, 17);
            label37.TabIndex = 1008;
            label37.Text = "Buscar :";
            // 
            // CbConyugeMinistro
            // 
            CbConyugeMinistro.AutoSize = true;
            CbConyugeMinistro.Location = new Point(552, 258);
            CbConyugeMinistro.Name = "CbConyugeMinistro";
            CbConyugeMinistro.Size = new Size(15, 14);
            CbConyugeMinistro.TabIndex = 18;
            CbConyugeMinistro.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(806, 408);
            button2.Name = "button2";
            button2.Size = new Size(159, 40);
            button2.TabIndex = 32;
            button2.Text = "MAS DATOS";
            button2.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarFoto
            // 
            BtnAgregarFoto.Location = new Point(915, 178);
            BtnAgregarFoto.Name = "BtnAgregarFoto";
            BtnAgregarFoto.Size = new Size(75, 23);
            BtnAgregarFoto.TabIndex = 23;
            BtnAgregarFoto.Text = "Agregar";
            BtnAgregarFoto.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(1012, 178);
            button14.Name = "button14";
            button14.Size = new Size(75, 23);
            button14.TabIndex = 24;
            button14.Text = "Borrar";
            button14.UseVisualStyleBackColor = true;
            // 
            // Grupo03
            // 
            Grupo03.Controls.Add(CmbGradoMinMinistro);
            Grupo03.Controls.Add(CmbTipoPastoreaMinistro);
            Grupo03.Location = new Point(942, 205);
            Grupo03.Name = "Grupo03";
            Grupo03.Size = new Size(178, 86);
            Grupo03.TabIndex = 25;
            Grupo03.TabStop = false;
            // 
            // CmbGradoMinMinistro
            // 
            CmbGradoMinMinistro.Font = new Font("Open Sans", 9F);
            CmbGradoMinMinistro.FormattingEnabled = true;
            CmbGradoMinMinistro.Location = new Point(6, 49);
            CmbGradoMinMinistro.Name = "CmbGradoMinMinistro";
            CmbGradoMinMinistro.Size = new Size(166, 25);
            CmbGradoMinMinistro.TabIndex = 26;
            // 
            // CmbTipoPastoreaMinistro
            // 
            CmbTipoPastoreaMinistro.Font = new Font("Open Sans", 9F);
            CmbTipoPastoreaMinistro.FormattingEnabled = true;
            CmbTipoPastoreaMinistro.Location = new Point(6, 17);
            CmbTipoPastoreaMinistro.Name = "CmbTipoPastoreaMinistro";
            CmbTipoPastoreaMinistro.Size = new Size(166, 25);
            CmbTipoPastoreaMinistro.TabIndex = 25;
            // 
            // CmdRegion
            // 
            CmdRegion.BackColor = Color.Transparent;
            CmdRegion.BackgroundImage = (Image)resources.GetObject("CmdRegion.BackgroundImage");
            CmdRegion.BackgroundImageLayout = ImageLayout.Zoom;
            CmdRegion.Cursor = Cursors.Hand;
            CmdRegion.FlatAppearance.BorderColor = Color.White;
            CmdRegion.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CmdRegion.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CmdRegion.FlatStyle = FlatStyle.Flat;
            CmdRegion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdRegion.ForeColor = Color.Transparent;
            CmdRegion.Location = new Point(763, 131);
            CmdRegion.Name = "CmdRegion";
            CmdRegion.Size = new Size(31, 27);
            CmdRegion.TabIndex = 14;
            CmdRegion.TextAlign = ContentAlignment.MiddleRight;
            CmdRegion.TextImageRelation = TextImageRelation.TextBeforeImage;
            CmdRegion.UseVisualStyleBackColor = false;
            // 
            // CmdProvincia
            // 
            CmdProvincia.BackColor = Color.Transparent;
            CmdProvincia.BackgroundImage = (Image)resources.GetObject("CmdProvincia.BackgroundImage");
            CmdProvincia.BackgroundImageLayout = ImageLayout.Zoom;
            CmdProvincia.Cursor = Cursors.Hand;
            CmdProvincia.FlatAppearance.BorderColor = Color.White;
            CmdProvincia.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CmdProvincia.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CmdProvincia.FlatStyle = FlatStyle.Flat;
            CmdProvincia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdProvincia.ForeColor = Color.Transparent;
            CmdProvincia.Location = new Point(763, 164);
            CmdProvincia.Name = "CmdProvincia";
            CmdProvincia.Size = new Size(31, 27);
            CmdProvincia.TabIndex = 15;
            CmdProvincia.TextAlign = ContentAlignment.MiddleRight;
            CmdProvincia.TextImageRelation = TextImageRelation.TextBeforeImage;
            CmdProvincia.UseVisualStyleBackColor = false;
            // 
            // CmdDistrito
            // 
            CmdDistrito.BackColor = Color.Transparent;
            CmdDistrito.BackgroundImage = (Image)resources.GetObject("CmdDistrito.BackgroundImage");
            CmdDistrito.BackgroundImageLayout = ImageLayout.Zoom;
            CmdDistrito.Cursor = Cursors.Hand;
            CmdDistrito.FlatAppearance.BorderColor = Color.White;
            CmdDistrito.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CmdDistrito.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CmdDistrito.FlatStyle = FlatStyle.Flat;
            CmdDistrito.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdDistrito.ForeColor = Color.Transparent;
            CmdDistrito.Location = new Point(763, 194);
            CmdDistrito.Name = "CmdDistrito";
            CmdDistrito.Size = new Size(31, 27);
            CmdDistrito.TabIndex = 16;
            CmdDistrito.TextAlign = ContentAlignment.MiddleRight;
            CmdDistrito.TextImageRelation = TextImageRelation.TextBeforeImage;
            CmdDistrito.UseVisualStyleBackColor = false;
            // 
            // CmdConyuge
            // 
            CmdConyuge.BackColor = Color.Transparent;
            CmdConyuge.BackgroundImage = (Image)resources.GetObject("CmdConyuge.BackgroundImage");
            CmdConyuge.BackgroundImageLayout = ImageLayout.Zoom;
            CmdConyuge.Cursor = Cursors.Hand;
            CmdConyuge.FlatAppearance.BorderColor = Color.White;
            CmdConyuge.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CmdConyuge.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CmdConyuge.FlatStyle = FlatStyle.Flat;
            CmdConyuge.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdConyuge.ForeColor = Color.Transparent;
            CmdConyuge.Location = new Point(763, 252);
            CmdConyuge.Name = "CmdConyuge";
            CmdConyuge.Size = new Size(31, 27);
            CmdConyuge.TabIndex = 18;
            CmdConyuge.TextAlign = ContentAlignment.MiddleRight;
            CmdConyuge.TextImageRelation = TextImageRelation.TextBeforeImage;
            CmdConyuge.UseVisualStyleBackColor = false;
            // 
            // CmdIglesia
            // 
            CmdIglesia.BackColor = Color.Transparent;
            CmdIglesia.BackgroundImage = (Image)resources.GetObject("CmdIglesia.BackgroundImage");
            CmdIglesia.BackgroundImageLayout = ImageLayout.Zoom;
            CmdIglesia.Cursor = Cursors.Hand;
            CmdIglesia.FlatAppearance.BorderColor = Color.White;
            CmdIglesia.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CmdIglesia.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CmdIglesia.FlatStyle = FlatStyle.Flat;
            CmdIglesia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdIglesia.ForeColor = Color.Transparent;
            CmdIglesia.Location = new Point(763, 310);
            CmdIglesia.Name = "CmdIglesia";
            CmdIglesia.Size = new Size(31, 27);
            CmdIglesia.TabIndex = 20;
            CmdIglesia.TextAlign = ContentAlignment.MiddleRight;
            CmdIglesia.TextImageRelation = TextImageRelation.TextBeforeImage;
            CmdIglesia.UseVisualStyleBackColor = false;
            // 
            // CmdGradoMinisterial
            // 
            CmdGradoMinisterial.BackColor = Color.Transparent;
            CmdGradoMinisterial.BackgroundImage = (Image)resources.GetObject("CmdGradoMinisterial.BackgroundImage");
            CmdGradoMinisterial.BackgroundImageLayout = ImageLayout.Zoom;
            CmdGradoMinisterial.Cursor = Cursors.Hand;
            CmdGradoMinisterial.FlatAppearance.BorderColor = Color.White;
            CmdGradoMinisterial.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CmdGradoMinisterial.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CmdGradoMinisterial.FlatStyle = FlatStyle.Flat;
            CmdGradoMinisterial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdGradoMinisterial.ForeColor = Color.Transparent;
            CmdGradoMinisterial.Location = new Point(1124, 254);
            CmdGradoMinisterial.Name = "CmdGradoMinisterial";
            CmdGradoMinisterial.Size = new Size(31, 27);
            CmdGradoMinisterial.TabIndex = 26;
            CmdGradoMinisterial.TextAlign = ContentAlignment.MiddleRight;
            CmdGradoMinisterial.TextImageRelation = TextImageRelation.TextBeforeImage;
            CmdGradoMinisterial.UseVisualStyleBackColor = false;
            // 
            // TxtBuscarMinistro
            // 
            TxtBuscarMinistro.Font = new Font("Open Sans", 9F);
            TxtBuscarMinistro.Location = new Point(954, 483);
            TxtBuscarMinistro.Name = "TxtBuscarMinistro";
            TxtBuscarMinistro.Size = new Size(166, 24);
            TxtBuscarMinistro.TabIndex = 33;
            // 
            // FmrMinistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 772);
            Controls.Add(TxtBuscarMinistro);
            Controls.Add(CmdGradoMinisterial);
            Controls.Add(CmdIglesia);
            Controls.Add(CmdConyuge);
            Controls.Add(CmdDistrito);
            Controls.Add(CmdProvincia);
            Controls.Add(CmdRegion);
            Controls.Add(Grupo03);
            Controls.Add(button14);
            Controls.Add(BtnAgregarFoto);
            Controls.Add(CbConyugeMinistro);
            Controls.Add(label36);
            Controls.Add(label16);
            Controls.Add(label37);
            Controls.Add(label24);
            Controls.Add(pictureBox1);
            Controls.Add(Grupo01);
            Controls.Add(label31);
            Controls.Add(label20);
            Controls.Add(button2);
            Controls.Add(CmdReporteMinistro);
            Controls.Add(CmdLimpiarMinistro);
            Controls.Add(CmdEliminarMinistro);
            Controls.Add(CmdActualizarMinistro);
            Controls.Add(CmdNuevoMinistro);
            Controls.Add(label19);
            Controls.Add(label29);
            Controls.Add(label27);
            Controls.Add(label21);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(label25);
            Controls.Add(Grupo02);
            Controls.Add(DgvMinistro);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label17);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(CmdCerrar);
            Controls.Add(label1);
            Name = "FmrMinistro";
            Text = "FmrMinistro";
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvMinistro).EndInit();
            Grupo02.ResumeLayout(false);
            Grupo02.PerformLayout();
            Grupo01.ResumeLayout(false);
            Grupo01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Grupo03.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        internal PictureBox CmdCerrar;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label13;
        private Label label16;
        private Label label17;
        private Label label22;
        private Label label23;
        private Label label24;
        private DataGridView DgvMinistro;
        private TextBox TxtCodigoMinistro;
        private GroupBox Grupo02;
        private Label label25;
        private Label label21;
        private Label label14;
        private Label label12;
        private Label label27;
        private Label label29;
        private Label label19;
        private TextBox TxtMovil02Ministro;
        private TextBox TxtConyugeMinistroSC;
        private ComboBox CmbTipoRegionMinistro;
        private Button CmdReporteMinistro;
        private Button CmdLimpiarMinistro;
        private Button CmdEliminarMinistro;
        private Button CmdActualizarMinistro;
        private Button CmdNuevoMinistro;
        private Label label20;
        private Label label31;
        private ComboBox CmbTipoIglesiaMinistro;
        private GroupBox Grupo01;
        private TextBox TxtApMaternoMinistro;
        private TextBox TxtApPaternoMinistro;
        private TextBox TxtNombreMinistro;
        private PictureBox pictureBox1;
        private Label label36;
        private Label label37;
        private CheckBox CbConyugeMinistro;
        private Button button2;
        private Button BtnAgregarFoto;
        private Button button14;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private ComboBox CmbEstadoCivilMinistro;
        private ComboBox CmbTipoSexo;
        private TextBox TxtDniPasapMinistro;
        private TextBox textBox3;
        private TextBox TxtCorreoMinistro;
        private TextBox TxtHijosMinistro;
        private ComboBox CmbTipoDistritoMinistro;
        private ComboBox CmbTipoProvinciaMinistro;
        private TextBox TxtDireccionMinistro;
        private DateTimePicker DtpFechaIngresoADPMinistro;
        private TextBox TxtTiempoMinMinistro;
        private GroupBox Grupo03;
        private ComboBox CmbTipoConyugeCKMinistro;
        private DateTimePicker DtpFechaNacMinistro;
        private TextBox TxtMovil01Ministro;
        private TextBox TxtTelefonoMinistro;
        private ComboBox CmbTipoPastoreaMinistro;
        private ComboBox CmbGradoMinMinistro;
        private Button CmdRegion;
        private Button CmdProvincia;
        private Button CmdDistrito;
        private Button CmdConyuge;
        private Button CmdIglesia;
        private Button CmdGradoMinisterial;
        private TextBox TxtBuscarMinistro;
    }
}