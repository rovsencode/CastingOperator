using System;
using System.Collections.Generic;
using System.Text;

namespace CastingOperator.Model
{
    class GroupMate
    {
        private string _name;
        private Student[] _students;
        public string Name { get { return _name; } 
            set
            {
                if (value.Length>0)
                {
                    _name = value;
                }
            } 
        }
        public GroupMate ()
        {
            _students = new Student[0];
        }
    
        public Student this[int index]
        {
            get
            {
                if (index<_students.Length)
                {
                    return _students[index];
                }
                throw new Exception();
            }
            set
            {
                if (index<_students.Length)
                {
                    _students[index] = value;
                }
                throw new Exception();
            }
           
        }
     
        public void AddStudent(Student s)
        {

            int count = 0;
            if (count<_students.Length)
            {
                _students[count] = s;
                count++;
            }
        
          
            
         

        }
        public GroupMate(string Name, int length)
        {          
            this.Name = Name;
            _students = new Student[length];
        }
        // - Sort() - Studentləri topladıqları bala uyğun çoxdan aza doğru sıralayır. (Operator overloading vasitəsi ilə)
    }
}
