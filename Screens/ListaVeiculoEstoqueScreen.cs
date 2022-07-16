using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devcar.Repositories;
using Devcar.Models;

namespace Devcar.Screens
{
    public class ListaVeiculoEstoqueScreen
    {
        public static void VeiculoEstoque(Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine("LISTA DE VEÍCULO NO ESTOQUE");
            Console.WriteLine("============================="+ "\r\n");
            int count = 1;

            if (!estoque.Veiculos.Any())
            {
                Console.WriteLine("Estoque ZERADO hora de Fabricar!");
            }
            else {
                foreach (var veiculo in estoque.Veiculos)
                {

                    Console.WriteLine($"{count}: {veiculo.ToString()}" + "\r\n");

                    count++;
                }
                count = 1;
            }
        
            Console.ReadLine();
        }
    }
}
