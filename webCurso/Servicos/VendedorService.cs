using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webCurso.Data;
using webCurso.Models;

namespace webCurso.Servicos
{
    public class VendedorService
    {

        private readonly webCursoContext _context;

        public VendedorService(webCursoContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }

    }
}
