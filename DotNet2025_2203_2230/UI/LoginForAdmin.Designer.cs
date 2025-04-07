namespace UI
{
    partial class LoginForAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForAdmin));
            label2 = new Label();
            password = new TextBox();
            buttonForEntry = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(552, 232);
            label2.Name = "label2";
            label2.Size = new Size(89, 31);
            label2.TabIndex = 0;
            label2.Text = ":סיסמה";
            // 
            // password
            // 
            password.Location = new Point(332, 238);
            password.Margin = new Padding(3, 4, 3, 4);
            password.Name = "password";
            password.Size = new Size(179, 27);
            password.TabIndex = 1;
            // 
            // buttonForEntry
            // 
            buttonForEntry.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonForEntry.Location = new Point(397, 363);
            buttonForEntry.Margin = new Padding(3, 4, 3, 4);
            buttonForEntry.Name = "buttonForEntry";
            buttonForEntry.Size = new Size(114, 55);
            buttonForEntry.TabIndex = 2;
            buttonForEntry.Text = "כניסה";
            buttonForEntry.UseVisualStyleBackColor = true;
            buttonForEntry.Click += buttonForEntry_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(392, 124);
            label1.Name = "label1";
            label1.Size = new Size(138, 37);
            label1.TabIndex = 15;
            label1.Text = "כניסת מנהל";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(332, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 54);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // LoginForAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(buttonForEntry);
            Controls.Add(password);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForAdmin";
            Text = "LoginForAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox password;
        private Button buttonForEntry;
        private Label label1;
        private PictureBox pictureBox1;
    }
}