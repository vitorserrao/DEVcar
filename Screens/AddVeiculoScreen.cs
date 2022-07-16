using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devcar.Models;
using Devcar.Repositories;


namespace Devcar.Screens
{
    public static class AddVeiculoScreen
    {
      

        public static void CriaMotoTriciculo(Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine("================= Moto | Tricículo ====================");
            var chassi = Guid.NewGuid().ToString().Substring(0, 18);
            var dataFabricacao = DateTime.Now;
            Console.Write("nome: ");
            var nome = (Console.ReadLine());
            Console.Write("potencia: ");
            var pot = Convert.ToDouble(Console.ReadLine());
            Console.Write("Número de rodas: ");
            var totalRodas = Convert.ToInt16(Console.ReadLine());
            Console.Write("Placa: ");
            var placa = (Console.ReadLine());
            Console.Write("Valor de venda: ");
            var valor = Convert.ToDecimal(Console.ReadLine());
            var cpf = "00000000";
            Console.Write("Cor: ");
            var cor = Console.ReadLine();

            var motoTriciculo = new MotoTriciculo("Moto/Tricículo",chassi, dataFabricacao, nome, placa, valor, cpf, cor, pot, false, 0, new DateTime(2000, 01, 01), totalRodas);
            Console.WriteLine("=====================================");
            Console.WriteLine("Veículo adicionado com sucesso!");
            estoque.Veiculos.Add(motoTriciculo);
            Console.WriteLine("Enter para voltar ao Menu Principal!");
            Console.ReadLine();
        }

        public static void CriaCarro(Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine("================= Carro ====================");
            var chassi = Guid.NewGuid().ToString().Substring(0, 18);
            var dataFabricacao = DateTime.Now;
            Console.Write("nome: ");
            var nome = (Console.ReadLine());
            Console.Write("Total de portas: ");
            var totalPorta = Convert.ToInt16(Console.ReadLine());
            Console.Write("Tipo do Combustível(Gasolina ou Flex):  ");
            var combustivel = Console.ReadLine();
            Console.Write("potencia: ");
            var pot = Convert.ToDouble(Console.ReadLine());
            Console.Write("Placa: ");
            var placa = (Console.ReadLine());
            Console.Write("Valor de venda: ");
            var valor = Convert.ToDecimal(Console.ReadLine());
            var cpf = "00000000";
            Console.Write("Cor: ");
            var cor = Console.ReadLine();

            var carro = new Carro("Carro",chassi, dataFabricacao, nome, placa, valor, cpf, cor, pot, false, 0, new DateTime(2000, 01, 01), totalPorta, combustivel);
            Console.WriteLine("=====================================");
            Console.WriteLine("Veículo adicionado com sucesso!");
            estoque.Veiculos.Add(carro);
            Console.WriteLine("Enter para voltar ao Menu Principal!");
            Console.ReadLine();
        }

        public static void CriaCamionete(Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine("================= Camionete ====================");
            var chassi = Guid.NewGuid().ToString().Substring(0, 18);
            var dataFabricacao = DateTime.Now;
            Console.Write("nome: ");
            var nome = (Console.ReadLine());
            Console.Write("Total de portas: ");
            var totalPorta = Convert.ToInt16(Console.ReadLine());
            Console.Write("Capacidade caçamba (L): ");
            var cacamba = Convert.ToInt16(Console.ReadLine());
            Console.Write("Tipo do Combustível(Gasolina ou Disel):  ");
            var combustivel = Console.ReadLine();
            Console.Write("potencia: ");
            var pot = Convert.ToDouble(Console.ReadLine());
            Console.Write("Placa: ");
            var placa = (Console.ReadLine());
            Console.Write("Valor de venda: ");
            var valor = Convert.ToDecimal(Console.ReadLine());
            var cpf = "00000000";
            Console.Write("Cor (Produzimos Apenas em Roxo): ");
            var cor = Console.ReadLine();

            var camionete = new Camionete("Camionete", chassi, dataFabricacao, nome, placa, valor, cpf, cor, pot, false, 0, new DateTime(2000, 01, 01), totalPorta, combustivel, cacamba);
            Console.WriteLine("=====================================");
            Console.WriteLine("Veículo adicionado com sucesso!");
            estoque.Veiculos.Add(camionete);
            Console.WriteLine("Enter para voltar ao Menu Principal!");
            Console.ReadLine();
        }
    }
}
