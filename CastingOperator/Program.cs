using CastingOperator.Model;
using System;

namespace CastingOperator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bizə Persona upcasting olunmuş bir neçə data (Teacher, Student) gələcək.
            //Onlardan Studentləri seçib, GroupMate classındakı Student arrayına Indexer vasitəsi ilə əlavə edirik.
            GroupMate p326 = new GroupMate("p326",2);
            
            Student rovsen = new Student("Rovsen","Marley",19,6);
            Student tural = new Student("tural", "eliyev", 20, 8);
       
            p326.AddStudent(rovsen);
          p326.AddStudent(tural);
              p326[0].ShowInfo();
            p326[1].ShowInfo();
          //  rovsen.ShowInfo();
          
                }
    }
}
