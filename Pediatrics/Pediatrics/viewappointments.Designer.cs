namespace Pediatrics
{
    partial class viewappointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewappointments));
            idtextbox = new TextBox();
            searchbutton = new Button();
            dataGridView1 = new DataGridView();
            showalltextbox = new Button();
            backbutton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // idtextbox
            // 
            idtextbox.BackColor = Color.FromArgb(244, 255, 226);
            idtextbox.BorderStyle = BorderStyle.None;
            idtextbox.Location = new Point(252, 205);
            idtextbox.Name = "idtextbox";
            idtextbox.Size = new Size(54, 20);
            idtextbox.TabIndex = 1;
            // 
            // searchbutton
            // 
            searchbutton.BackColor = Color.FromArgb(244, 255, 226);
            searchbutton.FlatAppearance.BorderSize = 0;
            searchbutton.FlatStyle = FlatStyle.Flat;
            searchbutton.Location = new Point(189, 267);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(98, 36);
            searchbutton.TabIndex = 2;
            searchbutton.Text = "Search";
            searchbutton.UseVisualStyleBackColor = false;
            searchbutton.Click += searchbutton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(379, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(510, 410);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // showalltextbox
            // 
            showalltextbox.BackColor = Color.FromArgb(165, 210, 218);
            showalltextbox.FlatAppearance.BorderSize = 0;
            showalltextbox.FlatStyle = FlatStyle.Flat;
            showalltextbox.Location = new Point(74, 327);
            showalltextbox.Name = "showalltextbox";
            showalltextbox.Size = new Size(213, 35);
            showalltextbox.TabIndex = 7;
            showalltextbox.Text = "Show all records";
            showalltextbox.UseVisualStyleBackColor = false;
            showalltextbox.Click += showalltextbox_Click;
            // 
            // backbutton
            // 
            backbutton.BackColor = Color.FromArgb(254, 206, 219);
            backbutton.FlatAppearance.BorderSize = 0;
            backbutton.FlatStyle = FlatStyle.Flat;
            backbutton.Location = new Point(857, 521);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(53, 28);
            backbutton.TabIndex = 8;
            backbutton.Text = "Back";
            backbutton.UseVisualStyleBackColor = false;
            backbutton.Click += backbutton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(244, 255, 226);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(74, 267);
            button1.Name = "button1";
            button1.Size = new Size(80, 36);
            button1.TabIndex = 9;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // viewappointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(939, 576);
            Controls.Add(button1);
            Controls.Add(backbutton);
            Controls.Add(showalltextbox);
            Controls.Add(dataGridView1);
            Controls.Add(searchbutton);
            Controls.Add(idtextbox);
            DoubleBuffered = true;
            Name = "viewappointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "viewappointments";
            Load += viewappointments_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox idtextbox;
        private Button searchbutton;
        private DataGridView dataGridView1;
        private Button showalltextbox;
        private Button backbutton;
        private Button button1;
    }
}