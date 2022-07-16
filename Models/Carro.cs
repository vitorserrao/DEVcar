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



        public Carro(string tipo,string chassi, DateTime dataFabricacao, string nome, string placa,
            decimal valor, string cpfCliente, string cor, double potencia, bool vendido, decimal valorVendido, DateTime dataVenda, int totalPortas, string tipoCombustivel) :
            base(tipo, chassi, dataFabricacao, nome, placa, valor, cpfCliente, cor, potencia, vendido, valorVendido, dataVenda)
        {
            this.totalPortas = totalPortas; 
            this.tipoCombustivel = tipoCombustivel;
        }

        public override string ToString()
        {
            return string.Format("Categoria: {0}| Chassi: {1} | Data de Fabricação: {2} | Nome: {3}| " + "\r\n" +
                                "Placa: {4} |R$ Valor: {5:c}| CPF: {6}, Cor: {7}, Potência: {8}, Número de portas: {9} " + "\r\n" +
                                "Tipo ´combustível: {10}, Vendido: {11}, R$ Valor da Venda: {12:c}, Data da venda: {13}",
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
            vendido,
            valorVendido,
            dataVenda
           );
        }
    }
}
