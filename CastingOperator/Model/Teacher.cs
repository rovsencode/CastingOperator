using System;
using System.Collections.Generic;
using System.Text;

namespace CastingOperator.Model
{
    class Teacher : Person
    {
        private float _salary;

        public float Salary { get { return _salary; }
            set {
                if (value > 0)
                {
                    _salary = value;
                }
            }
        }
        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
        public Teacher(string Name, string Surname, int Age) : base(Name, Surname, Age)
        {

        }
        public static bool operator <(Teacher t1, Teacher t2)
            {

            return t1.Salary<t2.Salary;

            }
        public static bool operator >(Teacher t1, Teacher t2)
        {
            return t1.Salary > t2.Salary;
        }


    }
}
