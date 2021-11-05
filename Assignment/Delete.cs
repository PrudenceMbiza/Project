using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Assignment
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }
        //Make An SQL Connection
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SJB7MH9\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");

        int Student;
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Student > 0)
            {
                SqlCommand command = new SqlCommand("DELETE FROM Students WHERE [Student]=@student", conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@student", this.Student);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Student Deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // GetStudentRecords();
            }

            else
            {
                MessageBox.Show("Please Select a Student You Want To Delete!", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

