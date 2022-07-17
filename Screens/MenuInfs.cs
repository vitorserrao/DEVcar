using Devcar.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devcar.Models;


namespace Devcar.Screens
{
    class MenuInfs : Menu
    {
        public override void ShowOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine($"              Selecione");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("=======================================");

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("1 - Listar todos os veículos");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("2 - Veículos disponíveis");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("3 - Veículos vendidos");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("4 - Veículos vendido com maior preço");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("5 - Veículos vendido com o menor preço");

            Console.SetCursorPosition(2, 10);
            Console.WriteLine("0 - Voltar Menu Principal");

            Console.SetCursorPosition(2, 12);
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
                case "1": Veiculo.ListaTodosVeiculos(estoque); menu.Show(estoque); break;
                case "2": Veiculo.ListarVeiculosDisponivel(estoque, escolha); menu.Show(estoque); break;
                case "3": Veiculo.ListarVeiculosDisponivel(estoque, escolha); menu.Show(estoque); break;
                case "4": Veiculo.VendaValoresVeiculos(estoque, escolha); menu.Show(estoque); break;
                case "5": Veiculo.VendaValoresVeiculos(estoque, escolha); menu.Show(estoque); break;
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

