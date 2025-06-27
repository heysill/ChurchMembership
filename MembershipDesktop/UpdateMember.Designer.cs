namespace MembershipDesktop
{
    partial class UpdateMember
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
            txt_update = new TextBox();
            txt_name = new TextBox();
            txt_age = new TextBox();
            txt_birthdate = new TextBox();
            txt_address = new TextBox();
            txt_gmail = new TextBox();
            btn_update = new Button();
            btn_save = new Button();
            pictureBox1 = new PictureBox();
            lbl_name = new Label();
            lbl_age = new Label();
            lbl_birthdate = new Label();
            lbl_address = new Label();
            lbl_gmail = new Label();
            lbl_entermember = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_update
            // 
            txt_update.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_update.Location = new Point(241, 113);
            txt_update.Name = "txt_update";
            txt_update.Size = new Size(299, 26);
            txt_update.TabIndex = 0;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(241, 175);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(299, 26);
            txt_name.TabIndex = 1;
            // 
            // txt_age
            // 
            txt_age.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_age.Location = new Point(241, 219);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(299, 26);
            txt_age.TabIndex = 2;
            // 
            // txt_birthdate
            // 
            txt_birthdate.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_birthdate.Location = new Point(241, 261);
            txt_birthdate.Name = "txt_birthdate";
            txt_birthdate.Size = new Size(299, 26);
            txt_birthdate.TabIndex = 3;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_address.Location = new Point(241, 304);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(299, 26);
            txt_address.TabIndex = 4;
            // 
            // txt_gmail
            // 
            txt_gmail.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_gmail.Location = new Point(241, 346);
            txt_gmail.Name = "txt_gmail";
            txt_gmail.Size = new Size(299, 26);
            txt_gmail.TabIndex = 5;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(79, 119, 46);
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(546, 113);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(84, 26);
            btn_update.TabIndex = 6;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(79, 119, 46);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(345, 391);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(111, 27);
            btn_save.TabIndex = 7;
            btn_save.Text = "SAVE CHANGES";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.guibg2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.BackColor = Color.White;
            lbl_name.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(153, 178);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(56, 18);
            lbl_name.TabIndex = 9;
            lbl_name.Text = "Name:";
            // 
            // lbl_age
            // 
            lbl_age.AutoSize = true;
            lbl_age.BackColor = Color.White;
            lbl_age.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_age.Location = new Point(153, 222);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(41, 18);
            lbl_age.TabIndex = 10;
            lbl_age.Text = "Age:";
            // 
            // lbl_birthdate
            // 
            lbl_birthdate.AutoSize = true;
            lbl_birthdate.BackColor = Color.White;
            lbl_birthdate.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_birthdate.Location = new Point(152, 264);
            lbl_birthdate.Name = "lbl_birthdate";
            lbl_birthdate.Size = new Size(83, 18);
            lbl_birthdate.TabIndex = 11;
            lbl_birthdate.Text = "Birthdate:";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.BackColor = Color.White;
            lbl_address.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_address.Location = new Point(152, 307);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(73, 18);
            lbl_address.TabIndex = 12;
            lbl_address.Text = "Address:";
            // 
            // lbl_gmail
            // 
            lbl_gmail.AutoSize = true;
            lbl_gmail.BackColor = Color.White;
            lbl_gmail.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_gmail.Location = new Point(153, 349);
            lbl_gmail.Name = "lbl_gmail";
            lbl_gmail.Size = new Size(56, 18);
            lbl_gmail.TabIndex = 13;
            lbl_gmail.Text = "Gmail:";
            // 
            // lbl_entermember
            // 
            lbl_entermember.AutoSize = true;
            lbl_entermember.BackColor = Color.White;
            lbl_entermember.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_entermember.Location = new Point(115, 117);
            lbl_entermember.Name = "lbl_entermember";
            lbl_entermember.Size = new Size(120, 18);
            lbl_entermember.TabIndex = 14;
            lbl_entermember.Text = "Member Name:";
            // 
            // UpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_entermember);
            Controls.Add(lbl_gmail);
            Controls.Add(lbl_address);
            Controls.Add(lbl_birthdate);
            Controls.Add(lbl_age);
            Controls.Add(lbl_name);
            Controls.Add(btn_save);
            Controls.Add(btn_update);
            Controls.Add(txt_gmail);
            Controls.Add(txt_address);
            Controls.Add(txt_birthdate);
            Controls.Add(txt_age);
            Controls.Add(txt_name);
            Controls.Add(txt_update);
            Controls.Add(pictureBox1);
            Name = "UpdateMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateMember";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_update;
        private TextBox txt_name;
        private TextBox txt_age;
        private TextBox txt_birthdate;
        private TextBox txt_address;
        private TextBox txt_gmail;
        private Button btn_update;
        private Button btn_save;
        private PictureBox pictureBox1;
        private Label lbl_name;
        private Label lbl_age;
        private Label lbl_birthdate;
        private Label lbl_address;
        private Label lbl_gmail;
        private Label lbl_entermember;
    }
}