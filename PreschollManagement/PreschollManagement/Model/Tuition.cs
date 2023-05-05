using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreschollManagement.Model
{
    class Tuition
    {
        private string tuitionId;
        private int year;
        private string expiredDate;
        private float tuition;
        private float insurance;
        private float alimony;
        private float otherFee;
        private Student student;
        private Payment payment;
        private int status;

        public Tuition(string tuitionId, int year, string expiredDate, float tuition,
            float insurance, float alimony, float otherFee, Student student, Payment payment, int status)
        {
            this.tuitionId = tuitionId;
            this.year = year;
            this.expiredDate = expiredDate;
            this.tuition = tuition;
            this.insurance = insurance;
            this.alimony = alimony;
            this.otherFee = otherFee;
            this.student = student;
            this.payment = payment;
            this.status = status;
        }

        public Tuition(int year, string expiredDate, float tuition,
            float insurance, float alimony, float otherFee, Student student, Payment payment, int status)
        {
            this.year = year;
            this.expiredDate = expiredDate;
            this.tuition = tuition;
            this.insurance = insurance;
            this.alimony = alimony;
            this.otherFee = otherFee;
            this.student = student;
            this.payment = payment;
            this.status = status;
        }

        public Tuition(string tuitionId)
        {
            this.tuitionId = tuitionId;
        }

        public Tuition(string tuitionId, Student student)
        {
            this.student = student;
            this.tuitionId = tuitionId;
        }

        public Tuition(string tuitionId, Student student, int year)
        {
            this.student = student;
            this.tuitionId = tuitionId;
            this.year = year;
        }

        public string Id
        {
            get { return this.tuitionId; }
            set { this.tuitionId = value; }
        }

        public int Year
        {
            get { return this.year; }
            set
            {
                this.year = value;
            }
        }

        public string ExpriedDate
        {
            get { return this.expiredDate; }
            set
            {
                this.expiredDate = value;
            }
        }

        public float TuitionFee
        {
            get { return this.tuition; }
            set
            {
                this.tuition = value;
            }
        }

        public float Insurance
        {
            get { return this.insurance; }
            set
            {
                this.insurance = value;
            }
        }

        public float Alimony
        {
            get { return this.alimony; }
            set
            {
                this.alimony = value;
            }
        }

        public float OtherFee
        {
            get { return this.otherFee; }
            set
            {
                this.otherFee = value;
            }
        }

        public Student TStudent
        {
            get { return this.student; }
        }

        public Payment TPayment
        {
            get { return this.payment; }
            set { this.payment = value; }
        }

        public int Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public static List<Tuition> getListTuition()
        {
            List<Tuition> list = new List<Tuition>();
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                string query = "select mahocphi, hocphi.mahocsinh, hohocsinh, tenhocsinh, tenlop, namhoc, " +
                    "CONVERT(VARCHAR(10), handong, 105) as 'handong', CONVERT(VARCHAR(10), ngaydong, 105) as 'ngaydong'," +
                    " pttt, tienhocphi, tienbaohiem, tiencapduong, phikhac, trangthai from hocphi, " +
                    "lop, hocsinh where hocsinh.malop = lop.malop and hocphi.mahocsinh = hocsinh.mahocsinh";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        PersionalInfo myinfo = new PersionalInfo(reader["hohocsinh"].ToString(),
                            reader["tenhocsinh"].ToString());
                        Class myClass = new Class("", reader["tenlop"].ToString());

                        Student stu = new Student(reader["mahocsinh"].ToString(), myClass, myinfo);

                        Payment pay = new Payment(reader["pttt"].ToString(), reader["ngaydong"].ToString());

                        Tuition myTuition = new Tuition(
                                reader["mahocphi"].ToString(),
                                int.Parse(reader["namhoc"].ToString()),
                                reader["handong"].ToString(),
                                float.Parse(reader["tienhocphi"].ToString()),
                                float.Parse(reader["tienbaohiem"].ToString()),
                                float.Parse(reader["tiencapduong"].ToString()),
                                float.Parse(reader["phikhac"].ToString()),
                                stu,
                                pay,
                                int.Parse(reader["trangthai"].ToString())
                            );
                        list.Add(myTuition);
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

        public bool addTuition()
        {
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                string query = "set dateformat dmy; ";
                query += "insert into hocphi(mahocsinh, namhoc, handong, ngaydong, pttt, " +
                    "tienhocphi, tienbaohiem, tiencapduong, phikhac, trangthai) values( " +
                    "@mahocsinh , " +
                    "@namhoc , " +
                    "@handong , " +
                    "@ngaydong , " +
                    "@pttt , " +
                    "@tienhocphi , " +
                    "@tienbaohiem , " +
                    "@tiencapduong , " +
                    "@phikhac , " +
                    "@trangthai )";

                SqlCommand cmd = new SqlCommand(query, conn);

                string[] para = {
                    this.TStudent.Id,
                    this.Year.ToString(),
                    this.ExpriedDate,
                    this.TPayment.Date,
                    this.TPayment.Method,
                    this.TuitionFee.ToString(),
                    this.Insurance.ToString(),
                    this.Alimony.ToString(),
                    this.OtherFee.ToString(),
                    this.Status.ToString()
                };
                string[] splited = query.Split(' ');
                int index = 0;
                foreach (string each in splited)
                {
                    if (each[0] == '@')
                    {
                        cmd.Parameters.AddWithValue(each, para[index]);
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
                    MessageBox.Show(e.ToString());
                    return false;
                }

            }
        }

        public bool updateTuition()
        {
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                string query = "set dateformat dmy; ";
                query += "update hocphi set " +
                    "mahocsinh = @mahocsinh , " +
                    "namhoc = @namhoc , " +
                    "handong = @handong , " +
                    "ngaydong = @ngaydong , " +
                    "pttt = @pttt , " +
                    "tienhocphi = @tienhocphi , " +
                    "tienbaohiem = @tienbaohiem , " +
                    "tiencapduong = @tiencapduong , " +
                    "phikhac = @phikhac , " +
                    "trangthai = @trangthai where mahocphi = @mahocphi";

                SqlCommand cmd = new SqlCommand(query, conn);

                string[] para = {
                    this.TStudent.Id,
                    this.Year.ToString(),
                    this.ExpriedDate,
                    this.TPayment.Date,
                    this.TPayment.Method,
                    this.TuitionFee.ToString(),
                    this.Insurance.ToString(),
                    this.Alimony.ToString(),
                    this.OtherFee.ToString(),
                    this.Status.ToString(),
                    this.Id
                };
                string[] splited = query.Split(' ');
                int index = 0;
                foreach (string each in splited)
                {
                    if (each[0] == '@')
                    {
                        cmd.Parameters.AddWithValue(each, para[index]);
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
                    MessageBox.Show(e.ToString());
                    return false;
                }
            }
        }

        public bool deleteTuition()
        {
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                string query = "delete hocphi where mahocphi like @mahocphi ";


                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@mahocphi", this.Id);

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

        public List<Tuition> getListTuitionById()
        {
            List<Tuition> list = new List<Tuition>();
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                string query = "select mahocphi, hocphi.mahocsinh, hohocsinh, tenhocsinh, tenlop, namhoc, " +
                    "CONVERT(VARCHAR(10), handong, 105) as 'handong', CONVERT(VARCHAR(10), ngaydong, 105) as 'ngaydong'," +
                    " pttt, tienhocphi, tienbaohiem, tiencapduong, phikhac, trangthai from hocphi, " +
                    "lop, hocsinh where hocsinh.malop = lop.malop and hocphi.mahocsinh = hocsinh.mahocsinh and hocsinh.mahocsinh = @mahocsinh";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@mahocsinh", this.student.Id);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        PersionalInfo myinfo = new PersionalInfo(reader["hohocsinh"].ToString(),
                            reader["tenhocsinh"].ToString());
                        Class myClass = new Class("", reader["tenlop"].ToString());

                        Student stu = new Student(reader["mahocsinh"].ToString(), myClass, myinfo);

                        Payment pay = new Payment(reader["pttt"].ToString(), reader["ngaydong"].ToString());

                        Tuition myTuition = new Tuition(
                                reader["mahocphi"].ToString(),
                                int.Parse(reader["namhoc"].ToString()),
                                reader["handong"].ToString(),
                                float.Parse(reader["tienhocphi"].ToString()),
                                float.Parse(reader["tienbaohiem"].ToString()),
                                float.Parse(reader["tiencapduong"].ToString()),
                                float.Parse(reader["phikhac"].ToString()),
                                stu,
                                pay,
                                int.Parse(reader["trangthai"].ToString())
                            );
                        list.Add(myTuition);
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

        public List<Tuition> getListTuitionByLastName()
        {
            List<Tuition> list = new List<Tuition>();
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                string query = "select mahocphi, hocphi.mahocsinh, hohocsinh, tenhocsinh, tenlop, namhoc, " +
                    "CONVERT(VARCHAR(10), handong, 105) as 'handong', CONVERT(VARCHAR(10), ngaydong, 105) as 'ngaydong'," +
                    " pttt, tienhocphi, tienbaohiem, tiencapduong, phikhac, trangthai from hocphi, " +
                    "lop, hocsinh where hocsinh.malop = lop.malop and hocphi.mahocsinh = hocsinh.mahocsinh and hocsinh.tenhocsinh = @tenhocsinh";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@tenhocsinh", this.student.Info.LastName);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        PersionalInfo myinfo = new PersionalInfo(reader["hohocsinh"].ToString(),
                            reader["tenhocsinh"].ToString());
                        Class myClass = new Class("", reader["tenlop"].ToString());

                        Student stu = new Student(reader["mahocsinh"].ToString(), myClass, myinfo);

                        Payment pay = new Payment(reader["pttt"].ToString(), reader["ngaydong"].ToString());

                        Tuition myTuition = new Tuition(
                                reader["mahocphi"].ToString(),
                                int.Parse(reader["namhoc"].ToString()),
                                reader["handong"].ToString(),
                                float.Parse(reader["tienhocphi"].ToString()),
                                float.Parse(reader["tienbaohiem"].ToString()),
                                float.Parse(reader["tiencapduong"].ToString()),
                                float.Parse(reader["phikhac"].ToString()),
                                stu,
                                pay,
                                int.Parse(reader["trangthai"].ToString())
                            );
                        list.Add(myTuition);
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

        public DataTable getDataToPrint()
        {

            string tClass = this.student.Class.Name;
            DataTable table = new DataTable();
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                string query = "select hocsinh.mahocsinh, concat(concat(hohocsinh, ' '), tenhocsinh) as 'tenhocsinh', " +
                    "tenlop as 'lop', tienhocphi, tienbaohiem, tiencapduong, phikhac, " +
                    "tienhocphi + tienbaohiem + tiencapduong + phikhac as 'handong'  from hocsinh, lop, hocphi where " +
                    "hocsinh.malop = lop.malop and hocsinh.mahocsinh = hocphi.mahocsinh and tenlop = @tenlop " +
                    "and namhoc = @namhoc";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenlop", this.student.Class.Name);
                cmd.Parameters.AddWithValue("@namhoc", this.Year);


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
    }
}
