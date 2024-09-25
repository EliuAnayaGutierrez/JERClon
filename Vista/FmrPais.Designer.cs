namespace Vista
{
    partial class FmrPais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrPais));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            CmdCerrar = new PictureBox();
            label1 = new Label();
            DgvPais = new DataGridView();
            label2 = new Label();
            label4 = new Label();
            CmdReportePais = new Button();
            CmdLimpiarPais = new Button();
            CmdEliminarPais = new Button();
            CmdActualizarPais = new Button();
            CmdNuevoPais = new Button();
            Grupo01 = new GroupBox();
            TxtNombrePais = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvPais).BeginInit();
            Grupo01.SuspendLayout();
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
            CmdCerrar.TabIndex = 75;
            CmdCerrar.TabStop = false;
            CmdCerrar.Click += CmdCerrar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 29);
            label1.TabIndex = 77;
            label1.Text = "PAIS";
            // 
            // DgvPais
            // 
            DgvPais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvPais.DefaultCellStyle = dataGridViewCellStyle2;
            DgvPais.Location = new Point(40, 185);
            DgvPais.Name = "DgvPais";
            DgvPais.Size = new Size(795, 251);
            DgvPais.TabIndex = 97;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 9F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 80);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 98;
            label2.Text = "Pais : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Open Sans", 9F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(22, 50);
            label4.Name = "label4";
            label4.Size = new Size(27, 17);
            label4.TabIndex = 154;
            label4.Text = "Id : ";
            // 
            // CmdReportePais
            // 
            CmdReportePais.Cursor = Cursors.Hand;
            CmdReportePais.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdReportePais.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdReportePais.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdReportePais.FlatStyle = FlatStyle.Flat;
            CmdReportePais.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdReportePais.ForeColor = Color.Black;
            CmdReportePais.Image = (Image)resources.GetObject("CmdReportePais.Image");
            CmdReportePais.ImageAlign = ContentAlignment.MiddleLeft;
            CmdReportePais.Location = new Point(698, 123);
            CmdReportePais.Name = "CmdReportePais";
            CmdReportePais.Size = new Size(159, 40);
            CmdReportePais.TabIndex = 5;
            CmdReportePais.Text = "REPORTE";
            CmdReportePais.UseVisualStyleBackColor = true;
            // 
            // CmdLimpiarPais
            // 
            CmdLimpiarPais.Cursor = Cursors.Hand;
            CmdLimpiarPais.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarPais.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarPais.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarPais.FlatStyle = FlatStyle.Flat;
            CmdLimpiarPais.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdLimpiarPais.ForeColor = Color.Black;
            CmdLimpiarPais.Image = (Image)resources.GetObject("CmdLimpiarPais.Image");
            CmdLimpiarPais.ImageAlign = ContentAlignment.MiddleLeft;
            CmdLimpiarPais.Location = new Point(528, 123);
            CmdLimpiarPais.Name = "CmdLimpiarPais";
            CmdLimpiarPais.Size = new Size(159, 40);
            CmdLimpiarPais.TabIndex = 4;
            CmdLimpiarPais.Text = "LIMPIAR";
            CmdLimpiarPais.UseVisualStyleBackColor = true;
            // 
            // CmdEliminarPais
            // 
            CmdEliminarPais.Cursor = Cursors.Hand;
            CmdEliminarPais.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdEliminarPais.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarPais.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarPais.FlatStyle = FlatStyle.Flat;
            CmdEliminarPais.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdEliminarPais.ForeColor = Color.Black;
            CmdEliminarPais.Image = (Image)resources.GetObject("CmdEliminarPais.Image");
            CmdEliminarPais.ImageAlign = ContentAlignment.MiddleLeft;
            CmdEliminarPais.Location = new Point(358, 123);
            CmdEliminarPais.Name = "CmdEliminarPais";
            CmdEliminarPais.Size = new Size(159, 40);
            CmdEliminarPais.TabIndex = 3;
            CmdEliminarPais.Text = "ELIMINAR";
            CmdEliminarPais.UseVisualStyleBackColor = true;
            // 
            // CmdActualizarPais
            // 
            CmdActualizarPais.Cursor = Cursors.Hand;
            CmdActualizarPais.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdActualizarPais.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarPais.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarPais.FlatStyle = FlatStyle.Flat;
            CmdActualizarPais.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdActualizarPais.ForeColor = Color.Black;
            CmdActualizarPais.Image = (Image)resources.GetObject("CmdActualizarPais.Image");
            CmdActualizarPais.ImageAlign = ContentAlignment.MiddleLeft;
            CmdActualizarPais.Location = new Point(188, 123);
            CmdActualizarPais.Name = "CmdActualizarPais";
            CmdActualizarPais.Size = new Size(159, 40);
            CmdActualizarPais.TabIndex = 2;
            CmdActualizarPais.Text = "ACTUALIZAR";
            CmdActualizarPais.UseVisualStyleBackColor = true;
            // 
            // CmdNuevoPais
            // 
            CmdNuevoPais.Cursor = Cursors.Hand;
            CmdNuevoPais.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdNuevoPais.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoPais.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoPais.FlatStyle = FlatStyle.Flat;
            CmdNuevoPais.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdNuevoPais.ForeColor = Color.Black;
            CmdNuevoPais.Image = (Image)resources.GetObject("CmdNuevoPais.Image");
            CmdNuevoPais.ImageAlign = ContentAlignment.MiddleLeft;
            CmdNuevoPais.Location = new Point(22, 123);
            CmdNuevoPais.Name = "CmdNuevoPais";
            CmdNuevoPais.Size = new Size(159, 40);
            CmdNuevoPais.TabIndex = 1;
            CmdNuevoPais.Text = "NUEVO";
            CmdNuevoPais.UseVisualStyleBackColor = true;
            // 
            // Grupo01
            // 
            Grupo01.Controls.Add(TxtNombrePais);
            Grupo01.Location = new Point(94, 65);
            Grupo01.Name = "Grupo01";
            Grupo01.Size = new Size(252, 42);
            Grupo01.TabIndex = 0;
            Grupo01.TabStop = false;
            // 
            // TxtNombrePais
            // 
            TxtNombrePais.Location = new Point(6, 13);
            TxtNombrePais.Name = "TxtNombrePais";
            TxtNombrePais.Size = new Size(240, 23);
            TxtNombrePais.TabIndex = 0;
            // 
            // FmrPais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 465);
            Controls.Add(Grupo01);
            Controls.Add(CmdReportePais);
            Controls.Add(CmdLimpiarPais);
            Controls.Add(CmdEliminarPais);
            Controls.Add(CmdActualizarPais);
            Controls.Add(CmdNuevoPais);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(DgvPais);
            Controls.Add(label1);
            Controls.Add(CmdCerrar);
            Name = "FmrPais";
            Text = "Pais";
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvPais).EndInit();
            Grupo01.ResumeLayout(false);
            Grupo01.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal PictureBox CmdCerrar;
        private Label label1;
        private DataGridView DgvPais;
        private Label label2;
        private Label label4;
        private Button CmdReportePais;
        private Button CmdLimpiarPais;
        private Button CmdEliminarPais;
        private Button CmdActualizarPais;
        private Button CmdNuevoPais;
        private GroupBox Grupo01;
        private TextBox TxtNombrePais;
    }
}