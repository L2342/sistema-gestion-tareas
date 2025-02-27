namespace sistema_gestion_tareas
{
    partial class dashboardProfesores
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
            panel1 = new Panel();
            PnlNav = new Panel();
            BtnLogOut = new Button();
            BtnDashboard = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            dgvTareasAsignadas = new DataGridView();
            BtnCrearTarea = new Button();
            BtnEditarTarea = new Button();
            BtnEliminarTarea = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareasAsignadas).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(186, 577);
            panel1.TabIndex = 0;
            // 
            // PnlNav
            // 
            PnlNav.BackColor = Color.Purple;
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
            BtnLogOut.ForeColor = Color.Purple;
            BtnLogOut.Image = Properties.Resources.logout_16;
            BtnLogOut.Location = new Point(0, 535);
            BtnLogOut.Name = "BtnLogOut";
            BtnLogOut.Size = new Size(186, 42);
            BtnLogOut.TabIndex = 1;
            BtnLogOut.Text = "Cerrar Sesión";
            BtnLogOut.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnLogOut.UseVisualStyleBackColor = true;
            BtnLogOut.Click += BtnLogOut_Click;
            BtnLogOut.Leave += BtnLogOut_Leave;
            // 
            // BtnDashboard
            // 
            BtnDashboard.BackColor = Color.Thistle;
            BtnDashboard.Cursor = Cursors.Hand;
            BtnDashboard.Dock = DockStyle.Top;
            BtnDashboard.FlatAppearance.BorderSize = 0;
            BtnDashboard.FlatStyle = FlatStyle.Flat;
            BtnDashboard.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDashboard.ForeColor = Color.Purple;
            BtnDashboard.Image = Properties.Resources.house_16;
            BtnDashboard.Location = new Point(0, 144);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(186, 42);
            BtnDashboard.TabIndex = 1;
            BtnDashboard.Text = "DashBoard";
            BtnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnDashboard.UseVisualStyleBackColor = false;
            BtnDashboard.Click += BtnDashboard_Click;
            BtnDashboard.Leave += BtnDashboard_Leave;
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
            label2.Location = new Point(48, 114);
            label2.Name = "label2";
            label2.Size = new Size(92, 12);
            label2.TabIndex = 2;
            label2.Text = "Perfil de Docente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(34, 98);
            label1.Name = "label1";
            label1.Size = new Size(115, 16);
            label1.TabIndex = 1;
            label1.Text = "Hola Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconUsuario;
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Purple;
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(186, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(762, 67);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 9);
            label3.Name = "label3";
            label3.Size = new Size(447, 35);
            label3.TabIndex = 0;
            label3.Text = "Gestión Tareas Escolares - Profesores";
            // 
            // dgvTareasAsignadas
            // 
            dgvTareasAsignadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareasAsignadas.Location = new Point(221, 164);
            dgvTareasAsignadas.Name = "dgvTareasAsignadas";
            dgvTareasAsignadas.Size = new Size(693, 368);
            dgvTareasAsignadas.TabIndex = 2;
            // 
            // BtnCrearTarea
            // 
            BtnCrearTarea.BackColor = Color.Purple;
            BtnCrearTarea.Cursor = Cursors.Hand;
            BtnCrearTarea.FlatAppearance.BorderSize = 0;
            BtnCrearTarea.FlatStyle = FlatStyle.Flat;
            BtnCrearTarea.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCrearTarea.ForeColor = Color.White;
            BtnCrearTarea.Location = new Point(221, 101);
            BtnCrearTarea.Name = "BtnCrearTarea";
            BtnCrearTarea.Size = new Size(147, 43);
            BtnCrearTarea.TabIndex = 3;
            BtnCrearTarea.Text = "Agregar Tarea";
            BtnCrearTarea.UseVisualStyleBackColor = false;
            // 
            // BtnEditarTarea
            // 
            BtnEditarTarea.BackColor = Color.Purple;
            BtnEditarTarea.Cursor = Cursors.Hand;
            BtnEditarTarea.FlatAppearance.BorderSize = 0;
            BtnEditarTarea.FlatStyle = FlatStyle.Flat;
            BtnEditarTarea.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditarTarea.ForeColor = Color.White;
            BtnEditarTarea.Location = new Point(396, 101);
            BtnEditarTarea.Name = "BtnEditarTarea";
            BtnEditarTarea.Size = new Size(147, 43);
            BtnEditarTarea.TabIndex = 3;
            BtnEditarTarea.Text = "Editar Tarea";
            BtnEditarTarea.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarTarea
            // 
            BtnEliminarTarea.BackColor = Color.Purple;
            BtnEliminarTarea.Cursor = Cursors.Hand;
            BtnEliminarTarea.FlatAppearance.BorderSize = 0;
            BtnEliminarTarea.FlatStyle = FlatStyle.Flat;
            BtnEliminarTarea.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminarTarea.ForeColor = Color.White;
            BtnEliminarTarea.Location = new Point(571, 101);
            BtnEliminarTarea.Name = "BtnEliminarTarea";
            BtnEliminarTarea.Size = new Size(147, 43);
            BtnEliminarTarea.TabIndex = 3;
            BtnEliminarTarea.Text = "Eliminar Tarea";
            BtnEliminarTarea.UseVisualStyleBackColor = false;
            // 
            // dashboardProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(948, 577);
            Controls.Add(BtnEliminarTarea);
            Controls.Add(BtnEditarTarea);
            Controls.Add(BtnCrearTarea);
            Controls.Add(dgvTareasAsignadas);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboardProfesores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboardProfesores";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareasAsignadas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button BtnDashboard;
        private Label label2;
        private Button BtnLogOut;
        private Panel PnlNav;
        private Panel panel3;
        private Label label3;
        private DataGridView dgvTareasAsignadas;
        private Button BtnCrearTarea;
        private Button BtnEditarTarea;
        private Button BtnEliminarTarea;
    }
}