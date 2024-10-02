using Microsoft.EntityFrameworkCore;

namespace CodingTest.Models
{

    public class ElementsContext : DbContext
    {
        public  DbSet<Elements>Elements{ get; set; }

        // Find the index of "\bin"


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source= C:\\Users\\Thomh\\Documents\\CodingTest\\CodingTest\\Database\\Elements.db");



 


    }
}


