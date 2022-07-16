using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devcar.Screens;
using Devcar.Models;
using Devcar.Repositories;

namespace DEVcar
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            var veiculo = new Estoque();
            var menu = new Menu();
            menu.Show(veiculo);
            Console.WriteLine(veiculo);
            Console.ReadLine();
        }
    }
}
