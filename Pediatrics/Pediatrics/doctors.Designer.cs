namespace Pediatrics
{
    partial class doctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctors));
            doctoridtextbox = new TextBox();
            firstnametextbox = new TextBox();
            lastnametextbox = new TextBox();
            specialtytextbox = new TextBox();
            emailtextbox = new TextBox();
            contactnumbertextbox = new TextBox();
            scheduletextbox = new TextBox();
            addbutton = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // doctoridtextbox
            // 
            doctoridtextbox.BackColor = Color.FromArgb(231, 251, 255);
            doctoridtextbox.BorderStyle = BorderStyle.None;
            doctoridtextbox.Location = new Point(246, 52);
            doctoridtextbox.Name = "doctoridtextbox";
            doctoridtextbox.Size = new Size(40, 20);
            doctoridtextbox.TabIndex = 7;
            // 
            // firstnametextbox
            // 
            firstnametextbox.BackColor = Color.FromArgb(241, 253, 255);
            firstnametextbox.BorderStyle = BorderStyle.None;
            firstnametextbox.Location = new Point(125, 171);
            firstnametextbox.Name = "firstnametextbox";
            firstnametextbox.Size = new Size(180, 20);
            firstnametextbox.TabIndex = 8;
            // 
            // lastnametextbox
            // 
            lastnametextbox.BackColor = Color.FromArgb(231, 251, 255);
            lastnametextbox.BorderStyle = BorderStyle.None;
            lastnametextbox.Location = new Point(125, 230);
            lastnametextbox.Name = "lastnametextbox";
            lastnametextbox.Size = new Size(180, 20);
            lastnametextbox.TabIndex = 9;
            // 
            // specialtytextbox
            // 
            specialtytextbox.BackColor = Color.FromArgb(231, 251, 255);
            specialtytextbox.BorderStyle = BorderStyle.None;
            specialtytextbox.Location = new Point(125, 290);
            specialtytextbox.Name = "specialtytextbox";
            specialtytextbox.Size = new Size(180, 20);
            specialtytextbox.TabIndex = 10;
            // 
            // emailtextbox
            // 
            emailtextbox.BackColor = Color.FromArgb(231, 251, 255);
            emailtextbox.BorderStyle = BorderStyle.None;
            emailtextbox.Location = new Point(125, 412);
            emailtextbox.Name = "emailtextbox";
            emailtextbox.Size = new Size(180, 20);
            emailtextbox.TabIndex = 11;
            // 
            // contactnumbertextbox
            // 
            contactnumbertextbox.BackColor = Color.FromArgb(231, 251, 255);
            contactnumbertextbox.BorderStyle = BorderStyle.None;
            contactnumbertextbox.Location = new Point(125, 350);
            contactnumbertextbox.Name = "contactnumbertextbox";
            contactnumbertextbox.Size = new Size(180, 20);
            contactnumbertextbox.TabIndex = 12;
            contactnumbertextbox.TextChanged += textBox6_TextChanged;
            // 
            // scheduletextbox
            // 
            scheduletextbox.BackColor = Color.FromArgb(231, 251, 255);
            scheduletextbox.BorderStyle = BorderStyle.None;
            scheduletextbox.Location = new Point(125, 470);
            scheduletextbox.Name = "scheduletextbox";
            scheduletextbox.Size = new Size(180, 20);
            scheduletextbox.TabIndex = 13;
            scheduletextbox.TextChanged += scheduletextbox_TextChanged;
            // 
            // addbutton
            // 
            addbutton.BackColor = Color.FromArgb(224, 249, 181);
            addbutton.FlatAppearance.BorderSize = 0;
            addbutton.FlatStyle = FlatStyle.Flat;
            addbutton.Location = new Point(615, 44);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(110, 36);
            addbutton.TabIndex = 14;
            addbutton.Text = "Add doctor";
            addbutton.UseVisualStyleBackColor = false;
            addbutton.Click += addbutton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(165, 210, 218);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(835, 524);
            button1.Name = "button1";
            button1.Size = new Size(51, 29);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(416, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(483, 352);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 218, 228);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(469, 46);
            button2.Name = "button2";
            button2.Size = new Size(117, 32);
            button2.TabIndex = 17;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(250, 249, 193);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(755, 46);
            button3.Name = "button3";
            button3.Size = new Size(116, 32);
            button3.TabIndex = 18;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 60);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // doctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(939, 576);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(addbutton);
            Controls.Add(scheduletextbox);
            Controls.Add(contactnumbertextbox);
            Controls.Add(emailtextbox);
            Controls.Add(specialtytextbox);
            Controls.Add(lastnametextbox);
            Controls.Add(firstnametextbox);
            Controls.Add(doctoridtextbox);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "doctors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "doctors";
            Load += doctors_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox doctoridtextbox;
        private TextBox firstnametextbox;
        private TextBox lastnametextbox;
        private TextBox specialtytextbox;
        private TextBox emailtextbox;
        private TextBox contactnumbertextbox;
        private TextBox scheduletextbox;
        private Button addbutton;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}