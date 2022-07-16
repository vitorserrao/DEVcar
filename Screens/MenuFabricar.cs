using Devcar.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devcar.Models;


namespace Devcar.Screens
{
    class MenuFabricar : Menu
    {
        public override void ShowOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine($"Selecione para fabricar ");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("==========================");

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("1 - Moto / Tricículo");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("2 - Carro");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("3 - Camionete");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("0 - Voltar Menu Principal");

            Console.SetCursorPosition(2, 10);
            Console.Write("Opção selecionada: ");
        }
        public override void Show(Estoque estoque)
        {
            var menu = new Menu();
            Console.Clear();
            DrawCanvas();
            ShowOptions();
            var escolha = Console.ReadLine();
            switch (escolha)
            {
                case "1": AddVeiculoScreen.CriaMotoTriciculo(estoque); menu.Show(estoque); break;
                case "2": AddVeiculoScreen.CriaCarro(estoque); Show(estoque); break;
                case "3": AddVeiculoScreen.CriaCamionete(estoque); Show(estoque); break;
                case "0":
                    {
                        Console.Clear();
                        menu.Show(estoque);
                        break;
                    }
                default: Show(estoque); break;


            }
            Console.ReadLine();
        }
    }
}

