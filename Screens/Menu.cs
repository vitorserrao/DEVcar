using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devcar.Repositories;
using Devcar.Models;

namespace Devcar.Screens
{
    public class Menu
    {
        const short col = 30;
        const short row = 12;
        
        public virtual void Show(Estoque estoque)
        {
            var menuFabricar = new MenuFabricar();
            Console.Clear();
            DrawCanvas();
            ShowOptions();
            var option = Console.ReadLine();
            switch (option)
            {
                case "1": menuFabricar.Show(estoque); Show(estoque); break;
                case "2": Veiculo.VendaVeiculo(estoque); Show(estoque); break;
                case "3": Veiculo.ListarInformacao(estoque);Show(estoque); break;
                case "0":
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }

                default: Show(estoque); break;
                
            }
            Console.ReadLine();
        }
        public virtual void ShowOptions()
        {

            Console.SetCursorPosition(3, 2);
            Console.WriteLine($"       DEVcar v0.1 ");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("=============================");

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("1 - Adicionar Novo Veículo");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("2 - Vender Veículo");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("3 - Listar Informações");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("4 - Alterar Informações");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(2, 11);
            Console.Write("Opção selecionada: ");
        }
        public virtual void DrawCanvas()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Printhline();
            for (int i = 0; i < 12; i++)
            {
                Console.Write("|");

                for (int line = 0; line <= 30; line++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write(Environment.NewLine);
            }
            Printhline();
        }
        public virtual void Printhline()
        {
            System.Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                System.Console.Write("-", Console.ForegroundColor);
            }
            System.Console.Write("+");
            Console.Write(Environment.NewLine);

        }

    }

}
