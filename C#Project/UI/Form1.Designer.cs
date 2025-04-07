namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AdminEntry = new Button();
            UserEntry = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AdminEntry
            // 
            AdminEntry.Location = new Point(507, 189);
            AdminEntry.Margin = new Padding(3, 4, 3, 4);
            AdminEntry.Name = "AdminEntry";
            AdminEntry.Size = new Size(151, 92);
            AdminEntry.TabIndex = 0;
            AdminEntry.Text = "מנהל";
            AdminEntry.UseVisualStyleBackColor = true;
            AdminEntry.Click += AdminEntry_Click;
            // 
            // UserEntry
            // 
            UserEntry.Location = new Point(298, 189);
            UserEntry.Margin = new Padding(3, 4, 3, 4);
            UserEntry.Name = "UserEntry";
            UserEntry.Size = new Size(151, 92);
            UserEntry.TabIndex = 0;
            UserEntry.Text = "משתמש";
            UserEntry.UseVisualStyleBackColor = true;
            UserEntry.Click += UserEntry_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(342, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 54);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(UserEntry);
            Controls.Add(AdminEntry);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AdminEntry;
        private Button UserEntry;
        private PictureBox pictureBox1;
    }
}
