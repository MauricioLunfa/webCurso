using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webCurso.Data;
using webCurso.Models;
using Microsoft.EntityFrameworkCore;
using webCurso.Servicos.Exceptions;

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

        public void Insert(Vendedor ven)
        {

            _context.Add(ven);
            _context.SaveChanges();

        }

        public Vendedor PesquisarId(int id)
        {
            return _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remover(int id)
        {
            var obj = _context.Vendedor.Find(id);
            _context.Vendedor.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Vendedor obj)
        {
            // Se não existir dados do vendedor 
            if (!_context.Vendedor.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id não encontrado!");
            }

            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }

            // Se acontecer algum erro de retorno do banco de dados
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
