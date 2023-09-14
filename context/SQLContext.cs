using Microsoft.EntityFrameworkCore;

namespace RestWithAspNet.context
{
    public class SQLContext : DbContext
    {

        public SQLContext(){}
        public SQLContext(DbContextOptions<SQLContext> options) : base(options){}


    }
}