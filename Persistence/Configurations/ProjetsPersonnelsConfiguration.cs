using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace InfrastructurePersistence
{
    public  class ProjetsPersonnelsConfiguration
        : IEntityTypeConfiguration<ProjetsPersonnels>
    {
        public void Configure(EntityTypeBuilder<ProjetsPersonnels> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ProjetsPersonnels", "dbo");

            // key
            builder.HasKey(t => t.ProjetID);

            // properties
            builder.Property(t => t.ProjetID)
                .IsRequired()
                .HasColumnName("ProjetID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CvId)
                .HasColumnName("CV_ID")
                .HasColumnType("int");

            builder.Property(t => t.Nom)
                .HasColumnName("Nom")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("text");

            builder.Property(t => t.Lien)
                .HasColumnName("Lien")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.DateDebut)
                .HasColumnName("DateDebut")
                .HasColumnType("date");

            builder.Property(t => t.DateFin)
                .HasColumnName("DateFin")
                .HasColumnType("date");

            // relationships
            builder.HasOne(t => t.CVs)
                .WithMany(t => t.ListProjetsPersonnels)
                .HasForeignKey(d => d.CvId)
                .HasConstraintName("FK__ProjetsPe__CV_ID__4F7CD00D");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "ProjetsPersonnels";
        }

        public struct Columns
        {
            public const string ProjetID = "ProjetID";
            public const string CvId = "CV_ID";
            public const string Nom = "Nom";
            public const string Description = "Description";
            public const string Lien = "Lien";
            public const string DateDebut = "DateDebut";
            public const string DateFin = "DateFin";
        }
        #endregion
    }
}
