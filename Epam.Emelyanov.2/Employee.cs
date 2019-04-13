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

        public string _Experience
        {
            get
            {
                return experience;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || !int.TryParse(value, out int e) || e < 0)
                {
                    throw new ArgumentException("Invalid experience!");
                }
                experience = value;
            }
        }
        public string _Position
        {
            get
            {
                return position;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
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

        public Employee(string firstName, string lastName, string patronymic, DateTime dateOfBirth, string age, string experience, string position) : base(firstName, lastName, patronymic, dateOfBirth, age)
        {
            _Experience = experience;
            _Position = position;
        }
        public override string ToString()
        {
            return ($"ФИО: {_FirstName} {_LastName} {_Patronymic}, Дата рождения: {_DateOfBrith.ToLongDateString()}, Возраст: {_Age}, Стаж: {_Experience}, Должность: {_Position}");
        }
    }
}
