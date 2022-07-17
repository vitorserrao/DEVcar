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
        public MotoTriciculo(string tipo, string chassi, DateTime dataFabricacao, string nome, string placa,
            string cpfCliente, string cor, double potencia, bool vendido, decimal valorVendido,
            DateTime dataVenda, decimal preco, int numeroRodas) : 
            base(tipo, chassi, dataFabricacao, nome, placa, cpfCliente, cor, potencia, vendido,valorVendido, dataVenda, preco ) 
        {
        
            this.numeroRodas = numeroRodas;
        }

        public override string ToString()
        {
            return string.Format("{0}| Nome: {1}| Chassi: {2} | Data de Fabricação: {3} | Cor: {4}| Potência: {5}| Número de rodas: {6} \r\n" +
                                "|R$ Preço: {7:c}| R$ Valor de venda: {8:c}| Data da venda: {9}| Placa: {10}| CPF Cliente: {11}|",
             tipo,
             nome,
             chassi,
             dataFabricacao,
             cor,
             potencia,
             numeroRodas,
             preco,
             valorVendido,
             dataVenda,
             placa,
             cpfCliente
            );
        }

    }
}
