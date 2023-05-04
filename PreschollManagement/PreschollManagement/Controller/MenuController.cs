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
        public static object MyFood { get; private set; }

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

        public static List<Food> GetFoods(string menuId)
        {
            MyMenu menu = new MyMenu(menuId);

            return menu.getListFood();
        }

        public static string addFood(string foodName, int day, string session, string note, string menuId)
        {
            Food newFood = new Food(foodName, day, sessionStringToNumber(session), note, new MyMenu(menuId));
            if (MyMenu.addFood(newFood))
                return "Thêm món ăn thành công";
            return "Thêm món ăn thất bại, vui lòng thử lại sau";
        }

        private static string sessionStringToNumber(string session)
        {
            if (session == "Trưa")
                return "0";
            else if (session == "Xế")
                return "1";
            return "2";
        }

        public static string updateFood(string foodName, int day, string session, string note, string foodId)
        {
            Food food = new Food(foodId, foodName, day, sessionStringToNumber(session), note, null);
            if (MyMenu.updateFood(food))
            {
                return "Cập nhật món ăn thành công!";
            }
            return "Có lỗi xảy ra, vui lòng thử lại sau!";
        }

        public static string deleteFood(string foodId)
        {
            Food food = new Food(foodId);
            if (MyMenu.deleteFood(food))
            {
                return "Xóa món ăn thành công!";
            }
            return "Có lỗi xảy ra, vui lòng thử lại sau!";
        }
    }
}
