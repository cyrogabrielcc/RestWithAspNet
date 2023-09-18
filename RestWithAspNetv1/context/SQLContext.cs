using Microsoft.EntityFrameworkCore;
using RestWithAspNet.model;

namespace RestWithAspNet.context
{
    public class SQLContext : DbContext
    {

        public SQLContext(){}
        public SQLContext(DbContextOptions<SQLContext> options) : base(options){}

        public DbSet<Person> Persons {get; set;}
        
    }
}