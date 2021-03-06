﻿namespace OrderingSystem.Admin
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.cbxProductManager = new System.Windows.Forms.GroupBox();
            this.productStockField = new System.Windows.Forms.NumericUpDown();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.productNameField = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.productPriceField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblprprice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxProductManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productStockField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxProductManager
            // 
            this.cbxProductManager.BackColor = System.Drawing.Color.Transparent;
            this.cbxProductManager.Controls.Add(this.btnCancel);
            this.cbxProductManager.Controls.Add(this.productStockField);
            this.cbxProductManager.Controls.Add(this.productPictureBox);
            this.cbxProductManager.Controls.Add(this.productNameField);
            this.cbxProductManager.Controls.Add(this.btnReset);
            this.cbxProductManager.Controls.Add(this.btnAdd);
            this.cbxProductManager.Controls.Add(this.productPriceField);
            this.cbxProductManager.Controls.Add(this.label1);
            this.cbxProductManager.Controls.Add(this.productCategoryComboBox);
            this.cbxProductManager.Controls.Add(this.label5);
            this.cbxProductManager.Controls.Add(this.label4);
            this.cbxProductManager.Controls.Add(this.label6);
            this.cbxProductManager.Controls.Add(this.lblprprice);
            this.cbxProductManager.Controls.Add(this.label2);
            this.cbxProductManager.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProductManager.ForeColor = System.Drawing.Color.PeachPuff;
            this.cbxProductManager.Location = new System.Drawing.Point(12, 3);
            this.cbxProductManager.Name = "cbxProductManager";
            this.cbxProductManager.Size = new System.Drawing.Size(690, 214);
            this.cbxProductManager.TabIndex = 21;
            this.cbxProductManager.TabStop = false;
            this.cbxProductManager.Text = "Add a New Product";
            // 
            // productStockField
            // 
            this.productStockField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productStockField.Location = new System.Drawing.Point(180, 171);
            this.productStockField.Name = "productStockField";
            this.productStockField.Size = new System.Drawing.Size(105, 29);
            this.productStockField.TabIndex = 18;
            // 
            // productPictureBox
            // 
            this.productPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("productPictureBox.Image")));
            this.productPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("productPictureBox.InitialImage")));
            this.productPictureBox.Location = new System.Drawing.Point(180, 44);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(105, 104);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPictureBox.TabIndex = 15;
            this.productPictureBox.TabStop = false;
            // 
            // productNameField
            // 
            this.productNameField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameField.Location = new System.Drawing.Point(481, 35);
            this.productNameField.Name = "productNameField";
            this.productNameField.Size = new System.Drawing.Size(194, 29);
            this.productNameField.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Firebrick;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(306, 166);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 39);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Chocolate;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(402, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 39);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // productPriceField
            // 
            this.productPriceField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceField.Location = new System.Drawing.Point(481, 83);
            this.productPriceField.Name = "productPriceField";
            this.productPriceField.Size = new System.Drawing.Size(194, 29);
            this.productPriceField.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(301, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product Name: ";
            // 
            // productCategoryComboBox
            // 
            this.productCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCategoryComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCategoryComboBox.FormattingEnabled = true;
            this.productCategoryComboBox.Items.AddRange(new object[] {
            "Food",
            "Drink"});
            this.productCategoryComboBox.Location = new System.Drawing.Point(481, 126);
            this.productCategoryComboBox.Name = "productCategoryComboBox";
            this.productCategoryComboBox.Size = new System.Drawing.Size(194, 29);
            this.productCategoryComboBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(8, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Product Picture: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(301, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Product Category: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(8, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Product Stock: ";
            // 
            // lblprprice
            // 
            this.lblprprice.AutoSize = true;
            this.lblprprice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprprice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblprprice.Location = new System.Drawing.Point(301, 82);
            this.lblprprice.Name = "lblprprice";
            this.lblprprice.Size = new System.Drawing.Size(141, 30);
            this.lblprprice.TabIndex = 10;
            this.lblprprice.Text = "Product Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(-192, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product Price: ";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaShell;
            this.btnCancel.Location = new System.Drawing.Point(520, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 39);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(706, 226);
            this.Controls.Add(this.cbxProductManager);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.cbxProductManager.ResumeLayout(false);
            this.cbxProductManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productStockField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cbxProductManager;
        private System.Windows.Forms.NumericUpDown productStockField;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.TextBox productNameField;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox productPriceField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productCategoryComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblprprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;

    }
}