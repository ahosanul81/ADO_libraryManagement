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

namespace LibraryManagement.Forms
{
    public partial class FormMembers : Form
    {
        public FormMembers()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("LibraryManagementDB connection string not found!");
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("insert into Members (MemberName, Email, Phone,JoinDate) values(@m, @e, @p, @j)"))
                {
                        
                        cmd.Parameters.AddWithValue("@m", txtMemberName.Text);
                        cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@p", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@j", dtpJoinDate.Value);

                        cmd.ExecuteNonQuery();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("A member added successful.");
                        }
                }
                con.Close();
            }
        }

        private void FormMembers_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
