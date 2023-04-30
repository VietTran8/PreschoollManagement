using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreschollManagement
{
    class FormatDtp
    {
        public static void FormatDateTimePicker(DateTimePicker picker, string format)
        {
            picker.Format = DateTimePickerFormat.Custom;
            picker.CustomFormat = format;
        }
    }
}
