using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement.Forms
{
    public partial class FormBorrowBooks : Form
    {
        public FormBorrowBooks()
        {
            InitializeComponent();
        }

        private void btnEntryBorrow_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt16(txtBookId.Text);
            int memberId = Convert.ToInt16(cmbMember.SelectedValue);
            DateTime issueDate = Convert.ToDateTime(dtpIssueDate.Text);
            DateTime returnDate = Convert.ToDateTime(dtpReturnDate.Text);



            // sql connection 
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("LibraryManagementDB connection string not found!");
                return;
            }


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "insert into BorrowRecord (BookId,MemberId,IssueDate,ReturnDate) values(@b, @m, @i, @r)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
     
                    cmd.Parameters.AddWithValue("@b", bookId);
                    cmd.Parameters.AddWithValue("@m", memberId);
                    cmd.Parameters.AddWithValue("@i", issueDate);
                    cmd.Parameters.AddWithValue("@r", returnDate);
                 
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("A book is borrowed successful.");
                        
                    }
                }
                con.Close();
            }

        }

        private void FormBooks_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllBooks();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }





        public DataTable GetAllBooks()
        {
            DataTable members = new DataTable();
            // sql connection 
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("LibraryManagementDB connection string not found!");

            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "select * from Books";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    da.Fill(members);
                }
                con.Close();
            }
            return members;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;
            DataTable members = FormMembers.GetAllMembers();

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtBookId.Text = Convert.ToString(row.Cells[0].Value);
            txtBookName.Text = row.Cells[1].Value?.ToString();

            cmbMember.DataSource = members;
            cmbMember.DisplayMember = "MemberName";
            cmbMember.ValueMember = "MemberId";

            dtpIssueDate.Value = DateTime.Now;
            dtpReturnDate.Value = DateTime.Now.AddDays(7);
  

        }
    }
}
