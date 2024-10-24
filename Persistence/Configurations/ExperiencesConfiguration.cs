using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace InfrastructurePersistence
{
    public  class ExperiencesConfiguration
        : IEntityTypeConfiguration<Experiences>
    {
        public void Configure(EntityTypeBuilder<Experiences> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Experiences", "dbo");

            // key
            builder.HasKey(t => t.ExperienceID);

            // properties
            builder.Property(t => t.ExperienceID)
                .IsRequired()
                .HasColumnName("ExperienceID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CvId)
                .HasColumnName("CV_ID")
                .HasColumnType("int");

            builder.Property(t => t.Entreprise)
                .HasColumnName("Entreprise")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Poste)
                .HasColumnName("Poste")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("text");

            builder.Property(t => t.DateDebut)
                .HasColumnName("DateDebut")
                .HasColumnType("date");

            builder.Property(t => t.DateFin)
                .HasColumnName("DateFin")
                .HasColumnType("date");

            // relationships
            builder.HasOne(t => t.CVs)
                .WithMany(t => t.ListExperiences)
                .HasForeignKey(d => d.CvId)
                .HasConstraintName("FK__Experienc__CV_ID__3B75D760");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Experiences";
        }

        public struct Columns
        {
            public const string ExperienceID = "ExperienceID";
            public const string CvId = "CV_ID";
            public const string Entreprise = "Entreprise";
            public const string Poste = "Poste";
            public const string Description = "Description";
            public const string DateDebut = "DateDebut";
            public const string DateFin = "DateFin";
        }
        #endregion
    }
}
