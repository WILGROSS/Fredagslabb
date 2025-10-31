using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class InputHandlerService
    {
        public string GetUserInputString()
        {
            return Console.ReadLine();
        }

        public int GetUserInputInt()
        {
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Ogiltig inmatning. Vänligen ange ett giltigt heltal:");
            }
            return userInput;
        }

        public bool GetUserInputBool()
        {
            string userInput = Console.ReadLine().ToLower();
            while (userInput != "ja" && userInput != "nej")
            {
                Console.WriteLine("Ogiltig inmatning. Vänligen ange 'ja' eller 'nej':");
                userInput = Console.ReadLine().ToLower();
            }

            bool isTrue = false;
            if (userInput == "ja")
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }
    }
}
