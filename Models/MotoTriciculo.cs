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
            decimal valor, string cpfCliente, string cor, double potencia, bool vendido, decimal valorVendido,
            DateTime dataVenda, int numeroRodas) : 
            base(tipo, chassi, dataFabricacao, nome, placa, valor, cpfCliente, cor, potencia, vendido,valorVendido, dataVenda ) 
        {
        
            this.numeroRodas = numeroRodas;
        }

        public override string ToString()
        {
            return string.Format("Categoria: {0}| Chassi: {1} | Data de Fabricação: {2} | Nome: {3}| " + "\r\n" +
                                 "Placa: {4} |R$ Valor: {5:c}| CPF: {6}, Cor: {7}, Potência: {8}|Número de rodas: {9}" + "\r\n" + 
                                 " Vendido: {10}| R$ Valor da Venda: {11:c}| Data da venda: {12}",
             tipo,
             chassi,
             dataFabricacao,
             nome,
             placa,
             valor,
             cpfCliente,
             cor,
             potencia,
             numeroRodas,
             vendido,
             valorVendido,
             dataVenda
            );
        }

    }
}
