﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webCurso.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<Vendas> Vendas { get; set; } = new List<Vendas>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVenda(Vendas sr)
        {
            Vendas.Add(sr);
        }

        public void RemoveVenda(Vendas sr)
        {
            Vendas.Remove(sr);
        }

        public double TotalVendas(DateTime DtInicio, DateTime DtFinal)
        {
            return Vendas.Where(sr => sr.Data >= DtInicio && sr.Data <= DtFinal).Sum(sr => sr.Valor);
        }
    }
}