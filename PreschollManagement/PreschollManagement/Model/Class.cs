using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreschollManagement.Model
{
    class Class
    {
        private string classId;
        private string className;
        private string room;
        private string classLevel;
        private string schoolYear;

        public Class(string classId, string className, string room, string classLevel, string schoolYear)
        {
            this.classId = classId;
            this.className = className;
            this.room = room;
            this.classLevel = classLevel;
            this.schoolYear = schoolYear;
        }

        public Class(string className, string room, string classLevel, string schoolYear)
        {
            this.className = className;
            this.room = room;
            this.classLevel = classLevel;
            this.schoolYear = schoolYear;
        }

        public Class(string classId, string className)
        {
            this.classId = classId;
            this.className = className;
        }

        public Class(string classId)
        {
            this.classId = classId;
        }

        public string Id
        {
            get { return this.classId; }
            set { this.classId = value; }
        }
        public string Name
        {
            get { return this.className; }
            set { this.className = value; }
        }

        public string Room
        {
            get { return this.room; }
            set { this.room = value; }
        }

        public string Level
        {
            get { return this.classLevel; }
            set { this.classLevel = value; }
        }

        public string SchoolYear
        {
            get { return this.schoolYear; }
            set { this.schoolYear = value; }
        }

        public static List<Class> getListClass()
        {
            List<Class> list = new List<Class>();
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                string query = "select * from lop";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Class myClass = new Class(reader["malop"].ToString(), reader["tenlop"].ToString(),
                            reader["phong"].ToString(), reader["khoilop"].ToString(), reader["nienkhoa"].ToString());
                        list.Add(myClass);
                    }
                    conn.Close();
                    return list;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return null;
                }
            }
        }

        public bool addClass()
        {
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                string query = "exec themLop N'" + this.className + "', '" + this.room + "', N'" + this.classLevel + "', '" + this.schoolYear + "'";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    int numRowsAffected = cmd.ExecuteNonQuery();
                    if (numRowsAffected > 0)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return false;
                }

            }
        }

        public bool updateClass()
        {
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                string query = "update lop set tenlop = @tenlop , phong = @phong , nienkhoa = @nienkhoa ," +
                    "khoilop = @khoilop where malop like @malop";

                SqlCommand cmd = new SqlCommand(query, conn);

                //Add params to command
                string[] listWords = query.Split(' ');
                string[] listParams = { this.className, this.room, this.schoolYear, this.classLevel, this.classId };
                int index = 0;
                foreach (string word in listWords)
                {
                    if (word[0] == '@')
                    {
                        cmd.Parameters.AddWithValue(word, listParams[index]);
                        index++;
                    }
                }

                try
                {
                    int numRowsAffected = cmd.ExecuteNonQuery();
                    if (numRowsAffected > 0)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public bool deleteClass()
        {

            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                
                string query = "exec deleteClass '"+this.classId+"'";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    int numRowsAffected = cmd.ExecuteNonQuery();
                    if (numRowsAffected > 0)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }

                conn.Close();
            }
        }
    }
}
