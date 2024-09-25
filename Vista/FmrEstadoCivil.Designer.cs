namespace Vista
{
    partial class FmrEstadoCivil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrEstadoCivil));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            CmdCerrar = new PictureBox();
            label1 = new Label();
            DgvEstadoCivil = new DataGridView();
            label3 = new Label();
            CmdReporteEstadoCivil = new Button();
            CmdLimpiarEstadoCivil = new Button();
            CmdEliminarEstadoCivil = new Button();
            CmdActualizarEstadoCivil = new Button();
            CmdNuevoEstadoCivil = new Button();
            label2 = new Label();
            Grupo01 = new GroupBox();
            TxtNombrePais = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvEstadoCivil).BeginInit();
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
            CmdCerrar.TabIndex = 105;
            CmdCerrar.TabStop = false;
            CmdCerrar.Click += CmdCerrar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 29);
            label1.TabIndex = 106;
            label1.Text = "ESTADO CIVIL";
            // 
            // DgvEstadoCivil
            // 
            DgvEstadoCivil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DgvEstadoCivil.DefaultCellStyle = dataGridViewCellStyle1;
            DgvEstadoCivil.Location = new Point(40, 180);
            DgvEstadoCivil.Name = "DgvEstadoCivil";
            DgvEstadoCivil.Size = new Size(795, 251);
            DgvEstadoCivil.TabIndex = 120;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans", 9F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(22, 80);
            label3.Name = "label3";
            label3.Size = new Size(76, 17);
            label3.TabIndex = 117;
            label3.Text = "Estado civil :";
            // 
            // CmdReporteEstadoCivil
            // 
            CmdReporteEstadoCivil.Cursor = Cursors.Hand;
            CmdReporteEstadoCivil.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdReporteEstadoCivil.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteEstadoCivil.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteEstadoCivil.FlatStyle = FlatStyle.Flat;
            CmdReporteEstadoCivil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdReporteEstadoCivil.ForeColor = Color.Black;
            CmdReporteEstadoCivil.Image = (Image)resources.GetObject("CmdReporteEstadoCivil.Image");
            CmdReporteEstadoCivil.ImageAlign = ContentAlignment.MiddleLeft;
            CmdReporteEstadoCivil.Location = new Point(698, 124);
            CmdReporteEstadoCivil.Name = "CmdReporteEstadoCivil";
            CmdReporteEstadoCivil.Size = new Size(159, 40);
            CmdReporteEstadoCivil.TabIndex = 5;
            CmdReporteEstadoCivil.Text = "REPORTE";
            CmdReporteEstadoCivil.UseVisualStyleBackColor = true;
            // 
            // CmdLimpiarEstadoCivil
            // 
            CmdLimpiarEstadoCivil.Cursor = Cursors.Hand;
            CmdLimpiarEstadoCivil.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarEstadoCivil.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarEstadoCivil.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarEstadoCivil.FlatStyle = FlatStyle.Flat;
            CmdLimpiarEstadoCivil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdLimpiarEstadoCivil.ForeColor = Color.Black;
            CmdLimpiarEstadoCivil.Image = (Image)resources.GetObject("CmdLimpiarEstadoCivil.Image");
            CmdLimpiarEstadoCivil.ImageAlign = ContentAlignment.MiddleLeft;
            CmdLimpiarEstadoCivil.Location = new Point(528, 124);
            CmdLimpiarEstadoCivil.Name = "CmdLimpiarEstadoCivil";
            CmdLimpiarEstadoCivil.Size = new Size(159, 40);
            CmdLimpiarEstadoCivil.TabIndex = 4;
            CmdLimpiarEstadoCivil.Text = "LIMPIAR";
            CmdLimpiarEstadoCivil.UseVisualStyleBackColor = true;
            // 
            // CmdEliminarEstadoCivil
            // 
            CmdEliminarEstadoCivil.Cursor = Cursors.Hand;
            CmdEliminarEstadoCivil.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdEliminarEstadoCivil.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarEstadoCivil.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarEstadoCivil.FlatStyle = FlatStyle.Flat;
            CmdEliminarEstadoCivil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdEliminarEstadoCivil.ForeColor = Color.Black;
            CmdEliminarEstadoCivil.Image = (Image)resources.GetObject("CmdEliminarEstadoCivil.Image");
            CmdEliminarEstadoCivil.ImageAlign = ContentAlignment.MiddleLeft;
            CmdEliminarEstadoCivil.Location = new Point(358, 124);
            CmdEliminarEstadoCivil.Name = "CmdEliminarEstadoCivil";
            CmdEliminarEstadoCivil.Size = new Size(159, 40);
            CmdEliminarEstadoCivil.TabIndex = 3;
            CmdEliminarEstadoCivil.Text = "ELIMINAR";
            CmdEliminarEstadoCivil.UseVisualStyleBackColor = true;
            // 
            // CmdActualizarEstadoCivil
            // 
            CmdActualizarEstadoCivil.Cursor = Cursors.Hand;
            CmdActualizarEstadoCivil.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdActualizarEstadoCivil.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarEstadoCivil.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarEstadoCivil.FlatStyle = FlatStyle.Flat;
            CmdActualizarEstadoCivil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdActualizarEstadoCivil.ForeColor = Color.Black;
            CmdActualizarEstadoCivil.Image = (Image)resources.GetObject("CmdActualizarEstadoCivil.Image");
            CmdActualizarEstadoCivil.ImageAlign = ContentAlignment.MiddleLeft;
            CmdActualizarEstadoCivil.Location = new Point(188, 124);
            CmdActualizarEstadoCivil.Name = "CmdActualizarEstadoCivil";
            CmdActualizarEstadoCivil.Size = new Size(159, 40);
            CmdActualizarEstadoCivil.TabIndex = 2;
            CmdActualizarEstadoCivil.Text = "ACTUALIZAR";
            CmdActualizarEstadoCivil.UseVisualStyleBackColor = true;
            // 
            // CmdNuevoEstadoCivil
            // 
            CmdNuevoEstadoCivil.Cursor = Cursors.Hand;
            CmdNuevoEstadoCivil.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdNuevoEstadoCivil.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoEstadoCivil.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoEstadoCivil.FlatStyle = FlatStyle.Flat;
            CmdNuevoEstadoCivil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdNuevoEstadoCivil.ForeColor = Color.Black;
            CmdNuevoEstadoCivil.Image = (Image)resources.GetObject("CmdNuevoEstadoCivil.Image");
            CmdNuevoEstadoCivil.ImageAlign = ContentAlignment.MiddleLeft;
            CmdNuevoEstadoCivil.Location = new Point(22, 124);
            CmdNuevoEstadoCivil.Name = "CmdNuevoEstadoCivil";
            CmdNuevoEstadoCivil.Size = new Size(159, 40);
            CmdNuevoEstadoCivil.TabIndex = 1;
            CmdNuevoEstadoCivil.Text = "NUEVO";
            CmdNuevoEstadoCivil.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 9F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 50);
            label2.Name = "label2";
            label2.Size = new Size(24, 17);
            label2.TabIndex = 154;
            label2.Text = "Id :";
            // 
            // Grupo01
            // 
            Grupo01.Controls.Add(TxtNombrePais);
            Grupo01.Location = new Point(128, 62);
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
            // FmrEstadoCivil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 430);
            Controls.Add(Grupo01);
            Controls.Add(label2);
            Controls.Add(CmdReporteEstadoCivil);
            Controls.Add(CmdLimpiarEstadoCivil);
            Controls.Add(CmdEliminarEstadoCivil);
            Controls.Add(CmdActualizarEstadoCivil);
            Controls.Add(CmdNuevoEstadoCivil);
            Controls.Add(DgvEstadoCivil);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(CmdCerrar);
            Name = "FmrEstadoCivil";
            Text = "FmrEstadoCivil";
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvEstadoCivil).EndInit();
            Grupo01.ResumeLayout(false);
            Grupo01.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal PictureBox CmdCerrar;
        private Label label1;
        private DataGridView DgvEstadoCivil;
        private Label label5;
        private Label label3;
        private Button CmdReporteEstadoCivil;
        private Button CmdLimpiarEstadoCivil;
        private Button CmdEliminarEstadoCivil;
        private Button CmdActualizarEstadoCivil;
        private Button CmdNuevoEstadoCivil;
        private Label label2;
        private GroupBox Grupo01;
        private TextBox TxtNombrePais;
    }
}