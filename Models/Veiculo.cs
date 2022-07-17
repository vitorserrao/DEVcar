using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; 
using Devcar.Repositories;
using Devcar.Screens;


namespace Devcar.Models
{
    public class Veiculo
    {
        public string tipo { get; set; }
        public string chassi { get; set; }
        public DateTime dataFabricacao { get; set; }
        public string nome { get; set; }
        public string placa { get; set; }
        public string cpfCliente { get; set; }
        public string cor { get; set; }
        public double potencia { get; set; }
        public bool vendido { get; set; }
        public DateTime dataVenda { get; set; }
        public decimal valorVendido { get; set; }
        public decimal preco { get; set; }

        public Veiculo(string tipo, string chassi, DateTime dataFabricacao, string nome, string placa,
                       string cpfCliente, string cor, double potencia, bool vendido, decimal valorVendido, 
                       DateTime dataVenda, decimal preco)
        {
            this.tipo = tipo;
            this.chassi = chassi;
            this.dataFabricacao = dataFabricacao;
            this.nome = nome;
            this.placa = placa;
            this.cpfCliente = cpfCliente;
            this.cor = cor;
            this.potencia = potencia;
            this.vendido = vendido;
            this.valorVendido = valorVendido;
            this.dataVenda = dataVenda;
            this.preco = preco; 
        }

        public void test()
        {
           
            cor= "roxo";
        }
        public static void VendaVeiculo(Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine("================= Venda Veículo ================== \r\n");
            Console.Write("Chassi: ");
            var chassi = Console.ReadLine();
            var filtrar = estoque.Veiculos.Where(id => id.chassi.StartsWith(chassi)).ToList();
            if (!filtrar.Any())
            {
                Tratamento(estoque, "principal","Veículo Não encontrado! Enter para voltar ao Menu Principal!");
            }
            
            
         Console.Write("CPF do comprador : ");  
         var cpfCliente = Console.ReadLine();
         Console.Write("Valor da Venda: ");
         var valorVendido = Convert.ToDecimal(Console.ReadLine());
         filtrar[0].vendido = true;
         filtrar[0].cpfCliente = cpfCliente;
         filtrar[0].valorVendido = valorVendido;
         filtrar[0].dataVenda = DateTime.Now;
         Console.WriteLine("=================================================");
         Console.WriteLine("Venda realizada com sucesso!");
         Console.ReadLine();
            
        }

        public static void ListaTodosVeiculos(Estoque estoque)
        {

            Console.Clear();
            Console.WriteLine("   Lista de Todos os Veículos");
            Console.WriteLine("===================================");
            Console.WriteLine("Digite a categoria de veículo desejada (Carro, Moto, Camionete ou Todas):");
            var categoria = Console.ReadLine().ToLower();

            
            int count = 1;
            
            if (categoria == "todas")
            {
                var filtrar = estoque.Veiculos.ToList();
                if (!filtrar.Any())
                {
                    Tratamento(estoque, "principal", "Estoque vazio e sem registro de venda");
                }
                foreach (var veiculo in filtrar)
                {
                    Console.WriteLine("\r\n");
                    Console.WriteLine($"{count} {veiculo.ToString()}" + "\r\n");
                    count++;
                }
                count = 1;
            }
            else
            {
                var filtro = estoque.Veiculos.Where(item => item.tipo == categoria).ToList();
                if (!filtro.Any())
                {
                    Tratamento(estoque, "principal", "Categoria de veículo está vazia ou não existe");
                }
                foreach (var veiculo in filtro)
                {
                    Console.WriteLine("\r\n");
                    Console.WriteLine($"{count} {veiculo.ToString()}" + "\r\n");

                    count++;
                }
                count = 1;
            }
         


            Console.ReadLine();

        }
        public static void ListarVeiculosDisponivel(Estoque estoque, string escolhe)
        {
            Console.Clear();

            int count = 1;
            var statusVenda = false;
            var mensagem = "     Lista de veículo disponível";
            if (escolhe == "3")
            {
                statusVenda = true;
                mensagem = "     Lista de veículos vendidos";
            }
            var filtrar = estoque.Veiculos.Where(status => status.vendido == statusVenda).ToList();
            Console.WriteLine(mensagem);
            Console.WriteLine("==========================================");

            if (!filtrar.Any())
            {
                Console.WriteLine("Não foi vendido nenhum veículo!");
            }
            else
            {

                foreach (var veiculo in filtrar)
                {

                    Console.WriteLine($"{count}: {veiculo.ToString()}" + "\r\n");

                    count++;
                }
                count = 1;
            }

            Console.ReadLine();

        }
        public static void VendaValoresVeiculos(Estoque estoque, string escolhe)
        {
            Console.Clear();

            int count = 1;
            var filtrar = estoque.Veiculos.OrderBy(valor => valor.valorVendido).ToList();
            var mensagem = "     Lista de veículo vendido com menores preços";
            if (escolhe == "4")
            {
                filtrar = estoque.Veiculos.OrderBy(valor => valor.valorVendido).Reverse().ToList();
                mensagem = "     Lista de veículo vendido com maiores preços";
            }
           
            Console.WriteLine(mensagem);
            Console.WriteLine("==========================================");

            if (!filtrar.Any())
            {
                Console.WriteLine("Não foi vendido nenhum veículo!");
            }
            else
            {

                foreach (var veiculo in filtrar)
                {

                    Console.WriteLine($"{count}: {veiculo.ToString()}" + "\r\n");

                    count++;
                }
                count = 1;
            }

            Console.ReadLine();

        }
        public static void Tratamento(Estoque estoque, string menu, string mensagem)
        {   
            Console.Write(mensagem);
            Console.ReadLine();
            if(menu == "fabricar"){var ir = new MenuFabricar(); ir.Show(estoque); }
            else{ var ir = new Menu(); ir.Show(estoque); }
           
        }
        public static void AlterarInf(Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine("================= Alteração de Veículo ==================");
            Console.Write("Chassi: ");
            var chassi = Console.ReadLine();
            var filtrar = estoque.Veiculos.Where(id => id.chassi.StartsWith(chassi) && id.vendido == false).ToList();
            if (!filtrar.Any())
            {
                Tratamento(estoque,"principal","Veículo Não encontrado! Enter para voltar ao Menu Principal!");
            }
            var corAntiga = filtrar[0].cor;
            var precoAntigo = filtrar[0].preco;
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Cor atual do veículo: {corAntiga}");
            Console.WriteLine($"Preço atual do veículo: R${precoAntigo}");
            Console.WriteLine("----------------------------------");
            try
            {
                Console.Write("Nova cor do veículo: ");
                var corNova = filtrar[0].cor = Console.ReadLine();
                Console.Write("Novo Preço do veículo R$: ");
                var precoNovo = filtrar[0].preco = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("===================================");
                Console.WriteLine($"Alterações realizadas com sucesso: {corAntiga} -> {corNova} e R$ {precoAntigo} -> R$ {precoNovo}");
                Console.ReadLine();
            }
            catch { Veiculo.Tratamento(estoque, "principal", "Ops! Digite um valor válido!"); }
        }

    }
}