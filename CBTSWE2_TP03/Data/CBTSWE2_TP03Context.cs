/*

    Integrantes:

    Luiz Gustavo Verissimo Monteiro - CB3030326
    Kaik Persike Maiorquino - CB3029689

 */

using Microsoft.EntityFrameworkCore;
using CBTSWE2_TP03.Models;

namespace CBTSWE2_TP03.Data
{
    public class CBTSWE2_TP03Context : DbContext
    {
        public CBTSWE2_TP03Context(DbContextOptions<CBTSWE2_TP03Context> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}