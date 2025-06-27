namespace MembershipDesktop
{
    partial class AddMember
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
            pictureBox1 = new PictureBox();
            txt_name = new TextBox();
            txt_age = new TextBox();
            txt_birthdate = new TextBox();
            txt_address = new TextBox();
            txt_gmail = new TextBox();
            btn_save = new Button();
            btn_exit = new Button();
            lbl_name = new Label();
            lbl_age = new Label();
            lbl_birthdate = new Label();
            lbl_address = new Label();
            lbl_gmail = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.guibg2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(279, 140);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(329, 26);
            txt_name.TabIndex = 1;
            // 
            // txt_age
            // 
            txt_age.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_age.Location = new Point(279, 185);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(329, 26);
            txt_age.TabIndex = 2;
            // 
            // txt_birthdate
            // 
            txt_birthdate.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_birthdate.Location = new Point(279, 229);
            txt_birthdate.Name = "txt_birthdate";
            txt_birthdate.Size = new Size(329, 26);
            txt_birthdate.TabIndex = 3;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_address.Location = new Point(279, 275);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(329, 26);
            txt_address.TabIndex = 4;
            // 
            // txt_gmail
            // 
            txt_gmail.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_gmail.Location = new Point(279, 321);
            txt_gmail.Name = "txt_gmail";
            txt_gmail.Size = new Size(329, 26);
            txt_gmail.TabIndex = 5;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(79, 119, 46);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(279, 381);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 32);
            btn_save.TabIndex = 6;
            btn_save.Text = "SAVE";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(79, 119, 46);
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(441, 381);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(77, 32);
            btn_exit.TabIndex = 7;
            btn_exit.Text = "EXIT";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.BackColor = Color.White;
            lbl_name.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(187, 142);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(62, 19);
            lbl_name.TabIndex = 8;
            lbl_name.Text = "Name:";
            // 
            // lbl_age
            // 
            lbl_age.AutoSize = true;
            lbl_age.BackColor = Color.White;
            lbl_age.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_age.Location = new Point(187, 187);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(47, 19);
            lbl_age.TabIndex = 9;
            lbl_age.Text = "Age:";
            // 
            // lbl_birthdate
            // 
            lbl_birthdate.AutoSize = true;
            lbl_birthdate.BackColor = Color.White;
            lbl_birthdate.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_birthdate.Location = new Point(187, 231);
            lbl_birthdate.Name = "lbl_birthdate";
            lbl_birthdate.Size = new Size(92, 19);
            lbl_birthdate.TabIndex = 10;
            lbl_birthdate.Text = "Birthdate:";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.BackColor = Color.White;
            lbl_address.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_address.Location = new Point(187, 277);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(80, 19);
            lbl_address.TabIndex = 11;
            lbl_address.Text = "Address:";
            // 
            // lbl_gmail
            // 
            lbl_gmail.AutoSize = true;
            lbl_gmail.BackColor = Color.White;
            lbl_gmail.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_gmail.Location = new Point(187, 323);
            lbl_gmail.Name = "lbl_gmail";
            lbl_gmail.Size = new Size(62, 19);
            lbl_gmail.TabIndex = 12;
            lbl_gmail.Text = "Gmail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(79, 119, 46);
            label1.Location = new Point(312, 88);
            label1.Name = "label1";
            label1.Size = new Size(177, 29);
            label1.TabIndex = 13;
            label1.Text = "ADD MEMBER";
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lbl_gmail);
            Controls.Add(lbl_address);
            Controls.Add(lbl_birthdate);
            Controls.Add(lbl_age);
            Controls.Add(lbl_name);
            Controls.Add(btn_exit);
            Controls.Add(btn_save);
            Controls.Add(txt_gmail);
            Controls.Add(txt_address);
            Controls.Add(txt_birthdate);
            Controls.Add(txt_age);
            Controls.Add(txt_name);
            Controls.Add(pictureBox1);
            Name = "AddMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMember";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txt_name;
        private TextBox txt_age;
        private TextBox txt_birthdate;
        private TextBox txt_address;
        private TextBox txt_gmail;
        private Button btn_save;
        private Button btn_exit;
        private Label lbl_name;
        private Label lbl_age;
        private Label lbl_birthdate;
        private Label lbl_address;
        private Label lbl_gmail;
        private Label label1;
    }
}