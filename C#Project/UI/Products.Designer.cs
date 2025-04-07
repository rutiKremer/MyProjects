namespace UI
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            stockAmount = new NumericUpDown();
            price = new NumericUpDown();
            category = new ComboBox();
            nameProduct = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            add = new Label();
            tabPage2 = new TabPage();
            delete = new Label();
            productList = new ComboBox();
            label3 = new Label();
            tabPage3 = new TabPage();
            productForUpdate = new ComboBox();
            amount = new NumericUpDown();
            priceP = new NumericUpDown();
            categoryP = new ComboBox();
            pName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label12 = new Label();
            label10 = new Label();
            update = new Label();
            tabPage4 = new TabPage();
            name = new TextBox();
            allP = new Button();
            find = new Button();
            oneProduct = new ComboBox();
            label13 = new Label();
            label11 = new Label();
            allProduct = new ListBox();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)price).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceP).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(419, 26);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 0;
            label1.Text = "מוצרים";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(32, 83);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(862, 440);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(stockAmount);
            tabPage1.Controls.Add(price);
            tabPage1.Controls.Add(category);
            tabPage1.Controls.Add(nameProduct);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(add);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(854, 407);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספת מוצר";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // stockAmount
            // 
            stockAmount.Location = new Point(275, 221);
            stockAmount.Name = "stockAmount";
            stockAmount.RightToLeft = RightToLeft.No;
            stockAmount.Size = new Size(150, 27);
            stockAmount.TabIndex = 13;
            // 
            // price
            // 
            price.DecimalPlaces = 1;
            price.Location = new Point(325, 162);
            price.Name = "price";
            price.RightToLeft = RightToLeft.No;
            price.Size = new Size(150, 27);
            price.TabIndex = 14;
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Location = new Point(324, 94);
            category.Name = "category";
            category.RightToLeft = RightToLeft.No;
            category.Size = new Size(151, 28);
            category.TabIndex = 12;
            // 
            // nameProduct
            // 
            nameProduct.Location = new Point(324, 35);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(144, 27);
            nameProduct.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(470, 221);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(118, 28);
            label6.TabIndex = 7;
            label6.Text = ":כמות במלאי";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(530, 157);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(58, 28);
            label5.TabIndex = 8;
            label5.Text = ":מחיר";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(501, 90);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(87, 28);
            label4.TabIndex = 9;
            label4.Text = ":קטגוריה";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(496, 31);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(92, 28);
            label2.TabIndex = 10;
            label2.Text = ":שם מוצר";
            // 
            // add
            // 
            add.AutoSize = true;
            add.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            add.Location = new Point(77, 290);
            add.Name = "add";
            add.Size = new Size(80, 38);
            add.TabIndex = 6;
            add.Text = "הוסף";
            add.Click += add_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(delete);
            tabPage2.Controls.Add(productList);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.RightToLeft = RightToLeft.No;
            tabPage2.Size = new Size(854, 407);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "מחיקת מוצר";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.AutoSize = true;
            delete.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            delete.Location = new Point(62, 280);
            delete.Name = "delete";
            delete.Size = new Size(74, 38);
            delete.TabIndex = 7;
            delete.Text = "מחק";
            delete.Click += delete_Click;
            // 
            // productList
            // 
            productList.FormattingEnabled = true;
            productList.Location = new Point(237, 57);
            productList.Name = "productList";
            productList.Size = new Size(199, 28);
            productList.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(457, 53);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 0;
            label3.Text = ":רשימת המוצרים";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(productForUpdate);
            tabPage3.Controls.Add(amount);
            tabPage3.Controls.Add(priceP);
            tabPage3.Controls.Add(categoryP);
            tabPage3.Controls.Add(pName);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(update);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(854, 407);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "עדכון מוצר";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // productForUpdate
            // 
            productForUpdate.FormattingEnabled = true;
            productForUpdate.Location = new Point(356, 32);
            productForUpdate.Name = "productForUpdate";
            productForUpdate.RightToLeft = RightToLeft.No;
            productForUpdate.Size = new Size(151, 28);
            productForUpdate.TabIndex = 24;
            // 
            // amount
            // 
            amount.Location = new Point(317, 291);
            amount.Name = "amount";
            amount.RightToLeft = RightToLeft.No;
            amount.Size = new Size(150, 27);
            amount.TabIndex = 22;
            // 
            // priceP
            // 
            priceP.DecimalPlaces = 1;
            priceP.Location = new Point(378, 225);
            priceP.Name = "priceP";
            priceP.RightToLeft = RightToLeft.No;
            priceP.Size = new Size(150, 27);
            priceP.TabIndex = 23;
            // 
            // categoryP
            // 
            categoryP.FormattingEnabled = true;
            categoryP.Location = new Point(376, 156);
            categoryP.Name = "categoryP";
            categoryP.RightToLeft = RightToLeft.No;
            categoryP.Size = new Size(151, 28);
            categoryP.TabIndex = 21;
            // 
            // pName
            // 
            pName.Location = new Point(356, 93);
            pName.Name = "pName";
            pName.Size = new Size(144, 27);
            pName.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(502, 291);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(118, 28);
            label7.TabIndex = 16;
            label7.Text = ":כמות במלאי";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(562, 220);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(58, 28);
            label8.TabIndex = 17;
            label8.Text = ":מחיר";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(533, 152);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(87, 28);
            label9.TabIndex = 18;
            label9.Text = ":קטגוריה";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(533, 26);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.Yes;
            label12.Size = new Size(207, 31);
            label12.TabIndex = 19;
            label12.Text = "בחירת מוצר לעדכון:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(528, 93);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(92, 28);
            label10.TabIndex = 19;
            label10.Text = ":שם מוצר";
            // 
            // update
            // 
            update.AutoSize = true;
            update.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            update.Location = new Point(114, 320);
            update.Name = "update";
            update.Size = new Size(69, 38);
            update.TabIndex = 15;
            update.Text = "עדכן";
            update.Click += update_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(name);
            tabPage4.Controls.Add(allP);
            tabPage4.Controls.Add(find);
            tabPage4.Controls.Add(oneProduct);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(allProduct);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(854, 407);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "כל המוצרים";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            name.Location = new Point(49, 26);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 22;
            // 
            // allP
            // 
            allP.Location = new Point(710, 19);
            allP.Name = "allP";
            allP.Size = new Size(124, 39);
            allP.TabIndex = 21;
            allP.Text = "כל המוצרים";
            allP.UseVisualStyleBackColor = true;
            allP.Click += allP_Click;
            // 
            // find
            // 
            find.Location = new Point(464, 61);
            find.Name = "find";
            find.Size = new Size(94, 29);
            find.TabIndex = 20;
            find.Text = "חפש";
            find.UseVisualStyleBackColor = true;
            find.Click += find_Click;
            // 
            // oneProduct
            // 
            oneProduct.FormattingEnabled = true;
            oneProduct.Location = new Point(318, 27);
            oneProduct.Name = "oneProduct";
            oneProduct.RightToLeft = RightToLeft.No;
            oneProduct.Size = new Size(199, 28);
            oneProduct.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(180, 26);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.No;
            label13.Size = new Size(119, 23);
            label13.TabIndex = 18;
            label13.Text = ":חיפוש לפי שם";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(523, 27);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(176, 23);
            label11.TabIndex = 18;
            label11.Text = ":חיפוש לפי מזהה מוצר";
            // 
            // allProduct
            // 
            allProduct.FormattingEnabled = true;
            allProduct.ItemHeight = 20;
            allProduct.Location = new Point(59, 114);
            allProduct.Name = "allProduct";
            allProduct.Size = new Size(762, 244);
            allProduct.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 54);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Products";
            Text = "Products";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)price).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceP).EndInit();
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
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private NumericUpDown stockAmount;
        private NumericUpDown price;
        private ComboBox category;
        private TextBox nameProduct;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label add;
        private ListBox allProduct;
        private ComboBox productList;
        private Label label3;
        private Label delete;
        private ComboBox productForUpdate;
        private NumericUpDown amount;
        private NumericUpDown priceP;
        private ComboBox categoryP;
        private TextBox pName;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label12;
        private Label label10;
        private Label update;
        private Button find;
        private ComboBox oneProduct;
        private Label label11;
        private Button allP;
        private Label label13;
        private TextBox name;
        private PictureBox pictureBox1;
        //private Button findByName;
    }
}