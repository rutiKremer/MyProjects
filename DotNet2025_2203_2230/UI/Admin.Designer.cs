namespace UI
{
    partial class Admin
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
            products = new Button();
            sales = new Button();
            customers = new Button();
            SuspendLayout();
            // 
            // products
            // 
            products.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            products.Location = new Point(608, 185);
            products.Margin = new Padding(3, 4, 3, 4);
            products.Name = "products";
            products.Size = new Size(218, 95);
            products.TabIndex = 0;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // sales
            // 
            sales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sales.Location = new Point(364, 185);
            sales.Margin = new Padding(3, 4, 3, 4);
            sales.Name = "sales";
            sales.Size = new Size(218, 95);
            sales.TabIndex = 0;
            sales.Text = "מבצעים";
            sales.UseVisualStyleBackColor = true;
            sales.Click += sales_Click;
            // 
            // customers
            // 
            customers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customers.Location = new Point(118, 185);
            customers.Margin = new Padding(3, 4, 3, 4);
            customers.Name = "customers";
            customers.Size = new Size(218, 95);
            customers.TabIndex = 0;
            customers.Text = "לקוחות";
            customers.UseVisualStyleBackColor = true;
            customers.Click += customers_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(customers);
            Controls.Add(sales);
            Controls.Add(products);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
        }

        #endregion

        private Button products;
        private Button sales;
        private Button customers;
    }
}