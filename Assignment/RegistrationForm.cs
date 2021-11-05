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
    public partial class formReg : Form
    {
        public formReg()
        {
            InitializeComponent();
        }

        private void formReg_Load(object sender, EventArgs e)
        {

        }

       private void buttonReg_Click(object sender, EventArgs e)
        {
           /*Am Not Quite sure with this one @Tshego
            * 
            * string StudentNumber = TextBoxStudentNum.Text;
            string FirstName = textBoxFname.Text;
            string LastName = TextBoxLname.Text;
            string DateOfBirth = TextBoxLname.Text;
            string PhoneNumber = TextBoxLname.Text;
            string Gender = TextBoxLname.Text;
            string PhysicalAddress = TextBoxLname.Text;
            string ModuleCode = richTextBoxModule.Text;



            if (StudentNumber==Text && FirstName==Text && LastName==Text && DateOfBirth==Text && PhoneNumber==Text && Gender==Text && PhysicalAddress==Text)
            {

                MessageBox.Show("YOU HAVE REGISTERED SUCCESSFULLY");
                this.Hide();

            }
            else
            {
                if (StudentNumber.Trim().Equals(""))
                {
                    MessageBox.Show("ENTER YOUR FIRSTNAME TO REGISTER", "EMPTY FIRSTNAME", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (FirstName.Trim().Equals(""))
                {
                    MessageBox.Show("ENTER YOUR FIRSTNAME TO REGISTER", "EMPTY FIRSTNAME", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (LastName.Trim().Equals(""))
                {
                    MessageBox.Show("ENTER YOUR LASTNAME TO REGISTER", "EMPTY LASTNAME", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (DateOfBirth.Trim().Equals(""))
                {
                    MessageBox.Show("ENTER YOUR DATEOFBIRTH TO REGISTER", "EMPTY DATEOFBIRTH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (PhoneNumber.Trim().Equals(""))
                {
                    MessageBox.Show("ENTER YOUR PHONENUMBER TO REGISTER", "EMPTY PHONENUMBER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Gender.Trim().Equals(""))
                {
                    MessageBox.Show("ENTER YOUR GENDER TO REGISTER", "EMPTY GENDER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (PhysicalAddress.Trim().Equals(""))
                {
                    MessageBox.Show("ENTER YOUR PHYSICALADDRESS TO REGISTER", "EMPTY PHYSICALADDRESS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ModuleCode.Trim().Equals(""))
                {
                    MessageBox.Show("ENTER YOUR MODULE CODE TO REGISTER", "EMPTY MODULECODES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           */


         
            }

        private void textBoxPhoneNum_TextChanged(object sender, EventArgs e)
        {

        }
    } 
 }


