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

        public async Task<List<Vendedor>> CarregaDadosAsync()
        {
            return await _context.Vendedor.ToListAsync();
        }

        public async Task InsertAsync(Vendedor ven)
        {

            _context.Add(ven);
            await _context.SaveChangesAsync();

        }

        public async Task<Vendedor> PesquisarIdAsync(int id)
        {
            return await _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoverAsync(int id)
        {
            try
            {
                var obj = await _context.Vendedor.FindAsync(id);
                _context.Vendedor.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegridadeException("Ação não permitida, existe movimentação desse vendedor!");
            }
        }

        public async Task UpdateAsync(Vendedor obj)
        {

            bool seTemAlgum = await _context.Vendedor.AnyAsync(x => x.Id == obj.Id);
            // Se não existir dados do vendedor 
            if (!seTemAlgum)
            {
                throw new NotFoundException("Id não encontrado!");
            }

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }

            // Se acontecer algum erro de retorno do banco de dados
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
