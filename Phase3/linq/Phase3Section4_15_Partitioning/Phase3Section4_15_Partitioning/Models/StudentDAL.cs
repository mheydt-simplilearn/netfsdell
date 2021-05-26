using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Section4_15_Partitioning.Models
{
    public class StudentDAL
    {
        string connectionString = "data source=.\\SQLEXPRESS;initial catalog=School;integrated security=False;MultipleActiveResultSets=True;User id=sa;Password=P@ssword";

        public IEnumerable<Student> GetAllStudents()
        {
            List<Student> lstStudents = new List<Student>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Student", con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Student student = new Student();

                    student.ID = Convert.ToInt32(rdr["ID"]);
                    student.Name = rdr["Name"].ToString();
                    student.Email = rdr["Email"].ToString();
                    student.Address = rdr["Address"].ToString();
                    student.Class = rdr["Class"].ToString();
                    student.MarksPercent = Convert.ToInt32(rdr["MarksPercent"]);

                    lstStudents.Add(student);
                }
                con.Close();
            }
            return lstStudents;
        }
    }
}
