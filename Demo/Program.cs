using Demo.Models;
using Demo.Services;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuRenderingService menuService = new MenuRenderingService();
            InputHandlerService inputService = new InputHandlerService();
            StudentHandlerService studentService = new StudentHandlerService();

            List<Student> students = new List<Student>();

            bool isRunning = true;
            while (isRunning)
            {
                menuService.RenderMenu();
               
                int userMenuSelection = inputService.GetUserInputInt();

                if (userMenuSelection == 1)
                {
                    menuService.RenderStudentCreationScreen();

                    Console.WriteLine("Ange elevens namn:");
                    string name = inputService.GetUserInputString();
                    Console.WriteLine("Ange elevens ålder:");
                    int age = inputService.GetUserInputInt();
                    Console.WriteLine("Ange elevens skola:");
                    string school = inputService.GetUserInputString();
                    Console.WriteLine("Är eleven aktiv? (ja/nej):");
                    bool isActive = inputService.GetUserInputBool();

                    Student newStudent = studentService.CreateNewStudent(age, name, school, isActive);

                    students.Add(newStudent);
                }
                else if (userMenuSelection == 2)
                {
                    menuService.RenderStudentUpdateScreen(students);

                    int studentIndex = inputService.GetUserInputInt() - 1;

                    Console.WriteLine("Ange elevens nya namn:");
                    string name = inputService.GetUserInputString();
                    Console.WriteLine("Ange elevens nya ålder:");
                    int age = inputService.GetUserInputInt();
                    Console.WriteLine("Ange elevens nya skola:");
                    string school = inputService.GetUserInputString();
                    Console.WriteLine("Är eleven aktiv? (ja/nej):");
                    bool isActive = inputService.GetUserInputBool();

                    Student studentSelectedForUpdate = students[studentIndex];

                    studentService.UpdateStudent(studentSelectedForUpdate, age, name, school, isActive);

                    Console.Clear();
                    Console.WriteLine($"{studentSelectedForUpdate.Name} har uppdaterats i elevlistan!");
                    Console.WriteLine("Tryck på valfri knapp för att återgå till menyn");
                    Console.ReadKey();
                }
                else if (userMenuSelection == 3)
                {
                    menuService.RenderAllStudents(students);
                }
                else if (userMenuSelection == 4)
                {
                    isRunning = false;
                    menuService.RenderExitMessage();
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
