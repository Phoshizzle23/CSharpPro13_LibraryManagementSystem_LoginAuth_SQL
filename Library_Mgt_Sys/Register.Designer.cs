namespace Library_Mgt_Sys
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            clrbtn = new Button();
            regbtn = new Button();
            checkbxShowPas = new CheckBox();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            genBtn = new Button();
            txtComPassword = new TextBox();
            label4 = new Label();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // clrbtn
            // 
            clrbtn.BackColor = Color.WhiteSmoke;
            clrbtn.FlatStyle = FlatStyle.Flat;
            clrbtn.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            clrbtn.ForeColor = Color.FromArgb(116, 86, 174);
            clrbtn.Location = new Point(51, 539);
            clrbtn.Name = "clrbtn";
            clrbtn.Size = new Size(175, 35);
            clrbtn.TabIndex = 22;
            clrbtn.Text = "clear";
            clrbtn.UseVisualStyleBackColor = false;
            clrbtn.Click += clrbtn_Click;
            // 
            // regbtn
            // 
            regbtn.BackColor = Color.FromArgb(116, 86, 174);
            regbtn.FlatStyle = FlatStyle.Flat;
            regbtn.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            regbtn.ForeColor = Color.WhiteSmoke;
            regbtn.Location = new Point(51, 476);
            regbtn.Name = "regbtn";
            regbtn.Size = new Size(175, 35);
            regbtn.TabIndex = 21;
            regbtn.Text = "register";
            regbtn.UseVisualStyleBackColor = false;
            regbtn.Click += regbtn_Click;
            // 
            // checkbxShowPas
            // 
            checkbxShowPas.AutoSize = true;
            checkbxShowPas.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkbxShowPas.ForeColor = Color.FromArgb(164, 165, 169);
            checkbxShowPas.Location = new Point(70, 358);
            checkbxShowPas.Name = "checkbxShowPas";
            checkbxShowPas.Size = new Size(145, 21);
            checkbxShowPas.TabIndex = 20;
            checkbxShowPas.Text = "show password";
            checkbxShowPas.UseVisualStyleBackColor = true;
            checkbxShowPas.CheckedChanged += checkbxShowPas_CheckedChanged;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(230, 231, 233);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.Location = new Point(27, 241);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(217, 19);
            txtpassword.TabIndex = 19;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.FromArgb(230, 231, 233);
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtusername.Location = new Point(27, 157);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(217, 19);
            txtusername.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(81, 625);
            label6.Name = "label6";
            label6.Size = new Size(107, 17);
            label6.TabIndex = 17;
            label6.Text = "back to login";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(164, 165, 169);
            label5.Location = new Point(40, 598);
            label5.Name = "label5";
            label5.Size = new Size(203, 17);
            label5.TabIndex = 16;
            label5.Text = "Already have and account?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(11, 86, 174);
            label3.Location = new Point(27, 212);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 15;
            label3.Text = "password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(11, 86, 174);
            label2.Location = new Point(27, 128);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 14;
            label2.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(11, 86, 174);
            label1.Location = new Point(27, 87);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 13;
            label1.Text = "Get Started";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // genBtn
            // 
            genBtn.BackColor = Color.WhiteSmoke;
            genBtn.FlatStyle = FlatStyle.Flat;
            genBtn.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            genBtn.ForeColor = Color.FromArgb(116, 86, 174);
            genBtn.Location = new Point(51, 408);
            genBtn.Name = "genBtn";
            genBtn.Size = new Size(175, 37);
            genBtn.TabIndex = 23;
            genBtn.Text = "generate password";
            genBtn.UseVisualStyleBackColor = false;
            genBtn.Click += genBtn_Click;
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtComPassword.BorderStyle = BorderStyle.None;
            txtComPassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComPassword.Location = new Point(27, 318);
            txtComPassword.Name = "txtComPassword";
            txtComPassword.PasswordChar = '*';
            txtComPassword.Size = new Size(217, 19);
            txtComPassword.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(11, 86, 174);
            label4.Location = new Point(27, 289);
            label4.Name = "label4";
            label4.Size = new Size(144, 17);
            label4.TabIndex = 24;
            label4.Text = "confirm password";
            // 
            // exitBtn
            // 
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtn.ForeColor = Color.FromArgb(116, 86, 174);
            exitBtn.Location = new Point(240, 2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(35, 34);
            exitBtn.TabIndex = 26;
            exitBtn.Text = " X";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(277, 661);
            Controls.Add(exitBtn);
            Controls.Add(txtComPassword);
            Controls.Add(label4);
            Controls.Add(genBtn);
            Controls.Add(clrbtn);
            Controls.Add(regbtn);
            Controls.Add(checkbxShowPas);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clrbtn;
        private Button regbtn;
        private CheckBox checkbxShowPas;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button genBtn;
        private TextBox txtComPassword;
        private Label label4;
        private Button exitBtn;
    }
}