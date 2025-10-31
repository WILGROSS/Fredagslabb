using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class MenuRenderingService
    {
        public void RenderMenu()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till elevhanteringssystemet!\n-----------------------------------------");
            Console.WriteLine("1: Registrera en ny elev");
            Console.WriteLine("2: Uppdatera en elevs info");
            Console.WriteLine("3: Visa alla elever");
            Console.WriteLine("4: Stäng ner programmet");
        }

        public void RenderStudentCreationScreen()
        {
            Console.Clear();
            Console.WriteLine("Registrera en ny elev\n----------------------");
        }

        public void RenderExitMessage()
        {
            Console.Clear();
            Console.WriteLine("Tack för att du använde elevhanteringssystemet. Hej då!");
        }

        public void RenderAllStudents(List<Student> students)
        {
            Console.Clear();
            Console.WriteLine("Alla registrerade elever\n------------------------");

            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine($"Ålder: {student.Age}");
                Console.WriteLine($"Skola: {student.School}");

                if (student.isActive)
                {
                    Console.WriteLine("Status: Aktiv");
                }
                else
                {
                    Console.WriteLine("Status: Inaktiv");
                }
                Console.WriteLine("___________________" );
            }
            Console.WriteLine("Tryck på valfri knapp för att återgå till menyn...");
            Console.ReadKey();
        }

        public void RenderStudentUpdateScreen(List<Student> students)
        {
            Console.Clear();
            Console.WriteLine("Uppdatera en elevs information\n------------------------------");

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {students[i].Name}");
            }
            Console.WriteLine("Välj numret på den elev du vill uppdatera:");
        }
    }
}
