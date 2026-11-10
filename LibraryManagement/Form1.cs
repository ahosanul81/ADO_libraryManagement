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

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBooks fb = new FormBooks();
            fb.Show();
        }
    }
}
