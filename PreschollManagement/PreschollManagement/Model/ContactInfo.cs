using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreschollManagement.Model
{
    class ContactInfo
    {
        private string address;
        private string homeTown;

        public ContactInfo(string address, string homeTown)
        {
            this.address = address;
            this.homeTown = homeTown;
        }

        public string Address
        {
            get { return this.address;  }
            set { this.address = value; }
        }

        public string Hometown
        {
            get { return this.homeTown; }
            set { this.homeTown = value; }
        }
    }
}
