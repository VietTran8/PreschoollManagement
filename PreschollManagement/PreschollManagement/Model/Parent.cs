using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreschollManagement.Model
{
    class Parent
    {
        private string parentName;
        private string parentPhone;

        public Parent(string parentName, string parentPhone)
        {
            this.parentName = parentName;
            this.parentPhone = parentPhone;
        }

        public string Name
        {
            get { return this.parentName; }
            set { this.parentName = value; }
        }

        public string Phone
        {
            get { return this.parentPhone; }
            set { this.parentPhone = value; }
        }
    }
}
