using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;


namespace Assignment
{
    class DataHandler
    {
        public DataHandler()
        {

        }
        string Students;
        public List<Students> Serching(int student_)
        {
            List<Students> cake = new List<Students>();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Cakes ck = new Cakes();
                    ck.Order = int.Parse(reader[0].ToString());
                    ck.Name = reader[1].ToString();
                    ck.Surname = reader[2].ToString();
                    ck.Phonenumber = reader[3].ToString();
                    ck.Email = reader[4].ToString();
                    ck.Typeofcake = reader[5].ToString();
                    ck.Quantity = int.Parse(reader[6].ToString());
                    ck.Price = int.Parse(reader[7].ToString());
                    ck.Collectiondate = DateTime.Parse(reader[8].ToString());
                    ck.Specialmessage = reader[1].ToString();
                    cake.Add(new Cakes(ck.Order, ck.Name, ck.Surname, ck.Phonenumber, ck.Email, ck.Typeofcake, ck.Quantity, ck.Price, ck.Collectiondate, ck.Specialmessage));
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conn.Close();
            }
            return cake;
        }
    }
}
