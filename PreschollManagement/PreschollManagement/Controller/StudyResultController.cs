using PreschollManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreschollManagement.Controller
{
    class StudyResultController
    {
        public static string addNewList(int month, string ClassInfo)
        {
            string[] splited = ClassInfo.Split('-');
            string classId = splited[0].Trim();
            string schoolYear = splited[2] + "-" + splited[3];

            if (StudyResults.addListStudyResult(month, classId, schoolYear)) {
                return "Thêm danh sách kết quả rèn luyện thành công!";
            }
            return "Có lỗi xảy ra, vui lòng thử lại sau!";
        }

        public static List<string> getClasses()
        {
            List<Class> list = Class.getListClass();
            List<string> listInfo = new List<string>();

            foreach (Class each in list) 
            {
                string classInfo = each.Id + " - " + each.Name + " - " + each.SchoolYear;
                listInfo.Add(classInfo);
            }
            return listInfo;
        }

        public static bool resultsIsExists(string classInfo, int month)
        {
            string[] splited = classInfo.Split('-');
            string classId = splited[0].Trim();
            string schoolYear = splited[2] + "-" + splited[3];
            Class cls = new Class(classId);
            cls.SchoolYear = schoolYear;
            Student stu = new Student("", cls, null);
            List<Student> list = stu.getListStudentByClass();
            if (list != null && list.Count > 0)
            {
                string studentId = list[0].Id;

                StudyResults result = new StudyResults(new Student(studentId), month);
                if (result.isExists())
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public static string updateListStudyResult(int month, string ClassInfo)
        {
            if (resultsIsExists(ClassInfo, month))
            {
                string[] splited = ClassInfo.Split('-');
                string classId = splited[0].Trim();
                string schoolYear = splited[2] + "-" + splited[3];

                StudyResults.updateListStudyResult(month, classId, schoolYear);
                return "Làm mới danh sách kết quả rèn luyện thành công!";
            }
            else {
                return "Chưa có danh sách kết quả này!";
            }
        }

        public static DataTable viewListStudyResult(int month, string classInfo)
        {
            string[] splited = classInfo.Split('-');
            string classId = splited[0].Trim();
            string schoolYear = (splited[2] + "-" + splited[3]);

            DataTable table = StudyResults.viewStudyResult(month, classId, schoolYear.Trim());
            return table;
        }

        public static string updateStudyResult(
                string resultId,
                string physical,
                string awareness,
                string socialAffection,
                string language,
                string aesthetic
            )
        {
            StudyResults newResult = new StudyResults(
                     resultId,
                     convertResultToInt(physical),
                     convertResultToInt(awareness),
                     convertResultToInt(socialAffection),
                     convertResultToInt(language),
                     convertResultToInt(aesthetic)
                );

            if (newResult.updateStudyResult())
            {
                return "Cập nhật kết quả học tập thành công!";
            }
            return "Có lỗi xảy ra vui lòng thử lại";

        }

        private static int convertResultToInt(string result)

        {
            if (result == "Chưa xét")
                return 0;
            else if (result == "Chưa đạt")
            {
                return 1;
            }
            else
                return 2;
        }

        public static DataTable getListResultToPrint(int month, string classInfo)
        {
            if (resultsIsExists(classInfo, month))
            {
                string[] splited = classInfo.Split('-');
                string classId = splited[0].Trim();
                string schoolYear = (splited[2] + "-" + splited[3]);

                DataTable table = StudyResults.getListResultToPrint(month, classId, schoolYear.Trim());
                return table;
            }
            return null;
        }

        public static DataTable viewListStudyResultByStudentId(int month, string classInfo, string search)
        {
            string[] splited = classInfo.Split('-');
            string classId = splited[0].Trim();
            string schoolYear = (splited[2] + "-" + splited[3]);

            DataTable table = StudyResults.viewStudyResultByStudentId(month, classId, schoolYear.Trim(), search);
            return table;
        }


        public static DataTable viewListStudyResultByStudentName(int month, string classInfo, string search)
        {
            string[] splited = classInfo.Split('-');
            string classId = splited[0].Trim();
            string schoolYear = (splited[2] + "-" + splited[3]);

            DataTable table = StudyResults.viewStudyResultByStudentName(month, classId, schoolYear.Trim(), search);
            return table;
        }
    }
}
