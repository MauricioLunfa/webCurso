using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webCurso.Models;
using webCurso.Models.Enums;

namespace webCurso.Data
{
    public class SeedingService
    {

        private webCursoContext _context;

        public SeedingService(webCursoContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            // Testando se tem alguma base de dados 
            if (_context.Departamento.Any() || _context.Vendedor.Any() 
                || _context.Vendas.Any())
            {
                return; // O banco de dados já foi populado
            }

            Departamento d1 = new Departamento(1,"Computador");
            Departamento d2 = new Departamento(2,"Eletronicos");
            Departamento d3 = new Departamento(3,"Livros");
            Departamento d4 = new Departamento(4, "Alimentos");

            Vendedor v1 = new Vendedor(1,"Mauricio","mb@gmail.com",
                new DateTime(1977,2,5),1000,d1);

            Vendedor v2 = new Vendedor(2, "Vinicius", "vn@gmail.com",
                            new DateTime(1985, 5, 20), 2000, d2);

            Vendedor v3 = new Vendedor(3, "Tiago", "ts@gmail.com",
                            new DateTime(1990, 3, 15), 3000, d3);

            Vendedor v4 = new Vendedor(4, "Gustavo", "gm@gmail.com",
                            new DateTime(1990, 1, 08), 2500, d4);

            Vendedor v5 = new Vendedor(5, "Aline", "am@gmail.com",
                            new DateTime(1989, 7, 24), 3000, d1);

            Vendedor v6 = new Vendedor(6, "Joata", "jp@gmail.com",
                            new DateTime(1983, 10, 23), 4000, d2);

            Vendas s1 = new Vendas(1,new DateTime(2019,04,01),250.00,StatusVenda.Pendente,v1);
            Vendas s2 = new Vendas(2, new DateTime(2019, 04, 02), 1250.00, StatusVenda.Faturado, v2);
            Vendas s3 = new Vendas(3, new DateTime(2019, 04, 03), 1000.00, StatusVenda.Cancelado, v3);
            Vendas s4 = new Vendas(4, new DateTime(2019, 04, 04), 380.00, StatusVenda.Cancelado, v4);
            Vendas s5 = new Vendas(5, new DateTime(2019, 04, 01), 550.00, StatusVenda.Faturado, v5);
            Vendas s6 = new Vendas(6, new DateTime(2019, 04, 02), 680.00, StatusVenda.Pendente, v6);
            Vendas s7 = new Vendas(7, new DateTime(2019, 04, 03), 1750.00, StatusVenda.Faturado, v1);
            Vendas s8 = new Vendas(8, new DateTime(2019, 04, 04), 2050.00, StatusVenda.Pendente, v2);
            Vendas s9 = new Vendas(9, new DateTime(2019, 04, 01), 2150.00, StatusVenda.Pendente, v3);
            Vendas s10 = new Vendas(10, new DateTime(2019, 04, 02), 1150.00, StatusVenda.Faturado, v4);
            Vendas s11 = new Vendas(11, new DateTime(2019, 04, 03), 150.00, StatusVenda.Faturado, v5);
            Vendas s12 = new Vendas(12, new DateTime(2019, 04, 04), 850.00, StatusVenda.Pendente, v6);
            Vendas s13 = new Vendas(13, new DateTime(2019, 04, 01), 900.00, StatusVenda.Faturado, v1);
            Vendas s14 = new Vendas(14, new DateTime(2019, 04, 02), 1300.00, StatusVenda.Pendente, v2);


            _context.Departamento.AddRange(d1,d2,d3,d4);
            _context.Vendedor.AddRange(v1,v2,v3,v4,v5,v6);
            _context.Vendas.AddRange(s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,s11,s12,s13,s14);

            _context.SaveChanges();

        }

    }
}
