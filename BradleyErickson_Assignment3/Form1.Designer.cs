namespace BradleyErickson_Assignment3
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtProductDetails = new System.Windows.Forms.TextBox();
            this.lstSelectProducts = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblShippingCost = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calShippingCalender = new System.Windows.Forms.MonthCalendar();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.cboShippingOptions = new System.Windows.Forms.ComboBox();
            this.lstProductsSelected = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(501, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtProductDetails);
            this.tabPage1.Controls.Add(this.lstSelectProducts);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(493, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select Products:";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtProductDetails
            // 
            this.txtProductDetails.BackColor = System.Drawing.Color.LightGray;
            this.txtProductDetails.ForeColor = System.Drawing.Color.Red;
            this.txtProductDetails.Location = new System.Drawing.Point(278, 31);
            this.txtProductDetails.Multiline = true;
            this.txtProductDetails.Name = "txtProductDetails";
            this.txtProductDetails.Size = new System.Drawing.Size(207, 95);
            this.txtProductDetails.TabIndex = 1;
            // 
            // lstSelectProducts
            // 
            this.lstSelectProducts.FormattingEnabled = true;
            this.lstSelectProducts.Items.AddRange(new object[] {
            "Microsoft Surface Pro",
            "Apple iPad Air",
            "Samsung Galaxy Tab 3",
            "Google Nexus 7",
            "Amazon Kindle Fire HD"});
            this.lstSelectProducts.Location = new System.Drawing.Point(24, 31);
            this.lstSelectProducts.Name = "lstSelectProducts";
            this.lstSelectProducts.Size = new System.Drawing.Size(221, 95);
            this.lstSelectProducts.TabIndex = 0;
            this.lstSelectProducts.SelectedIndexChanged += new System.EventHandler(this.lstSelectProducts_SelectedIndexChanged);
            this.lstSelectProducts.DoubleClick += new System.EventHandler(this.lstSelectProducts_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTotal);
            this.tabPage2.Controls.Add(this.lblShippingCost);
            this.tabPage2.Controls.Add(this.lblDiscount);
            this.tabPage2.Controls.Add(this.lblSalesTax);
            this.tabPage2.Controls.Add(this.lblSubtotal);
            this.tabPage2.Controls.Add(this.lblDeliveryDate);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.calShippingCalender);
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.btnPurchase);
            this.tabPage2.Controls.Add(this.cboShippingOptions);
            this.tabPage2.Controls.Add(this.lstProductsSelected);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(493, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Shopping Cart:";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.LightGray;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(114, 296);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 21);
            this.lblTotal.TabIndex = 17;
            // 
            // lblShippingCost
            // 
            this.lblShippingCost.BackColor = System.Drawing.Color.LightGray;
            this.lblShippingCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShippingCost.Location = new System.Drawing.Point(115, 266);
            this.lblShippingCost.Name = "lblShippingCost";
            this.lblShippingCost.Size = new System.Drawing.Size(86, 22);
            this.lblShippingCost.TabIndex = 16;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.Color.LightGray;
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiscount.Location = new System.Drawing.Point(115, 234);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(86, 20);
            this.lblDiscount.TabIndex = 15;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BackColor = System.Drawing.Color.LightGray;
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesTax.Location = new System.Drawing.Point(115, 197);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(86, 21);
            this.lblSalesTax.TabIndex = 14;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.LightGray;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point(115, 169);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(86, 21);
            this.lblSubtotal.TabIndex = 13;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.BackColor = System.Drawing.Color.Black;
            this.lblDeliveryDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeliveryDate.ForeColor = System.Drawing.Color.Lime;
            this.lblDeliveryDate.Location = new System.Drawing.Point(251, 183);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(177, 38);
            this.lblDeliveryDate.TabIndex = 12;
            this.lblDeliveryDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Delivery:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Shipping Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Discount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sales Tax (6%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subtotal:";
            // 
            // calShippingCalender
            // 
            this.calShippingCalender.BackColor = System.Drawing.Color.White;
            this.calShippingCalender.ForeColor = System.Drawing.Color.Black;
            this.calShippingCalender.Location = new System.Drawing.Point(225, 12);
            this.calShippingCalender.Name = "calShippingCalender";
            this.calShippingCalender.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(310, 316);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 24);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(310, 286);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(118, 24);
            this.btnPurchase.TabIndex = 2;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // cboShippingOptions
            // 
            this.cboShippingOptions.FormattingEnabled = true;
            this.cboShippingOptions.Items.AddRange(new object[] {
            "Next Day",
            "Two Days",
            "One Week",
            "Two Weeks"});
            this.cboShippingOptions.Location = new System.Drawing.Point(310, 259);
            this.cboShippingOptions.Name = "cboShippingOptions";
            this.cboShippingOptions.Size = new System.Drawing.Size(118, 21);
            this.cboShippingOptions.TabIndex = 1;
            this.cboShippingOptions.SelectedIndexChanged += new System.EventHandler(this.cboShippingOptions_SelectedIndexChanged);
            // 
            // lstProductsSelected
            // 
            this.lstProductsSelected.FormattingEnabled = true;
            this.lstProductsSelected.Location = new System.Drawing.Point(24, 31);
            this.lstProductsSelected.Name = "lstProductsSelected";
            this.lstProductsSelected.Size = new System.Drawing.Size(154, 108);
            this.lstProductsSelected.TabIndex = 0;
            this.lstProductsSelected.DoubleClick += new System.EventHandler(this.lstProductsSelected_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 377);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtProductDetails;
        private System.Windows.Forms.ListBox lstSelectProducts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboShippingOptions;
        private System.Windows.Forms.ListBox lstProductsSelected;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.MonthCalendar calShippingCalender;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblShippingCost;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblSubtotal;
    }
}

