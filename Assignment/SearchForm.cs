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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SJB7MH9\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");
        public int student;

        private void SearchForm_Load(object sender, EventArgs e)
        {
            GetStudentRecords();
        }
        private void GetStudentRecords()
        {
            SqlCommand command = new SqlCommand("SELECT* FROM Cakes", conn);
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataReader sdr = command.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            dataGridViewSearch.DataSource = dt;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int student = int.Parse(textBoxStudentID.Text);
            DataHandler data = new DataHandler();
           // List<Students> value = data.Searching(student);
          //  dataGridViewSearch.DataSource = value;
        }

        private void dataGridViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            student = Convert.ToInt32(dataGridViewSearch.SelectedRows[0].Cells[0].Value);
        }
    }
}
