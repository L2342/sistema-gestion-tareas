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
            chkListaEstudiantes = new CheckedListBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(200, 20);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 0;
            label1.Text = "Crear/ Editar Tarea";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 71);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(165, 64);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Escribe el título de la tarea";
            txtTitulo.Size = new Size(400, 27);
            txtTitulo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 145);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 1;
            label3.Text = "Descripción";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(165, 110);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(400, 80);
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
            label4.Location = new Point(23, 224);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 1;
            label4.Text = "Fecha de entrega";
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Format = DateTimePickerFormat.Short;
            dtpFechaEntrega.Location = new Point(165, 222);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(200, 23);
            dtpFechaEntrega.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 316);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 1;
            label5.Text = "Grupos asignados";
            // 
            // chkListaEstudiantes
            // 
            chkListaEstudiantes.FormattingEnabled = true;
            chkListaEstudiantes.Location = new Point(165, 295);
            chkListaEstudiantes.Name = "chkListaEstudiantes";
            chkListaEstudiantes.Size = new Size(250, 94);
            chkListaEstudiantes.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Navy;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLight;
            btnGuardar.Location = new Point(290, 447);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 41);
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
            btnCancelar.Location = new Point(440, 447);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 41);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(600, 500);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(chkListaEstudiantes);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(txtDescription);
            Controls.Add(txtTitulo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
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
        private CheckedListBox chkListaEstudiantes;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}