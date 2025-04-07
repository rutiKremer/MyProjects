namespace UI
{
    partial class LoginForUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForUsers));
            IdentityCard = new TextBox();
            label2 = new Label();
            label1 = new Label();
            buttonForEntry = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // IdentityCard
            // 
            IdentityCard.Location = new Point(328, 204);
            IdentityCard.Name = "IdentityCard";
            IdentityCard.Size = new Size(144, 27);
            IdentityCard.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(478, 204);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(89, 28);
            label2.TabIndex = 12;
            label2.Text = ":ת.ז לקוח";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(333, 103);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 14;
            label1.Text = "כניסת משתמש";
            // 
            // buttonForEntry
            // 
            buttonForEntry.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonForEntry.Location = new Point(343, 315);
            buttonForEntry.Margin = new Padding(3, 4, 3, 4);
            buttonForEntry.Name = "buttonForEntry";
            buttonForEntry.Size = new Size(114, 55);
            buttonForEntry.TabIndex = 15;
            buttonForEntry.Text = "כניסה";
            buttonForEntry.UseVisualStyleBackColor = true;
            buttonForEntry.Click += buttonForEntry_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(277, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 54);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // LoginForUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(buttonForEntry);
            Controls.Add(label1);
            Controls.Add(IdentityCard);
            Controls.Add(label2);
            Name = "LoginForUsers";
            Text = "LoginForUsers";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IdentityCard;
        private Label label2;
        private Label label1;
        private Button buttonForEntry;
        private PictureBox pictureBox1;
    }
}