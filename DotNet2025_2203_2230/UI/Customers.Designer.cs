namespace UI
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            phone = new TextBox();
            address = new TextBox();
            NameCustomer = new TextBox();
            label4 = new Label();
            IdentityCard = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            add = new Label();
            tabPage2 = new TabPage();
            delete = new Label();
            customersList = new ComboBox();
            label8 = new Label();
            tabPage3 = new TabPage();
            phonCus = new TextBox();
            addressCus = new TextBox();
            label7 = new Label();
            label9 = new Label();
            identityCus = new ComboBox();
            label5 = new Label();
            nameCus = new TextBox();
            label14 = new Label();
            update = new Label();
            tabPage4 = new TabPage();
            searchCus = new Button();
            allC = new Button();
            oneCustomer = new ComboBox();
            label10 = new Label();
            allCustomers = new ListBox();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(411, 28);
            label1.Name = "label1";
            label1.Size = new Size(102, 37);
            label1.TabIndex = 1;
            label1.Text = "לקוחות";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(47, 68);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(821, 464);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(phone);
            tabPage1.Controls.Add(address);
            tabPage1.Controls.Add(NameCustomer);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(IdentityCard);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(add);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(813, 431);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספת לקוח";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // phone
            // 
            phone.Location = new Point(393, 253);
            phone.Name = "phone";
            phone.Size = new Size(144, 27);
            phone.TabIndex = 11;
            // 
            // address
            // 
            address.Location = new Point(393, 197);
            address.Name = "address";
            address.Size = new Size(144, 27);
            address.TabIndex = 11;
            // 
            // NameCustomer
            // 
            NameCustomer.Location = new Point(370, 137);
            NameCustomer.Name = "NameCustomer";
            NameCustomer.Size = new Size(144, 27);
            NameCustomer.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(563, 249);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(64, 28);
            label4.TabIndex = 10;
            label4.Text = ":טלפון";
            // 
            // IdentityCard
            // 
            IdentityCard.Location = new Point(383, 80);
            IdentityCard.Name = "IdentityCard";
            IdentityCard.Size = new Size(144, 27);
            IdentityCard.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(554, 193);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(73, 28);
            label3.TabIndex = 10;
            label3.Text = ":כתובת";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(537, 137);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(93, 28);
            label6.TabIndex = 10;
            label6.Text = ":שם לקוח";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(538, 76);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(89, 28);
            label2.TabIndex = 10;
            label2.Text = ":ת.ז לקוח";
            // 
            // add
            // 
            add.AutoSize = true;
            add.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            add.Location = new Point(104, 322);
            add.Name = "add";
            add.Size = new Size(80, 38);
            add.TabIndex = 6;
            add.Text = "הוסף";
            add.Click += add_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(delete);
            tabPage2.Controls.Add(customersList);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(813, 431);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "מחיקת לקוח";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.AutoSize = true;
            delete.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            delete.Location = new Point(70, 320);
            delete.Name = "delete";
            delete.Size = new Size(74, 38);
            delete.TabIndex = 10;
            delete.Text = "מחק";
            delete.Click += delete_Click;
            // 
            // customersList
            // 
            customersList.FormattingEnabled = true;
            customersList.Location = new Point(254, 51);
            customersList.Name = "customersList";
            customersList.RightToLeft = RightToLeft.No;
            customersList.Size = new Size(199, 28);
            customersList.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(489, 50);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(89, 28);
            label8.TabIndex = 8;
            label8.Text = ":ת.ז לקוח";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(phonCus);
            tabPage3.Controls.Add(addressCus);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(identityCus);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(nameCus);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(update);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(813, 431);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "עדכון לקוח";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // phonCus
            // 
            phonCus.Location = new Point(405, 269);
            phonCus.Name = "phonCus";
            phonCus.Size = new Size(144, 27);
            phonCus.TabIndex = 28;
            // 
            // addressCus
            // 
            addressCus.Location = new Point(405, 202);
            addressCus.Name = "addressCus";
            addressCus.Size = new Size(144, 27);
            addressCus.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(575, 265);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(64, 28);
            label7.TabIndex = 26;
            label7.Text = ":טלפון";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(566, 198);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(73, 28);
            label9.TabIndex = 27;
            label9.Text = ":כתובת";
            // 
            // identityCus
            // 
            identityCus.FormattingEnabled = true;
            identityCus.Location = new Point(333, 76);
            identityCus.Name = "identityCus";
            identityCus.RightToLeft = RightToLeft.No;
            identityCus.Size = new Size(199, 28);
            identityCus.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(549, 72);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(89, 28);
            label5.TabIndex = 24;
            label5.Text = ":ת.ז לקוח";
            // 
            // nameCus
            // 
            nameCus.Location = new Point(388, 137);
            nameCus.Name = "nameCus";
            nameCus.Size = new Size(144, 27);
            nameCus.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(545, 136);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.No;
            label14.Size = new Size(93, 28);
            label14.TabIndex = 22;
            label14.Text = ":שם לקוח";
            // 
            // update
            // 
            update.AutoSize = true;
            update.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            update.Location = new Point(84, 362);
            update.Name = "update";
            update.Size = new Size(69, 38);
            update.TabIndex = 16;
            update.Text = "עדכן";
            update.Click += update_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(searchCus);
            tabPage4.Controls.Add(allC);
            tabPage4.Controls.Add(oneCustomer);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(allCustomers);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(813, 431);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "כל הלקוחות";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // searchCus
            // 
            searchCus.Location = new Point(447, 70);
            searchCus.Name = "searchCus";
            searchCus.Size = new Size(94, 29);
            searchCus.TabIndex = 19;
            searchCus.Text = "חפש";
            searchCus.UseVisualStyleBackColor = true;
            searchCus.Click += searchCus_Click;
            // 
            // allC
            // 
            allC.Location = new Point(684, 25);
            allC.Name = "allC";
            allC.Size = new Size(94, 29);
            allC.TabIndex = 18;
            allC.Text = "כל הלקוחות";
            allC.UseVisualStyleBackColor = true;
            allC.Click += allC_Click;
            // 
            // oneCustomer
            // 
            oneCustomer.FormattingEnabled = true;
            oneCustomer.Location = new Point(302, 26);
            oneCustomer.Name = "oneCustomer";
            oneCustomer.RightToLeft = RightToLeft.No;
            oneCustomer.Size = new Size(199, 28);
            oneCustomer.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(507, 26);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(157, 23);
            label10.TabIndex = 15;
            label10.Text = ":חיפוש לקוח לפי ת.ז";
            // 
            // allCustomers
            // 
            allCustomers.FormattingEnabled = true;
            allCustomers.ItemHeight = 20;
            allCustomers.Location = new Point(19, 116);
            allCustomers.Name = "allCustomers";
            allCustomers.Size = new Size(775, 284);
            allCustomers.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 54);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Customers";
            Text = "Customers";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox IdentityCard;
        private Label label2;
        private Label add;
        private TabPage tabPage2;
        private Label delete;
        private ComboBox customersList;
        private Label label8;
        private TabPage tabPage3;
        private TextBox nameCus;
        private Label label14;
        private Label update;
        private TabPage tabPage4;
        private TextBox NameCustomer;
        private Label label6;
        private TextBox phone;
        private TextBox address;
        private Label label4;
        private Label label3;
        private TextBox phonCus;
        private TextBox addressCus;
        private Label label7;
        private Label label9;
        private ComboBox identityCus;
        private Label label5;
        private ListBox allCustomers;
        private ComboBox oneCustomer;
        private Label label10;
        private Button allC;
        private Button searchCus;
        private PictureBox pictureBox1;
    }
}