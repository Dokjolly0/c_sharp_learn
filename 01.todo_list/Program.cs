using TodoList;

class Program
{
    static void Main(string[] args)
    {
        var utils = new TodoListUtils();
        List<string> todos = new List<string>();
        int choise = utils.askMenu();
        bool whileCondition = choise >= 1 && choise <= 4;

        if (!whileCondition)
        {
            throw new Exception("Input wrong casted!");
        }

        while (whileCondition)
        {
            string input = "";
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Stampa di tutti i todo: ");

                    if (todos.Count == 0)
                    {
                        Console.WriteLine("La lista non contiene todo.");
                    }

                    foreach (string todo in todos)
                    {
                        Console.WriteLine(todo);
                    }

                    Console.WriteLine();
                    break;

                case 2:
                    Console.Write("Inserisci il nuovo todo: ");
                    input = Console.ReadLine();
                    todos.Add(input);
                    Console.WriteLine("Todo aggiunto con successo! \n");
                    break;

                case 3:
                    Console.Write("Inserisci todo da rimuovere: ");
                    input = Console.ReadLine();
                    if(!todos.Contains(input))
                    {
                        Console.WriteLine("Element not found");
                        Console.WriteLine();
                        break;
                    }
                    todos.Remove(input);
                    Console.WriteLine("Todo rimosso con successo! \n");
                    break;

                case 4:
                    choise = -1;
                    Console.WriteLine();
                    break;
            }

            if(choise != -1) 
            {
                choise = utils.askMenu();
                // Console.WriteLine(choise is int); // Debug
            }
            else
            {
                break;
            }
        }
    }
}