using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class TodoListUtils
    {
        // Class variable
        private List<string> todos = new List<string>();

        public int askMenu()
        {
            Console.WriteLine("1. Visualizza tutti i todo: ");
            Console.WriteLine("2. Aggiungi un todo");
            Console.WriteLine("3. Rimuovi un todo");
            Console.WriteLine("4. Esci");
            string choiseStr = Console.ReadLine();
            int choise;


            try
            {
                choise = Convert.ToInt32(choiseStr);
                return choise;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
