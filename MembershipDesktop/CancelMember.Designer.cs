namespace MembershipDesktop
{
    partial class CancelMember
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
            txt_cancel = new TextBox();
            btn_cancel = new Button();
            pictureBox1 = new PictureBox();
            lbl_cancel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_cancel
            // 
            txt_cancel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_cancel.Location = new Point(55, 142);
            txt_cancel.Name = "txt_cancel";
            txt_cancel.Size = new Size(164, 26);
            txt_cancel.TabIndex = 0;
            txt_cancel.Text = "Enter member name";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(79, 119, 46);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancel.ForeColor = Color.White;
            btn_cancel.Location = new Point(237, 139);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(86, 30);
            btn_cancel.TabIndex = 1;
            btn_cancel.Text = "CANCEL";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.guibg2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(384, 261);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lbl_cancel
            // 
            lbl_cancel.AutoSize = true;
            lbl_cancel.BackColor = Color.White;
            lbl_cancel.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cancel.ForeColor = Color.FromArgb(79, 119, 46);
            lbl_cancel.Location = new Point(55, 63);
            lbl_cancel.Name = "lbl_cancel";
            lbl_cancel.Size = new Size(282, 29);
            lbl_cancel.TabIndex = 3;
            lbl_cancel.Text = "CANCEL MEMBERSHIP";
            // 
            // CancelMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(lbl_cancel);
            Controls.Add(btn_cancel);
            Controls.Add(txt_cancel);
            Controls.Add(pictureBox1);
            Name = "CancelMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CancelMember";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_cancel;
        private Button btn_cancel;
        private PictureBox pictureBox1;
        private Label lbl_cancel;
    }
}