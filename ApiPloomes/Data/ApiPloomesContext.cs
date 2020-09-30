using ApiPloomes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPloomes.Data {
    public class ApiPloomesContext : DbContext {
        public ApiPloomesContext(DbContextOptions<ApiPloomesContext> options)
       : base(options) {
        }

        public DbSet<Usuario> Usuario { get; set; }
    
    }

}

