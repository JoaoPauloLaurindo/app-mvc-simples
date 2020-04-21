using System;
using System.Collections.Generic;
using System.Text;
using AppMvcBasic.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppMvcBasic.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<FornecedorModel> Fornecedores { get; set; }
        public DbSet<EnderecoModel> Enderecos { get; set; }
    }
}
