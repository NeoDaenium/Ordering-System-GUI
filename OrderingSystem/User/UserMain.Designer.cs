﻿namespace OrderingSystem
{
    partial class UserMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLogged = new System.Windows.Forms.Label();
            this.pnlbtm = new System.Windows.Forms.Panel();
            this.btnUserDetails = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenRep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransRep = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.pnlbtm.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(13, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 99);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(772, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "(c) Skorpion 3/4 ltd. Herbosa, Bancud, Javier 2017";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Version 0.7.2 Alpha";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(122)))), ((int)(((byte)(87)))));
            this.panel3.BackgroundImage = global::OrderingSystem.Properties.Resources.coffee2;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblLogged);
            this.panel3.Controls.Add(this.pnlbtm);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.mainMenu);
            this.panel3.Location = new System.Drawing.Point(1, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1144, 138);
            this.panel3.TabIndex = 8;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // lblLogged
            // 
            this.lblLogged.AutoSize = true;
            this.lblLogged.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLogged.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogged.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogged.Location = new System.Drawing.Point(831, 3);
            this.lblLogged.Name = "lblLogged";
            this.lblLogged.Size = new System.Drawing.Size(209, 21);
            this.lblLogged.TabIndex = 8;
            this.lblLogged.Text = "You are logged in as PatrickS";
            // 
            // pnlbtm
            // 
            this.pnlbtm.BackColor = System.Drawing.Color.Transparent;
            this.pnlbtm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlbtm.Controls.Add(this.btnUserDetails);
            this.pnlbtm.Controls.Add(this.btnHistory);
            this.pnlbtm.Controls.Add(this.btnOrder);
            this.pnlbtm.Location = new System.Drawing.Point(11, 41);
            this.pnlbtm.Name = "pnlbtm";
            this.pnlbtm.Size = new System.Drawing.Size(1113, 72);
            this.pnlbtm.TabIndex = 7;
            this.pnlbtm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // btnUserDetails
            // 
            this.btnUserDetails.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnUserDetails.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnUserDetails.FlatAppearance.BorderSize = 2;
            this.btnUserDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUserDetails.Image = global::OrderingSystem.Properties.Resources.ic_perm_identity_white_24dp_2x1;
            this.btnUserDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserDetails.Location = new System.Drawing.Point(838, 3);
            this.btnUserDetails.Name = "btnUserDetails";
            this.btnUserDetails.Size = new System.Drawing.Size(270, 64);
            this.btnUserDetails.TabIndex = 0;
            this.btnUserDetails.Text = "Change Account Details";
            this.btnUserDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserDetails.UseVisualStyleBackColor = false;
            this.btnUserDetails.Click += new System.EventHandler(this.btnClick);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnHistory.FlatAppearance.BorderSize = 2;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHistory.Image = global::OrderingSystem.Properties.Resources.ic_history_white_24dp_2x;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistory.Location = new System.Drawing.Point(178, 3);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(183, 64);
            this.btnHistory.TabIndex = 0;
            this.btnHistory.Text = "Order History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnClick);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnOrder.FlatAppearance.BorderSize = 2;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOrder.Image = global::OrderingSystem.Properties.Resources.ic_add_shopping_cart_white_24dp_2x;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.Location = new System.Drawing.Point(3, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(169, 63);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "New Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnClick);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Chocolate;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.btnMinimize.FlatAppearance.BorderSize = 2;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnMinimize.Location = new System.Drawing.Point(1046, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 29);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "__";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnClick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnExit.Location = new System.Drawing.Point(1086, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnClick);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.SaddleBrown;
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.menuUser,
            this.systemToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1142, 29);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenRep,
            this.mnuTransRep});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 25);
            this.mnuFile.Text = "File";
            // 
            // mnuGenRep
            // 
            this.mnuGenRep.Name = "mnuGenRep";
            this.mnuGenRep.Size = new System.Drawing.Size(277, 26);
            this.mnuGenRep.Text = "Generate Sales Report";
            this.mnuGenRep.Click += new System.EventHandler(this.menu_itemClicked);
            // 
            // mnuTransRep
            // 
            this.mnuTransRep.Name = "mnuTransRep";
            this.mnuTransRep.Size = new System.Drawing.Size(277, 26);
            this.mnuTransRep.Text = "Generate Transaction Report";
            this.mnuTransRep.Click += new System.EventHandler(this.menu_itemClicked);
            // 
            // menuUser
            // 
            this.menuUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogOut,
            this.mnuChangeDetails});
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(54, 25);
            this.menuUser.Text = "User";
            // 
            // mnuLogOut
            // 
            this.mnuLogOut.Name = "mnuLogOut";
            this.mnuLogOut.Size = new System.Drawing.Size(379, 26);
            this.mnuLogOut.Text = "Log out";
            this.mnuLogOut.Click += new System.EventHandler(this.menu_itemClicked);
            // 
            // mnuChangeDetails
            // 
            this.mnuChangeDetails.Name = "mnuChangeDetails";
            this.mnuChangeDetails.Size = new System.Drawing.Size(379, 26);
            this.mnuChangeDetails.Text = "Change Details (Requires Admin Password)";
            this.mnuChangeDetails.Click += new System.EventHandler(this.menu_itemClicked);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.systemToolStripMenuItem.Text = "Application";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Peru;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 351);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(5, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Order your coffee better. Faster.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "LAN Cafe Ordering System";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 629);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Order System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlbtm.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.Panel pnlbtm;
        private System.Windows.Forms.Button btnUserDetails;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem mnuGenRep;
        private System.Windows.Forms.ToolStripMenuItem mnuTransRep;
        private System.Windows.Forms.ToolStripMenuItem menuUser;
        private System.Windows.Forms.ToolStripMenuItem mnuLogOut;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeDetails;
        private System.Windows.Forms.Label lblLogged;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;

    }
}

