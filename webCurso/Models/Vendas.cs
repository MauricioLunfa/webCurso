using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webCurso.Models.Enums;

namespace webCurso.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public Vendas()
        {
        }

        public Vendas(int id, DateTime data, double valor, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }


    }
}
