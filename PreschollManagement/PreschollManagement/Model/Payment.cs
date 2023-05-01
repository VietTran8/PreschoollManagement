using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreschollManagement.Model
{
    internal class Payment
    {
        private string paymentMethod;
        private string paymentDate;

        public Payment(string paymentMethod, string paymentDate)
        {
            this.paymentMethod = paymentMethod;
            this.paymentDate = paymentDate;
        }

        public string Method
        {  
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }

        public string Date
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }
    }
}
