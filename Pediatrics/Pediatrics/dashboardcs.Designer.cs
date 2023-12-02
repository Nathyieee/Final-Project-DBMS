namespace Pediatrics
{
    partial class dashboardcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardcs));
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            timerlabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button9 = new Button();
            button10 = new Button();
            button8 = new Button();
            datelabel = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(254, 206, 219);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("STXihei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(670, 163);
            button2.Name = "button2";
            button2.Size = new Size(266, 49);
            button2.TabIndex = 1;
            button2.Text = "Add Patient ";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 249, 181);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("STXihei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(695, 292);
            button3.Name = "button3";
            button3.Size = new Size(241, 44);
            button3.TabIndex = 2;
            button3.Text = "View Doctors";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(250, 249, 193);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("STXihei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(615, 229);
            button4.Name = "button4";
            button4.Size = new Size(321, 42);
            button4.TabIndex = 3;
            button4.Text = "View Appointments";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(238, 229, 255);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("STXihei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(706, 421);
            button5.Name = "button5";
            button5.Size = new Size(230, 44);
            button5.TabIndex = 4;
            button5.Text = "Invoices";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(165, 210, 218);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("STXihei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(658, 359);
            button6.Name = "button6";
            button6.Size = new Size(278, 40);
            button6.TabIndex = 5;
            button6.Text = "View Medical Records";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(866, 490);
            button7.Name = "button7";
            button7.Size = new Size(70, 54);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // timerlabel
            // 
            timerlabel.AutoSize = true;
            timerlabel.BackColor = Color.Transparent;
            timerlabel.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            timerlabel.ForeColor = Color.Gray;
            timerlabel.Location = new Point(841, 12);
            timerlabel.Name = "timerlabel";
            timerlabel.Size = new Size(75, 19);
            timerlabel.TabIndex = 8;
            timerlabel.Text = "00:00:00";
            timerlabel.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 249, 181);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(430, 12);
            button1.Name = "button1";
            button1.Size = new Size(100, 36);
            button1.TabIndex = 9;
            button1.Text = "About Us";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(250, 249, 193);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(303, 12);
            button9.Name = "button9";
            button9.Size = new Size(111, 35);
            button9.TabIndex = 10;
            button9.Text = "Dashboard";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(238, 229, 255);
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(549, 13);
            button10.Name = "button10";
            button10.Size = new Size(100, 33);
            button10.TabIndex = 11;
            button10.Text = "Contacts";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.Transparent;
            button8.Location = new Point(786, 490);
            button8.Name = "button8";
            button8.Size = new Size(61, 54);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // datelabel
            // 
            datelabel.AutoSize = true;
            datelabel.BackColor = Color.Transparent;
            datelabel.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            datelabel.Location = new Point(717, 41);
            datelabel.Name = "datelabel";
            datelabel.Size = new Size(43, 19);
            datelabel.TabIndex = 12;
            datelabel.Text = "Date";
            // 
            // dashboardcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(939, 576);
            Controls.Add(datelabel);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button1);
            Controls.Add(timerlabel);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            DoubleBuffered = true;
            Name = "dashboardcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboardcs";
            Load += dashboardcs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label timerlabel;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button9;
        private Button button10;
        private Button button8;
        private Label datelabel;
    }
}