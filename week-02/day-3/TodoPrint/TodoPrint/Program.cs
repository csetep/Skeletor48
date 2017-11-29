using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoPrint
{
    public class TodoPrint
    {
        public static void Main(string[] args)
        {
            string todoText = " - Buy milk";

            var todoList = new List<string>();
            todoList.Add("My todo:");
            todoList.Add(todoText);
            todoList.Add(" - Download games");
            todoList.Add("\t - Diablo");

            foreach (string listElement in todoList)
            {
                Console.WriteLine(listElement);
            }

            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indention

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            Console.ReadKey();
        }
    }
}
