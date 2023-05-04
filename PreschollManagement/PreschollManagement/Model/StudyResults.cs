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
    class StudyResults
    {
        private string resultId;
        private Student student;
        private int month;
        private int physical;
        private int awareness;
        private int language;
        private int socialAffection;
        private int aesthetic;

        public StudyResults(string resultId, Student student, int month, int physical, int awareness, int language, int socialAffection, int aesthetic) 
        {
            this.resultId = resultId;
            this.student = student;
            this.month = month;
            this.physical = physical;
            this.awareness = awareness;
            this.language = language;
            this.socialAffection = socialAffection;
            this.aesthetic = aesthetic;
        }

        public StudyResults(Student student, int month)
        {
            this.student = student;
            this.month = month;
        }

        public StudyResults(
                string resultId,
                int physical,
                int awareness,
                int socialAffection,
                int language,
                int aesthetic
            )
        {
            this.resultId = resultId;
            this.physical = physical;
            this.awareness = awareness;
            this.socialAffection = socialAffection;
            this.language = language;
            this.aesthetic = aesthetic;
        }

        public static List<StudyResults> getListStudyResults()
        {
            List<StudyResults> list = new List<StudyResults>();
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();
                string query = "select maketqua, hocsinh.mahocsinh, CONCAT(CONCAT(hocsinh.hohocsinh, ' '), " +
                    "hocsinh.tenhocsinh) as 'hovaten', thang, thechat, nhanthuc, ngonngu, tinhcamxh, thammy from kqrenluyen, hocsinh where " +
                    "hocsinh.mahocsinh = kqrenluyen.mahocsinh";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string resultId = reader["maketqua"].ToString();
                        Student student = new Student(reader["mahocsinh"].ToString(), reader["hovaten"].ToString());
                        int month = int.Parse(reader["thang"].ToString());
                        int physical = int.Parse(reader["thechat"].ToString());
                        int awareness = int.Parse(reader["nhanthuc"].ToString());
                        int language = int.Parse(reader["ngonngu"].ToString());
                        int socialAffection = int.Parse(reader["tinhcamxh"].ToString());
                        int aesthetic = int.Parse(reader["thammy"].ToString());

                        StudyResults myResult = new StudyResults(resultId, student, month, physical, awareness, language, socialAffection, aesthetic);
                        list.Add(myResult);
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

        public static bool addListStudyResult(int month, string ClassId, string schoolYear)
        {
            Class newClass = new Class(ClassId);
            newClass.SchoolYear = schoolYear;
            Student stu = new Student("", newClass , null);

            List<Student> list = stu.getListStudentByClass();
            int count = 0;
            foreach (Student each in list)
            {
                string query = "insert into kqrenluyen (mahocsinh, thang, thechat, nhanthuc, ngongu, tinhcamxh, thammy)" +
                    "values ('"+each.Id+"', '"+month+"', 0, 0, 0, 0, 0); ";

                using (SqlConnection conn = DB.Instance.getConnection())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    try
                    {
                        int numRowsAffected = cmd.ExecuteNonQuery();
                        if (numRowsAffected > 0)
                        {
                            count++;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                        return false;
                    }
                }
            }

            if (count == list.Count)
            {
                return true;
            }
            return false;
        }


        public bool isExists()
        {
            string studentId = this.student.Id;
            int month = this.month;

            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                string query = "select * from kqrenluyen where mahocsinh = @mahocsinh and thang = @thang";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mahocsinh", studentId);
                cmd.Parameters.AddWithValue("@thang", month);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    return true;
                return false;
            }
        }

        public static DataTable viewStudyResult(int month, string classId, string schoolYear)
        {
            string query = "select maketqua as N'Mã kết quả', hocsinh.mahocsinh as N'Mã học sinh', concat(concat(hohocsinh, ' '), tenhocsinh) as 'Họ và tên', " +
                "CASE WHEN thechat = 0 THEN N'Chưa xét' WHEN thechat = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as N'Thể chất', " +
                "CASE WHEN nhanthuc = 0 THEN N'Chưa xét' WHEN nhanthuc = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as N'Nhận thức', " +
                "CASE WHEN ngongu = 0 THEN N'Chưa xét' WHEN ngongu = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as N'Ngôn ngữ', " +
                "CASE WHEN tinhcamxh = 0 THEN N'Chưa xét' WHEN tinhcamxh = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as N'Tình cảm xã hội', " +
                "CASE WHEN thammy = 0 THEN N'Chưa xét' WHEN thammy = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as N'Thẩm mỹ' " +
                "from kqrenluyen, hocsinh, lop " +
                "where kqrenluyen.mahocsinh = hocsinh.mahocsinh and hocsinh.malop = Lop.malop " +
                "and lop.malop = @classId and thang = @month and nienkhoa = @schoolYear";
            DataTable table = new DataTable();
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@classId", classId);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@schoolYear", schoolYear);

                try
                {
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);

                    adpt.Fill(table);

                    return table;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return null;
                }
            }
        }

        public static List<string> getNewAddedStudentIds(int month, string ClassId, string schoolYear)
        {
            List<string> list = new List<string>();
            string query = "select mahocsinh from hocsinh where hocsinh.mahocsinh not in (select mahocsinh from " +
                "kqrenluyen where thang = "+month+") and hocsinh.malop in (select lop.malop from kqrenluyen, hocsinh, lop " +
                "where kqrenluyen.mahocsinh = hocsinh.mahocsinh and lop.malop = hocsinh.malop and " +
                "lop.nienkhoa = '"+schoolYear.Trim()+"') and hocsinh.malop = '"+ClassId+"'";

            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    while (reader.Read())
                    {
                        list.Add(reader["mahocsinh"].ToString());
                    }
                    return list;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return null;
                }
            }
        }

        public static bool updateListStudyResult(int month, string ClassId, string schoolYear)
        {

            List<string> list = getNewAddedStudentIds(month, ClassId, schoolYear);

            if (list == null)
            {
                return false;
            }

            if (list.Count == 0)
                return false;
            int count = 0;
            foreach (string each in list)
            {
                string query = "insert into kqrenluyen (mahocsinh, thang, thechat, nhanthuc, ngongu, tinhcamxh, thammy)" +
                    "values ('" + each + "', '" + month + "', 0, 0, 0, 0, 0); ";

                using (SqlConnection conn = DB.Instance.getConnection())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    try
                    {
                        int numRowsAffected = cmd.ExecuteNonQuery();
                        if (numRowsAffected > 0)
                        {
                            count++;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                        return false;
                    }
                }
            }

            if (count == list.Count)
            {
                return true;
            }
            return false;
        }

        public bool updateStudyResult()
        {
            string resultId = this.resultId;
            int physical = this.physical;
            int awareness = this.awareness;
            int socialAffection = this.socialAffection;
            int language = this.language;
            int aesthetic = this.aesthetic;

            string query = "update kqrenluyen set thechat = @thechat , nhanthuc = @nhanthuc ," +
                "tinhcamxh = @tinhcamxh , ngongu = @ngongu , thammy = @thammy where maketqua = @maketqua";


            using (SqlConnection conn = DB.Instance.getConnection())

            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                string[] splited = query.Split(' ');
                object[] para = { physical, awareness, socialAffection, language, aesthetic, resultId };
                int index = 0;

                foreach (string item in splited)

                {
                    if (item[0] == '@')
                    {
                        cmd.Parameters.AddWithValue(item, para[index]);
                        index++;
                    }
                }

                try
                {
                    int numRowAffected = cmd.ExecuteNonQuery();

                    if (numRowAffected > 0)
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

        public static DataTable getListResultToPrint(int month, string classId, string schoolYear)
        {
            string query = "select concat(concat(tenlop, ' ('), concat(nienkhoa, ')')) as 'lop', thang, hocsinh.mahocsinh, concat(concat(hohocsinh, ' '), tenhocsinh) as 'hoten', " +
                "CASE WHEN thechat = 0 THEN N'Chưa xét' WHEN thechat = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as 'thechat', " +
                "CASE WHEN nhanthuc = 0 THEN N'Chưa xét' WHEN nhanthuc = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as 'nhanthuc', " +
                "CASE WHEN ngongu = 0 THEN N'Chưa xét' WHEN ngongu = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as 'ngongu', " +
                "CASE WHEN tinhcamxh = 0 THEN N'Chưa xét' WHEN tinhcamxh = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as 'tinhcamxh', " +
                "CASE WHEN thammy = 0 THEN N'Chưa xét' WHEN thammy = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as 'thammy' " +
                "from hocsinh, lop, kqrenluyen where hocsinh.mahocsinh = kqrenluyen.mahocsinh and hocsinh.malop = lop.malop " +
                "and lop.malop = '"+classId+"' and lop.nienkhoa = '"+schoolYear+"' and thang = "+month;
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                DataTable tb = new DataTable();
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                

                try
                {
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);

                    adpt.Fill(tb);

                    return tb;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return null;
                }
            }

        }

        public static DataTable viewStudyResultByStudentId(int month, string classId, string schoolYear, string search)
        {
            string query = "select maketqua as N'Mã kết quả', hocsinh.mahocsinh as N'Mã học sinh', concat(concat(hohocsinh, ' '), tenhocsinh) as 'Họ và tên', " +
                "CASE WHEN thechat = 0 THEN N'Chưa xét' WHEN thechat = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as N'Thể chất', " +
                "CASE WHEN nhanthuc = 0 THEN N'Chưa xét' WHEN nhanthuc = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as N'Nhận thức', " +
                "CASE WHEN ngongu = 0 THEN N'Chưa xét' WHEN ngongu = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as N'Ngôn ngữ', " +
                "CASE WHEN tinhcamxh = 0 THEN N'Chưa xét' WHEN tinhcamxh = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as N'Tình cảm xã hội', " +
                "CASE WHEN thammy = 0 THEN N'Chưa xét' WHEN thammy = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as N'Thẩm mỹ' " +
                "from kqrenluyen, hocsinh, lop " +
                "where kqrenluyen.mahocsinh = hocsinh.mahocsinh and hocsinh.malop = Lop.malop " +
                "and lop.malop = @classId and thang = @month and nienkhoa = @schoolYear " +
                "and hocsinh.mahocsinh like @timkiem";
            DataTable table = new DataTable();
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@classId", classId);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@schoolYear", schoolYear);
                cmd.Parameters.AddWithValue("@timkiem", search);

                try
                {
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);

                    adpt.Fill(table);

                    return table;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return null;
                }
            }
        }

        public static DataTable viewStudyResultByStudentName(int month, string classId, string schoolYear, string search)
        {
            string query = "select maketqua as N'Mã kết quả', hocsinh.mahocsinh as N'Mã học sinh', concat(concat(hohocsinh, ' '), tenhocsinh) as 'Họ và tên', " +
                "CASE WHEN thechat = 0 THEN N'Chưa xét' WHEN thechat = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as N'Thể chất', " +
                "CASE WHEN nhanthuc = 0 THEN N'Chưa xét' WHEN nhanthuc = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as N'Nhận thức', " +
                "CASE WHEN ngongu = 0 THEN N'Chưa xét' WHEN ngongu = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as N'Ngôn ngữ', " +
                "CASE WHEN tinhcamxh = 0 THEN N'Chưa xét' WHEN tinhcamxh = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as N'Tình cảm xã hội', " +
                "CASE WHEN thammy = 0 THEN N'Chưa xét' WHEN thammy = 1 THEN N'Chưa đạt' ELSE N'Đạt' END as N'Thẩm mỹ' " +
                "from kqrenluyen, hocsinh, lop " +
                "where kqrenluyen.mahocsinh = hocsinh.mahocsinh and hocsinh.malop = Lop.malop " +
                "and lop.malop = @classId and thang = @month and nienkhoa = @schoolYear " +
                "and hocsinh.tenhocsinh like @timkiem";
            DataTable table = new DataTable();
            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@classId", classId);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@schoolYear", schoolYear);
                cmd.Parameters.AddWithValue("@timkiem", search);

                try
                {
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);

                    adpt.Fill(table);

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
