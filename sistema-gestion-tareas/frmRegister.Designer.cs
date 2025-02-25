namespace sistema_gestion_tareas
{
    partial class frmRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtusername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtComPassword = new TextBox();
            CheckbxShowPas = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            cmbRole = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(28, 68);
            label1.Name = "label1";
            label1.Size = new Size(157, 27);
            label1.TabIndex = 0;
            label1.Text = "Empecemos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 112);
            label2.Name = "label2";
            label2.Size = new Size(127, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre de usuario";
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.FromArgb(230, 231, 233);
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(35, 132);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(216, 28);
            txtusername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 179);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 1;
            label3.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(35, 199);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 249);
            label4.Name = "label4";
            label4.Size = new Size(143, 17);
            label4.TabIndex = 1;
            label4.Text = "Confirmar Contraseña";
            label4.Click += label4_Click;
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtComPassword.BorderStyle = BorderStyle.None;
            txtComPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComPassword.Location = new Point(35, 269);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.PasswordChar = '•';
            txtComPassword.Size = new Size(216, 28);
            txtComPassword.TabIndex = 2;
            txtComPassword.TextChanged += textBox1_TextChanged;
            // 
            // CheckbxShowPas
            // 
            CheckbxShowPas.AutoSize = true;
            CheckbxShowPas.Cursor = Cursors.Hand;
            CheckbxShowPas.FlatStyle = FlatStyle.Flat;
            CheckbxShowPas.Location = new Point(131, 303);
            CheckbxShowPas.Name = "CheckbxShowPas";
            CheckbxShowPas.Size = new Size(117, 21);
            CheckbxShowPas.TabIndex = 3;
            CheckbxShowPas.Text = "Ver Contraseña";
            CheckbxShowPas.UseVisualStyleBackColor = true;
            CheckbxShowPas.CheckedChanged += CheckbxShowPas_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(35, 390);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 4;
            button1.Text = "Registarse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(35, 445);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 4;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 503);
            label5.Name = "label5";
            label5.Size = new Size(146, 17);
            label5.TabIndex = 5;
            label5.Text = "¿Ya tienes una cuenta?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(111, 520);
            label6.Name = "label6";
            label6.Size = new Size(67, 17);
            label6.TabIndex = 5;
            label6.Text = "Ir a Login";
            label6.Click += label6_Click;
            // 
            // cmbRole
            // 
            cmbRole.Cursor = Cursors.Hand;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Profesor", "Estudiante" });
            cmbRole.Location = new Point(35, 348);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(205, 25);
            cmbRole.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 328);
            label7.Name = "label7";
            label7.Size = new Size(34, 17);
            label7.TabIndex = 1;
            label7.Text = "Soy:";
            label7.Click += label4_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 544);
            Controls.Add(cmbRole);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CheckbxShowPas);
            Controls.Add(txtComPassword);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusername;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtComPassword;
        private CheckBox CheckbxShowPas;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private ComboBox cmbRole;
        private Label label7;
    }
}
