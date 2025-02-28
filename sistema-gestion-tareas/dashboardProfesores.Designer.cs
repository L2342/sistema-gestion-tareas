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
            BtnCrearTarea = new Button();
            BtnEditarTarea = new Button();
            BtnEliminarTarea = new Button();
            dgvTareasAsignadas = new DataGridView();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 769);
            panel1.TabIndex = 0;
            // 
            // PnlNav
            // 
            PnlNav.BackColor = Color.Purple;
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
            BtnLogOut.ForeColor = Color.Purple;
            BtnLogOut.Image = Properties.Resources.logout_16;
            BtnLogOut.Location = new Point(0, 713);
            BtnLogOut.Margin = new Padding(3, 4, 3, 4);
            BtnLogOut.Name = "BtnLogOut";
            BtnLogOut.Size = new Size(213, 56);
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
            BtnDashboard.Location = new Point(0, 192);
            BtnDashboard.Margin = new Padding(3, 4, 3, 4);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(213, 56);
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
            label2.Location = new Point(55, 152);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 2;
            label2.Text = "Perfil de Docente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(39, 131);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 1;
            label1.Text = "Hola Profesor/a";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconUsuario;
            pictureBox1.Location = new Point(69, 29);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 84);
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
            panel3.Location = new Point(213, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(870, 89);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 12);
            label3.Name = "label3";
            label3.Size = new Size(572, 45);
            label3.TabIndex = 0;
            label3.Text = "Gestión Tareas Escolares - Profesores";
            // 
            // BtnCrearTarea
            // 
            BtnCrearTarea.BackColor = Color.Purple;
            BtnCrearTarea.Cursor = Cursors.Hand;
            BtnCrearTarea.FlatAppearance.BorderSize = 0;
            BtnCrearTarea.FlatStyle = FlatStyle.Flat;
            BtnCrearTarea.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCrearTarea.ForeColor = Color.White;
            BtnCrearTarea.Location = new Point(253, 135);
            BtnCrearTarea.Margin = new Padding(3, 4, 3, 4);
            BtnCrearTarea.Name = "BtnCrearTarea";
            BtnCrearTarea.Size = new Size(168, 57);
            BtnCrearTarea.TabIndex = 3;
            BtnCrearTarea.Text = "Agregar Tarea";
            BtnCrearTarea.UseVisualStyleBackColor = false;
            BtnCrearTarea.Click += BtnCrearTarea_Click;
            // 
            // BtnEditarTarea
            // 
            BtnEditarTarea.BackColor = Color.Purple;
            BtnEditarTarea.Cursor = Cursors.Hand;
            BtnEditarTarea.FlatAppearance.BorderSize = 0;
            BtnEditarTarea.FlatStyle = FlatStyle.Flat;
            BtnEditarTarea.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditarTarea.ForeColor = Color.White;
            BtnEditarTarea.Location = new Point(453, 135);
            BtnEditarTarea.Margin = new Padding(3, 4, 3, 4);
            BtnEditarTarea.Name = "BtnEditarTarea";
            BtnEditarTarea.Size = new Size(168, 57);
            BtnEditarTarea.TabIndex = 3;
            BtnEditarTarea.Text = "Editar Tarea";
            BtnEditarTarea.UseVisualStyleBackColor = false;
            BtnEditarTarea.Click += BtnEditarTarea_Click;
            // 
            // BtnEliminarTarea
            // 
            BtnEliminarTarea.BackColor = Color.Purple;
            BtnEliminarTarea.Cursor = Cursors.Hand;
            BtnEliminarTarea.FlatAppearance.BorderSize = 0;
            BtnEliminarTarea.FlatStyle = FlatStyle.Flat;
            BtnEliminarTarea.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminarTarea.ForeColor = Color.White;
            BtnEliminarTarea.Location = new Point(653, 135);
            BtnEliminarTarea.Margin = new Padding(3, 4, 3, 4);
            BtnEliminarTarea.Name = "BtnEliminarTarea";
            BtnEliminarTarea.Size = new Size(168, 57);
            BtnEliminarTarea.TabIndex = 3;
            BtnEliminarTarea.Text = "Eliminar Tarea";
            BtnEliminarTarea.UseVisualStyleBackColor = false;
            BtnEliminarTarea.Click += BtnEliminarTarea_Click;
            // 
            // dgvTareasAsignadas
            // 
            dgvTareasAsignadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareasAsignadas.Location = new Point(253, 219);
            dgvTareasAsignadas.Margin = new Padding(3, 4, 3, 4);
            dgvTareasAsignadas.Name = "dgvTareasAsignadas";
            dgvTareasAsignadas.RowHeadersWidth = 51;
            dgvTareasAsignadas.Size = new Size(792, 491);
            dgvTareasAsignadas.TabIndex = 2;
            // 
            // dashboardProfesores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1083, 769);
            Controls.Add(BtnEliminarTarea);
            Controls.Add(BtnEditarTarea);
            Controls.Add(BtnCrearTarea);
            Controls.Add(dgvTareasAsignadas);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button BtnCrearTarea;
        private Button BtnEditarTarea;
        private Button BtnEliminarTarea;
        private DataGridView dgvTareasAsignadas;
    }
}