using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devcar.Models;

namespace Devcar.Repositories
{
    public class Estoque
    {
        public IList<Veiculo> Veiculos { get; set; }
        public Estoque()
        {
            Veiculos = new List<Veiculo>(); 
        }
    }

}
