using Microsoft.EntityFrameworkCore;
using FetchWebapi.Model;
namespace FetchWebapi.Data{

public class Appdbcontext:DbContext{
    public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options)
    {
        
    }
    public DbSet<MovieDetails> MovieDetails{get; set;}
    
}
}