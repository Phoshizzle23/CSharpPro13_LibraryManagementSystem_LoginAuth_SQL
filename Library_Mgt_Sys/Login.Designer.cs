namespace Library_Mgt_Sys
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            userTxt = new TextBox();
            passwordtxt = new TextBox();
            checkbxShowPas = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(11, 86, 174);
            label1.Location = new Point(75, 106);
            label1.Name = "label1";
            label1.Size = new Size(203, 23);
            label1.TabIndex = 1;
            label1.Text = "Night City Library";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(11, 86, 174);
            label2.Location = new Point(75, 155);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 2;
            label2.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(11, 86, 174);
            label3.Location = new Point(75, 238);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 3;
            label3.Text = "password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(164, 165, 169);
            label5.Location = new Point(94, 478);
            label5.Name = "label5";
            label5.Size = new Size(186, 17);
            label5.TabIndex = 5;
            label5.Text = "Don't have and account?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(126, 509);
            label6.Name = "label6";
            label6.Size = new Size(121, 17);
            label6.TabIndex = 6;
            label6.Text = "create account";
            label6.Click += label6_Click;
            // 
            // userTxt
            // 
            userTxt.BackColor = Color.FromArgb(230, 231, 233);
            userTxt.BorderStyle = BorderStyle.None;
            userTxt.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userTxt.Location = new Point(75, 186);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(231, 19);
            userTxt.TabIndex = 7;
            // 
            // passwordtxt
            // 
            passwordtxt.BackColor = Color.FromArgb(230, 231, 233);
            passwordtxt.BorderStyle = BorderStyle.None;
            passwordtxt.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordtxt.Location = new Point(75, 274);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '*';
            passwordtxt.Size = new Size(231, 19);
            passwordtxt.TabIndex = 8;
            // 
            // checkbxShowPas
            // 
            checkbxShowPas.AutoSize = true;
            checkbxShowPas.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkbxShowPas.ForeColor = Color.FromArgb(164, 165, 169);
            checkbxShowPas.Location = new Point(161, 303);
            checkbxShowPas.Name = "checkbxShowPas";
            checkbxShowPas.Size = new Size(145, 21);
            checkbxShowPas.TabIndex = 9;
            checkbxShowPas.Text = "show password";
            checkbxShowPas.UseVisualStyleBackColor = true;
            checkbxShowPas.CheckedChanged += checkbxShowPas_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(110, 357);
            button1.Name = "button1";
            button1.Size = new Size(168, 40);
            button1.TabIndex = 10;
            button1.Text = "log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(110, 419);
            button2.Name = "button2";
            button2.Size = new Size(170, 36);
            button2.TabIndex = 11;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // exitBtn
            // 
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtn.ForeColor = Color.FromArgb(116, 86, 174);
            exitBtn.Location = new Point(335, 1);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(35, 34);
            exitBtn.TabIndex = 12;
            exitBtn.Text = " X";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(372, 554);
            Controls.Add(exitBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkbxShowPas);
            Controls.Add(passwordtxt);
            Controls.Add(userTxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox userTxt;
        private TextBox passwordtxt;
        private CheckBox checkbxShowPas;
        private Button button1;
        private Button button2;
        private Button exitBtn;
    }
}