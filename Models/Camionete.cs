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
        public Camionete(string chassi, DateTime dataFabricacao, string nome, string placa,
            decimal valor, string cpfCliente, string cor, double potencia, bool vendido, decimal valorVendido, DateTime dataVenda, int totalPortas, string tipoCombustivel, int capacidadeCacamba):
            base(chassi, dataFabricacao, nome, placa, valor, cpfCliente, cor, potencia,
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
            return string.Format("Chassi: {0} | Data de Fabricação: {1} | Nome: {2}| " + "\r\n" +
                "Placa: {3} |R$ Valor: {4:c}| CPF: {5}, Cor: {6}, Potência: {7}, Vendido: {8}, Valor da Venda {9}, Data da venda {10} ",
             chassi,
             dataFabricacao,
             nome,
             placa,
             valor,
             cpfCliente,
             cor,
             potencia,
             vendido,
             valorVendido,
             dataVenda
            );
        }


    }
}
