using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devcar.Models
{
    public class Carro : Veiculo

    {
        public int totalPortas { get; set; }
        public string tipoCombustivel { get; set; }



        public Carro(string chassi, DateTime dataFabricacao, string nome, string placa,
            decimal valor, string cpfCliente, string cor, double potencia, bool vendido, decimal valorVendido, DateTime dataVenda, int totalPortas, string tipoCombustivel) :
            base(chassi, dataFabricacao, nome, placa, valor, cpfCliente, cor, potencia, vendido, valorVendido, dataVenda)
        {
            this.totalPortas = totalPortas; 
            this.tipoCombustivel = tipoCombustivel;
        }


    }
}
