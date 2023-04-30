using PreschollManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreschollManagement.Controller
{
    class AccountController
    {

        public static List<Account> getListAccount()
        {
            return Account.getListAccount();
        }
        public static string createAccount(string username, string password, int role)
        {
            Account myAcc = new Account(username, password, role);
            if (myAcc.usernameIsExists())
            {
                return "Tên tài khoản đã tồn tại!";
            }
            else
            {
                if (myAcc.createAccount())
                {
                    return "Tạo tài khoản thành công";
                }
                return "Tạo tài khoản thất bại, đã có lỗi xảy ra vui lòng thử lại sau";
            }
        }

        public static string updateRole(int role, string username)
        {
            Account myAcc = new Account(username, "", role);
            if (myAcc.updateRole())
            {
                return "Cập nhật vai trò thành công!";
            }
            return "Cập nhật vai trò không thành công";
        }

        public static string deleteAccount(string username)
        {
          
            Account myAcc = new Account(username, "", -1);
            if (myAcc.delettAccount())
            {
                return "Xóa tài khoản thành công!";
            }
            return "Đã có lỗi xảy ra, vui lòng thử lại sau!";
        }

        public static string resetPassword(string username, string newPassword)
        {
            Account myAcc = new Account(username, newPassword);
            if (myAcc.resetPassword())
            {
                return "Đổi mật khẩu thành công!";            
            }
            return "Có lỗi xảy ra, vui lòng thử lại!";
        }
    }
}
