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
            try
            {
                var chassi = Guid.NewGuid().ToString().Substring(0, 18);
                var dataFabricacao = DateTime.Now;
                Console.Write("nome: ");
                var nome = (Console.ReadLine());
                Console.Write("Nímero de potencia (cavalos): ");
                var pot = Convert.ToDouble(Console.ReadLine());
                Console.Write("Número de rodas: ");
                var totalRodas = Convert.ToInt16(Console.ReadLine());
                Console.Write("Placa: ");
                var placa = (Console.ReadLine());
                var cpf = "00000000";
                Console.Write("Cor: ");
                var cor = Console.ReadLine();
                Console.Write("Preço do veículo R$: ");
                var preco = Convert.ToDecimal(Console.ReadLine());
                var motoTriciculo = new MotoTriciculo("moto", chassi, dataFabricacao, nome, placa, cpf, cor, pot, false, 0, new DateTime(2000, 01, 01), preco, totalRodas);
                Console.WriteLine("=====================================");
                Console.WriteLine("Veículo adicionado com sucesso!");
                estoque.Veiculos.Add(motoTriciculo);
                Console.WriteLine("Enter para voltar ao Menu Principal!");
                Console.ReadLine();
            }
            catch { Veiculo.Tratamento(estoque, "fabricar", "Ops! Digite um valor válido!"); }
        }

        public static void CriaCarro(Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine("================= Carro ====================");
            try
            {
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
                var cpf = "00000000";
                Console.Write("Cor: ");
                var cor = Console.ReadLine();
                Console.Write("Preço do veículo: ");
                var preco = Convert.ToDecimal(Console.ReadLine());
                var carro = new Carro("carro", chassi, dataFabricacao, nome, placa, cpf, cor, pot, false, 0, new DateTime(2000, 01, 01), preco, totalPorta, combustivel);
                Console.WriteLine("=====================================");
                Console.WriteLine("Veículo adicionado com sucesso!");
                estoque.Veiculos.Add(carro);
                Console.WriteLine("Enter para voltar ao Menu Principal!");
                Console.ReadLine();
            }
            catch { Veiculo.Tratamento(estoque, "fabricar", "Ops! Digite um valor válido!"); }

        }

        public static void CriaCamionete(Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine("================= Camionete ====================");
            try { 
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
                Console.Write("Preço do veículo: ");
                var preco = Convert.ToDecimal(Console.ReadLine());
                var cpf = "00000000";
                Console.Write("IMPORTANTE: Produzimos apenas em cor Roxo \r\n");
                var camionete = new Camionete("camionete", chassi, dataFabricacao, nome, placa, cpf, "roxo", pot, false, 0, new DateTime(2000, 01, 01), preco, totalPorta, combustivel, cacamba);
                Console.WriteLine("=====================================");
                Console.WriteLine("Veículo adicionado com sucesso!");
                estoque.Veiculos.Add(camionete);
                Console.WriteLine("Enter para voltar ao Menu Principal!");
                Console.ReadLine();
            }
            catch { Veiculo.Tratamento(estoque, "fabricar", "Ops! Digite um valor válido!"); }
        }
    }
}
