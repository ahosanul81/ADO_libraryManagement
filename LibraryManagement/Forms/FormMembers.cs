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

namespace LibraryManagement.Forms
{
    public partial class FormMembers : Form
    {
   
        string photo = "";
        int memberId = 0;
        public FormMembers()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            string memberName= txtMemberName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            DateTime joinDate = dtpJoinDate.Value;
           


            // validation
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(memberName))
            {
                errorMessage = "Member name is required.";
            }
            else if (memberName.Length > 50)
            {
                errorMessage = "Member name cannot exceed 50 characters.";
            }
            else if (phone.Length != 11)
            {
                errorMessage = "Phone number must  11 digits.";
            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                errorMessage = "Invalid email address. Include '@' and '.' signs.";
            }
          
            else if (joinDate.Date < DateTime.Today)
            {
                errorMessage = "Join date cannot be in the past.";
            }
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }





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
                string query = "insert into Members (MemberName, Email, Phone,JoinDate, Photo) values(@m, @e, @p, @j,@img)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    byte[] imageData = null;
                    if (!String.IsNullOrEmpty(photo))
                    {
                        imageData = File.ReadAllBytes(photo);
                    }


                    cmd.Parameters.AddWithValue("@m", memberName);
                    cmd.Parameters.AddWithValue("@p", phone );
                    cmd.Parameters.AddWithValue("@e", email );
                    cmd.Parameters.AddWithValue("@j", joinDate);
                    if (imageData != null)
                    {

                        cmd.Parameters.AddWithValue("@img", imageData);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@img", DBNull.Value);
                    }
                    int result =  cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("A member added successful.");
                        dataGridView1.DataSource = GetAllMembers();
                    }
                }
                con.Close();
            }
        }

        private void FormMembers_Load(object sender, EventArgs e)
        {
            DataTable members =  GetAllMembers();
            dataGridView1.DataSource = members;
            btnUpdateMember.Visible = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                photo = openFileDialog1.FileName;
            }
        }



        public static DataTable GetAllMembers()
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

                string query = "select * from Members";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    da.Fill(members);
                }
                con.Close();
            }
            return members;
        }
        public DataTable GetMemberById()
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

                string query = "select * from Members where MemberId = @memberId";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    da.Fill(members);
                }
                con.Close();
            }
            return members;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore column headers
            if (e.RowIndex < 0)
                return;
          

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            memberId = (int)row.Cells[0].Value;
            txtMemberName.Text = row.Cells[1].Value?.ToString();
            txtPhone.Text = row.Cells[2].Value?.ToString();
            txtEmail.Text = row.Cells[3].Value?.ToString();
            dtpJoinDate.Value = Convert.ToDateTime(row.Cells[4].Value);
            btnUpdateMember.Visible = true;
            // Display member photo
            if (row.Cells[5].Value != DBNull.Value)
            {
                byte[] imageData = (byte[])row.Cells[5].Value;

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox2.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox2.Image = null;
            }


        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            string memberName = txtMemberName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            DateTime joinDate = dtpJoinDate.Value;



            // validation
            string errorMessage = "";

            
            if (memberName.Length > 50)
            {
                errorMessage = "Member name cannot exceed 50 characters.";
            }
            else if (phone.Length != 11)
            {
                errorMessage = "Phone number must  11 digits.";
            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                errorMessage = "Invalid email address. Include '@' and '.' signs.";
            }

            else if (joinDate.Date < DateTime.Today)
            {
                errorMessage = "Join date cannot be in the past.";
            }
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }





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
                string query = @"
                        UPDATE Members
                        SET
                            MemberName = @m,
                            Email = @e,
                            Phone = @p,
                            JoinDate = @j,
                            Photo = @img
                        WHERE MemberId = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    byte[] imageData = null;
                    if (!String.IsNullOrEmpty(photo))
                    {
                        imageData = File.ReadAllBytes(photo);
                    }


                    cmd.Parameters.AddWithValue("@m", memberName);
                    cmd.Parameters.AddWithValue("@p", phone);
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@j", joinDate);
                    cmd.Parameters.AddWithValue("@id", memberId);
                    //if (imageData != null)
                    //{
                    //    cmd.Parameters.AddWithValue("@img", imageData);
                    //}
                    //else
                    //{
                    //    cmd.Parameters.AddWithValue("@img", DBNull.Value);
                    //}

                    cmd.Parameters.Add("@img", SqlDbType.VarBinary, -1).Value =
                            imageData != null ? (object)imageData : DBNull.Value;

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("A member updated successful.");
                        dataGridView1.DataSource = GetAllMembers();
                    }
                }
                con.Close();
            }
        }
    }
}
