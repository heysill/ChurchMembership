namespace MembershipDesktop
{
    partial class MainMenu
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
            btn_add = new Button();
            btn_view = new Button();
            btn_cancel = new Button();
            btn_update = new Button();
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
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(79, 119, 46);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(296, 126);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(221, 60);
            btn_add.TabIndex = 1;
            btn_add.Text = "ADD MEMBER";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_view
            // 
            btn_view.BackColor = Color.FromArgb(79, 119, 46);
            btn_view.FlatStyle = FlatStyle.Flat;
            btn_view.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_view.ForeColor = Color.White;
            btn_view.Location = new Point(296, 192);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(221, 60);
            btn_view.TabIndex = 2;
            btn_view.Text = "VIEW MEMBER";
            btn_view.UseVisualStyleBackColor = false;
            btn_view.Click += btn_view_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(79, 119, 46);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancel.ForeColor = Color.White;
            btn_cancel.Location = new Point(296, 258);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(221, 60);
            btn_cancel.TabIndex = 3;
            btn_cancel.Text = "CANCEL MEMBERSHIP";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(79, 119, 46);
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(296, 324);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(221, 60);
            btn_update.TabIndex = 4;
            btn_update.Text = "UPDATE MEMBER";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_update);
            Controls.Add(btn_cancel);
            Controls.Add(btn_view);
            Controls.Add(btn_add);
            Controls.Add(pictureBox1);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_add;
        private Button btn_view;
        private Button btn_cancel;
        private Button btn_update;
    }
}