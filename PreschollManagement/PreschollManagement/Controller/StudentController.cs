using PreschollManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreschollManagement.Controller
{
    class StudentController
    {
        public static DataTable getListStudent()
        {
            DataTable table = new DataTable();
            List<Student> list = Student.getListStudent();
            if (list != null)
            {
                table.Columns.AddRange(new DataColumn[13] {
                    new DataColumn("Mã học sinh"),
                    new DataColumn("Mã lớp"),
                    new DataColumn("Tên lớp"),
                    new DataColumn("Họ học sinh"),
                    new DataColumn("Tên học sinh"),
                    new DataColumn("Giới tính"),
                    new DataColumn("Ngày sinh"),
                    new DataColumn("Dân tộc"),
                    new DataColumn("Tôn giáo"),
                    new DataColumn("Địa chỉ"),
                    new DataColumn("Quê quán"),
                    new DataColumn("Tên phụ huynh"),
                    new DataColumn("Số điện thoại"),
                });

                foreach (Student student in list)
                {
                    string id = student.Id,
                           classId = student.Class.Id,
                           className = student.Class.Name,
                           firstName = student.Info.FirstName,
                           lastName = student.Info.LastName,
                           gender = student.Info.Gender,
                           birthDay = student.Info.BirthDay,
                           ethincity = student.Info.Ethnicity,
                           religion = student.Info.Religion,
                           address = student.Contact.Address,
                           hometown = student.Contact.Hometown,
                           parentName = student.MyParent.Name,
                           parentPhone = student.MyParent.Phone;

                    table.Rows.Add(
                        id,
                        classId,
                        className,
                        firstName,
                        lastName,
                        gender,
                        birthDay,
                        ethincity,
                        religion,
                        address,
                        hometown,
                        parentName,
                        parentPhone
                    );
                }
                return table;
            }
            else
            {
                return null;
            }
        }

        public static DataTable getListStudentBy(string sid, string lastname, int choose)
        {
            DataTable table = new DataTable();
            Student myStudent = new Student(sid, lastname);
            List<Student> list;
            if (choose == 0)
            {
                list = myStudent.getListStudentById();
            }
            else
            {
                list = myStudent.getListStudentByLastName();
            }
            if (list != null)
            {
                table.Columns.AddRange(new DataColumn[13] {
                    new DataColumn("Mã học sinh"),
                    new DataColumn("Mã lớp"),
                    new DataColumn("Tên lớp"),
                    new DataColumn("Họ học sinh"),
                    new DataColumn("Tên học sinh"),
                    new DataColumn("Giới tính"),
                    new DataColumn("Ngày sinh"),
                    new DataColumn("Dân tộc"),
                    new DataColumn("Tôn giáo"),
                    new DataColumn("Địa chỉ"),
                    new DataColumn("Quê quán"),
                    new DataColumn("Tên phụ huynh"),
                    new DataColumn("Số điện thoại"),
                });

                foreach (Student student in list)
                {
                    string id = student.Id,
                           classId = student.Class.Id,
                           className = student.Class.Name,
                           firstName = student.Info.FirstName,
                           lastName = student.Info.LastName,
                           gender = student.Info.Gender,
                           birthDay = student.Info.BirthDay,
                           ethincity = student.Info.Ethnicity,
                           religion = student.Info.Religion,
                           address = student.Contact.Address,
                           hometown = student.Contact.Hometown,
                           parentName = student.MyParent.Name,
                           parentPhone = student.MyParent.Phone;

                    table.Rows.Add(
                        id,
                        classId,
                        className,
                        firstName,
                        lastName,
                        gender,
                        birthDay,
                        ethincity,
                        religion,
                        address,
                        hometown,
                        parentName,
                        parentPhone
                    );
                }
                return table;
            }
            else
            {
                return null;
            }
        }

        public static List<String> getListClass()
        {
            List<String> response = new List<String>();
            List<Class> list = Class.getListClass();
            if (list != null)
            {
                foreach (Class each in list)
                {
                    response.Add(each.Name + " - " + each.Id);
                }
                return response;
            }
            return null;
        }

        public static string addStudent(
                        string classId, string firstName, string lastName,
                        int gender, string birthDay,
                        string ethincity, string religion, string address,
                        string hometown, string parentName, string parentPhone)
        {
            Class newClass = new Class(classId);
            PersionalInfo newInfo = new PersionalInfo(firstName, lastName, gender, birthDay,
                                                       ethincity, religion);
            ContactInfo newContact = new ContactInfo(address, hometown);
            Parent newParent = new Parent(parentName, parentPhone);

            Student newStudent = new Student(newClass, newInfo, newContact, newParent);
            if (newStudent.addStudent())
            {
                return "Thêm hồ sơ thành công";
            }
            return "Thêm hồ sơ thất bại, vui lòng kiểm tra lại thông tin!";
        }

        public static string updateStudent(
                        string studentId, string classId, string firstName, 
                        string lastName, int gender, string birthDay,
                        string ethincity, string religion, string address,
                        string hometown, string parentName, string parentPhone)
        {
            Class newClass = new Class(classId);
            PersionalInfo newInfo = new PersionalInfo(firstName, lastName, gender, birthDay,
                                                       ethincity, religion);
            ContactInfo newContact = new ContactInfo(address, hometown);
            Parent newParent = new Parent(parentName, parentPhone);

            Student newStudent = new Student(studentId, newClass, newInfo, newContact, newParent);

            if (newStudent.updateStudent())
            {
                return "Cập nhật hồ sơ thành công";
            }
            return "Cập nhật hồ sơ thất bại, vui lòng kiếm tra lại thông tin";
        }


        public static string deleteStudent(string studentId)
        {
            Student myStudent = new Student(studentId);
            if (myStudent.deleteStudent())
            {
                return "Xóa học sinh thành công!";
            }
            return "Có lỗi xảy ra";
        }

        public static DataTable printStudentList()
        {
            return Student.getDataToPrint();
        }
    }
}
