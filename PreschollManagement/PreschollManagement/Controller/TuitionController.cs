using PreschollManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreschollManagement.Controller
{
    class TuitionController
    {
        public static DataTable getListTuition()
        {
            DataTable table = new DataTable();
            List<Tuition> list = Tuition.getListTuition();
            if (list != null)
            {
                table.Columns.AddRange(new DataColumn[14] {
                    new DataColumn("Mã học phí"),
                    new DataColumn("Mã học sinh"),
                    new DataColumn("Họ học sinh"),
                    new DataColumn("Tên học sinh"),
                    new DataColumn("Lớp"),
                    new DataColumn("Năm học"),
                    new DataColumn("Hạn đóng"),
                    new DataColumn("Ngày đóng"),
                    new DataColumn("PTTT"),
                    new DataColumn("Học phí"),
                    new DataColumn("Phí bảo hiểm"),
                    new DataColumn("Phí cấp dưỡng"),
                    new DataColumn("Phí khác"),
                    new DataColumn("Trạng thái")
                });

                foreach (Tuition tuition in list)
                {
                    string status = "";
                    if (tuition.Status == 0)
                    {
                        status = "Chưa đóng";
                    } else
                    {
                        status = "Đã đóng";
                    }
                    table.Rows.Add(
                        tuition.Id,
                        tuition.TStudent.Id,
                        tuition.TStudent.Info.FirstName,
                        tuition.TStudent.Info.LastName,
                        tuition.TStudent.Class.Name,
                        tuition.Year,
                        tuition.ExpriedDate,
                        tuition.TPayment.Date,
                        tuition.TPayment.Method,
                        tuition.TuitionFee,
                        tuition.Insurance,
                        tuition.Alimony,
                        tuition.OtherFee,
                        status
                    );
                }
                return table;
            }
            else
            {
                return null;
            }
        }

        public static string addTuition(int year, string expiredDate, float tuition,
            float insurance, float alimony, float otherFee, string id, string paymentDate, string paymentMethod, int status)
        {
            Tuition myTui = new Tuition(
                     year,
                     expiredDate,
                     tuition,
                     insurance,
                     alimony,
                     otherFee,
                     new Student(id),
                     new Payment(paymentMethod, paymentDate),
                     status
                );
            if (myTui.addTuition())
                return "Thêm học phí thành công!";
            return "Thêm học phí không thành công, vui lòng kiểm tra lại thông tin";
        }

        public static string updateTuition(string tuitionid, int year, string expiredDate, float tuition,
            float insurance, float alimony, float otherFee, string id, string paymentDate, string paymentMethod, int status)
        {
            Tuition myTui = new Tuition(
                    tuitionid,
                    year,
                    expiredDate,
                    tuition,
                    insurance,
                    alimony,
                    otherFee,
                    new Student(id),
                    new Payment(paymentMethod, paymentDate),
                    status
               );
            if (myTui.updateTuition())
                return "Cập nhật học phí thành công!";
            return "Cập nhật học phí không thành công, vui lòng kiểm tra lại thông tin";
        }

        public static Dictionary<string, List<string>> fetchStudent()
        {
            List<Student> list = Student.getListStudent();
            if (list != null)
            {
                Dictionary<string, List<string>> myDict = new Dictionary<string, List<string>>();
                foreach (Student each in list)
                {
                    List<string> listInfo = new List<string>();
                    listInfo.Add(each.Class.Name);
                    listInfo.Add(each.Info.FirstName);
                    listInfo.Add(each.Info.LastName);
                    myDict.Add(each.Id, listInfo);
                }
                List<string> listInfo1 = new List<string>();
                listInfo1.Add("");
                listInfo1.Add("");
                listInfo1.Add("");
                myDict.Add("", listInfo1);
                return myDict;
            }
            else {
                return null;
            }
        }

        public static string deleteTuition(string tuitionId)
        {
            Tuition newTuition = new Tuition(tuitionId);
            if (newTuition.deleteTuition())
            { 
                return "Đã xóa thành công!";
            }
            return "Xóa thất bại, vui lòng thử lại sau";
        }

        public static DataTable getListTuitionById(string id)
        {
            DataTable table = new DataTable();
            Tuition newTuition = new Tuition("", new Student(id));
            List<Tuition> list = newTuition.getListTuitionById();
            if (list != null)
            {
                table.Columns.AddRange(new DataColumn[14] {
                    new DataColumn("Mã học phí"),
                    new DataColumn("Mã học sinh"),
                    new DataColumn("Họ học sinh"),
                    new DataColumn("Tên học sinh"),
                    new DataColumn("Lớp"),
                    new DataColumn("Năm học"),
                    new DataColumn("Hạn đóng"),
                    new DataColumn("Ngày đóng"),
                    new DataColumn("PTTT"),
                    new DataColumn("Học phí"),
                    new DataColumn("Phí bảo hiểm"),
                    new DataColumn("Phí cấp dưỡng"),
                    new DataColumn("Phí khác"),
                    new DataColumn("Trạng thái")
                });

                foreach (Tuition tuition in list)
                {
                    string status = "";
                    if (tuition.Status == 0)
                    {
                        status = "Chưa đóng";
                    }
                    else
                    {
                        status = "Đã đóng";
                    }
                    table.Rows.Add(
                        tuition.Id,
                        tuition.TStudent.Id,
                        tuition.TStudent.Info.FirstName,
                        tuition.TStudent.Info.LastName,
                        tuition.TStudent.Class.Name,
                        tuition.Year,
                        tuition.ExpriedDate,
                        tuition.TPayment.Date,
                        tuition.TPayment.Method,
                        tuition.TuitionFee,
                        tuition.Insurance,
                        tuition.Alimony,
                        tuition.OtherFee,
                        status
                    );
                }
                return table;
            }
            else
            {
                return null;
            }
        }

        public static DataTable getListTuitionByLastName(string lastname)
        {
            DataTable table = new DataTable();
            Tuition newTuition = new Tuition("", new Student("", lastname));
            List<Tuition> list = newTuition.getListTuitionByLastName();
            if (list != null)
            {
                table.Columns.AddRange(new DataColumn[14] {
                    new DataColumn("Mã học phí"),
                    new DataColumn("Mã học sinh"),
                    new DataColumn("Họ học sinh"),
                    new DataColumn("Tên học sinh"),
                    new DataColumn("Lớp"),
                    new DataColumn("Năm học"),
                    new DataColumn("Hạn đóng"),
                    new DataColumn("Ngày đóng"),
                    new DataColumn("PTTT"),
                    new DataColumn("Học phí"),
                    new DataColumn("Phí bảo hiểm"),
                    new DataColumn("Phí cấp dưỡng"),
                    new DataColumn("Phí khác"),
                    new DataColumn("Trạng thái")
                });

                foreach (Tuition tuition in list)
                {
                    string status = "";
                    if (tuition.Status == 0)
                    {
                        status = "Chưa đóng";
                    }
                    else
                    {
                        status = "Đã đóng";
                    }
                    table.Rows.Add(
                        tuition.Id,
                        tuition.TStudent.Id,
                        tuition.TStudent.Info.FirstName,
                        tuition.TStudent.Info.LastName,
                        tuition.TStudent.Class.Name,
                        tuition.Year,
                        tuition.ExpriedDate,
                        tuition.TPayment.Date,
                        tuition.TPayment.Method,
                        tuition.TuitionFee,
                        tuition.Insurance,
                        tuition.Alimony,
                        tuition.OtherFee,
                        status
                    );
                }
                return table;
            }
            else
            {
                return null;
            }
        }

        public static DataTable printStudentList(string Class, int year)
        {
            Tuition tui = new Tuition("", new Student("", new Class("", Class), null), year);
            return tui.getDataToPrint();
        }
}
}
