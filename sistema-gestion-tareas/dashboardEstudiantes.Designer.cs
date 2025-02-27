namespace sistema_gestion_tareas
{
    partial class btnOrdenar
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
            panel3 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            PnlNav = new Panel();
            BtnLogOut = new Button();
            BtnDashboard = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvTareasAsignadas = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            cmbEstados = new ComboBox();
            btnCambiarEstado = new Button();
            label6 = new Label();
            cmbCriterios = new ComboBox();
            button1 = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTareasAsignadas).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(186, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(746, 67);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 9);
            label3.Name = "label3";
            label3.Size = new Size(456, 35);
            label3.TabIndex = 0;
            label3.Text = "Gestión Tareas Escolares - Estudiantes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(PnlNav);
            panel1.Controls.Add(BtnLogOut);
            panel1.Controls.Add(BtnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 538);
            panel1.TabIndex = 2;
            // 
            // PnlNav
            // 
            PnlNav.BackColor = Color.MediumSeaGreen;
            PnlNav.Location = new Point(0, 144);
            PnlNav.Name = "PnlNav";
            PnlNav.Size = new Size(8, 42);
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
            BtnLogOut.Image = Properties.Resources.logout_16__1_;
            BtnLogOut.Location = new Point(0, 496);
            BtnLogOut.Name = "BtnLogOut";
            BtnLogOut.Size = new Size(186, 42);
            BtnLogOut.TabIndex = 1;
            BtnLogOut.Text = "Cerrar Sesión";
            BtnLogOut.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnLogOut.UseVisualStyleBackColor = true;
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
            BtnDashboard.Image = Properties.Resources.house_16__1_;
            BtnDashboard.Location = new Point(0, 144);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(186, 42);
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
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 144);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(158, 161, 178);
            label2.Location = new Point(34, 114);
            label2.Name = "label2";
            label2.Size = new Size(104, 12);
            label2.TabIndex = 2;
            label2.Text = "Perfil de Estudiante";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSpringGreen;
            label1.Location = new Point(34, 98);
            label1.Name = "label1";
            label1.Size = new Size(117, 16);
            label1.TabIndex = 1;
            label1.Text = "Hola Estudiante";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconUsuario_1_;
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvTareasAsignadas
            // 
            dgvTareasAsignadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareasAsignadas.Location = new Point(203, 114);
            dgvTareasAsignadas.Name = "dgvTareasAsignadas";
            dgvTareasAsignadas.Size = new Size(702, 253);
            dgvTareasAsignadas.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SeaGreen;
            label4.Location = new Point(203, 81);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 0;
            label4.Text = "Mis Tareas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SeaGreen;
            label5.Location = new Point(203, 380);
            label5.Name = "label5";
            label5.Size = new Size(173, 21);
            label5.TabIndex = 0;
            label5.Text = "Cambiar Estado Tarea";
            // 
            // cmbEstados
            // 
            cmbEstados.FormattingEnabled = true;
            cmbEstados.Items.AddRange(new object[] { " ", "Pendiente", "En progreso", "Completada" });
            cmbEstados.Location = new Point(393, 382);
            cmbEstados.Name = "cmbEstados";
            cmbEstados.Size = new Size(166, 23);
            cmbEstados.TabIndex = 5;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.BackColor = Color.MediumSeaGreen;
            btnCambiarEstado.Cursor = Cursors.Hand;
            btnCambiarEstado.FlatStyle = FlatStyle.Flat;
            btnCambiarEstado.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarEstado.ForeColor = SystemColors.ButtonHighlight;
            btnCambiarEstado.Location = new Point(574, 375);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(144, 34);
            btnCambiarEstado.TabIndex = 6;
            btnCambiarEstado.Text = "Cambiar Estado";
            btnCambiarEstado.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SeaGreen;
            label6.Location = new Point(574, 423);
            label6.Name = "label6";
            label6.Size = new Size(106, 21);
            label6.TabIndex = 0;
            label6.Text = "Ordenar Por:";
            // 
            // cmbCriterios
            // 
            cmbCriterios.FormattingEnabled = true;
            cmbCriterios.Items.AddRange(new object[] { " ", "Fecha de entrega", "Asignatura", "Estado" });
            cmbCriterios.Location = new Point(686, 425);
            cmbCriterios.Name = "cmbCriterios";
            cmbCriterios.Size = new Size(120, 23);
            cmbCriterios.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(815, 423);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 6;
            button1.Text = "Ordenar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnOrdenar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 538);
            Controls.Add(button1);
            Controls.Add(btnCambiarEstado);
            Controls.Add(cmbCriterios);
            Controls.Add(cmbEstados);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvTareasAsignadas);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "btnOrdenar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboardEstudiantes";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTareasAsignadas).EndInit();
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
        private DataGridView dgvTareasAsignadas;
        private Label label4;
        private Label label5;
        private ComboBox cmbEstados;
        private Button btnCambiarEstado;
        private Label label6;
        private ComboBox cmbCriterios;
        private Button button1;
    }
}