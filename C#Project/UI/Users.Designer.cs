namespace UI
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            label1 = new Label();
            orderItem = new ListBox();
            label2 = new Label();
            label3 = new Label();
            productList = new ComboBox();
            label4 = new Label();
            amountForOrder = new NumericUpDown();
            addToCart = new Button();
            finishOrder = new Button();
            label5 = new Label();
            showSale = new Button();
            salesOfProduct = new ListBox();
            sum = new ListBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)amountForOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(655, 60);
            label1.Name = "label1";
            label1.Size = new Size(144, 27);
            label1.TabIndex = 15;
            label1.Text = "הוספת מוצר להזמנה";
            // 
            // orderItem
            // 
            orderItem.FormattingEnabled = true;
            orderItem.ItemHeight = 20;
            orderItem.Location = new Point(31, 78);
            orderItem.Name = "orderItem";
            orderItem.RightToLeft = RightToLeft.Yes;
            orderItem.Size = new Size(464, 384);
            orderItem.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(447, 9);
            label2.Name = "label2";
            label2.Size = new Size(140, 37);
            label2.TabIndex = 15;
            label2.Text = "ביצוע הזמנה";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(820, 291);
            label3.Name = "label3";
            label3.Size = new Size(185, 27);
            label3.TabIndex = 15;
            label3.Text = ":רשימת מבצעים של המוצר";
            // 
            // productList
            // 
            productList.FormattingEnabled = true;
            productList.Location = new Point(517, 106);
            productList.Name = "productList";
            productList.RightToLeft = RightToLeft.Yes;
            productList.Size = new Size(372, 28);
            productList.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(901, 161);
            label4.Name = "label4";
            label4.Size = new Size(104, 27);
            label4.TabIndex = 15;
            label4.Text = ":כמות להוספה";
            // 
            // amountForOrder
            // 
            amountForOrder.Location = new Point(739, 165);
            amountForOrder.Name = "amountForOrder";
            amountForOrder.Size = new Size(150, 27);
            amountForOrder.TabIndex = 18;
            // 
            // addToCart
            // 
            addToCart.Location = new Point(655, 217);
            addToCart.Name = "addToCart";
            addToCart.Size = new Size(134, 53);
            addToCart.TabIndex = 19;
            addToCart.Text = "\U0001f6d2 הוסף לסל ";
            addToCart.UseVisualStyleBackColor = true;
            addToCart.Click += addToCart_Click;
            // 
            // finishOrder
            // 
            finishOrder.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            finishOrder.Location = new Point(31, 470);
            finishOrder.Name = "finishOrder";
            finishOrder.Size = new Size(164, 56);
            finishOrder.TabIndex = 20;
            finishOrder.Text = "בצע הזמנה";
            finishOrder.UseVisualStyleBackColor = true;
            finishOrder.Click += finishOrder_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(334, 477);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(161, 37);
            label5.TabIndex = 15;
            label5.Text = "סכום לתשלום:";
            // 
            // showSale
            // 
            showSale.Location = new Point(695, 433);
            showSale.Name = "showSale";
            showSale.Size = new Size(94, 29);
            showSale.TabIndex = 19;
            showSale.Text = "הצג מבצעים";
            showSale.UseVisualStyleBackColor = true;
            showSale.Click += showSale_Click;
            // 
            // salesOfProduct
            // 
            salesOfProduct.FormattingEnabled = true;
            salesOfProduct.ItemHeight = 20;
            salesOfProduct.Location = new Point(517, 291);
            salesOfProduct.Name = "salesOfProduct";
            salesOfProduct.Size = new Size(297, 124);
            salesOfProduct.TabIndex = 21;
            // 
            // sum
            // 
            sum.FormattingEnabled = true;
            sum.ItemHeight = 20;
            sum.Location = new Point(235, 486);
            sum.Name = "sum";
            sum.Size = new Size(68, 24);
            sum.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(288, 490);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(309, 482);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 32);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(267, 54);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 545);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(sum);
            Controls.Add(salesOfProduct);
            Controls.Add(finishOrder);
            Controls.Add(showSale);
            Controls.Add(addToCart);
            Controls.Add(amountForOrder);
            Controls.Add(productList);
            Controls.Add(orderItem);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Users";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)amountForOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox orderItem;
        private Label label2;
        private Label label3;
        private ComboBox productList;
        private Label label4;
        private NumericUpDown amountForOrder;
        private Button addToCart;
        private Button finishOrder;
        private Label label5;
        private Button showSale;
        private ListBox salesOfProduct;
        private ListBox sum;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}