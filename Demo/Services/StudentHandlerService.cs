using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class StudentHandlerService
    {
        public Student CreateNewStudent(int age, string name, string school, bool isActive)
        {
            Student newStudent = new Student();

            newStudent.Age = age;
            newStudent.Name = name;
            newStudent.School = school;
            newStudent.isActive = isActive;
            return newStudent;
        }

        public void UpdateStudent(Student student, int age, string name, string school, bool isActive)
        {
            student.Age = age;
            student.Name = name;
            student.School = school;
            student.isActive = isActive;
        }
    }
}
