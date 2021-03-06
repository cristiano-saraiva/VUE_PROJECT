// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectSchoolApi.Data;

namespace ProjectSchoolApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210330233123_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("ProjectSchoolApi.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataNasc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataNasc = "22/02/1989",
                            Nome = "Maria",
                            ProfessorId = 1,
                            Sobrenome = "José"
                        },
                        new
                        {
                            Id = 2,
                            DataNasc = "15/12/2001",
                            Nome = "João",
                            ProfessorId = 2,
                            Sobrenome = "Miguel"
                        },
                        new
                        {
                            Id = 3,
                            DataNasc = "22/01/2009",
                            Nome = "Alex",
                            ProfessorId = 3,
                            Sobrenome = "Miranda"
                        });
                });

            modelBuilder.Entity("ProjectSchoolApi.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Vinicios"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Paula"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Luna"
                        });
                });

            modelBuilder.Entity("ProjectSchoolApi.Models.Aluno", b =>
                {
                    b.HasOne("ProjectSchoolApi.Models.Professor", "Professor")
                        .WithMany("Alunos")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("ProjectSchoolApi.Models.Professor", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
