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

        public Food( string foodName, int day, string session, string note, MyMenu menu)
        {
            this.foodName = foodName;
            this.day = day;
            this.session = session;
            this.note = note;
            this.menu = menu;
        }

        public Food(string foodId)
        {
            this.foodId = foodId;
        }

        public string Id
        {
            get { return this.foodId; }
            set { this.foodId = value; }
        }

        public string Name
        {
            get { return this.foodName; }
            set { this.foodName = value; }
        }

        public int Day
        {
            get { return this.day; }
            set { this.day = value; }
        }

        public string Session
        {
            get { return this.session; }
            set { this.session = value; }
        }

        public string Note
        {
            get { return this.note; }
            set { this.note = value; }
        }

        public MyMenu TMenu
        {
            get { return this.menu; }
            set { this.menu = value; }
        }

        public bool addFood()
        {
            string query = "insert into monan (tenmon, thu, buoi, ghichu, mathucdon) values ( " +
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

        public bool updateFood()
        {
            string query = "update monan set tenmon = @tenmon , thu = @thu , buoi = @buoi , ghichu = @ghichu where mamon = @mamon";

            using (SqlConnection con = DB.Instance.getConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@tenmon", this.foodName);
                cmd.Parameters.AddWithValue("@thu", this.day);
                cmd.Parameters.AddWithValue("@buoi", this.session);
                cmd.Parameters.AddWithValue("@ghichu", this.note);
                cmd.Parameters.AddWithValue("@mamon", this.Id);

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
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }

        public bool deleteFood()
        {
            string query = "delete monan where mamon = @mamon";

            using (SqlConnection con = DB.Instance.getConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@mamon", this.Id);

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
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }
    }
}
