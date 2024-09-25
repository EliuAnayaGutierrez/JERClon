namespace Vista
{
    partial class FmrIglesia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrIglesia));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            CmdCerrar = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Grupo01 = new GroupBox();
            TxtDireccionIglesia = new TextBox();
            TxtNombreIglesia = new TextBox();
            CmbTipoDistritoIglesia = new ComboBox();
            DgvIglesia = new DataGridView();
            label7 = new Label();
            CmdReporteIglesia = new Button();
            CmdLimpiarIglesia = new Button();
            CmdEliminarIglesia = new Button();
            CmdActualizarIglesia = new Button();
            CmdNuevoIglesia = new Button();
            CmdDistrito = new Button();
            CmdSector = new Button();
            Grupo02 = new GroupBox();
            CmbTipoSectorIglesia = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).BeginInit();
            Grupo01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvIglesia).BeginInit();
            Grupo02.SuspendLayout();
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
            CmdCerrar.TabIndex = 110;
            CmdCerrar.TabStop = false;
            CmdCerrar.Click += CmdCerrar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 29);
            label1.TabIndex = 109;
            label1.Text = "IGLESIA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Open Sans", 9F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(22, 80);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 122;
            label5.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 9F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 110);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 123;
            label2.Text = "Distrito :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans", 9F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(22, 140);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 124;
            label3.Text = "Direccion :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Open Sans", 9F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(427, 110);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 125;
            label4.Text = "Sector :";
            // 
            // Grupo01
            // 
            Grupo01.Controls.Add(TxtDireccionIglesia);
            Grupo01.Controls.Add(TxtNombreIglesia);
            Grupo01.Controls.Add(CmbTipoDistritoIglesia);
            Grupo01.Location = new Point(109, 68);
            Grupo01.Name = "Grupo01";
            Grupo01.Size = new Size(238, 102);
            Grupo01.TabIndex = 0;
            Grupo01.TabStop = false;
            // 
            // TxtDireccionIglesia
            // 
            TxtDireccionIglesia.Font = new Font("Open Sans", 9F);
            TxtDireccionIglesia.Location = new Point(6, 72);
            TxtDireccionIglesia.Name = "TxtDireccionIglesia";
            TxtDireccionIglesia.Size = new Size(226, 24);
            TxtDireccionIglesia.TabIndex = 3;
            // 
            // TxtNombreIglesia
            // 
            TxtNombreIglesia.Font = new Font("Open Sans", 9F);
            TxtNombreIglesia.Location = new Point(6, 12);
            TxtNombreIglesia.Name = "TxtNombreIglesia";
            TxtNombreIglesia.Size = new Size(226, 24);
            TxtNombreIglesia.TabIndex = 1;
            // 
            // CmbTipoDistritoIglesia
            // 
            CmbTipoDistritoIglesia.Font = new Font("Open Sans", 9F);
            CmbTipoDistritoIglesia.FormattingEnabled = true;
            CmbTipoDistritoIglesia.Location = new Point(6, 40);
            CmbTipoDistritoIglesia.Name = "CmbTipoDistritoIglesia";
            CmbTipoDistritoIglesia.Size = new Size(226, 25);
            CmbTipoDistritoIglesia.TabIndex = 2;
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
            DgvIglesia.Location = new Point(40, 257);
            DgvIglesia.Name = "DgvIglesia";
            DgvIglesia.Size = new Size(813, 222);
            DgvIglesia.TabIndex = 149;
            // 
            // label7
            // 
            label7.Font = new Font("Open Sans", 9F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(22, 50);
            label7.Name = "label7";
            label7.Size = new Size(70, 16);
            label7.TabIndex = 150;
            label7.Text = "Id :";
            // 
            // CmdReporteIglesia
            // 
            CmdReporteIglesia.Cursor = Cursors.Hand;
            CmdReporteIglesia.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdReporteIglesia.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteIglesia.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteIglesia.FlatStyle = FlatStyle.Flat;
            CmdReporteIglesia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdReporteIglesia.ForeColor = Color.Black;
            CmdReporteIglesia.Image = (Image)resources.GetObject("CmdReporteIglesia.Image");
            CmdReporteIglesia.ImageAlign = ContentAlignment.MiddleLeft;
            CmdReporteIglesia.Location = new Point(698, 192);
            CmdReporteIglesia.Name = "CmdReporteIglesia";
            CmdReporteIglesia.Size = new Size(159, 40);
            CmdReporteIglesia.TabIndex = 9;
            CmdReporteIglesia.Text = "REPORTE";
            CmdReporteIglesia.UseVisualStyleBackColor = true;
            // 
            // CmdLimpiarIglesia
            // 
            CmdLimpiarIglesia.Cursor = Cursors.Hand;
            CmdLimpiarIglesia.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarIglesia.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarIglesia.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarIglesia.FlatStyle = FlatStyle.Flat;
            CmdLimpiarIglesia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdLimpiarIglesia.ForeColor = Color.Black;
            CmdLimpiarIglesia.Image = (Image)resources.GetObject("CmdLimpiarIglesia.Image");
            CmdLimpiarIglesia.ImageAlign = ContentAlignment.MiddleLeft;
            CmdLimpiarIglesia.Location = new Point(528, 192);
            CmdLimpiarIglesia.Name = "CmdLimpiarIglesia";
            CmdLimpiarIglesia.Size = new Size(159, 40);
            CmdLimpiarIglesia.TabIndex = 8;
            CmdLimpiarIglesia.Text = "LIMPIAR";
            CmdLimpiarIglesia.UseVisualStyleBackColor = true;
            // 
            // CmdEliminarIglesia
            // 
            CmdEliminarIglesia.Cursor = Cursors.Hand;
            CmdEliminarIglesia.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdEliminarIglesia.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarIglesia.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarIglesia.FlatStyle = FlatStyle.Flat;
            CmdEliminarIglesia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdEliminarIglesia.ForeColor = Color.Black;
            CmdEliminarIglesia.Image = (Image)resources.GetObject("CmdEliminarIglesia.Image");
            CmdEliminarIglesia.ImageAlign = ContentAlignment.MiddleLeft;
            CmdEliminarIglesia.Location = new Point(358, 192);
            CmdEliminarIglesia.Name = "CmdEliminarIglesia";
            CmdEliminarIglesia.Size = new Size(159, 40);
            CmdEliminarIglesia.TabIndex = 7;
            CmdEliminarIglesia.Text = "ELIMINAR";
            CmdEliminarIglesia.UseVisualStyleBackColor = true;
            // 
            // CmdActualizarIglesia
            // 
            CmdActualizarIglesia.Cursor = Cursors.Hand;
            CmdActualizarIglesia.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdActualizarIglesia.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarIglesia.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarIglesia.FlatStyle = FlatStyle.Flat;
            CmdActualizarIglesia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdActualizarIglesia.ForeColor = Color.Black;
            CmdActualizarIglesia.Image = (Image)resources.GetObject("CmdActualizarIglesia.Image");
            CmdActualizarIglesia.ImageAlign = ContentAlignment.MiddleLeft;
            CmdActualizarIglesia.Location = new Point(188, 192);
            CmdActualizarIglesia.Name = "CmdActualizarIglesia";
            CmdActualizarIglesia.Size = new Size(159, 40);
            CmdActualizarIglesia.TabIndex = 6;
            CmdActualizarIglesia.Text = "ACTUALIZAR";
            CmdActualizarIglesia.UseVisualStyleBackColor = true;
            // 
            // CmdNuevoIglesia
            // 
            CmdNuevoIglesia.Cursor = Cursors.Hand;
            CmdNuevoIglesia.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdNuevoIglesia.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoIglesia.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoIglesia.FlatStyle = FlatStyle.Flat;
            CmdNuevoIglesia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdNuevoIglesia.ForeColor = Color.Black;
            CmdNuevoIglesia.Image = (Image)resources.GetObject("CmdNuevoIglesia.Image");
            CmdNuevoIglesia.ImageAlign = ContentAlignment.MiddleLeft;
            CmdNuevoIglesia.Location = new Point(22, 192);
            CmdNuevoIglesia.Name = "CmdNuevoIglesia";
            CmdNuevoIglesia.Size = new Size(159, 40);
            CmdNuevoIglesia.TabIndex = 5;
            CmdNuevoIglesia.Text = "NUEVO";
            CmdNuevoIglesia.UseVisualStyleBackColor = true;
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
            CmdDistrito.Location = new Point(353, 107);
            CmdDistrito.Name = "CmdDistrito";
            CmdDistrito.Size = new Size(31, 27);
            CmdDistrito.TabIndex = 2;
            CmdDistrito.TextAlign = ContentAlignment.MiddleRight;
            CmdDistrito.TextImageRelation = TextImageRelation.TextBeforeImage;
            CmdDistrito.UseVisualStyleBackColor = false;
            // 
            // CmdSector
            // 
            CmdSector.BackColor = Color.Transparent;
            CmdSector.BackgroundImage = (Image)resources.GetObject("CmdSector.BackgroundImage");
            CmdSector.BackgroundImageLayout = ImageLayout.Zoom;
            CmdSector.Cursor = Cursors.Hand;
            CmdSector.FlatAppearance.BorderColor = Color.White;
            CmdSector.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CmdSector.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CmdSector.FlatStyle = FlatStyle.Flat;
            CmdSector.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdSector.ForeColor = Color.Transparent;
            CmdSector.Location = new Point(733, 103);
            CmdSector.Name = "CmdSector";
            CmdSector.Size = new Size(31, 27);
            CmdSector.TabIndex = 4;
            CmdSector.TextAlign = ContentAlignment.MiddleRight;
            CmdSector.TextImageRelation = TextImageRelation.TextBeforeImage;
            CmdSector.UseVisualStyleBackColor = false;
            // 
            // Grupo02
            // 
            Grupo02.Controls.Add(CmbTipoSectorIglesia);
            Grupo02.Location = new Point(475, 92);
            Grupo02.Name = "Grupo02";
            Grupo02.Size = new Size(252, 42);
            Grupo02.TabIndex = 4;
            Grupo02.TabStop = false;
            // 
            // CmbTipoSectorIglesia
            // 
            CmbTipoSectorIglesia.Font = new Font("Open Sans", 9F);
            CmbTipoSectorIglesia.FormattingEnabled = true;
            CmbTipoSectorIglesia.Location = new Point(8, 11);
            CmbTipoSectorIglesia.Name = "CmbTipoSectorIglesia";
            CmbTipoSectorIglesia.Size = new Size(238, 25);
            CmbTipoSectorIglesia.TabIndex = 4;
            // 
            // FmrIglesia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 502);
            Controls.Add(Grupo02);
            Controls.Add(CmdSector);
            Controls.Add(CmdDistrito);
            Controls.Add(CmdReporteIglesia);
            Controls.Add(CmdLimpiarIglesia);
            Controls.Add(CmdEliminarIglesia);
            Controls.Add(CmdActualizarIglesia);
            Controls.Add(CmdNuevoIglesia);
            Controls.Add(label7);
            Controls.Add(DgvIglesia);
            Controls.Add(Grupo01);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(CmdCerrar);
            Controls.Add(label1);
            Name = "FmrIglesia";
            Text = "FmrIglesia";
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).EndInit();
            Grupo01.ResumeLayout(false);
            Grupo01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvIglesia).EndInit();
            Grupo02.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal PictureBox CmdCerrar;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox Grupo01;
        private TextBox TxtDireccionIglesia;
        private ComboBox CmbTipoDistritoIglesia;
        private TextBox TxtNombreIglesia;
        private DataGridView DgvIglesia;
        private Label label7;
        private Button CmdReporteIglesia;
        private Button CmdLimpiarIglesia;
        private Button CmdEliminarIglesia;
        private Button CmdActualizarIglesia;
        private Button CmdNuevoIglesia;
        private Button CmdDistrito;
        private Button CmdSector;
        private GroupBox Grupo02;
        private ComboBox CmbTipoSectorIglesia;
    }
}