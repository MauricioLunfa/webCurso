using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webCurso.Models;
using Microsoft.EntityFrameworkCore;

namespace webCurso.Servicos
{
    public class DepartamentoService
    {

        private readonly webCursoContext _context;

        public DepartamentoService(webCursoContext context)
        {
            _context = context;
        }

        public async Task<List<Departamento>> CarregandoDadosAsync()
        {
            return await _context.Departamento.OrderBy(x => x.Nome).ToListAsync();
        }

    }
}
