using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreschollManagement.Model
{
    class MyMenu
    {
        private string menuId;
        private string startDate;
        private string endDate;

        public MyMenu(string menuId, string startDate, string endDate)
        {
            this.menuId = menuId;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public MyMenu(string startDate, string endDate)
        {
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public MyMenu(string Id)
        {
            this.menuId = Id;
        }

        public string Id
        {
            get { return this.menuId; }
            set { this.menuId = value; }
        }

        public string StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }
        public string EndDate
        {
            get { return this.endDate; }
            set { this.endDate = value; }
        }

        public bool create()
        {
            string query = "SET DATEFORMAT dmy; ";

            query += "insert into thucdon (ngaybatdau, ngayketthuc) values ( @ngaybatdau , @ngayketthuc )";

            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ngaybatdau", this.startDate);
                cmd.Parameters.AddWithValue("@ngayketthuc", this.endDate);

                int numRowAffected = cmd.ExecuteNonQuery();

                if (numRowAffected > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool isExists()
        {
            string query = "select * from thucdon where ngaybatdau = @ngaybatdau";

            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                string[] splited = this.startDate.Split('-');

                string newStartDay = splited[2] + "-" + splited[1] + "-" + splited[0];

                cmd.Parameters.AddWithValue("@ngaybatdau", newStartDay);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                return false;
            }
        }

        public string getId()
        {
            string query = "select mathucdon from thucdon where ngaybatdau = @ngaybatdau";

            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                string[] splited = this.startDate.Split('-');

                string newStartDay = splited[2] + "-" + splited[1] + "-" + splited[0];

                cmd.Parameters.AddWithValue("@ngaybatdau", newStartDay);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    return reader["mathucdon"].ToString();
                }
                return "";
            }
        }

        public List<Food> getListFood()
        {
            string id = this.Id;

            string query = "select * from monan where mathucdon = " + id + "";

            List<Food> list = new List<Food>();

            using (SqlConnection conn = DB.Instance.getConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Food myFood = new Food(
                                reader["mamon"].ToString(),
                                reader["tenmon"].ToString(),
                                int.Parse(reader["thu"].ToString()),
                                numSessionToString(reader["buoi"].ToString()),
                                reader["ghichu"].ToString(),
                                null
                            );
                        list.Add(myFood);
                    }
                    return list;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }
        }

        public static bool addFood(Food food)
        {
            return food.addFood();
        }

        public static string numSessionToString(string session)
        {
            if (session == "0")
                return "Trưa";
            else if (session == "1")
                return "Xế";
            return "Chiều";
        }

        public static bool updateFood(Food food)
        {
            return food.updateFood();
        }

        public static bool deleteFood(Food food)
        {
            return food.deleteFood();
        }
    }
}
