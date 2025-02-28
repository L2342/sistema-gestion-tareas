namespace sistema_gestion_tareas
{
    partial class dashBoard_Profesores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {              components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashBoard_Profesores));
            panel3 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            btnGuardarGrupo = new Button();
            cmbGrupos = new ComboBox();
            PnlNav = new Panel();
            BtnLogOut = new Button();
            BtnDashboard = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvTareasDisponibles = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            cmbEstados = new ComboBox();
            btnCambiarEstado = new Button();
            label6 = new Label();
            cmbCriterios = new ComboBox();
            btnOrdenar = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTareasDisponibles).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(213, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(852, 89);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 12);
            label3.Name = "label3";
            label3.Size = new Size(583, 45);
            label3.TabIndex = 0;
            label3.Text = "Gestión Tareas Escolares - Estudiantes";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnGuardarGrupo);
            panel1.Controls.Add(cmbGrupos);
            panel1.Controls.Add(PnlNav);
            panel1.Controls.Add(BtnLogOut);
            panel1.Controls.Add(BtnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 717);
            panel1.TabIndex = 2;
            // 
            // btnGuardarGrupo
            // 
            btnGuardarGrupo.BackColor = Color.MediumSeaGreen;
            btnGuardarGrupo.Cursor = Cursors.Hand;
            btnGuardarGrupo.FlatStyle = FlatStyle.Flat;
            btnGuardarGrupo.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarGrupo.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarGrupo.Location = new Point(36, 288);
            btnGuardarGrupo.Margin = new Padding(3, 4, 3, 4);
            btnGuardarGrupo.Name = "btnGuardarGrupo";
            btnGuardarGrupo.Size = new Size(165, 58);
            btnGuardarGrupo.TabIndex = 7;
            btnGuardarGrupo.Text = "Determinar Grupo";
            btnGuardarGrupo.UseVisualStyleBackColor = false;
            btnGuardarGrupo.Click += btnGuardarGrupo_Click_1;
            // 
            // cmbGrupos
            // 
            cmbGrupos.FormattingEnabled = true;
            cmbGrupos.Items.AddRange(new object[] { "Grupo A", "Grupo B", "Grupo C", "Grupo N" });
            cmbGrupos.Location = new Point(12, 365);
            cmbGrupos.Margin = new Padding(3, 4, 3, 4);
            cmbGrupos.Name = "cmbGrupos";
            cmbGrupos.Size = new Size(189, 28);
            cmbGrupos.TabIndex = 7;
            cmbGrupos.SelectedIndexChanged += cmbGrupos_SelectedIndexChanged;
            // 
            // PnlNav
            // 
            PnlNav.BackColor = Color.MediumSeaGreen;
            PnlNav.Location = new Point(0, 192);
            PnlNav.Margin = new Padding(3, 4, 3, 4);
            PnlNav.Name = "PnlNav";
            PnlNav.Size = new Size(9, 56);
            PnlNav.TabIndex = 2;
            // 
            // BtnLogOut
            // 
            BtnLogOut.Cursor = Cursors.Hand;
            BtnLogOut.Dock = DockStyle.Bottom;
            BtnLogOut.FlatAppearance.BorderSize = 0;
            BtnLogOut.FlatStyle = FlatStyle.Flat;
            BtnLogOut.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogOut.ForeColor = Color.SpringGreen;
            BtnLogOut.Image = (Image)resources.GetObject("BtnLogOut.Image");
            BtnLogOut.Location = new Point(0, 661);
            BtnLogOut.Margin = new Padding(3, 4, 3, 4);
            BtnLogOut.Name = "BtnLogOut";
            BtnLogOut.Size = new Size(213, 56);
            BtnLogOut.TabIndex = 1;
            BtnLogOut.Text = "Cerrar Sesión";
            BtnLogOut.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnLogOut.UseVisualStyleBackColor = true;
            BtnLogOut.Click += BtnLogOut_Click;
            // 
            // BtnDashboard
            // 
            BtnDashboard.BackColor = Color.SeaGreen;
            BtnDashboard.Cursor = Cursors.Hand;
            BtnDashboard.Dock = DockStyle.Top;
            BtnDashboard.FlatAppearance.BorderSize = 0;
            BtnDashboard.FlatStyle = FlatStyle.Flat;
            BtnDashboard.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDashboard.ForeColor = Color.SpringGreen;
            BtnDashboard.Image = (Image)resources.GetObject("BtnDashboard.Image");
            BtnDashboard.Location = new Point(0, 192);
            BtnDashboard.Margin = new Padding(3, 4, 3, 4);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(213, 56);
            BtnDashboard.TabIndex = 1;
            BtnDashboard.Text = "DashBoard";
            BtnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnDashboard.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(213, 192);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(158, 161, 178);
            label2.Location = new Point(39, 152);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 2;
            label2.Text = "Perfil de Estudiante";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSpringGreen;
            label1.Location = new Point(39, 131);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 1;
            label1.Text = "Hola Estudiante";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 29);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvTareasDisponibles
            // 
            dgvTareasDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareasDisponibles.Location = new Point(232, 152);
            dgvTareasDisponibles.Margin = new Padding(3, 4, 3, 4);
            dgvTareasDisponibles.Name = "dgvTareasDisponibles";
            dgvTareasDisponibles.RowHeadersWidth = 51;
            dgvTareasDisponibles.Size = new Size(802, 337);
            dgvTareasDisponibles.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SeaGreen;
            label4.Location = new Point(232, 108);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 0;
            label4.Text = "Mis Tareas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SeaGreen;
            label5.Location = new Point(232, 507);
            label5.Name = "label5";
            label5.Size = new Size(216, 28);
            label5.TabIndex = 0;
            label5.Text = "Cambiar Estado Tarea";
            // 
            // cmbEstados
            // 
            cmbEstados.FormattingEnabled = true;
            cmbEstados.Items.AddRange(new object[] { " Pendiente", "En progreso", "Completada" });
            cmbEstados.Location = new Point(449, 509);
            cmbEstados.Margin = new Padding(3, 4, 3, 4);
            cmbEstados.Name = "cmbEstados";
            cmbEstados.Size = new Size(189, 28);
            cmbEstados.TabIndex = 5;
            cmbEstados.SelectedIndexChanged += cmbEstados_SelectedIndexChanged;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.BackColor = Color.MediumSeaGreen;
            btnCambiarEstado.Cursor = Cursors.Hand;
            btnCambiarEstado.FlatStyle = FlatStyle.Flat;
            btnCambiarEstado.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarEstado.ForeColor = SystemColors.ButtonHighlight;
            btnCambiarEstado.Location = new Point(656, 500);
            btnCambiarEstado.Margin = new Padding(3, 4, 3, 4);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(165, 45);
            btnCambiarEstado.TabIndex = 6;
            btnCambiarEstado.Text = "Cambiar Estado";
            btnCambiarEstado.UseVisualStyleBackColor = false;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SeaGreen;
            label6.Location = new Point(656, 564);
            label6.Name = "label6";
            label6.Size = new Size(132, 28);
            label6.TabIndex = 0;
            label6.Text = "Ordenar Por:";
            // 
            // cmbCriterios
            // 
            cmbCriterios.FormattingEnabled = true;
            cmbCriterios.Items.AddRange(new object[] { "Fecha de entrega", "Asignatura", "Estado" });
            cmbCriterios.Location = new Point(784, 567);
            cmbCriterios.Margin = new Padding(3, 4, 3, 4);
            cmbCriterios.Name = "cmbCriterios";
            cmbCriterios.Size = new Size(137, 28);
            cmbCriterios.TabIndex = 5;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.MediumSeaGreen;
            btnOrdenar.Cursor = Cursors.Hand;
            btnOrdenar.FlatStyle = FlatStyle.Flat;
            btnOrdenar.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenar.ForeColor = SystemColors.ButtonHighlight;
            btnOrdenar.Location = new Point(931, 564);
            btnOrdenar.Margin = new Padding(3, 4, 3, 4);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(103, 45);
            btnOrdenar.TabIndex = 6;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += button1_Click;
            // 
            // dashBoard_Profesores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 717);
            Controls.Add(btnOrdenar);
            Controls.Add(btnCambiarEstado);
            Controls.Add(cmbCriterios);
            Controls.Add(cmbEstados);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvTareasDisponibles);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "dashBoard_Profesores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboardEstudiantes";
            Load += form_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTareasDisponibles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Label label3;
        private Panel panel1;
        private Panel PnlNav;
        private Button BtnLogOut;
        private Button BtnDashboard;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvTareasDisponibles;
        private Label label4;
        private Label label5;
        private ComboBox cmbEstados;
        private Button btnCambiarEstado;
        private Label label6;
        private ComboBox cmbCriterios;
        private Button btnOrdenar;
        private Button btnGuardarGrupo;
        private ComboBox cmbGrupos;
    }
}