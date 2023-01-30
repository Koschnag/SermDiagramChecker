using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SermTreeCore.Contracts;
using SermTreeCore.Models;

namespace WebAPI.Context
{
    public class SermDbContext: DbContext
    {
        public SermDbContext(DbContextOptions<SermDbContext> options) : base(options)
        {
            //Use ConnectionString from secret.json
        }
        public DbSet<SermTree> Diagrams { get; set; }
    }
}

