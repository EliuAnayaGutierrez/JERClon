namespace Vista
{
    partial class FmrSector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrSector));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            CmdCerrar = new PictureBox();
            label3 = new Label();
            DgvSector = new DataGridView();
            CmdReporteSector = new Button();
            CmdLimpiarSector = new Button();
            CmdEliminarSector = new Button();
            CmdActualizarSector = new Button();
            CmdNuevoSector = new Button();
            label2 = new Label();
            Grupo01 = new GroupBox();
            TxtNombreSector = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvSector).BeginInit();
            Grupo01.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 29);
            label1.TabIndex = 103;
            label1.Text = "SECTOR";
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
            CmdCerrar.TabIndex = 104;
            CmdCerrar.TabStop = false;
            CmdCerrar.Click += CmdCerrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans", 9F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(22, 80);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 105;
            label3.Text = "Sector :";
            // 
            // DgvSector
            // 
            DgvSector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DgvSector.DefaultCellStyle = dataGridViewCellStyle1;
            DgvSector.Location = new Point(40, 183);
            DgvSector.Name = "DgvSector";
            DgvSector.Size = new Size(795, 251);
            DgvSector.TabIndex = 111;
            // 
            // CmdReporteSector
            // 
            CmdReporteSector.Cursor = Cursors.Hand;
            CmdReporteSector.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdReporteSector.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteSector.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteSector.FlatStyle = FlatStyle.Flat;
            CmdReporteSector.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdReporteSector.ForeColor = Color.Black;
            CmdReporteSector.Image = (Image)resources.GetObject("CmdReporteSector.Image");
            CmdReporteSector.ImageAlign = ContentAlignment.MiddleLeft;
            CmdReporteSector.Location = new Point(698, 122);
            CmdReporteSector.Name = "CmdReporteSector";
            CmdReporteSector.Size = new Size(159, 40);
            CmdReporteSector.TabIndex = 5;
            CmdReporteSector.Text = "REPORTE";
            CmdReporteSector.UseVisualStyleBackColor = true;
            // 
            // CmdLimpiarSector
            // 
            CmdLimpiarSector.Cursor = Cursors.Hand;
            CmdLimpiarSector.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarSector.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarSector.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarSector.FlatStyle = FlatStyle.Flat;
            CmdLimpiarSector.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdLimpiarSector.ForeColor = Color.Black;
            CmdLimpiarSector.Image = (Image)resources.GetObject("CmdLimpiarSector.Image");
            CmdLimpiarSector.ImageAlign = ContentAlignment.MiddleLeft;
            CmdLimpiarSector.Location = new Point(528, 122);
            CmdLimpiarSector.Name = "CmdLimpiarSector";
            CmdLimpiarSector.Size = new Size(159, 40);
            CmdLimpiarSector.TabIndex = 4;
            CmdLimpiarSector.Text = "LIMPIAR";
            CmdLimpiarSector.UseVisualStyleBackColor = true;
            // 
            // CmdEliminarSector
            // 
            CmdEliminarSector.Cursor = Cursors.Hand;
            CmdEliminarSector.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdEliminarSector.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarSector.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarSector.FlatStyle = FlatStyle.Flat;
            CmdEliminarSector.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdEliminarSector.ForeColor = Color.Black;
            CmdEliminarSector.Image = (Image)resources.GetObject("CmdEliminarSector.Image");
            CmdEliminarSector.ImageAlign = ContentAlignment.MiddleLeft;
            CmdEliminarSector.Location = new Point(358, 122);
            CmdEliminarSector.Name = "CmdEliminarSector";
            CmdEliminarSector.Size = new Size(159, 40);
            CmdEliminarSector.TabIndex = 3;
            CmdEliminarSector.Text = "ELIMINAR";
            CmdEliminarSector.UseVisualStyleBackColor = true;
            // 
            // CmdActualizarSector
            // 
            CmdActualizarSector.Cursor = Cursors.Hand;
            CmdActualizarSector.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdActualizarSector.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarSector.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarSector.FlatStyle = FlatStyle.Flat;
            CmdActualizarSector.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdActualizarSector.ForeColor = Color.Black;
            CmdActualizarSector.Image = (Image)resources.GetObject("CmdActualizarSector.Image");
            CmdActualizarSector.ImageAlign = ContentAlignment.MiddleLeft;
            CmdActualizarSector.Location = new Point(188, 122);
            CmdActualizarSector.Name = "CmdActualizarSector";
            CmdActualizarSector.Size = new Size(159, 40);
            CmdActualizarSector.TabIndex = 2;
            CmdActualizarSector.Text = "ACTUALIZAR";
            CmdActualizarSector.UseVisualStyleBackColor = true;
            // 
            // CmdNuevoSector
            // 
            CmdNuevoSector.Cursor = Cursors.Hand;
            CmdNuevoSector.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdNuevoSector.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoSector.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoSector.FlatStyle = FlatStyle.Flat;
            CmdNuevoSector.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdNuevoSector.ForeColor = Color.Black;
            CmdNuevoSector.Image = (Image)resources.GetObject("CmdNuevoSector.Image");
            CmdNuevoSector.ImageAlign = ContentAlignment.MiddleLeft;
            CmdNuevoSector.Location = new Point(22, 122);
            CmdNuevoSector.Name = "CmdNuevoSector";
            CmdNuevoSector.Size = new Size(159, 40);
            CmdNuevoSector.TabIndex = 1;
            CmdNuevoSector.Text = "NUEVO";
            CmdNuevoSector.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 9F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 50);
            label2.Name = "label2";
            label2.Size = new Size(24, 17);
            label2.TabIndex = 176;
            label2.Text = "Id :";
            // 
            // Grupo01
            // 
            Grupo01.Controls.Add(TxtNombreSector);
            Grupo01.Location = new Point(95, 65);
            Grupo01.Name = "Grupo01";
            Grupo01.Size = new Size(252, 42);
            Grupo01.TabIndex = 0;
            Grupo01.TabStop = false;
            // 
            // TxtNombreSector
            // 
            TxtNombreSector.Location = new Point(6, 13);
            TxtNombreSector.Name = "TxtNombreSector";
            TxtNombreSector.Size = new Size(240, 23);
            TxtNombreSector.TabIndex = 0;
            // 
            // FmrSector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 446);
            Controls.Add(Grupo01);
            Controls.Add(label2);
            Controls.Add(CmdReporteSector);
            Controls.Add(CmdLimpiarSector);
            Controls.Add(CmdEliminarSector);
            Controls.Add(CmdActualizarSector);
            Controls.Add(CmdNuevoSector);
            Controls.Add(DgvSector);
            Controls.Add(label3);
            Controls.Add(CmdCerrar);
            Controls.Add(label1);
            Name = "FmrSector";
            Text = "FmrSector";
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvSector).EndInit();
            Grupo01.ResumeLayout(false);
            Grupo01.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        internal PictureBox CmdCerrar;
        private Label label3;
        private DataGridView DgvSector;
        private Button CmdReporteSector;
        private Button CmdLimpiarSector;
        private Button CmdEliminarSector;
        private Button CmdActualizarSector;
        private Button CmdNuevoSector;
        private Label label2;
        private GroupBox Grupo01;
        private TextBox TxtNombreSector;
    }
}