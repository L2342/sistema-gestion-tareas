namespace sistema_gestion_tareas
{
    partial class frmLogin
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
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            CheckbxShowPas = new CheckBox();
            txtPassword = new TextBox();
            txtusername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(114, 439);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 16;
            label6.Text = "Registrate";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 412);
            label5.Name = "label5";
            label5.Size = new Size(151, 17);
            label5.TabIndex = 17;
            label5.Text = "¿No tienes una cuenta?";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(40, 361);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 14;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(40, 320);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 15;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CheckbxShowPas
            // 
            CheckbxShowPas.AutoSize = true;
            CheckbxShowPas.Cursor = Cursors.Hand;
            CheckbxShowPas.FlatStyle = FlatStyle.Flat;
            CheckbxShowPas.Location = new Point(136, 266);
            CheckbxShowPas.Name = "CheckbxShowPas";
            CheckbxShowPas.Size = new Size(117, 21);
            CheckbxShowPas.TabIndex = 13;
            CheckbxShowPas.Text = "Ver Contraseña";
            CheckbxShowPas.UseVisualStyleBackColor = true;
            CheckbxShowPas.CheckedChanged += CheckbxShowPas_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(40, 232);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 11;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.FromArgb(230, 231, 233);
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(40, 165);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(216, 28);
            txtusername.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 212);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 8;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 145);
            label2.Name = "label2";
            label2.Size = new Size(127, 17);
            label2.TabIndex = 9;
            label2.Text = "Nombre de usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(33, 101);
            label1.Name = "label1";
            label1.Size = new Size(179, 27);
            label1.TabIndex = 6;
            label1.Text = "Iniciar Sesión";
            label1.Click += label1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 544);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CheckbxShowPas);
            Controls.Add(txtPassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button button2;
        private Button button1;
        private CheckBox CheckbxShowPas;
        private TextBox txtPassword;
        private TextBox txtusername;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}