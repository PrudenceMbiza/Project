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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }
        int student;
        //SQL Connection
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SJB7MH9\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");

        private void textBoxAddress_Load(object sender, EventArgs e)
        {
            GetStudentRecords();
        }
        private void GetStudentRecords()
        {
            SqlCommand command = new SqlCommand("SELECT* FROM tblStudent", conn);
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataReader sdr = command.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            student = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            textBoxStudentNumber.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxFname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxLName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBoxDOB.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBoxGender.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBoxPNumber.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBoxAddress.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBoxModuleCode.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void textBoxFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (student > 0)
            {
                SqlCommand command = new SqlCommand("UPDATE Students SET StudentNumber=@studentnumber,FirstName=@firstname,LastName=@lastname,DateOfBirth=@dateofbirth,PhoneNumber=@phone,PhysicalAddress=@address,ModuleCodes=@modulecodes WHERE [Student]=@student", conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@studentnumber", textBoxStudentNumber.Text);
                command.Parameters.AddWithValue("@firstname", textBoxFname.Text);
                command.Parameters.AddWithValue("@lastname", textBoxLName.Text);
                command.Parameters.AddWithValue("@dateofbirth", textBoxDOB.Text);
                command.Parameters.AddWithValue("@phone", textBoxPNumber.Text);
                command.Parameters.AddWithValue("@address", textBoxAddress.Text);
                command.Parameters.AddWithValue("@modulecodes", textBoxModuleCode.Text);
                command.Parameters.AddWithValue("@student", this.student);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentRecords();
            }

            else
            {
                MessageBox.Show("Please Select a Student to Update!", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
