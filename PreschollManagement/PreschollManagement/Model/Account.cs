using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreschollManagement.Model
{
    public class Account
    {
        private string username;
        private string password;
        private int role;

        public Account(string username, string password, int role) 
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public Account(string username)
        {
            this.username = username;
        }

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;

        }

        public string Name 
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get
            {
                string password = "";
                for (int i = 0; i < this.password.Length; i++)
                {
                    password += "*";
                }
                return password;
            }
            set { this.password = value; }
        }

        public object Role
        {
            get
            {
                switch (this.role) 
                {
                    case 0:
                        return "Quản trị viên";
                    case 1:
                        return "Tổ chuyên môn";
                    case 2:
                        return "Giáo viên";
                    case 3:
                        return "Kế toán";
                    case 4:
                        return "Cấp dưỡng";
                    default:
                        return null;
                }
            }
            set { this.role = (int)value; }
        }

        public static List<Account> getListAccount()
        {
            List<Account> list = new List<Account>();
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                string query = "select * from taikhoan";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Account myAcc = new Account(reader["tentaikhoan"].ToString(), reader["matkhau"].ToString(),
                           int.Parse(reader["vaitro"].ToString()));
                        list.Add(myAcc);
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

        public bool usernameIsExists()
        {
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                string query = "select * from taikhoan where tentaikhoan like @tentaikhoan";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tentaikhoan", this.username);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
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

        public bool createAccount()
        {
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                string query = "insert into taikhoan values ( @username , @password , @role )";

                SqlCommand cmd = new SqlCommand(query, conn);

                //Add params to command
                string[] listWords = query.Split(' ');
                string[] listParams = { this.username, this.password, this.role.ToString() };
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

        public bool updateRole()
        {
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                string query = "update taikhoan set vaitro = @role where tentaikhoan like @username ";

                SqlCommand cmd = new SqlCommand(query, conn);

                //Add params to command
                cmd.Parameters.AddWithValue("@role", this.role.ToString());
                cmd.Parameters.AddWithValue("@username", this.username);


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

        public bool delettAccount()
        {
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                string query = "delete taikhoan where tentaikhoan = @username";

                SqlCommand cmd = new SqlCommand(query, conn);

                //Add params to command
                cmd.Parameters.AddWithValue("@username", this.username);


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

        public bool resetPassword()
        {
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                string query = "update taikhoan set matkhau = @matkhau where tentaikhoan like @username";

                SqlCommand cmd = new SqlCommand(query, conn);

                //Add params to command
                cmd.Parameters.AddWithValue("@username", this.username);
                cmd.Parameters.AddWithValue("@matkhau", this.password);


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

        public int accountValidate()
        {
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                string query = "select vaitro from taikhoan where tentaikhoan = @username and matkhau = @password";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", this.username);
                cmd.Parameters.AddWithValue("@password", this.password);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        return int.Parse(reader["vaitro"].ToString());
                    }
                    return -1;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return -1;
                }
            }
        }
    }
}
