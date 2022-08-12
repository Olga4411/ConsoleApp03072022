using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp03072022.Models
{
    class CustomerModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CustomerModel(int _id, string _fn, string _ln, DateTime _bd)
        {
            ID = _id;
            FirstName = _fn;
            LastName = _ln;
            DateOfBirth = _bd;
        }
        public override string ToString()
        {
            return $"{ID} {FirstName} {LastName} {DateOfBirth.ToShortDateString()}";
        }
    }
}
