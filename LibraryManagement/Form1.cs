using LibraryManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMembers fm = new FormMembers();
            fm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterGroupBox();
        }

     

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAddBook ab = new FormAddBook();
            ab.Show();
        }

        private void borrowBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBorrowBooks fb = new FormBorrowBooks();
            fb.Show();
        }

        private void borrowReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookreport bp = new bookreport();
            bp.Show();
        }

        private void membersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMembersReport fm = new FormMembersReport(); 
            fm.Show();
        }

        private void btnMemberNav_Click(object sender, EventArgs e)
        {
            FormMembers f = new FormMembers();
            f.Show();
        }

        private void navBtnAddBook_Click(object sender, EventArgs e)
        {
            FormAddBook f = new FormAddBook();
            f.Show();
        }

        private void navBtnBorrowBook_Click(object sender, EventArgs e)
        {
            FormBorrowBooks f = new FormBorrowBooks();
            f.Show();
        }

        private void navBtnBookReport_Click(object sender, EventArgs e)
        {
            bookreport b = new bookreport();
            b.Show();
        }

        private void navBtnMemberReport_Click(object sender, EventArgs e)
        {
            FormMembersReport f = new FormMembersReport();
            f.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CenterGroupBox()
        {
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;
        }
    }
}
