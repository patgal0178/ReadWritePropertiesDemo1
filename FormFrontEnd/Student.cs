using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FormFrontEnd
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private double age;
        private DateTime dOb;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (value.Length >= 2)
                {
                    firstName = value;
                }
                else
                {
                    throw new DataException("length must be longer than 2 character");
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
                if (value.Length >= 2)
                {
                    lastName = value;
                }
                else
                {
                    throw new DataException("length must be longer than 2 character");
                }
            }
}

        public double Age
        {
            get
            {
                return age;
            }

            set
            {
                if(value>=16 && value <= 90)
                {
                    age = value;
                }
                else
                {
                    throw new DataException("age must be between 16 and 90");
                }
            }
        }

        public DateTime DOB
        {
            get
            {
                return dOb;
            }

            set
            {
                if(value< DateTime.Now)
                {
                    dOb = value;
                }
                else
                {
                    throw new DataException("DOB must be before todays date");
                }
            }
        }
    }
}
