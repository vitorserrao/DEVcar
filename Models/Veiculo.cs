using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; 
using Devcar.Repositories;


namespace Devcar.Models
{
    public class Veiculo
    {
        public string tipo { get; set; }
        public string chassi { get; set; }
        public DateTime dataFabricacao { get; set; }
        public string nome { get; set; }
        public string placa { get; set; }
        public decimal valor { get; set; }
        public string cpfCliente { get; set; } 
        public string cor { get; set; }
        public double potencia { get; set; }
        public bool vendido { get; set; }
        public DateTime dataVenda { get; set; }
        public decimal valorVendido { get; set; }

        public Veiculo(string tipo,  string chassi, DateTime dataFabricacao, string nome, string placa,decimal valor, 
                       string cpfCliente, string cor, double potencia, bool vendido,decimal valorVendido, DateTime dataVenda)
        {   
            this.tipo = tipo;
            this.chassi = chassi;
            this.dataFabricacao = dataFabricacao;
            this.nome = nome;
            this.placa = placa;
            this.valor = valor;
            this.cpfCliente = cpfCliente;
            this.cor = cor;
            this.potencia = potencia;
            this.vendido = vendido;
            this.valorVendido = valorVendido;
            this.dataVenda = dataVenda;
            
          
        }

        public static void VendaVeiculo(Estoque estoque)
        {
            Console.Clear();
            Console.Write("Chassi: ");
            var chassi = (Console.ReadLine());
            Console.Write("CPF do comprador : ");
            var cpfCliente = (Console.ReadLine());
            Console.Write("Valor da Venda: ");
            var valorVenda = Convert.ToDecimal(Console.ReadLine()); 
            var filtrar = estoque.Veiculos.Where(id => id.chassi.StartsWith(chassi)).ToList();
            filtrar[0].cpfCliente = cpfCliente;
            filtrar[0].vendido = true;
            filtrar[0].valorVendido = valorVenda;
            filtrar[0].dataVenda = DateTime.Now;
            Console.WriteLine(filtrar[0]);
            Console.ReadLine();
        }


        
        public static void ListarInformacao(Estoque estoque)
        {
                Console.Clear();
                Console.WriteLine("LISTA DE PRODUTOS CADASTRADOS");
                Console.WriteLine("=============================" + "\r\n");
                int count = 1;
                var filtrar = estoque.Veiculos.Where(status => status.vendido == false).ToList();
                if (!filtrar.Any())
                {
                    Console.WriteLine("Estoque ZERADO hora de Fabricar!");
                }
                else
                {
                    
                    foreach (var veiculo in filtrar)
                        {

                            Console.WriteLine($"Veiculo {count}: {veiculo.ToString()}" + "\r\n");

                            count++;
                        }
                        count = 1;
                    }

                Console.ReadLine();
            
        }
        public void alterarInf(string novaCor, decimal novoValor)
        {
            cor = novaCor;
            valor = novoValor;
        }

       
    }
}