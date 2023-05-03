using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreschollManagement.Model
{
    class Food
    {
        private string foodId;
        private string foodName;
        private int day;
        private string session;
        private string note;
        private MyMenu menu;


        public Food(string foodId, string foodName, int day, string session, string note, MyMenu menu) 
        {
            this.foodId = foodId;
            this.foodName = foodName;
            this.day = day;
            this.session = session;
            this.note = note;
            this.menu = menu;
        }

        public bool addFood()
        {
            string query = "insert into food (tenmon, thu, buoi, ghichu, mathucdon) values ( " +
                "@tenmon , @thu , @buoi , @ghichu , @mathucdon" +
                ")";

            using (SqlConnection con = DB.Instance.getConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@tenmon", this.foodName);
                cmd.Parameters.AddWithValue("@thu", this.day);
                cmd.Parameters.AddWithValue("@buoi", this.session);
                cmd.Parameters.AddWithValue("@ghichu", this.note);
                cmd.Parameters.AddWithValue("@mathucdon", this.menu.Id);

                try
                {

                    int numRowAffected = cmd.ExecuteNonQuery();

                    if (numRowAffected > 0)
                    {
                        return true;
                    }
                    return false;
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }
    }
}
