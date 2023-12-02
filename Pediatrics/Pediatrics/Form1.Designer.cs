namespace Pediatrics
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            loginbutton = new Button();
            label1 = new Label();
            label2 = new Label();
            usernametextbox = new TextBox();
            passwordtextbox = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.Transparent;
            loginbutton.BackgroundImage = (Image)resources.GetObject("loginbutton.BackgroundImage");
            loginbutton.BackgroundImageLayout = ImageLayout.Stretch;
            loginbutton.FlatAppearance.BorderSize = 0;
            loginbutton.FlatStyle = FlatStyle.Flat;
            loginbutton.Font = new Font("STXihei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginbutton.Location = new Point(537, 426);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(94, 29);
            loginbutton.TabIndex = 0;
            loginbutton.Text = "Log In";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 283);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 186);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // usernametextbox
            // 
            usernametextbox.BackColor = Color.FromArgb(255, 255, 245);
            usernametextbox.BorderStyle = BorderStyle.None;
            usernametextbox.Font = new Font("STXihei", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            usernametextbox.ForeColor = Color.Gray;
            usernametextbox.Location = new Point(520, 303);
            usernametextbox.Name = "usernametextbox";
            usernametextbox.PlaceholderText = "Username";
            usernametextbox.Size = new Size(279, 28);
            usernametextbox.TabIndex = 3;
            usernametextbox.TextChanged += usernametextbox_TextChanged;
            // 
            // passwordtextbox
            // 
            passwordtextbox.BackColor = Color.FromArgb(255, 255, 245);
            passwordtextbox.BorderStyle = BorderStyle.None;
            passwordtextbox.Cursor = Cursors.IBeam;
            passwordtextbox.Font = new Font("STXihei", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            passwordtextbox.Location = new Point(520, 361);
            passwordtextbox.Multiline = true;
            passwordtextbox.Name = "passwordtextbox";
            passwordtextbox.PasswordChar = '*';
            passwordtextbox.PlaceholderText = "Password";
            passwordtextbox.Size = new Size(279, 27);
            passwordtextbox.TabIndex = 4;
            passwordtextbox.TextChanged += passwordtextbox_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("STXihei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(678, 426);
            button1.Name = "button1";
            button1.Size = new Size(88, 29);
            button1.TabIndex = 5;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(770, 364);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 6;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(939, 576);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(passwordtextbox);
            Controls.Add(usernametextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginbutton);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginbutton;
        private Label label1;
        private Label label2;
        private TextBox usernametextbox;
        private TextBox passwordtextbox;
        private Button button1;
        private CheckBox checkBox1;
    }
}