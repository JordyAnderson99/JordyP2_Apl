using Microsoft.EntityFrameworkCore;

namespace JordyP2_Apl.Dal{

    public class Contexto: DbContext{

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            optionsBuilder.UseSqlite(@"Data Source = Data/Proyecto.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            
        }
    }
}