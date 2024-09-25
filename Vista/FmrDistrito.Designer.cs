namespace Vista
{
    partial class FmrDistrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrDistrito));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            Grupo01 = new GroupBox();
            CmbTipoPaisDistrito = new ComboBox();
            TxtDistrito = new TextBox();
            CmbTipoRegionDistrito = new ComboBox();
            CmbTipoProvinciaDistrito = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            CmdCerrar = new PictureBox();
            label5 = new Label();
            DgvDistrito = new DataGridView();
            CmdReporteDistrito = new Button();
            CmdLimpiarDistrito = new Button();
            CmdEliminarDistrito = new Button();
            CmdActualizarDistrito = new Button();
            CmdNuevoDistrito = new Button();
            label6 = new Label();
            CmdPais = new Button();
            CmdRegion = new Button();
            CmdProvincia = new Button();
            Grupo01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvDistrito).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(387, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 29);
            label1.TabIndex = 127;
            label1.Text = "DISTRITO";
            // 
            // Grupo01
            // 
            Grupo01.Controls.Add(CmbTipoPaisDistrito);
            Grupo01.Controls.Add(TxtDistrito);
            Grupo01.Controls.Add(CmbTipoRegionDistrito);
            Grupo01.Controls.Add(CmbTipoProvinciaDistrito);
            Grupo01.Location = new Point(120, 66);
            Grupo01.Name = "Grupo01";
            Grupo01.Size = new Size(261, 133);
            Grupo01.TabIndex = 0;
            Grupo01.TabStop = false;
            // 
            // CmbTipoPaisDistrito
            // 
            CmbTipoPaisDistrito.Font = new Font("Open Sans", 9F);
            CmbTipoPaisDistrito.FormattingEnabled = true;
            CmbTipoPaisDistrito.Location = new Point(6, 15);
            CmbTipoPaisDistrito.Name = "CmbTipoPaisDistrito";
            CmbTipoPaisDistrito.Size = new Size(249, 25);
            CmbTipoPaisDistrito.TabIndex = 0;
            // 
            // TxtDistrito
            // 
            TxtDistrito.Font = new Font("Open Sans", 9F);
            TxtDistrito.Location = new Point(6, 103);
            TxtDistrito.Name = "TxtDistrito";
            TxtDistrito.Size = new Size(249, 24);
            TxtDistrito.TabIndex = 3;
            // 
            // CmbTipoRegionDistrito
            // 
            CmbTipoRegionDistrito.Font = new Font("Open Sans", 9F);
            CmbTipoRegionDistrito.FormattingEnabled = true;
            CmbTipoRegionDistrito.Location = new Point(6, 43);
            CmbTipoRegionDistrito.Name = "CmbTipoRegionDistrito";
            CmbTipoRegionDistrito.Size = new Size(249, 25);
            CmbTipoRegionDistrito.TabIndex = 1;
            // 
            // CmbTipoProvinciaDistrito
            // 
            CmbTipoProvinciaDistrito.Font = new Font("Open Sans", 9F);
            CmbTipoProvinciaDistrito.FormattingEnabled = true;
            CmbTipoProvinciaDistrito.Location = new Point(6, 72);
            CmbTipoProvinciaDistrito.Name = "CmbTipoProvinciaDistrito";
            CmbTipoProvinciaDistrito.Size = new Size(249, 25);
            CmbTipoProvinciaDistrito.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans", 9F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(22, 110);
            label3.Name = "label3";
            label3.Size = new Size(55, 17);
            label3.TabIndex = 142;
            label3.Text = "Region  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 80);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 143;
            label2.Text = "Pais :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Open Sans", 9F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(22, 140);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 144;
            label4.Text = "Provincia  :";
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
            CmdCerrar.TabIndex = 145;
            CmdCerrar.TabStop = false;
            CmdCerrar.Click += CmdCerrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Open Sans", 9F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(22, 170);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 146;
            label5.Text = "Distrito  :";
            // 
            // DgvDistrito
            // 
            DgvDistrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvDistrito.DefaultCellStyle = dataGridViewCellStyle2;
            DgvDistrito.Location = new Point(40, 281);
            DgvDistrito.Name = "DgvDistrito";
            DgvDistrito.Size = new Size(795, 251);
            DgvDistrito.TabIndex = 148;
            // 
            // CmdReporteDistrito
            // 
            CmdReporteDistrito.Cursor = Cursors.Hand;
            CmdReporteDistrito.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdReporteDistrito.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteDistrito.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteDistrito.FlatStyle = FlatStyle.Flat;
            CmdReporteDistrito.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdReporteDistrito.ForeColor = Color.Black;
            CmdReporteDistrito.Image = (Image)resources.GetObject("CmdReporteDistrito.Image");
            CmdReporteDistrito.ImageAlign = ContentAlignment.MiddleLeft;
            CmdReporteDistrito.Location = new Point(698, 218);
            CmdReporteDistrito.Name = "CmdReporteDistrito";
            CmdReporteDistrito.Size = new Size(159, 40);
            CmdReporteDistrito.TabIndex = 8;
            CmdReporteDistrito.Text = "REPORTE";
            CmdReporteDistrito.UseVisualStyleBackColor = true;
            // 
            // CmdLimpiarDistrito
            // 
            CmdLimpiarDistrito.Cursor = Cursors.Hand;
            CmdLimpiarDistrito.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarDistrito.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarDistrito.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarDistrito.FlatStyle = FlatStyle.Flat;
            CmdLimpiarDistrito.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdLimpiarDistrito.ForeColor = Color.Black;
            CmdLimpiarDistrito.Image = (Image)resources.GetObject("CmdLimpiarDistrito.Image");
            CmdLimpiarDistrito.ImageAlign = ContentAlignment.MiddleLeft;
            CmdLimpiarDistrito.Location = new Point(528, 218);
            CmdLimpiarDistrito.Name = "CmdLimpiarDistrito";
            CmdLimpiarDistrito.Size = new Size(159, 40);
            CmdLimpiarDistrito.TabIndex = 7;
            CmdLimpiarDistrito.Text = "LIMPIAR";
            CmdLimpiarDistrito.UseVisualStyleBackColor = true;
            // 
            // CmdEliminarDistrito
            // 
            CmdEliminarDistrito.Cursor = Cursors.Hand;
            CmdEliminarDistrito.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdEliminarDistrito.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarDistrito.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarDistrito.FlatStyle = FlatStyle.Flat;
            CmdEliminarDistrito.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdEliminarDistrito.ForeColor = Color.Black;
            CmdEliminarDistrito.Image = (Image)resources.GetObject("CmdEliminarDistrito.Image");
            CmdEliminarDistrito.ImageAlign = ContentAlignment.MiddleLeft;
            CmdEliminarDistrito.Location = new Point(358, 218);
            CmdEliminarDistrito.Name = "CmdEliminarDistrito";
            CmdEliminarDistrito.Size = new Size(159, 40);
            CmdEliminarDistrito.TabIndex = 6;
            CmdEliminarDistrito.Text = "ELIMINAR";
            CmdEliminarDistrito.UseVisualStyleBackColor = true;
            // 
            // CmdActualizarDistrito
            // 
            CmdActualizarDistrito.Cursor = Cursors.Hand;
            CmdActualizarDistrito.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdActualizarDistrito.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarDistrito.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarDistrito.FlatStyle = FlatStyle.Flat;
            CmdActualizarDistrito.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdActualizarDistrito.ForeColor = Color.Black;
            CmdActualizarDistrito.Image = (Image)resources.GetObject("CmdActualizarDistrito.Image");
            CmdActualizarDistrito.ImageAlign = ContentAlignment.MiddleLeft;
            CmdActualizarDistrito.Location = new Point(188, 218);
            CmdActualizarDistrito.Name = "CmdActualizarDistrito";
            CmdActualizarDistrito.Size = new Size(159, 40);
            CmdActualizarDistrito.TabIndex = 5;
            CmdActualizarDistrito.Text = "ACTUALIZAR";
            CmdActualizarDistrito.UseVisualStyleBackColor = true;
            // 
            // CmdNuevoDistrito
            // 
            CmdNuevoDistrito.Cursor = Cursors.Hand;
            CmdNuevoDistrito.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdNuevoDistrito.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoDistrito.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoDistrito.FlatStyle = FlatStyle.Flat;
            CmdNuevoDistrito.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdNuevoDistrito.ForeColor = Color.Black;
            CmdNuevoDistrito.Image = (Image)resources.GetObject("CmdNuevoDistrito.Image");
            CmdNuevoDistrito.ImageAlign = ContentAlignment.MiddleLeft;
            CmdNuevoDistrito.Location = new Point(22, 218);
            CmdNuevoDistrito.Name = "CmdNuevoDistrito";
            CmdNuevoDistrito.Size = new Size(159, 40);
            CmdNuevoDistrito.TabIndex = 4;
            CmdNuevoDistrito.Text = "NUEVO";
            CmdNuevoDistrito.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Open Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(22, 50);
            label6.Name = "label6";
            label6.Size = new Size(24, 17);
            label6.TabIndex = 154;
            label6.Text = "Id :";
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
            CmdPais.Location = new Point(387, 74);
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
            CmdRegion.Location = new Point(387, 107);
            CmdRegion.Name = "CmdRegion";
            CmdRegion.Size = new Size(31, 27);
            CmdRegion.TabIndex = 1;
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
            CmdProvincia.Location = new Point(387, 137);
            CmdProvincia.Name = "CmdProvincia";
            CmdProvincia.Size = new Size(31, 27);
            CmdProvincia.TabIndex = 2;
            CmdProvincia.TextAlign = ContentAlignment.MiddleRight;
            CmdProvincia.TextImageRelation = TextImageRelation.TextBeforeImage;
            CmdProvincia.UseVisualStyleBackColor = false;
            // 
            // FmrDistrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 565);
            Controls.Add(CmdProvincia);
            Controls.Add(CmdRegion);
            Controls.Add(CmdPais);
            Controls.Add(label6);
            Controls.Add(CmdReporteDistrito);
            Controls.Add(CmdLimpiarDistrito);
            Controls.Add(CmdEliminarDistrito);
            Controls.Add(CmdActualizarDistrito);
            Controls.Add(CmdNuevoDistrito);
            Controls.Add(DgvDistrito);
            Controls.Add(label5);
            Controls.Add(CmdCerrar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(Grupo01);
            Controls.Add(label1);
            Name = "FmrDistrito";
            Text = "FmrDistrito";
            Grupo01.ResumeLayout(false);
            Grupo01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvDistrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox Grupo01;
        private ComboBox CmbTipoProvinciaDistrito;
        private ComboBox CmbTipoPaisDistrito;
        private Label label3;
        private Label label2;
        private Label label4;
        private ComboBox CmbTipoRegionDistrito;
        private TextBox TxtDistrito;
        internal PictureBox CmdCerrar;
        private Label label5;
        private DataGridView DgvDistrito;
        private Button CmdReporteDistrito;
        private Button CmdLimpiarDistrito;
        private Button CmdEliminarDistrito;
        private Button CmdActualizarDistrito;
        private Button CmdNuevoDistrito;
        private Label label6;
        private Button CmdPais;
        private Button CmdRegion;
        private Button CmdProvincia;
    }
}