namespace Pediatrics
{
    partial class MedicalRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalRecords));
            patienttextbox = new TextBox();
            button1 = new Button();
            showallrecordbutton = new Button();
            dataGridView1 = new DataGridView();
            nametextbox = new TextBox();
            namebutton = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            firstnametextbox = new TextBox();
            lastnametextbox = new TextBox();
            dateofbirthtextbox = new TextBox();
            gendertextbox = new TextBox();
            contacttextbox = new TextBox();
            addresstextbox = new TextBox();
            idtextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // patienttextbox
            // 
            patienttextbox.BackColor = Color.FromArgb(255, 243, 246);
            patienttextbox.BorderStyle = BorderStyle.None;
            patienttextbox.Font = new Font("STXihei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            patienttextbox.Location = new Point(54, 95);
            patienttextbox.Name = "patienttextbox";
            patienttextbox.PlaceholderText = "Search Patient by ID";
            patienttextbox.Size = new Size(258, 25);
            patienttextbox.TabIndex = 1;
            patienttextbox.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(254, 206, 219);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(350, 87);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 3;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // showallrecordbutton
            // 
            showallrecordbutton.BackColor = Color.FromArgb(223, 206, 254);
            showallrecordbutton.FlatAppearance.BorderSize = 0;
            showallrecordbutton.FlatStyle = FlatStyle.Flat;
            showallrecordbutton.Location = new Point(572, 36);
            showallrecordbutton.Name = "showallrecordbutton";
            showallrecordbutton.Size = new Size(284, 42);
            showallrecordbutton.TabIndex = 4;
            showallrecordbutton.Text = "Show all record";
            showallrecordbutton.UseVisualStyleBackColor = false;
            showallrecordbutton.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(516, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(380, 341);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nametextbox
            // 
            nametextbox.BackColor = Color.FromArgb(255, 243, 246);
            nametextbox.BorderStyle = BorderStyle.None;
            nametextbox.Font = new Font("STXihei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            nametextbox.Location = new Point(54, 163);
            nametextbox.Name = "nametextbox";
            nametextbox.PlaceholderText = "Search Patient by Name";
            nametextbox.Size = new Size(258, 25);
            nametextbox.TabIndex = 7;
            // 
            // namebutton
            // 
            namebutton.BackColor = Color.FromArgb(254, 206, 219);
            namebutton.FlatAppearance.BorderSize = 0;
            namebutton.FlatStyle = FlatStyle.Flat;
            namebutton.Location = new Point(341, 159);
            namebutton.Name = "namebutton";
            namebutton.Size = new Size(103, 31);
            namebutton.TabIndex = 8;
            namebutton.Text = "Show";
            namebutton.UseVisualStyleBackColor = false;
            namebutton.Click += namebutton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(254, 206, 219);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(855, 523);
            button2.Name = "button2";
            button2.Size = new Size(55, 26);
            button2.TabIndex = 9;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(223, 206, 254);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(138, 488);
            button3.Name = "button3";
            button3.Size = new Size(94, 35);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(223, 206, 254);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(265, 484);
            button4.Name = "button4";
            button4.Size = new Size(94, 39);
            button4.TabIndex = 11;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // firstnametextbox
            // 
            firstnametextbox.BackColor = Color.FromArgb(248, 244, 255);
            firstnametextbox.BorderStyle = BorderStyle.None;
            firstnametextbox.Font = new Font("STXihei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            firstnametextbox.Location = new Point(68, 340);
            firstnametextbox.Name = "firstnametextbox";
            firstnametextbox.PlaceholderText = "First Name";
            firstnametextbox.Size = new Size(148, 25);
            firstnametextbox.TabIndex = 19;
            firstnametextbox.TextChanged += textBox1_TextChanged_1;
            // 
            // lastnametextbox
            // 
            lastnametextbox.BackColor = Color.FromArgb(248, 244, 255);
            lastnametextbox.BorderStyle = BorderStyle.None;
            lastnametextbox.Font = new Font("STXihei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lastnametextbox.Location = new Point(276, 340);
            lastnametextbox.Name = "lastnametextbox";
            lastnametextbox.PlaceholderText = "Last Name";
            lastnametextbox.Size = new Size(152, 25);
            lastnametextbox.TabIndex = 20;
            // 
            // dateofbirthtextbox
            // 
            dateofbirthtextbox.BackColor = Color.FromArgb(248, 244, 255);
            dateofbirthtextbox.BorderStyle = BorderStyle.None;
            dateofbirthtextbox.Font = new Font("STXihei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateofbirthtextbox.Location = new Point(64, 393);
            dateofbirthtextbox.Name = "dateofbirthtextbox";
            dateofbirthtextbox.PlaceholderText = "Date of Birth";
            dateofbirthtextbox.Size = new Size(152, 25);
            dateofbirthtextbox.TabIndex = 21;
            // 
            // gendertextbox
            // 
            gendertextbox.BackColor = Color.FromArgb(248, 244, 255);
            gendertextbox.BorderStyle = BorderStyle.None;
            gendertextbox.Font = new Font("STXihei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            gendertextbox.Location = new Point(276, 393);
            gendertextbox.Name = "gendertextbox";
            gendertextbox.PlaceholderText = "Gender";
            gendertextbox.Size = new Size(152, 25);
            gendertextbox.TabIndex = 22;
            // 
            // contacttextbox
            // 
            contacttextbox.BackColor = Color.FromArgb(248, 244, 255);
            contacttextbox.BorderStyle = BorderStyle.None;
            contacttextbox.Font = new Font("STXihei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            contacttextbox.Location = new Point(64, 439);
            contacttextbox.Name = "contacttextbox";
            contacttextbox.PlaceholderText = "Contact Number";
            contacttextbox.Size = new Size(152, 25);
            contacttextbox.TabIndex = 23;
            // 
            // addresstextbox
            // 
            addresstextbox.BackColor = Color.FromArgb(248, 244, 255);
            addresstextbox.BorderStyle = BorderStyle.None;
            addresstextbox.Font = new Font("STXihei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            addresstextbox.Location = new Point(276, 439);
            addresstextbox.Name = "addresstextbox";
            addresstextbox.PlaceholderText = "Address";
            addresstextbox.Size = new Size(152, 25);
            addresstextbox.TabIndex = 24;
            // 
            // idtextbox
            // 
            idtextbox.BackColor = Color.FromArgb(248, 244, 255);
            idtextbox.BorderStyle = BorderStyle.None;
            idtextbox.Font = new Font("STXihei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            idtextbox.Location = new Point(185, 292);
            idtextbox.Name = "idtextbox";
            idtextbox.PlaceholderText = "ID";
            idtextbox.Size = new Size(115, 25);
            idtextbox.TabIndex = 26;
            // 
            // MedicalRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(939, 576);
            Controls.Add(idtextbox);
            Controls.Add(addresstextbox);
            Controls.Add(contacttextbox);
            Controls.Add(gendertextbox);
            Controls.Add(dateofbirthtextbox);
            Controls.Add(lastnametextbox);
            Controls.Add(firstnametextbox);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(namebutton);
            Controls.Add(nametextbox);
            Controls.Add(dataGridView1);
            Controls.Add(showallrecordbutton);
            Controls.Add(button1);
            Controls.Add(patienttextbox);
            DoubleBuffered = true;
            Name = "MedicalRecords";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MedicalRecords";
            Load += MedicalRecords_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox patienttextbox;
        private Button button1;
        private Button showallrecordbutton;
        private DataGridView dataGridView1;
        private TextBox nametextbox;
        private Button namebutton;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox firstnametextbox;
        private TextBox lastnametextbox;
        private TextBox dateofbirthtextbox;
        private TextBox gendertextbox;
        private TextBox contacttextbox;
        private TextBox addresstextbox;
        private TextBox idtextbox;
    }
}