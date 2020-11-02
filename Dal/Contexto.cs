using Microsoft.EntityFrameworkCore;
using JordyP2_Apl.Entidades;

namespace JordyP2_Apl.Dal{

    public class Contexto: DbContext{
        
        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Proyectos>  Proyectos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            optionsBuilder.UseSqlite(@"Data Source = Data/Proyecto.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Tareas>().HasData(new Tareas {TareaId = 1, TipoTarea = "Analisis"});
            modelBuilder.Entity<Tareas>().HasData(new Tareas {TareaId = 2, TipoTarea = "Diseño"});
            modelBuilder.Entity<Tareas>().HasData(new Tareas {TareaId = 3, TipoTarea = "Programacion 3"});
            modelBuilder.Entity<Tareas>().HasData(new Tareas {TareaId = 4, TipoTarea = "Electronica"});
            modelBuilder.Entity<Tareas>().HasData(new Tareas {TareaId = 5, TipoTarea = "Calculo 3"});
            modelBuilder.Entity<Tareas>().HasData(new Tareas {TareaId = 6, TipoTarea ="Estructura de Datos"});
        }
    }
}