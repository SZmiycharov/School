using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class TestSchool
    {
        /*Училище "Свобода". Учители: Димитър Георгиев, Христина Николова.
Група "английски език": Иван Петров, Васил Тодоров, Елена Михайлова, Радослав Георгиев,МиленаСтефанова,учител ХристинаНиколова.
Група "френски език": Петър Петров, Васил Василев, учител Христина Николова.
Група "информатика": Милка Колева, Пенчо Тошев, Ива Борисова, Милена Иванова, Христо Тодоров, учител Димитър Георгиев.
          */
        public static void AddObjectsToSchool(School school)
        {
            Teacher teacherGeorgiev = new Teacher("Dimitur", "Georgiev");
            Teacher teacherNikolova = new Teacher("Hristina", "Nikolova");
            school.AddTeacher(teacherGeorgiev);
            school.AddTeacher(teacherNikolova);


            Group englishGroup = new Group("Angliiski ezik");
            englishGroup.AddStudent(new Student("Ivan", "Petrov"));
            englishGroup.AddStudent(new Student("Vasil","Todorov"));
            englishGroup.AddStudent(new Student("Elena","Mihailova"));
            englishGroup.AddStudent(new Student("Radoslav","Georgiev"));
            englishGroup.AddStudent(new Student("Milena","Stefanova"));
            school.AddGroup(englishGroup);
            teacherNikolova.AddGroup(englishGroup);

            Group frenchGroup = new Group("Frenski ezik");
            frenchGroup.AddStudent(new Student("Petur", "Petrov"));
            frenchGroup.AddStudent(new Student("Vasil", "Vasilev"));
            school.AddGroup(frenchGroup);
            teacherNikolova.AddGroup(frenchGroup);

            Group informaticsGroup = new Group("Informatika");
            informaticsGroup.AddStudent(new Student("Milka", "Koleva"));
            informaticsGroup.AddStudent(new Student("Pencho", "Toshev"));
            informaticsGroup.AddStudent(new Student("Iva", "Borisova"));
            informaticsGroup.AddStudent(new Student("Milena", "Ivanova"));
            informaticsGroup.AddStudent(new Student("Hristo", "Todorov"));
            school.AddGroup(informaticsGroup);
            teacherGeorgiev.AddGroup(informaticsGroup);
        }

        public static void Main()
        {
            School school = new School("Svoboda");
            AddObjectsToSchool(school);
            
            foreach (Teacher teacher in school.Teachers)
            {
                teacher.PrintGroups(Console.Out);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
