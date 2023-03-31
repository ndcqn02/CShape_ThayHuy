using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Student
    {
        private int id, age;
        private string name;
        private int classRoomID;

        public Student()
        {

        }

        public Student(int id, int age, string name, int classRoomID)
        {
            this.Id = id;
            this.Age = age;
            this.Name = name;
            this.ClassRoomID = classRoomID;
        }

        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public int ClassRoomID { get => classRoomID; set => classRoomID = value; }
    }

    class ClassRoom
    {
        private string idClass, nameClass;

        public ClassRoom() { }

        public ClassRoom(string idClass, string nameClass)
        {
            this.idClass = idClass;
            this.nameClass = nameClass;
        }

        public string IdClass { get => idClass; set => idClass = value; }
        public string NameClass { get => nameClass; set => nameClass = value; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<ClassRoom> classRooms = new List<ClassRoom>();
            classRooms =  new ClassRoom("1", "20T1");


            List<Student> students = new List<Student>
            {
                new Student{Id = 1, Name = "Jogn", Age = 18, ClassRoomID = 1},
                new Student{Id = 2, Name = "John", Age = 26},
                new Student{Id = 3, Name = "Marry", Age = 5},
                new Student{Id = 4, Name = "Ron", Age = 20},
                new Student{Id = 5, Name = "Ram", Age = 18},
                new Student{Id = 6, Name = "Jogn", Age = 11},

            };

            var filteredResult = from item in students
                                 where item.Age > 10 && item.Age < 25
                                 select item.Name;
            foreach(var i in filteredResult)
            {
                Console.WriteLine(i);  
            }

            Console.ReadKey();
        }
    }

    
}
