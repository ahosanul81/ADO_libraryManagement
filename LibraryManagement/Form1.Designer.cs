namespace LibraryManagement
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMemberNav = new System.Windows.Forms.Button();
            this.navBtnAddBook = new System.Windows.Forms.Button();
            this.navBtnBorrowBook = new System.Windows.Forms.Button();
            this.navBtnBookReport = new System.Windows.Forms.Button();
            this.navBtnMemberReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.ForestGreen;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 25, 0, 25);
            this.menuStrip1.Size = new System.Drawing.Size(1026, 86);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.booksToolStripMenuItem});
            this.formsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(100, 36);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.membersToolStripMenuItem.Text = "Members";
            this.membersToolStripMenuItem.Click += new System.EventHandler(this.membersToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem1,
            this.borrowBookToolStripMenuItem1});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // addBookToolStripMenuItem1
            // 
            this.addBookToolStripMenuItem1.Name = "addBookToolStripMenuItem1";
            this.addBookToolStripMenuItem1.Size = new System.Drawing.Size(270, 40);
            this.addBookToolStripMenuItem1.Text = "Add Book";
            this.addBookToolStripMenuItem1.Click += new System.EventHandler(this.addBookToolStripMenuItem1_Click);
            // 
            // borrowBookToolStripMenuItem1
            // 
            this.borrowBookToolStripMenuItem1.Name = "borrowBookToolStripMenuItem1";
            this.borrowBookToolStripMenuItem1.Size = new System.Drawing.Size(270, 40);
            this.borrowBookToolStripMenuItem1.Text = "Borrow Book";
            this.borrowBookToolStripMenuItem1.Click += new System.EventHandler(this.borrowBookToolStripMenuItem1_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowReportToolStripMenuItem,
            this.membersReportToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(108, 36);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // borrowReportToolStripMenuItem
            // 
            this.borrowReportToolStripMenuItem.Name = "borrowReportToolStripMenuItem";
            this.borrowReportToolStripMenuItem.Size = new System.Drawing.Size(310, 40);
            this.borrowReportToolStripMenuItem.Text = "Books Report";
            this.borrowReportToolStripMenuItem.Click += new System.EventHandler(this.borrowReportToolStripMenuItem_Click);
            // 
            // membersReportToolStripMenuItem
            // 
            this.membersReportToolStripMenuItem.Name = "membersReportToolStripMenuItem";
            this.membersReportToolStripMenuItem.Size = new System.Drawing.Size(310, 40);
            this.membersReportToolStripMenuItem.Text = "Members Report";
            this.membersReportToolStripMenuItem.Click += new System.EventHandler(this.membersReportToolStripMenuItem_Click);
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // borrowBookToolStripMenuItem
            // 
            this.borrowBookToolStripMenuItem.Name = "borrowBookToolStripMenuItem";
            this.borrowBookToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.borrowBookToolStripMenuItem.Text = "Borrow Book";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.navBtnMemberReport);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.navBtnBookReport);
            this.groupBox1.Controls.Add(this.navBtnBorrowBook);
            this.groupBox1.Controls.Add(this.navBtnAddBook);
            this.groupBox1.Controls.Add(this.btnMemberNav);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 486);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnMemberNav
            // 
            this.btnMemberNav.BackColor = System.Drawing.Color.DarkGreen;
            this.btnMemberNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberNav.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMemberNav.Location = new System.Drawing.Point(123, 71);
            this.btnMemberNav.Name = "btnMemberNav";
            this.btnMemberNav.Size = new System.Drawing.Size(247, 97);
            this.btnMemberNav.TabIndex = 0;
            this.btnMemberNav.Text = "Members";
            this.btnMemberNav.UseVisualStyleBackColor = false;
            this.btnMemberNav.Click += new System.EventHandler(this.btnMemberNav_Click);
            // 
            // navBtnAddBook
            // 
            this.navBtnAddBook.BackColor = System.Drawing.Color.SteelBlue;
            this.navBtnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBtnAddBook.ForeColor = System.Drawing.SystemColors.Info;
            this.navBtnAddBook.Location = new System.Drawing.Point(376, 71);
            this.navBtnAddBook.Name = "navBtnAddBook";
            this.navBtnAddBook.Size = new System.Drawing.Size(247, 97);
            this.navBtnAddBook.TabIndex = 1;
            this.navBtnAddBook.Text = "Add Books";
            this.navBtnAddBook.UseVisualStyleBackColor = false;
            this.navBtnAddBook.Click += new System.EventHandler(this.navBtnAddBook_Click);
            // 
            // navBtnBorrowBook
            // 
            this.navBtnBorrowBook.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.navBtnBorrowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBtnBorrowBook.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.navBtnBorrowBook.Location = new System.Drawing.Point(629, 71);
            this.navBtnBorrowBook.Name = "navBtnBorrowBook";
            this.navBtnBorrowBook.Size = new System.Drawing.Size(247, 97);
            this.navBtnBorrowBook.TabIndex = 0;
            this.navBtnBorrowBook.Text = "Borrow Book";
            this.navBtnBorrowBook.UseVisualStyleBackColor = false;
            this.navBtnBorrowBook.Click += new System.EventHandler(this.navBtnBorrowBook_Click);
            // 
            // navBtnBookReport
            // 
            this.navBtnBookReport.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.navBtnBookReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBtnBookReport.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.navBtnBookReport.Location = new System.Drawing.Point(238, 293);
            this.navBtnBookReport.Name = "navBtnBookReport";
            this.navBtnBookReport.Size = new System.Drawing.Size(247, 97);
            this.navBtnBookReport.TabIndex = 1;
            this.navBtnBookReport.Text = "Books Report";
            this.navBtnBookReport.UseVisualStyleBackColor = false;
            this.navBtnBookReport.Click += new System.EventHandler(this.navBtnBookReport_Click);
            // 
            // navBtnMemberReport
            // 
            this.navBtnMemberReport.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.navBtnMemberReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBtnMemberReport.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.navBtnMemberReport.Location = new System.Drawing.Point(503, 293);
            this.navBtnMemberReport.Name = "navBtnMemberReport";
            this.navBtnMemberReport.Size = new System.Drawing.Size(247, 97);
            this.navBtnMemberReport.TabIndex = 1;
            this.navBtnMemberReport.Text = "Member Report";
            this.navBtnMemberReport.UseVisualStyleBackColor = false;
            this.navBtnMemberReport.Click += new System.EventHandler(this.navBtnMemberReport_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(123, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(753, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.navBtnBookReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 621);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrowBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem membersReportToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button navBtnMemberReport;
        private System.Windows.Forms.Button navBtnBookReport;
        private System.Windows.Forms.Button navBtnBorrowBook;
        private System.Windows.Forms.Button navBtnAddBook;
        private System.Windows.Forms.Button btnMemberNav;
        private System.Windows.Forms.Button button1;
    }
}

