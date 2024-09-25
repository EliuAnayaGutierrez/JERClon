namespace Vista
{
    partial class FmrGradoInstruccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrGradoInstruccion));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            CmdCerrar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            DgvGradoInstruccion = new DataGridView();
            CmdReporteGradoInstruccion = new Button();
            CmdLimpiarGradoInstruccion = new Button();
            CmdEliminarGradoInstruccion = new Button();
            CmdActualizarGradoInstruccion = new Button();
            CmdNuevoGradoInstruccion = new Button();
            label3 = new Label();
            Grupo02 = new GroupBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvGradoInstruccion).BeginInit();
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
            CmdCerrar.TabIndex = 74;
            CmdCerrar.TabStop = false;
            CmdCerrar.Click += CmdCerrar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 9);
            label1.Name = "label1";
            label1.Size = new Size(348, 29);
            label1.TabIndex = 76;
            label1.Text = "GRADOS DE INSTRUCCION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 9F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 80);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 87;
            label2.Text = "Grado :";
            // 
            // DgvGradoInstruccion
            // 
            DgvGradoInstruccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvGradoInstruccion.DefaultCellStyle = dataGridViewCellStyle2;
            DgvGradoInstruccion.Location = new Point(40, 195);
            DgvGradoInstruccion.Name = "DgvGradoInstruccion";
            DgvGradoInstruccion.Size = new Size(861, 346);
            DgvGradoInstruccion.TabIndex = 96;
            // 
            // CmdReporteGradoInstruccion
            // 
            CmdReporteGradoInstruccion.Cursor = Cursors.Hand;
            CmdReporteGradoInstruccion.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdReporteGradoInstruccion.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteGradoInstruccion.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteGradoInstruccion.FlatStyle = FlatStyle.Flat;
            CmdReporteGradoInstruccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdReporteGradoInstruccion.ForeColor = Color.Black;
            CmdReporteGradoInstruccion.Image = (Image)resources.GetObject("CmdReporteGradoInstruccion.Image");
            CmdReporteGradoInstruccion.ImageAlign = ContentAlignment.MiddleLeft;
            CmdReporteGradoInstruccion.Location = new Point(698, 142);
            CmdReporteGradoInstruccion.Name = "CmdReporteGradoInstruccion";
            CmdReporteGradoInstruccion.Size = new Size(159, 40);
            CmdReporteGradoInstruccion.TabIndex = 5;
            CmdReporteGradoInstruccion.Text = "REPORTE";
            CmdReporteGradoInstruccion.UseVisualStyleBackColor = true;
            // 
            // CmdLimpiarGradoInstruccion
            // 
            CmdLimpiarGradoInstruccion.Cursor = Cursors.Hand;
            CmdLimpiarGradoInstruccion.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarGradoInstruccion.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarGradoInstruccion.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarGradoInstruccion.FlatStyle = FlatStyle.Flat;
            CmdLimpiarGradoInstruccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdLimpiarGradoInstruccion.ForeColor = Color.Black;
            CmdLimpiarGradoInstruccion.Image = (Image)resources.GetObject("CmdLimpiarGradoInstruccion.Image");
            CmdLimpiarGradoInstruccion.ImageAlign = ContentAlignment.MiddleLeft;
            CmdLimpiarGradoInstruccion.Location = new Point(528, 142);
            CmdLimpiarGradoInstruccion.Name = "CmdLimpiarGradoInstruccion";
            CmdLimpiarGradoInstruccion.Size = new Size(159, 40);
            CmdLimpiarGradoInstruccion.TabIndex = 4;
            CmdLimpiarGradoInstruccion.Text = "LIMPIAR";
            CmdLimpiarGradoInstruccion.UseVisualStyleBackColor = true;
            // 
            // CmdEliminarGradoInstruccion
            // 
            CmdEliminarGradoInstruccion.Cursor = Cursors.Hand;
            CmdEliminarGradoInstruccion.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdEliminarGradoInstruccion.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarGradoInstruccion.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarGradoInstruccion.FlatStyle = FlatStyle.Flat;
            CmdEliminarGradoInstruccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdEliminarGradoInstruccion.ForeColor = Color.Black;
            CmdEliminarGradoInstruccion.Image = (Image)resources.GetObject("CmdEliminarGradoInstruccion.Image");
            CmdEliminarGradoInstruccion.ImageAlign = ContentAlignment.MiddleLeft;
            CmdEliminarGradoInstruccion.Location = new Point(358, 142);
            CmdEliminarGradoInstruccion.Name = "CmdEliminarGradoInstruccion";
            CmdEliminarGradoInstruccion.Size = new Size(159, 40);
            CmdEliminarGradoInstruccion.TabIndex = 3;
            CmdEliminarGradoInstruccion.Text = "ELIMINAR";
            CmdEliminarGradoInstruccion.UseVisualStyleBackColor = true;
            // 
            // CmdActualizarGradoInstruccion
            // 
            CmdActualizarGradoInstruccion.Cursor = Cursors.Hand;
            CmdActualizarGradoInstruccion.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdActualizarGradoInstruccion.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarGradoInstruccion.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarGradoInstruccion.FlatStyle = FlatStyle.Flat;
            CmdActualizarGradoInstruccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdActualizarGradoInstruccion.ForeColor = Color.Black;
            CmdActualizarGradoInstruccion.Image = (Image)resources.GetObject("CmdActualizarGradoInstruccion.Image");
            CmdActualizarGradoInstruccion.ImageAlign = ContentAlignment.MiddleLeft;
            CmdActualizarGradoInstruccion.Location = new Point(188, 142);
            CmdActualizarGradoInstruccion.Name = "CmdActualizarGradoInstruccion";
            CmdActualizarGradoInstruccion.Size = new Size(159, 40);
            CmdActualizarGradoInstruccion.TabIndex = 2;
            CmdActualizarGradoInstruccion.Text = "ACTUALIZAR";
            CmdActualizarGradoInstruccion.UseVisualStyleBackColor = true;
            // 
            // CmdNuevoGradoInstruccion
            // 
            CmdNuevoGradoInstruccion.Cursor = Cursors.Hand;
            CmdNuevoGradoInstruccion.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdNuevoGradoInstruccion.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoGradoInstruccion.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoGradoInstruccion.FlatStyle = FlatStyle.Flat;
            CmdNuevoGradoInstruccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdNuevoGradoInstruccion.ForeColor = Color.Black;
            CmdNuevoGradoInstruccion.Image = (Image)resources.GetObject("CmdNuevoGradoInstruccion.Image");
            CmdNuevoGradoInstruccion.ImageAlign = ContentAlignment.MiddleLeft;
            CmdNuevoGradoInstruccion.Location = new Point(22, 142);
            CmdNuevoGradoInstruccion.Name = "CmdNuevoGradoInstruccion";
            CmdNuevoGradoInstruccion.Size = new Size(159, 40);
            CmdNuevoGradoInstruccion.TabIndex = 1;
            CmdNuevoGradoInstruccion.Text = "NUEVO";
            CmdNuevoGradoInstruccion.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans", 9F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(22, 50);
            label3.Name = "label3";
            label3.Size = new Size(24, 17);
            label3.TabIndex = 131;
            label3.Text = "Id :";
            // 
            // Grupo02
            // 
            Grupo02.Controls.Add(textBox1);
            Grupo02.Location = new Point(95, 68);
            Grupo02.Name = "Grupo02";
            Grupo02.Size = new Size(242, 44);
            Grupo02.TabIndex = 0;
            Grupo02.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 23);
            textBox1.TabIndex = 0;
            // 
            // FmrGradoInstruccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 594);
            Controls.Add(Grupo02);
            Controls.Add(label3);
            Controls.Add(CmdReporteGradoInstruccion);
            Controls.Add(CmdLimpiarGradoInstruccion);
            Controls.Add(CmdEliminarGradoInstruccion);
            Controls.Add(CmdActualizarGradoInstruccion);
            Controls.Add(CmdNuevoGradoInstruccion);
            Controls.Add(DgvGradoInstruccion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CmdCerrar);
            Name = "FmrGradoInstruccion";
            Text = "FmrGradosInstruccion";
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvGradoInstruccion).EndInit();
            Grupo02.ResumeLayout(false);
            Grupo02.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal PictureBox CmdCerrar;
        private Label label1;
        private Label label2;
        private DataGridView DgvGradoInstruccion;
        private Button CmdReporteGradoInstruccion;
        private Button CmdLimpiarGradoInstruccion;
        private Button CmdEliminarGradoInstruccion;
        private Button CmdActualizarGradoInstruccion;
        private Button CmdNuevoGradoInstruccion;
        private Label label3;
        private GroupBox Grupo02;
        private TextBox textBox1;
    }
}