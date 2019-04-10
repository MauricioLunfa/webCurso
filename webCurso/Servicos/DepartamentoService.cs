using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webCurso.Models;

namespace webCurso.Servicos
{
    public class DepartamentoService
    {

        private readonly webCursoContext _context;

        public DepartamentoService(webCursoContext context)
        {
            _context = context;
        }

        public List<Departamento> FindAll()
        {
            return _context.Departamento.OrderBy(x => x.Nome).ToList();
        }

    }
}
