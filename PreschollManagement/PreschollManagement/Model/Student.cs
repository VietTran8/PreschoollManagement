using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreschollManagement.Model
{
    class Student
    {
        private string studentId;
        private Class studentClass;
        private PersionalInfo persionalInfo;
        private ContactInfo contactInfo;
        private Parent parent;


        public Student(string studentId, Class studentClass, PersionalInfo persionalInfo,
            ContactInfo contactInfo, Parent parent)
        {
            this.studentId = studentId;
            this.studentClass = studentClass;
            this.persionalInfo = persionalInfo;
            this.contactInfo = contactInfo;
            this.parent = parent;
        }

        public Student(string studentId, Class studentClass, PersionalInfo persionalInfo)
        {
            this.studentId = studentId;
            this.studentClass = studentClass;
            this.persionalInfo = persionalInfo;
        }

        public Student(Class studentClass, PersionalInfo persionalInfo,
            ContactInfo contactInfo, Parent parent)
        {
            this.studentClass = studentClass;
            this.persionalInfo = persionalInfo;
            this.contactInfo = contactInfo;
            this.parent = parent;
        }

        public Student(string studentId)
        {
            this.studentId = studentId;
        }

        public Student(string id, string lastName)
        {
            PersionalInfo per = new PersionalInfo(lastName);
            this.persionalInfo = per;
            this.studentId = id;
        }

        public string Id
        {
            get { return this.studentId; }
        }
        public Class Class
        {
            get { return this.studentClass; }
        }
        public PersionalInfo Info
        {
            get { return this.persionalInfo; }
        }
        public ContactInfo Contact
        {
            get { return this.contactInfo; }
        }
        public Parent MyParent
        {
            get { return this.parent; }
        }

        public static List<Student> getListStudent()
        {
            List<Student> list = new List<Student>();
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                string query = "select hocsinh.mahocsinh, hocsinh.malop, tenlop, " +
                    "hohocsinh, tenhocsinh, gioitinh, CONVERT(VARCHAR(10), ngaysinh, 105) as 'ngaysinh'" +
                    ", dantoc, tongiao, " +
                    "diachi, quequan, tenphuhuynh, sodienthoai from lop, hocsinh, " +
                    "phuhuynh where hocsinh.malop = lop.malop and " +
                    "hocsinh.mahocsinh = phuhuynh.mahocsinh";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Class newClass = new Class(reader["malop"].ToString(), reader["tenlop"].ToString());
                        
                        PersionalInfo myInfo = new PersionalInfo(reader["hohocsinh"].ToString(),
                            reader["tenhocsinh"].ToString(), int.Parse(reader["gioitinh"].ToString()),
                            reader["ngaysinh"].ToString(), reader["dantoc"].ToString(), 
                            reader["tongiao"].ToString());

                        ContactInfo myContact = new ContactInfo(reader["diachi"].ToString(), reader["quequan"].ToString());

                        Parent myParent = new Parent(reader["tenphuhuynh"].ToString(), reader["sodienthoai"].ToString());

                        Student myStudent = new Student(reader["mahocsinh"].ToString(),
                            newClass, myInfo, myContact, myParent);
                        list.Add(myStudent);
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

        public bool addStudent()
        {
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                int gen = 0;
                if (this.Info.Gender == "Nam")
                    gen = 0;
                else
                    gen = 1;
                
                string query = "SET DATEFORMAT dmy;" +
                    "exec themHocSinh '"+this.Class.Id+"', " +
                    "N'"+this.Info.FirstName+"', N'"+this.Info.LastName+"', " +
                    ""+gen+", '"+this.Info.BirthDay+"', " +
                    "N'"+this.Info.Ethnicity+"', N'"+this.Info.Religion+"', " +
                    "N'"+this.Contact.Address+"', " +
                    "N'"+this.contactInfo.Hometown+"', " +
                    "N'"+this.parent.Name+"', '"+this.parent.Phone+"'";

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
                    return false;
                }

            }
        }

        public bool updateStudent()
        {
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                int gen = 0;
                if (this.Info.Gender == "Nam")
                    gen = 0;
                else
                    gen = 1;

                string query = "SET DATEFORMAT dmy; ";
                query += "exec capNhatHocSinh '"+this.Id+"', '"+this.Class.Id+"', " +
                    "N'"+this.Info.FirstName+"', N'"+this.Info.LastName+"', "+gen+", '"+this.Info.BirthDay+"', " +
                    "N'"+this.Info.Ethnicity+"', N'"+this.Info.Religion+"', N'"+this.contactInfo.Address+"', " +
                    "N'"+this.contactInfo.Hometown+"', N'"+this.parent.Name+ "', '"+this.parent.Phone+"'";

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
                    return false;
                }
            }
        }

        public bool deleteStudent()
        {
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                

                string query = "delete phuhuynh where mahocsinh = @mahocsinh ; ";
                query += "delete kqrenluyen where mahocsinh = @mahocsinh; ";
                query += "delete hocphi where mahocsinh = @mahocsinh; ";


                query += "delete hocsinh where mahocsinh = @mahocsinh ";

                SqlCommand cmd = new SqlCommand(query, conn);

                //Add params to command
                cmd.Parameters.AddWithValue("@mahocsinh", this.studentId);

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

        public List<Student> getListStudentByLastName()
        {
            List<Student> list = new List<Student>();
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                string query = "select hocsinh.mahocsinh, hocsinh.malop, tenlop, " +
                    "hohocsinh, tenhocsinh, gioitinh, CONVERT(VARCHAR(10), ngaysinh, 105) as 'ngaysinh'" +
                    ", dantoc, tongiao, " +
                    "diachi, quequan, tenphuhuynh, sodienthoai from lop, hocsinh, " +
                    "phuhuynh where hocsinh.malop = lop.malop and " +
                    "hocsinh.mahocsinh = phuhuynh.mahocsinh and hocsinh.tenhocsinh like @tenhocsinh";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenhocsinh", this.Info.LastName);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Class newClass = new Class(reader["malop"].ToString(), reader["tenlop"].ToString());

                        PersionalInfo myInfo = new PersionalInfo(reader["hohocsinh"].ToString(),
                            reader["tenhocsinh"].ToString(), int.Parse(reader["gioitinh"].ToString()),
                            reader["ngaysinh"].ToString(), reader["dantoc"].ToString(),
                            reader["tongiao"].ToString());

                        ContactInfo myContact = new ContactInfo(reader["diachi"].ToString(), reader["quequan"].ToString());

                        Parent myParent = new Parent(reader["tenphuhuynh"].ToString(), reader["sodienthoai"].ToString());

                        Student myStudent = new Student(reader["mahocsinh"].ToString(),
                            newClass, myInfo, myContact, myParent);
                        list.Add(myStudent);
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

        public List<Student> getListStudentById()
        {
            List<Student> list = new List<Student>();
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                string query = "select hocsinh.mahocsinh, hocsinh.malop, tenlop, " +
                    "hohocsinh, tenhocsinh, gioitinh, CONVERT(VARCHAR(10), ngaysinh, 105) as 'ngaysinh'" +
                    ", dantoc, tongiao, " +
                    "diachi, quequan, tenphuhuynh, sodienthoai from lop, hocsinh, " +
                    "phuhuynh where hocsinh.malop = lop.malop and " +
                    "hocsinh.mahocsinh = phuhuynh.mahocsinh and hocsinh.mahocsinh like @mahocsinh";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@mahocsinh", this.studentId);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Class newClass = new Class(reader["malop"].ToString(), reader["tenlop"].ToString());

                        PersionalInfo myInfo = new PersionalInfo(reader["hohocsinh"].ToString(),
                            reader["tenhocsinh"].ToString(), int.Parse(reader["gioitinh"].ToString()),
                            reader["ngaysinh"].ToString(), reader["dantoc"].ToString(),
                            reader["tongiao"].ToString());

                        ContactInfo myContact = new ContactInfo(reader["diachi"].ToString(), reader["quequan"].ToString());

                        Parent myParent = new Parent(reader["tenphuhuynh"].ToString(), reader["sodienthoai"].ToString());

                        Student myStudent = new Student(reader["mahocsinh"].ToString(),
                            newClass, myInfo, myContact, myParent);
                        list.Add(myStudent);
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

        public static DataTable getDataToPrint()
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                string query = "select * from InDanhSachHocSinh";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);

                    return table;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return null;
                }
            }
        }

        public List<Student> getListStudentByClass()
        {
            string classId = this.Class.Id;
            string schoolYear = this.Class.SchoolYear.Trim();


            List<Student> list = new List<Student>();
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                string query = "select hocsinh.mahocsinh, hocsinh.malop, tenlop, " +
                    "hohocsinh, tenhocsinh, gioitinh, CONVERT(VARCHAR(10), ngaysinh, 105) as 'ngaysinh'" +
                    ", dantoc, tongiao, " +
                    "diachi, quequan, tenphuhuynh, sodienthoai from lop, hocsinh, " +
                    "phuhuynh where hocsinh.malop = lop.malop and " +
                    "hocsinh.mahocsinh = phuhuynh.mahocsinh and lop.malop = @malop and lop.nienkhoa = @nienkhoa";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@malop", classId);
                cmd.Parameters.AddWithValue("@nienkhoa", schoolYear);


                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Class newClass = new Class(reader["malop"].ToString(), reader["tenlop"].ToString());

                        PersionalInfo myInfo = new PersionalInfo(reader["hohocsinh"].ToString(),
                            reader["tenhocsinh"].ToString(), int.Parse(reader["gioitinh"].ToString()),
                            reader["ngaysinh"].ToString(), reader["dantoc"].ToString(),
                            reader["tongiao"].ToString());

                        ContactInfo myContact = new ContactInfo(reader["diachi"].ToString(), reader["quequan"].ToString());

                        Parent myParent = new Parent(reader["tenphuhuynh"].ToString(), reader["sodienthoai"].ToString());

                        Student myStudent = new Student(reader["mahocsinh"].ToString(),
                            newClass, myInfo, myContact, myParent);
                        list.Add(myStudent);
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
    }
}
