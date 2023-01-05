using System;
using System.Collections.Generic;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma lista de tarefas
            List<Task> tasks = new List<Task>();

            // Loop para exibir o menu
            while (true)
            {
                // Exibe o menu
                Console.WriteLine("Gerenciador de Tarefas");
                Console.WriteLine("1. Adicionar tarefa");
                Console.WriteLine("2. Remover tarefa");
                Console.WriteLine("3. Exibir tarefas");
                Console.WriteLine("4. Sair");
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");

                // Lê a opção do usuário
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    // Adiciona uma tarefa
                    Console.Write("Insira o nome da tarefa: ");
                    string taskName = Console.ReadLine();
                    Task task = new Task(taskName);
                    tasks.Add(task);
                    Console.WriteLine("Tarefa adicionada com sucesso!");
                }
                else if (option == 2)
                {
                    // Remove uma tarefa
                    Console.Write("Insira o índice da tarefa a ser removida: ");
                    int index = int.Parse(Console.ReadLine());
                    tasks.RemoveAt(index);
                    Console.WriteLine("Tarefa removida com sucesso!");
                }
                else if (option == 3)
                {
                    // Exibe as tarefas
                    Console.WriteLine("Tarefas:");
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine($"{i}: {tasks[i].Name}");
                    }
                }
                else if (option == 4)
                {
                    // Sai do programa
                    break;
                }
            }
        }
    }

    // Classe que representa uma tarefa
    class Task
    {
        public string Name { get; set; }

        public Task(string name)
        {
            Name = name;
        }
    }
}

