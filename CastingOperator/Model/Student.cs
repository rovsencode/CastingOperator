using System;
using System.Collections.Generic;
using System.Text;

namespace CastingOperator.Model
{
    class Student : Person
    {
        private float _point;
    
        public float Point { get { return _point; }
            set {
                if (value >= 0)
                {
                    _point = value;
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Name: " + Name + "\nSurname: " + Surname + "\nAge:"+Age+"\nPoint: " + Point);
        }
        public Student(string Name, string Surname, int Age, int Point) : base(Name, Surname, Age)
        {

            this.Point = Point;
        }
        public static bool operator>(Student s1,Student s2)
        {
        return s1.Point>s2.Point;
        }
        public static bool operator<(Student s1,Student s2)
        {
            return s1.Point<s2.Point;
        }

       


      
    }
}
