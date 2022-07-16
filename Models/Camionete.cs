using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devcar.Repositories;
namespace Devcar.Models
{
    public class Camionete : Carro
    {
        public int capacidadeCacamba { get; set; }
        public Camionete(string tipo,string chassi, DateTime dataFabricacao, string nome, string placa,
            decimal valor, string cpfCliente, string cor, double potencia, bool vendido, decimal valorVendido, DateTime dataVenda, int totalPortas, string tipoCombustivel, int capacidadeCacamba):
            base(tipo, chassi, dataFabricacao, nome, placa, valor, cpfCliente, cor, potencia,
                vendido,valorVendido,  dataVenda, totalPortas, tipoCombustivel)
        {
            this.capacidadeCacamba = capacidadeCacamba;
            if (this.cor.ToLower() != "roxo")
            {
                Console.WriteLine("Só produzimos roxo");
                this.cor = "Roxo";
            }
            else
            {
                Console.WriteLine("Vamos produzir");
            }

        }
       

        public override string ToString()
        {
            return string.Format("Categoria: {0}| Chassi: {1} | Data de Fabricação: {2} | Nome: {3}| " + "\r\n" +
                                "Placa: {4} |R$ Valor: {5:c}| CPF: {6}, Cor: {7}, Potência: {8}, Número de portas: {9} " + "\r\n" +
                                "Tipo ´combustível: {10}, Capacidade caçamba: {11} Vendido: {12}, R$ Valor da Venda: {13:c}, Data da venda: {14}",
            tipo,
            chassi,
            dataFabricacao,
            nome,
            placa,
            valor,
            cpfCliente,
            cor,
            potencia,
            totalPortas,
            tipoCombustivel,
            capacidadeCacamba,
            vendido,
            valorVendido,
            dataVenda
           ) ;
        }


    }
}
