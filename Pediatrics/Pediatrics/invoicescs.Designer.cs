namespace Pediatrics
{
    partial class invoicescs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoicescs));
            invoiceidtextbox = new TextBox();
            patientidtextbox = new TextBox();
            doctoridtextbox = new TextBox();
            appointmentidtextbox = new TextBox();
            datetextbox = new TextBox();
            totalamounttextbox = new TextBox();
            paymentstatustextbox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // invoiceidtextbox
            // 
            invoiceidtextbox.BackColor = Color.FromArgb(248, 244, 255);
            invoiceidtextbox.BorderStyle = BorderStyle.None;
            invoiceidtextbox.Location = new Point(172, 164);
            invoiceidtextbox.Name = "invoiceidtextbox";
            invoiceidtextbox.Size = new Size(42, 20);
            invoiceidtextbox.TabIndex = 7;
            // 
            // patientidtextbox
            // 
            patientidtextbox.BackColor = Color.FromArgb(254, 255, 223);
            patientidtextbox.BorderStyle = BorderStyle.None;
            patientidtextbox.Location = new Point(852, 62);
            patientidtextbox.Name = "patientidtextbox";
            patientidtextbox.Size = new Size(35, 20);
            patientidtextbox.TabIndex = 8;
            patientidtextbox.TextChanged += patientidtextbox_TextChanged;
            // 
            // doctoridtextbox
            // 
            doctoridtextbox.BackColor = Color.FromArgb(244, 255, 226);
            doctoridtextbox.BorderStyle = BorderStyle.None;
            doctoridtextbox.Location = new Point(644, 62);
            doctoridtextbox.Name = "doctoridtextbox";
            doctoridtextbox.Size = new Size(37, 20);
            doctoridtextbox.TabIndex = 9;
            // 
            // appointmentidtextbox
            // 
            appointmentidtextbox.BackColor = Color.FromArgb(255, 243, 246);
            appointmentidtextbox.BorderStyle = BorderStyle.None;
            appointmentidtextbox.Location = new Point(437, 62);
            appointmentidtextbox.Name = "appointmentidtextbox";
            appointmentidtextbox.Size = new Size(38, 20);
            appointmentidtextbox.TabIndex = 10;
            appointmentidtextbox.TextChanged += appointmentidtextbox_TextChanged;
            // 
            // datetextbox
            // 
            datetextbox.BackColor = Color.FromArgb(255, 243, 246);
            datetextbox.BorderStyle = BorderStyle.None;
            datetextbox.Font = new Font("STXihei", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            datetextbox.Location = new Point(55, 225);
            datetextbox.Name = "datetextbox";
            datetextbox.PlaceholderText = "Date";
            datetextbox.Size = new Size(159, 28);
            datetextbox.TabIndex = 11;
            // 
            // totalamounttextbox
            // 
            totalamounttextbox.BackColor = Color.FromArgb(255, 243, 246);
            totalamounttextbox.BorderStyle = BorderStyle.None;
            totalamounttextbox.Font = new Font("STXihei", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            totalamounttextbox.Location = new Point(55, 285);
            totalamounttextbox.Name = "totalamounttextbox";
            totalamounttextbox.PlaceholderText = "Total Amount";
            totalamounttextbox.Size = new Size(162, 28);
            totalamounttextbox.TabIndex = 12;
            // 
            // paymentstatustextbox
            // 
            paymentstatustextbox.BackColor = Color.FromArgb(255, 243, 246);
            paymentstatustextbox.BorderStyle = BorderStyle.None;
            paymentstatustextbox.Font = new Font("STXihei", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            paymentstatustextbox.Location = new Point(55, 343);
            paymentstatustextbox.Name = "paymentstatustextbox";
            paymentstatustextbox.PlaceholderText = "Payment Status";
            paymentstatustextbox.Size = new Size(162, 28);
            paymentstatustextbox.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(250, 249, 193);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(150, 407);
            button1.Name = "button1";
            button1.Size = new Size(84, 27);
            button1.TabIndex = 14;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(185, 235, 167);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(852, 529);
            button2.Name = "button2";
            button2.Size = new Size(49, 25);
            button2.TabIndex = 15;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(279, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(608, 349);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 218, 228);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(34, 407);
            button3.Name = "button3";
            button3.Size = new Size(89, 27);
            button3.TabIndex = 17;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // invoicescs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(939, 576);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(paymentstatustextbox);
            Controls.Add(totalamounttextbox);
            Controls.Add(datetextbox);
            Controls.Add(appointmentidtextbox);
            Controls.Add(doctoridtextbox);
            Controls.Add(patientidtextbox);
            Controls.Add(invoiceidtextbox);
            DoubleBuffered = true;
            Name = "invoicescs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "invoicescs";
            Load += invoicescs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox invoiceidtextbox;
        private TextBox patientidtextbox;
        private TextBox doctoridtextbox;
        private TextBox appointmentidtextbox;
        private TextBox datetextbox;
        private TextBox totalamounttextbox;
        private TextBox paymentstatustextbox;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
    }
}