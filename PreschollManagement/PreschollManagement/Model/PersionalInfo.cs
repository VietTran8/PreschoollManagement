using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreschollManagement.Model
{
    class PersionalInfo
    {
        private string firstName;
        private string lastName;
        private int gender;
        private string birthDay;
        private string ethnicity;
        private string religion;

        public PersionalInfo(string firstName, string lastName,
            int gender, string birthDay, string ethnicity, string religion)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.birthDay = birthDay;
            this.ethnicity = ethnicity;
            this.religion = religion;
        }

        public PersionalInfo(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


        public PersionalInfo(string lastName)
        {
            this.lastName = lastName;
        }

        public string FirstName 
        {
            get { return firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }

        public string Gender
        {
            get {
                if (gender == 0)
                    return "Nam";
                else
                    return "Nữ";
            }
        }

        public string BirthDay
        {
            get { return birthDay; }
            set { this.birthDay = value; }
        }

        public string Ethnicity
        {
            get { return ethnicity; }
            set { this.ethnicity = value; }
        }
        public string Religion
        {
            get { return religion; }
            set { this.religion = value; }
        }
    }
}
