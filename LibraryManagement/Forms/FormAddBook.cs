using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement.Forms
{
    public partial class FormAddBook : Form
    {
        public FormAddBook()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormAddBook_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            string BookName = txtBookName.Text;
            string AuthorName  = txtAuthorName.Text;
            string ISBN  = txtIsbn.Text;
            double Price  = Convert.ToDouble(Convert.ToInt16(txtPrice.Text));
            int TotalCopies = Convert.ToInt16(txtTotalCopies.Text);


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
                string query = "insert into Books (BookName,  AuthorName,ISBN, Price, TotalCopies) values(@b, @a, @i, @p,@t)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@b", BookName );
                    cmd.Parameters.AddWithValue("@a", AuthorName  );
                    cmd.Parameters.AddWithValue("@i", ISBN  );
                    cmd.Parameters.AddWithValue("@p", Price  );
                    cmd.Parameters.AddWithValue("@t", TotalCopies);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("A book added successful.");
                        
                    }

                }
                con.Close();
            }
        }
    }
}
