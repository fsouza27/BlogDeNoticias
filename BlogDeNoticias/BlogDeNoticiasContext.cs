using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlogDeNoticias
{
    public partial class BlogDeNoticiasContext : DbContext
    {
        public BlogDeNoticiasContext()
        {
        }

        public BlogDeNoticiasContext(DbContextOptions<BlogDeNoticiasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAutor> TbAutor { get; set; }
        public virtual DbSet<TbCategoria> TbCategoria { get; set; }
        public virtual DbSet<TbNoticia> TbNoticia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=123456;database=blog");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAutor>(entity =>
            {
                entity.HasKey(e => e.IdAutor)
                    .HasName("PRIMARY");

                entity.ToTable("tb_autor");

                entity.HasIndex(e => e.IdAutor)
                    .HasName("id_autor_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdAutor)
                    .HasColumnName("id_autor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdadeAutor)
                    .HasColumnName("idade_autor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastnameAutor)
                    .HasColumnName("lastname_autor")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Nacionalidade)
                    .HasColumnName("nacionalidade")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NomeAutor)
                    .HasColumnName("nome_autor")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCategoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PRIMARY");

                entity.ToTable("tb_categoria");

                entity.Property(e => e.IdCategoria)
                    .HasColumnName("id_categoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NomeCategoria)
                    .HasColumnName("nome_categoria")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbNoticia>(entity =>
            {
                entity.HasKey(e => e.IdNoticia)
                    .HasName("PRIMARY");

                entity.ToTable("tb_noticia");

                entity.HasIndex(e => e.IdNoticia)
                    .HasName("id_noticia_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdNoticia)
                    .HasColumnName("id_noticia")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DtCriado)
                    .HasColumnName("dt_criado")
                    .HasColumnType("timestamp(2)");

                entity.Property(e => e.DtModificado)
                    .HasColumnName("dt_modificado")
                    .HasColumnType("timestamp(2)");

                entity.Property(e => e.IdAutor)
                    .HasColumnName("id_autor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCategoria)
                    .HasColumnName("id_categoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Texto)
                    .HasColumnName("texto")
                    .HasColumnType("longtext");

                entity.Property(e => e.Titulo)
                    .HasColumnName("titulo")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
