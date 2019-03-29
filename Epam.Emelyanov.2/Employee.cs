using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Emelyanov._2
{
    class Employee : User
    {
        private string experience;
        private string position;

        public string Experience
        {
            get
            {
                return experience;
            }
            set
            {
                if (value == "" || !int.TryParse(value, out int e) || e < 0)
                {
                    throw new ArgumentException("Invalid experience!");
                }
                experience = value;
            }
        }
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                if (value != "")
                {
                    foreach (char c in value)
                    {
                        if (!Char.IsLetter(c))
                        {
                            throw new ArgumentException("Invalid position!");
                        }
                    }
                    position = value;
                }
                else
                {
                    throw new ArgumentException("Invalid position!");
                }
            }
        }

        public Employee(string _firstName, string _lastName, string _patronymic, DateTime _dateOfBirth, string _age, string _experience, string _position) : base(_firstName, _lastName, _patronymic, _dateOfBirth, _age)
        {
            Experience = _experience;
            Position = _position;
        }
    }
}
