using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace InfrastructurePersistence
{
    public  class CompetencesConfiguration
        : IEntityTypeConfiguration<Competences>
    {
        public void Configure(EntityTypeBuilder<Competences> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Competences", "dbo");

            // key
            builder.HasKey(t => t.CompetenceID);

            // properties
            builder.Property(t => t.CompetenceID)
                .IsRequired()
                .HasColumnName("CompetenceID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Nom)
                .HasColumnName("Nom")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Competences";
        }

        public struct Columns
        {
            public const string CompetenceID = "CompetenceID";
            public const string Nom = "Nom";
        }
        #endregion
    }
}
