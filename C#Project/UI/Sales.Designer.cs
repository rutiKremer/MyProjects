namespace UI
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dateEndSale = new DateTimePicker();
            dateBeginSale = new DateTimePicker();
            IsTheSaleForEverybody = new ComboBox();
            IncludingPriceInSale = new NumericUpDown();
            AmountForSale = new NumericUpDown();
            idProduct = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            add = new Label();
            tabPage2 = new TabPage();
            delete = new Label();
            idList = new ComboBox();
            label8 = new Label();
            tabPage3 = new TabPage();
            dateEndS = new DateTimePicker();
            dateBeginS = new DateTimePicker();
            id = new ComboBox();
            isForS = new ComboBox();
            priceS = new NumericUpDown();
            amountS = new NumericUpDown();
            idP = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label14 = new Label();
            update = new Label();
            tabPage4 = new TabPage();
            findByName = new Button();
            name = new TextBox();
            allS = new Button();
            find = new Button();
            oneSale = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            allSales = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IncludingPriceInSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AmountForSale).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountS).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(46, 67);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(821, 464);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dateEndSale);
            tabPage1.Controls.Add(dateBeginSale);
            tabPage1.Controls.Add(IsTheSaleForEverybody);
            tabPage1.Controls.Add(IncludingPriceInSale);
            tabPage1.Controls.Add(AmountForSale);
            tabPage1.Controls.Add(idProduct);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(add);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(813, 431);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספת מבצע";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateEndSale
            // 
            dateEndSale.Location = new Point(221, 278);
            dateEndSale.Name = "dateEndSale";
            dateEndSale.RightToLeft = RightToLeft.No;
            dateEndSale.Size = new Size(250, 27);
            dateEndSale.TabIndex = 15;
            // 
            // dateBeginSale
            // 
            dateBeginSale.Location = new Point(212, 226);
            dateBeginSale.Name = "dateBeginSale";
            dateBeginSale.RightToLeft = RightToLeft.No;
            dateBeginSale.Size = new Size(250, 27);
            dateBeginSale.TabIndex = 15;
            // 
            // IsTheSaleForEverybody
            // 
            IsTheSaleForEverybody.FormattingEnabled = true;
            IsTheSaleForEverybody.Location = new Point(255, 178);
            IsTheSaleForEverybody.Name = "IsTheSaleForEverybody";
            IsTheSaleForEverybody.RightToLeft = RightToLeft.No;
            IsTheSaleForEverybody.Size = new Size(151, 28);
            IsTheSaleForEverybody.TabIndex = 14;
            // 
            // IncludingPriceInSale
            // 
            IncludingPriceInSale.Location = new Point(349, 121);
            IncludingPriceInSale.Name = "IncludingPriceInSale";
            IncludingPriceInSale.RightToLeft = RightToLeft.No;
            IncludingPriceInSale.Size = new Size(150, 27);
            IncludingPriceInSale.TabIndex = 13;
            // 
            // AmountForSale
            // 
            AmountForSale.Location = new Point(256, 71);
            AmountForSale.Name = "AmountForSale";
            AmountForSale.RightToLeft = RightToLeft.No;
            AmountForSale.Size = new Size(150, 27);
            AmountForSale.TabIndex = 13;
            // 
            // idProduct
            // 
            idProduct.Location = new Point(403, 24);
            idProduct.Name = "idProduct";
            idProduct.Size = new Size(144, 27);
            idProduct.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(412, 71);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(258, 28);
            label6.TabIndex = 7;
            label6.Text = ":כמות נדרשת לקבלת המבצע";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(489, 276);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(181, 28);
            label7.TabIndex = 8;
            label7.Text = ":תאריך סיום המבצע";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(468, 224);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(202, 28);
            label4.TabIndex = 8;
            label4.Text = ":תאריך תחילת המבצע";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(416, 174);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(254, 28);
            label5.TabIndex = 8;
            label5.Text = ":האם המבצע לכלל הלקוחות";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(505, 121);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(165, 28);
            label3.TabIndex = 10;
            label3.Text = ":מחיר כולל במבצע";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(560, 23);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(110, 28);
            label2.TabIndex = 10;
            label2.Text = ":מזהה מוצר";
            // 
            // add
            // 
            add.AutoSize = true;
            add.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            add.Location = new Point(55, 331);
            add.Name = "add";
            add.Size = new Size(80, 38);
            add.TabIndex = 6;
            add.Text = "הוסף";
            add.Click += add_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(delete);
            tabPage2.Controls.Add(idList);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(813, 431);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "מחיקת מבצע";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.AutoSize = true;
            delete.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            delete.Location = new Point(67, 317);
            delete.Name = "delete";
            delete.Size = new Size(74, 38);
            delete.TabIndex = 10;
            delete.Text = "מחק";
            delete.Click += delete_Click;
            // 
            // idList
            // 
            idList.FormattingEnabled = true;
            idList.Location = new Point(254, 51);
            idList.Name = "idList";
            idList.RightToLeft = RightToLeft.No;
            idList.Size = new Size(199, 28);
            idList.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(486, 47);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(117, 28);
            label8.TabIndex = 8;
            label8.Text = ":מזהה מבצע";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dateEndS);
            tabPage3.Controls.Add(dateBeginS);
            tabPage3.Controls.Add(id);
            tabPage3.Controls.Add(isForS);
            tabPage3.Controls.Add(priceS);
            tabPage3.Controls.Add(amountS);
            tabPage3.Controls.Add(idP);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(update);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(813, 431);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "עדכון מבצע";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateEndS
            // 
            dateEndS.Location = new Point(252, 321);
            dateEndS.Name = "dateEndS";
            dateEndS.RightToLeft = RightToLeft.No;
            dateEndS.Size = new Size(250, 27);
            dateEndS.TabIndex = 27;
            // 
            // dateBeginS
            // 
            dateBeginS.Location = new Point(243, 269);
            dateBeginS.Name = "dateBeginS";
            dateBeginS.RightToLeft = RightToLeft.No;
            dateBeginS.Size = new Size(250, 27);
            dateBeginS.TabIndex = 28;
            // 
            // id
            // 
            id.FormattingEnabled = true;
            id.Location = new Point(427, 20);
            id.Name = "id";
            id.RightToLeft = RightToLeft.No;
            id.Size = new Size(151, 28);
            id.TabIndex = 26;
            // 
            // isForS
            // 
            isForS.FormattingEnabled = true;
            isForS.Location = new Point(286, 221);
            isForS.Name = "isForS";
            isForS.RightToLeft = RightToLeft.No;
            isForS.Size = new Size(151, 28);
            isForS.TabIndex = 26;
            // 
            // priceS
            // 
            priceS.Location = new Point(380, 164);
            priceS.Name = "priceS";
            priceS.RightToLeft = RightToLeft.No;
            priceS.Size = new Size(150, 27);
            priceS.TabIndex = 24;
            // 
            // amountS
            // 
            amountS.Location = new Point(287, 114);
            amountS.Name = "amountS";
            amountS.RightToLeft = RightToLeft.No;
            amountS.Size = new Size(150, 27);
            amountS.TabIndex = 25;
            // 
            // idP
            // 
            idP.Location = new Point(434, 67);
            idP.Name = "idP";
            idP.Size = new Size(144, 27);
            idP.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(443, 114);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(258, 28);
            label9.TabIndex = 17;
            label9.Text = ":כמות נדרשת לקבלת המבצע";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(520, 319);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(181, 28);
            label10.TabIndex = 18;
            label10.Text = ":תאריך סיום המבצע";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(499, 267);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(202, 28);
            label11.TabIndex = 19;
            label11.Text = ":תאריך תחילת המבצע";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(447, 217);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(254, 28);
            label12.TabIndex = 20;
            label12.Text = ":האם המבצע לכלל הלקוחות";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(536, 164);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.No;
            label13.Size = new Size(165, 28);
            label13.TabIndex = 21;
            label13.Text = ":מחיר כולל במבצע";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(591, 20);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.No;
            label15.Size = new Size(117, 28);
            label15.TabIndex = 22;
            label15.Text = ":מזהה מבצע";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(591, 66);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.No;
            label14.Size = new Size(110, 28);
            label14.TabIndex = 22;
            label14.Text = ":מזהה מוצר";
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
            tabPage4.Controls.Add(findByName);
            tabPage4.Controls.Add(name);
            tabPage4.Controls.Add(allS);
            tabPage4.Controls.Add(find);
            tabPage4.Controls.Add(oneSale);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(allSales);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(813, 431);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "כל המבצעים";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // findByName
            // 
            findByName.Location = new Point(96, 64);
            findByName.Name = "findByName";
            findByName.Size = new Size(94, 29);
            findByName.TabIndex = 30;
            findByName.Text = "חפש";
            findByName.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            name.Location = new Point(15, 29);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 29;
            // 
            // allS
            // 
            allS.Location = new Point(676, 22);
            allS.Name = "allS";
            allS.Size = new Size(124, 39);
            allS.TabIndex = 28;
            allS.Text = "כל המבצעים";
            allS.UseVisualStyleBackColor = true;
            allS.Click += allS_Click;
            // 
            // find
            // 
            find.Location = new Point(430, 64);
            find.Name = "find";
            find.Size = new Size(94, 29);
            find.TabIndex = 27;
            find.Text = "חפש";
            find.UseVisualStyleBackColor = true;
            find.Click += find_Click;
            // 
            // oneSale
            // 
            oneSale.FormattingEnabled = true;
            oneSale.Location = new Point(284, 30);
            oneSale.Name = "oneSale";
            oneSale.RightToLeft = RightToLeft.No;
            oneSale.Size = new Size(199, 28);
            oneSale.TabIndex = 26;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(146, 29);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.No;
            label16.Size = new Size(119, 23);
            label16.TabIndex = 24;
            label16.Text = ":חיפוש לפי שם";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(489, 30);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.No;
            label17.Size = new Size(181, 23);
            label17.TabIndex = 25;
            label17.Text = ":חיפוש לפי מזהה מבצע";
            // 
            // allSales
            // 
            allSales.FormattingEnabled = true;
            allSales.ItemHeight = 20;
            allSales.Location = new Point(17, 134);
            allSales.Name = "allSales";
            allSales.Size = new Size(778, 284);
            allSales.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(413, 27);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 3;
            label1.Text = "מבצעים";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 54);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Sales";
            Text = "Sales";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IncludingPriceInSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)AmountForSale).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceS).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountS).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private NumericUpDown AmountForSale;
        private TextBox idProduct;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label add;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ListBox allSales;
        private Label label1;
        private NumericUpDown IncludingPriceInSale;
        private Label label3;
        private ComboBox IsTheSaleForEverybody;
        private Label label7;
        private Label label4;
        private DateTimePicker dateEndSale;
        private DateTimePicker dateBeginSale;
        private Label delete;
        private ComboBox idList;
        private Label label8;
        private DateTimePicker dateEndS;
        private DateTimePicker dateBeginS;
        private ComboBox isForS;
        private NumericUpDown priceS;
        private NumericUpDown amountS;
        private TextBox idP;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label update;
        private Label label15;
        private ComboBox id;
        private Button findByName;
        private TextBox name;
        private Button allS;
        private Button find;
        private ComboBox oneSale;
        private Label label16;
        private Label label17;
        private PictureBox pictureBox1;
    }
}