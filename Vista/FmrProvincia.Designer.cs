namespace Vista
{
    partial class FmrProvincia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrProvincia));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            CmdCerrar = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            CmbTipoPaisProvincia = new ComboBox();
            CmbTipoRegionProvincia = new ComboBox();
            Grupo01 = new GroupBox();
            TxtNombreProvincia = new TextBox();
            DgvProvincia = new DataGridView();
            label5 = new Label();
            CmdReporteProvincia = new Button();
            CmdLimpiarProvincia = new Button();
            CmdEliminarProvincia = new Button();
            CmdActualizarProvincia = new Button();
            CmdNuevoProvincia = new Button();
            CmdPais = new Button();
            CmdRegion = new Button();
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).BeginInit();
            Grupo01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProvincia).BeginInit();
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
            CmdCerrar.TabIndex = 79;
            CmdCerrar.TabStop = false;
            CmdCerrar.Click += CmdCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 9F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 140);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 101;
            label2.Text = "Provincia";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(323, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 29);
            label1.TabIndex = 102;
            label1.Text = "PROVINCIA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans", 9F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(23, 80);
            label3.Name = "label3";
            label3.Size = new Size(40, 17);
            label3.TabIndex = 103;
            label3.Text = "Pais : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Open Sans", 9F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(23, 110);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 104;
            label4.Text = "Region : ";
            // 
            // CmbTipoPaisProvincia
            // 
            CmbTipoPaisProvincia.Font = new Font("Open Sans", 9F);
            CmbTipoPaisProvincia.FormattingEnabled = true;
            CmbTipoPaisProvincia.Location = new Point(11, 15);
            CmbTipoPaisProvincia.Name = "CmbTipoPaisProvincia";
            CmbTipoPaisProvincia.Size = new Size(246, 25);
            CmbTipoPaisProvincia.TabIndex = 0;
            // 
            // CmbTipoRegionProvincia
            // 
            CmbTipoRegionProvincia.Font = new Font("Open Sans", 9F);
            CmbTipoRegionProvincia.FormattingEnabled = true;
            CmbTipoRegionProvincia.Location = new Point(11, 44);
            CmbTipoRegionProvincia.Name = "CmbTipoRegionProvincia";
            CmbTipoRegionProvincia.Size = new Size(246, 25);
            CmbTipoRegionProvincia.TabIndex = 1;
            // 
            // Grupo01
            // 
            Grupo01.Controls.Add(TxtNombreProvincia);
            Grupo01.Controls.Add(CmbTipoPaisProvincia);
            Grupo01.Controls.Add(CmbTipoRegionProvincia);
            Grupo01.Location = new Point(144, 63);
            Grupo01.Name = "Grupo01";
            Grupo01.Size = new Size(263, 101);
            Grupo01.TabIndex = 0;
            Grupo01.TabStop = false;
            // 
            // TxtNombreProvincia
            // 
            TxtNombreProvincia.Font = new Font("Open Sans", 9F);
            TxtNombreProvincia.Location = new Point(11, 71);
            TxtNombreProvincia.Name = "TxtNombreProvincia";
            TxtNombreProvincia.Size = new Size(246, 24);
            TxtNombreProvincia.TabIndex = 2;
            // 
            // DgvProvincia
            // 
            DgvProvincia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvProvincia.DefaultCellStyle = dataGridViewCellStyle2;
            DgvProvincia.Location = new Point(40, 256);
            DgvProvincia.Name = "DgvProvincia";
            DgvProvincia.Size = new Size(734, 283);
            DgvProvincia.TabIndex = 116;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Open Sans", 9F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(22, 50);
            label5.Name = "label5";
            label5.Size = new Size(27, 17);
            label5.TabIndex = 117;
            label5.Text = "Id : ";
            // 
            // CmdReporteProvincia
            // 
            CmdReporteProvincia.Cursor = Cursors.Hand;
            CmdReporteProvincia.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdReporteProvincia.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteProvincia.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteProvincia.FlatStyle = FlatStyle.Flat;
            CmdReporteProvincia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdReporteProvincia.ForeColor = Color.Black;
            CmdReporteProvincia.Image = (Image)resources.GetObject("CmdReporteProvincia.Image");
            CmdReporteProvincia.ImageAlign = ContentAlignment.MiddleLeft;
            CmdReporteProvincia.Location = new Point(698, 191);
            CmdReporteProvincia.Name = "CmdReporteProvincia";
            CmdReporteProvincia.Size = new Size(159, 40);
            CmdReporteProvincia.TabIndex = 7;
            CmdReporteProvincia.Text = "REPORTE";
            CmdReporteProvincia.UseVisualStyleBackColor = true;
            // 
            // CmdLimpiarProvincia
            // 
            CmdLimpiarProvincia.Cursor = Cursors.Hand;
            CmdLimpiarProvincia.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarProvincia.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarProvincia.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarProvincia.FlatStyle = FlatStyle.Flat;
            CmdLimpiarProvincia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdLimpiarProvincia.ForeColor = Color.Black;
            CmdLimpiarProvincia.Image = (Image)resources.GetObject("CmdLimpiarProvincia.Image");
            CmdLimpiarProvincia.ImageAlign = ContentAlignment.MiddleLeft;
            CmdLimpiarProvincia.Location = new Point(528, 191);
            CmdLimpiarProvincia.Name = "CmdLimpiarProvincia";
            CmdLimpiarProvincia.Size = new Size(159, 40);
            CmdLimpiarProvincia.TabIndex = 6;
            CmdLimpiarProvincia.Text = "LIMPIAR";
            CmdLimpiarProvincia.UseVisualStyleBackColor = true;
            // 
            // CmdEliminarProvincia
            // 
            CmdEliminarProvincia.Cursor = Cursors.Hand;
            CmdEliminarProvincia.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdEliminarProvincia.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarProvincia.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarProvincia.FlatStyle = FlatStyle.Flat;
            CmdEliminarProvincia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdEliminarProvincia.ForeColor = Color.Black;
            CmdEliminarProvincia.Image = (Image)resources.GetObject("CmdEliminarProvincia.Image");
            CmdEliminarProvincia.ImageAlign = ContentAlignment.MiddleLeft;
            CmdEliminarProvincia.Location = new Point(358, 191);
            CmdEliminarProvincia.Name = "CmdEliminarProvincia";
            CmdEliminarProvincia.Size = new Size(159, 40);
            CmdEliminarProvincia.TabIndex = 5;
            CmdEliminarProvincia.Text = "ELIMINAR";
            CmdEliminarProvincia.UseVisualStyleBackColor = true;
            // 
            // CmdActualizarProvincia
            // 
            CmdActualizarProvincia.Cursor = Cursors.Hand;
            CmdActualizarProvincia.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdActualizarProvincia.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarProvincia.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarProvincia.FlatStyle = FlatStyle.Flat;
            CmdActualizarProvincia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdActualizarProvincia.ForeColor = Color.Black;
            CmdActualizarProvincia.Image = (Image)resources.GetObject("CmdActualizarProvincia.Image");
            CmdActualizarProvincia.ImageAlign = ContentAlignment.MiddleLeft;
            CmdActualizarProvincia.Location = new Point(188, 191);
            CmdActualizarProvincia.Name = "CmdActualizarProvincia";
            CmdActualizarProvincia.Size = new Size(159, 40);
            CmdActualizarProvincia.TabIndex = 4;
            CmdActualizarProvincia.Text = "ACTUALIZAR";
            CmdActualizarProvincia.UseVisualStyleBackColor = true;
            // 
            // CmdNuevoProvincia
            // 
            CmdNuevoProvincia.Cursor = Cursors.Hand;
            CmdNuevoProvincia.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdNuevoProvincia.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoProvincia.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoProvincia.FlatStyle = FlatStyle.Flat;
            CmdNuevoProvincia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdNuevoProvincia.ForeColor = Color.Black;
            CmdNuevoProvincia.Image = (Image)resources.GetObject("CmdNuevoProvincia.Image");
            CmdNuevoProvincia.ImageAlign = ContentAlignment.MiddleLeft;
            CmdNuevoProvincia.Location = new Point(22, 191);
            CmdNuevoProvincia.Name = "CmdNuevoProvincia";
            CmdNuevoProvincia.Size = new Size(159, 40);
            CmdNuevoProvincia.TabIndex = 3;
            CmdNuevoProvincia.Text = "NUEVO";
            CmdNuevoProvincia.UseVisualStyleBackColor = true;
            // 
            // CmdPais
            // 
            CmdPais.BackColor = Color.Transparent;
            CmdPais.BackgroundImage = (Image)resources.GetObject("CmdPais.BackgroundImage");
            CmdPais.BackgroundImageLayout = ImageLayout.Zoom;
            CmdPais.Cursor = Cursors.Hand;
            CmdPais.FlatAppearance.BorderColor = Color.White;
            CmdPais.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CmdPais.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CmdPais.FlatStyle = FlatStyle.Flat;
            CmdPais.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdPais.ForeColor = Color.Transparent;
            CmdPais.Location = new Point(409, 76);
            CmdPais.Name = "CmdPais";
            CmdPais.Size = new Size(31, 27);
            CmdPais.TabIndex = 0;
            CmdPais.TextAlign = ContentAlignment.MiddleRight;
            CmdPais.TextImageRelation = TextImageRelation.TextBeforeImage;
            CmdPais.UseVisualStyleBackColor = false;
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
            CmdRegion.Location = new Point(410, 109);
            CmdRegion.Name = "CmdRegion";
            CmdRegion.Size = new Size(31, 27);
            CmdRegion.TabIndex = 1;
            CmdRegion.TextAlign = ContentAlignment.MiddleRight;
            CmdRegion.TextImageRelation = TextImageRelation.TextBeforeImage;
            CmdRegion.UseVisualStyleBackColor = false;
            // 
            // FmrProvincia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 554);
            Controls.Add(CmdRegion);
            Controls.Add(CmdPais);
            Controls.Add(CmdReporteProvincia);
            Controls.Add(CmdLimpiarProvincia);
            Controls.Add(CmdEliminarProvincia);
            Controls.Add(CmdActualizarProvincia);
            Controls.Add(CmdNuevoProvincia);
            Controls.Add(label5);
            Controls.Add(DgvProvincia);
            Controls.Add(Grupo01);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(CmdCerrar);
            Name = "FmrProvincia";
            Text = "FmrProvincia";
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).EndInit();
            Grupo01.ResumeLayout(false);
            Grupo01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProvincia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal PictureBox CmdCerrar;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox CmbTipoPaisProvincia;
        private ComboBox CmbTipoRegionProvincia;
        private GroupBox Grupo01;
        private TextBox TxtNombreProvincia;
        private DataGridView DgvProvincia;
        private Label label5;
        private Button CmdReporteProvincia;
        private Button CmdLimpiarProvincia;
        private Button CmdEliminarProvincia;
        private Button CmdActualizarProvincia;
        private Button CmdNuevoProvincia;
        private Button CmdPais;
        private Button CmdRegion;
    }
}