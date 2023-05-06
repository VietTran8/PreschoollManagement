using PreschollManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreschollManagement.Controller
{
    public class ClassController
    {
        public static List<Class> getListClass()
        {
            return Class.getListClass();
        }

        public static string addClass(string className, string room, string classLevel, 
            string schoolYearFrom, string schoolYearTo)
        {
            string schoolYear = schoolYearFrom + " - " + schoolYearTo;
            Class myClass = new Class(className, room, classLevel, schoolYear);
            if (myClass.addClass())
            {
                return "Thêm lớp học thành công!";
            }
            return "Thêm lớp học không thành công, vui lòng kiểm tra lại thông tin!";
        }

        public static string updateClass(string classId, string className, string room, string classLevel,
            string schoolYearFrom, string schoolYearTo)
        {
            string schoolYear = schoolYearFrom + " - " + schoolYearTo;
            Class myClass = new Class(classId, className, room, classLevel, schoolYear);
            if (myClass.updateClass())
            {
                return "Cập nhật lớp học thành công!";
            }
            return "Cập nhật lớp học không thành công, vui lòng kiểm tra lại thông tin!";
        }

        public static string deleteClass(string classId)
        {
            Class myClass = new Class(classId);
            if (myClass.deleteClass())
            {
                return "Xóa lớp học thành công!";
            }
            return "Có lỗi xảy ra, vui lòng thử lại!";
        }
    }
}
