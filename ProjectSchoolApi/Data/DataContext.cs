using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProjectSchoolApi.Models;

namespace ProjectSchoolApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Aluno> Alunos {get; set;}
        public DbSet<Professor> Professores {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Professor>()
            .HasData(
                new List<Professor>(){
                    new Professor(){
                        Id = 1,
                        Nome = "Vinicios",
                    },
                    new Professor(){
                        Id = 2,
                        Nome = "Paula",
                    },
                    new Professor(){
                        Id = 3,
                        Nome = "Luna",
                    }
                }
            );
            builder.Entity<Aluno>()
            .HasData(
                new List<Aluno>(){
                    new Aluno(){
                        Id = 1,
                        Nome = "Maria",
                        Sobrenome = "José",
                        DataNasc = "22/02/1989",
                        ProfessorId = 1
                    },
                    new Aluno(){
                        Id = 2,
                        Nome = "João",
                        Sobrenome = "Miguel",
                        DataNasc = "15/12/2001",
                        ProfessorId = 2
                    },
                    new Aluno(){
                        Id = 3,
                        Nome = "Alex",
                        Sobrenome = "Miranda",
                        DataNasc = "22/01/2009",
                        ProfessorId = 3
                    }
                }
            );
        }
    }
}