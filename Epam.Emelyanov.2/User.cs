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

        public string _FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
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
        public string _LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
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
        public string _Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
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
        public DateTime _DateOfBrith
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
        public string _Age
        {
            get
            {
                return age;
            }
            set
            {                
                if(string.IsNullOrEmpty(value) || !int.TryParse(value,out int a) || a < 0)
                {
                    throw new ArgumentException("Invalid age!");
                }
                age = value;
            }
        }

        public User(string firstName, string lastName, string patronymic, DateTime dateOfBirth, string age)
        {
            _FirstName = firstName;
            _LastName = lastName;
            _Patronymic = patronymic;
            _DateOfBrith = dateOfBirth;
            _Age = age;
        }
        public override string ToString()
        {
            return ($"Имя: {_FirstName}, Фамилия: {_LastName}, Отчество: {_Patronymic}, Дата рождения: {_DateOfBrith.ToLongDateString()}, Возраст: {_Age}");
        }
    }
}
