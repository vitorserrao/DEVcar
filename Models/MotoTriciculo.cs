using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devcar.Models
{
    public class MotoTriciculo : Veiculo

    {
       
        public int numeroRodas { get; set; }
        public MotoTriciculo(string chassi, DateTime dataFabricacao, string nome, string placa,
            decimal valor, string cpfCliente, string cor, double potencia, bool vendido, decimal valorVendido,
            DateTime dataVenda, int numeroRodas) : 
            base(chassi, dataFabricacao, nome, placa, valor, cpfCliente, cor, potencia, vendido,valorVendido, dataVenda ) 
        {
        
            this.numeroRodas = numeroRodas;
        }

  
    }
}
