namespace MembershipDesktop
{
    partial class ViewMember
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
            dataGridView1 = new DataGridView();
            column_name = new DataGridViewTextBoxColumn();
            column_age = new DataGridViewTextBoxColumn();
            column_birthdate = new DataGridViewTextBoxColumn();
            column_address = new DataGridViewTextBoxColumn();
            column_gmail = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            btn_exit = new Button();
            lbl_view = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { column_name, column_age, column_birthdate, column_address, column_gmail });
            dataGridView1.Location = new Point(84, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(633, 261);
            dataGridView1.TabIndex = 0;
            // 
            // column_name
            // 
            column_name.HeaderText = "Name";
            column_name.Name = "column_name";
            // 
            // column_age
            // 
            column_age.HeaderText = "Age";
            column_age.Name = "column_age";
            // 
            // column_birthdate
            // 
            column_birthdate.HeaderText = "Birthdate";
            column_birthdate.Name = "column_birthdate";
            // 
            // column_address
            // 
            column_address.HeaderText = "Address";
            column_address.Name = "column_address";
            // 
            // column_gmail
            // 
            column_gmail.HeaderText = "Gmail";
            column_gmail.Name = "column_gmail";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.guibg2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(79, 119, 46);
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(364, 403);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 35);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "EXIT";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // lbl_view
            // 
            lbl_view.AutoSize = true;
            lbl_view.BackColor = Color.White;
            lbl_view.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_view.ForeColor = Color.FromArgb(79, 119, 46);
            lbl_view.Location = new Point(296, 86);
            lbl_view.Name = "lbl_view";
            lbl_view.Size = new Size(235, 29);
            lbl_view.TabIndex = 9;
            lbl_view.Text = "LIST OF MEMBERS";
            // 
            // ViewMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_view);
            Controls.Add(btn_exit);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "ViewMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewMember";
            Load += ViewMember_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn column_name;
        private DataGridViewTextBoxColumn column_age;
        private DataGridViewTextBoxColumn column_birthdate;
        private DataGridViewTextBoxColumn column_address;
        private DataGridViewTextBoxColumn column_gmail;
        private PictureBox pictureBox1;
        private Button btn_exit;
        private Label lbl_view;
    }
}