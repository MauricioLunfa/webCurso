using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webCurso.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Nome obrigatório!")]
        [StringLength(60,MinimumLength =3, ErrorMessage = "Tamanho do nome deve ser entre 3 e 60 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email obrigatório!")]
        [EmailAddress(ErrorMessage ="Email inválido!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name ="Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Salário obrigatório!")]
        [Range(100.0,5000.0,ErrorMessage ="Salário não pode ser maior que {2} e menor que {1} ")]
        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double SalarioBase { get; set; }

        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; } // Informando ao frame que o departamento não pode ser null
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
