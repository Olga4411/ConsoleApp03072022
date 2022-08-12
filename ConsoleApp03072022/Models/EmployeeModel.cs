using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp03072022.Models
{
    class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int PositionID { get; set; }
        public int Salary { get; set; }

        public EmployeeModel(int _id_1, string _fn_1, string _ln_1, string dateofbirth, int _pos, int _sal )
        {
            EmployeeID = _id_1;
            FirstName = _fn_1;
            LastName = _ln_1;
            BirthDate = DateTime.Parse(dateofbirth.ToString());
            PositionID = _pos;
            Salary = _sal;
        }
        public override string ToString()
        {
            return $"{EmployeeID} {FirstName} {LastName} {BirthDate.ToShortDateString()} {PositionID} {Salary}";
        }
        
    }
}
