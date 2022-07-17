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
            string cpfCliente, string cor, double potencia, bool vendido, decimal valorVendido, 
            DateTime dataVenda, decimal preco, int totalPortas, string tipoCombustivel) :
            base(tipo, chassi, dataFabricacao, nome, placa, cpfCliente, cor, potencia, vendido, valorVendido
                , dataVenda, preco)
        {
            this.totalPortas = totalPortas; 
            this.tipoCombustivel = tipoCombustivel;
        }



        public override string ToString()
        {
            return string.Format("{0}| Nome: {1}| Chassi: {2}| Data de Fabricação: {3} | Cor: {4}| Potência: {5}| \r\n" +
                                 "Número de portas: {6}| Tipo combustível: {7}|\r\n" +
                                "|R$ Preço: {8:c}| R$ Valor de venda: {9:c}|  Data da venda: {10}|Placa: {11}| CPF Cliente: {12}|",
            tipo,
            nome,
            chassi,
            dataFabricacao,
            cor,
            potencia,
            totalPortas,
            tipoCombustivel,
            preco,
            valorVendido,
            dataVenda,
            placa,
            cpfCliente

           );
        }
    }
}
