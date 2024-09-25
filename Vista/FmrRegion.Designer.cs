namespace Vista
{
    partial class FmrRegion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrRegion));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            CmdCerrar = new PictureBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            CmdReporteCargo = new Button();
            CmdLimpiarCargo = new Button();
            CmdEliminarCargo = new Button();
            CmdActualizarCargo = new Button();
            CmdNuevoCargo = new Button();
            Grupo01 = new GroupBox();
            TxtNombreRegion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Grupo01.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 29);
            label1.TabIndex = 79;
            label1.Text = "REGION";
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
            CmdCerrar.TabIndex = 78;
            CmdCerrar.TabStop = false;
            CmdCerrar.Click += CmdCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 9F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 50);
            label2.Name = "label2";
            label2.Size = new Size(27, 17);
            label2.TabIndex = 100;
            label2.Text = "Id : ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(40, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(817, 261);
            dataGridView1.TabIndex = 103;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Open Sans", 9F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(22, 80);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 111;
            label4.Text = "Region : ";
            // 
            // CmdReporteCargo
            // 
            CmdReporteCargo.Cursor = Cursors.Hand;
            CmdReporteCargo.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdReporteCargo.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteCargo.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdReporteCargo.FlatStyle = FlatStyle.Flat;
            CmdReporteCargo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdReporteCargo.ForeColor = Color.Black;
            CmdReporteCargo.Image = (Image)resources.GetObject("CmdReporteCargo.Image");
            CmdReporteCargo.ImageAlign = ContentAlignment.MiddleLeft;
            CmdReporteCargo.Location = new Point(698, 127);
            CmdReporteCargo.Name = "CmdReporteCargo";
            CmdReporteCargo.Size = new Size(159, 40);
            CmdReporteCargo.TabIndex = 5;
            CmdReporteCargo.Text = "REPORTE";
            CmdReporteCargo.UseVisualStyleBackColor = true;
            // 
            // CmdLimpiarCargo
            // 
            CmdLimpiarCargo.Cursor = Cursors.Hand;
            CmdLimpiarCargo.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarCargo.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarCargo.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdLimpiarCargo.FlatStyle = FlatStyle.Flat;
            CmdLimpiarCargo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdLimpiarCargo.ForeColor = Color.Black;
            CmdLimpiarCargo.Image = (Image)resources.GetObject("CmdLimpiarCargo.Image");
            CmdLimpiarCargo.ImageAlign = ContentAlignment.MiddleLeft;
            CmdLimpiarCargo.Location = new Point(528, 127);
            CmdLimpiarCargo.Name = "CmdLimpiarCargo";
            CmdLimpiarCargo.Size = new Size(159, 40);
            CmdLimpiarCargo.TabIndex = 4;
            CmdLimpiarCargo.Text = "LIMPIAR";
            CmdLimpiarCargo.UseVisualStyleBackColor = true;
            // 
            // CmdEliminarCargo
            // 
            CmdEliminarCargo.Cursor = Cursors.Hand;
            CmdEliminarCargo.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdEliminarCargo.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarCargo.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdEliminarCargo.FlatStyle = FlatStyle.Flat;
            CmdEliminarCargo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdEliminarCargo.ForeColor = Color.Black;
            CmdEliminarCargo.Image = (Image)resources.GetObject("CmdEliminarCargo.Image");
            CmdEliminarCargo.ImageAlign = ContentAlignment.MiddleLeft;
            CmdEliminarCargo.Location = new Point(358, 127);
            CmdEliminarCargo.Name = "CmdEliminarCargo";
            CmdEliminarCargo.Size = new Size(159, 40);
            CmdEliminarCargo.TabIndex = 3;
            CmdEliminarCargo.Text = "ELIMINAR";
            CmdEliminarCargo.UseVisualStyleBackColor = true;
            // 
            // CmdActualizarCargo
            // 
            CmdActualizarCargo.Cursor = Cursors.Hand;
            CmdActualizarCargo.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdActualizarCargo.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarCargo.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdActualizarCargo.FlatStyle = FlatStyle.Flat;
            CmdActualizarCargo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdActualizarCargo.ForeColor = Color.Black;
            CmdActualizarCargo.Image = (Image)resources.GetObject("CmdActualizarCargo.Image");
            CmdActualizarCargo.ImageAlign = ContentAlignment.MiddleLeft;
            CmdActualizarCargo.Location = new Point(188, 127);
            CmdActualizarCargo.Name = "CmdActualizarCargo";
            CmdActualizarCargo.Size = new Size(159, 40);
            CmdActualizarCargo.TabIndex = 2;
            CmdActualizarCargo.Text = "ACTUALIZAR";
            CmdActualizarCargo.UseVisualStyleBackColor = true;
            // 
            // CmdNuevoCargo
            // 
            CmdNuevoCargo.Cursor = Cursors.Hand;
            CmdNuevoCargo.FlatAppearance.BorderColor = Color.FromArgb(12, 61, 92);
            CmdNuevoCargo.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoCargo.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            CmdNuevoCargo.FlatStyle = FlatStyle.Flat;
            CmdNuevoCargo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CmdNuevoCargo.ForeColor = Color.Black;
            CmdNuevoCargo.Image = (Image)resources.GetObject("CmdNuevoCargo.Image");
            CmdNuevoCargo.ImageAlign = ContentAlignment.MiddleLeft;
            CmdNuevoCargo.Location = new Point(22, 127);
            CmdNuevoCargo.Name = "CmdNuevoCargo";
            CmdNuevoCargo.Size = new Size(159, 40);
            CmdNuevoCargo.TabIndex = 1;
            CmdNuevoCargo.Text = "NUEVO";
            CmdNuevoCargo.UseVisualStyleBackColor = true;
            // 
            // Grupo01
            // 
            Grupo01.Controls.Add(TxtNombreRegion);
            Grupo01.Location = new Point(105, 64);
            Grupo01.Name = "Grupo01";
            Grupo01.Size = new Size(242, 44);
            Grupo01.TabIndex = 0;
            Grupo01.TabStop = false;
            // 
            // TxtNombreRegion
            // 
            TxtNombreRegion.Location = new Point(8, 14);
            TxtNombreRegion.Name = "TxtNombreRegion";
            TxtNombreRegion.Size = new Size(231, 23);
            TxtNombreRegion.TabIndex = 0;
            // 
            // FmrRegion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 479);
            Controls.Add(Grupo01);
            Controls.Add(CmdReporteCargo);
            Controls.Add(CmdLimpiarCargo);
            Controls.Add(CmdEliminarCargo);
            Controls.Add(CmdActualizarCargo);
            Controls.Add(CmdNuevoCargo);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CmdCerrar);
            Name = "FmrRegion";
            Text = "FmrRegion";
            ((System.ComponentModel.ISupportInitialize)CmdCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Grupo01.ResumeLayout(false);
            Grupo01.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        internal PictureBox CmdCerrar;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label4;
        private Button CmdReporteCargo;
        private Button CmdLimpiarCargo;
        private Button CmdEliminarCargo;
        private Button CmdActualizarCargo;
        private Button CmdNuevoCargo;
        private GroupBox Grupo01;
        private TextBox TxtNombreRegion;
    }
}