namespace sistema_gestion_tareas
{
    partial class frmAddEdit
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtTitulo = new TextBox();
            label3 = new Label();
            txtDescription = new RichTextBox();
            toolTip1 = new ToolTip(components);
            label4 = new Label();
            dtpFechaEntrega = new DateTimePicker();
            label5 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label6 = new Label();
            cbxAsignaturas = new ComboBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(240, 12);
            label1.Name = "label1";
            label1.Size = new Size(227, 32);
            label1.TabIndex = 0;
            label1.Text = "Crear Tarea";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 75);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(189, 75);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Escribe el título de la tarea";
            txtTitulo.Size = new Size(457, 32);
            txtTitulo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 144);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 1;
            label3.Text = "Descripción";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(189, 144);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(457, 105);
            txtDescription.TabIndex = 3;
            txtDescription.Text = "";
            toolTip1.SetToolTip(txtDescription, "Describe brevemente la tarea.  ");
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 288);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 1;
            label4.Text = "Fecha de entrega";
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Format = DateTimePickerFormat.Short;
            dtpFechaEntrega.Location = new Point(189, 288);
            dtpFechaEntrega.Margin = new Padding(3, 4, 3, 4);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(228, 27);
            dtpFechaEntrega.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 364);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 1;
            label5.Text = "Grupos asignados";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Navy;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLight;
            btnGuardar.Location = new Point(331, 719);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 55);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Navy;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLight;
            btnCancelar.Location = new Point(503, 719);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 55);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 529);
            label6.Name = "label6";
            label6.Size = new Size(207, 25);
            label6.TabIndex = 1;
            label6.Text = "Asignatura relacionada";
            // 
            // cbxAsignaturas
            // 
            cbxAsignaturas.FormattingEnabled = true;
            cbxAsignaturas.Items.AddRange(new object[] { "", "Matemáticas", "Lenguas", "Análisis Literario", "Ciencias Sociales y ciudadanas", "Fisica", "Quimica", "Biologia", "Ingles", "Filosofia", "Religión" });
            cbxAsignaturas.Location = new Point(231, 537);
            cbxAsignaturas.Margin = new Padding(3, 4, 3, 4);
            cbxAsignaturas.Name = "cbxAsignaturas";
            cbxAsignaturas.Size = new Size(211, 28);
            cbxAsignaturas.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Grupo A", "Grupo B", "Grupo C", "Grupo N" });
            comboBox1.Location = new Point(189, 365);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 28);
            comboBox1.TabIndex = 7;
            // 
            // frmAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(686, 788);
            Controls.Add(comboBox1);
            Controls.Add(cbxAsignaturas);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(txtDescription);
            Controls.Add(txtTitulo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "frmAddEdit";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitulo;
        private Label label3;
        private RichTextBox txtDescription;
        private ToolTip toolTip1;
        private Label label4;
        private DateTimePicker dtpFechaEntrega;
        private Label label5;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label6;
        private ComboBox cbxAsignaturas;
        private ComboBox comboBox1;
    }
}