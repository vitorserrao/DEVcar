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
            string cpfCliente, string cor, double potencia, bool vendido, decimal valorVendido, 
            DateTime dataVenda, decimal preco, int totalPortas, string tipoCombustivel, int capacidadeCacamba):
            base(tipo, chassi, dataFabricacao, nome, placa, cpfCliente, cor, potencia,
                vendido,valorVendido,  dataVenda, preco, totalPortas, tipoCombustivel)
        {
            this.capacidadeCacamba = capacidadeCacamba;


        }
       

        public override string ToString()
        {
            return string.Format("{0}| Nome: {1}| Chassi: {2}| Data de Fabricação: {3} | Cor: {4}| Potência: {5}| \r\n" +
                                 "Número de portas: {6}| Capacidade caçamba: {7}| Tipo combustível: {8}|\r\n"+
                                "|R$ Preço: {9} |R$ Valor de venda: {10:c}|  Data da venda: {11}| Placa: {12}| CPF Cliente: {13}|",


            tipo,
            nome,
            chassi,
            dataFabricacao,
            cor,
            potencia,
            totalPortas,
            capacidadeCacamba,
            tipoCombustivel,
            preco,
            valorVendido,
            dataVenda,
            placa,
            cpfCliente
           
           ) ;
        }


    }
}
