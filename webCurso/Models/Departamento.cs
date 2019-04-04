using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webCurso.Models
{
    public class Departamento
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedor ven)
        {
            Vendedores.Add(ven);
        }

        public double TotalVendas(DateTime dtInicio,DateTime dtFinal)
        {
            return Vendedores.Sum(Vendedor => Vendedor.TotalVendas(dtInicio,dtFinal));
        }

    }
}
