using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace InfrastructurePersistence
{
    public  class LanguesConfiguration
        : IEntityTypeConfiguration<Langues>
    {
        public void Configure(EntityTypeBuilder<Langues> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Langues", "dbo");

            // key
            builder.HasKey(t => t.LangueID);

            // properties
            builder.Property(t => t.LangueID)
                .IsRequired()
                .HasColumnName("LangueID")
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
            public const string Name = "Langues";
        }

        public struct Columns
        {
            public const string LangueID = "LangueID";
            public const string Nom = "Nom";
        }
        #endregion
    }
}
