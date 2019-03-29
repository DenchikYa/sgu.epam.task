using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Emelyanov._2
{
    class User
    {
        private string firstName;
        private string lastName;
        private string patronymic;
        private DateTime dateOfBrith;
        private string age;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if(value != "")
                {
                    foreach (char c in value)
                    {
                        if (!Char.IsLetter(c))
                        {
                            throw new ArgumentException("Invalid name!");
                        }
                    }
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("Invalid name!");
                }           
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if(value != "")
                {
                    foreach (char c in value)
                    {
                        if (!Char.IsLetter(c))
                        {
                            throw new ArgumentException("Invalid last name!");
                        }
                    }
                    lastName = value;
                }
                else
                {
                    throw new ArgumentException("Invalid last name!");
                }           
            }
        }
        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                if(value != "")
                {
                    foreach (char c in value)
                    {
                        if (!Char.IsLetter(c))
                        {
                            throw new ArgumentException("Invalid patronymic!");
                        }
                    }
                    patronymic = value;
                }
                else
                {
                    throw new ArgumentException("Invalid patronymic!");
                }                
            }
        }
        public DateTime DateOfBitrh
        {
            get
            {
                return dateOfBrith;
            }
            set
            {
                dateOfBrith = value;
            }
        }
        public string Age
        {
            get
            {
                return age;
            }
            set
            {                
                if(value == "" || !int.TryParse(value,out int a) || a < 0)
                {
                    throw new ArgumentException("Invalid age!");
                }
                age = value;
            }
        }

        public User(string _firstName, string _lastName, string _patronymic, DateTime _dateOfBirth, string _age)
        {
            FirstName = _firstName;
            LastName = _lastName;
            Patronymic = _patronymic;
            dateOfBrith = _dateOfBirth;
            Age = _age;
        }

    }
}
