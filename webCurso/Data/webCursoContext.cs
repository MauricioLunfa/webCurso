using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace webCurso.Models
{
    public class webCursoContext : DbContext
    {
        public webCursoContext (DbContextOptions<webCursoContext> options)
            : base(options)
        {
        }

        public DbSet<webCurso.Models.Departamento> Departamento { get; set; }
    }
}
