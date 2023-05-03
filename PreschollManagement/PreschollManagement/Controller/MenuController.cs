using PreschollManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreschollManagement.Controller
{
    class MenuController
    {
        public static string create(string startDate, string endDate)
        {
            
            MyMenu menu = new MyMenu(startDate, endDate);
            if (!menu.isExists())
            {
                if (menu.create())
                {
                    return "Tạo mới thực đơn thành công!";
                }
                return "Tạo mới thực đơn không thành công, vui lòng thử lại sau!";
            }
            return "Thực đơn này đã tồn tại!";
        }

        public static bool isExists(string startDate)
        {
            MyMenu menu = new MyMenu(startDate, "");
            if (!menu.isExists())
            {
                return false;
            }
            return true;
        }

        public static string getId(string startDate)
        {
            MyMenu menu = new MyMenu(startDate, "");
            return menu.getId();
        }
    }
}
