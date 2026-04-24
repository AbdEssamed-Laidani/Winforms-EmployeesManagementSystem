using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElmplotyeesManagment
{
    internal class clsEmployee
    {

        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Phone {  get; set; }
        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
        
    }
}
