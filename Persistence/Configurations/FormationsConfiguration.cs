using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace InfrastructurePersistence
{
    public  class FormationsConfiguration
        : IEntityTypeConfiguration<Formations>
    {
        public void Configure(EntityTypeBuilder<Formations> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Formations", "dbo");

            // key
            builder.HasKey(t => t.FormationID);

            // properties
            builder.Property(t => t.FormationID)
                .IsRequired()
                .HasColumnName("FormationID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CvId)
                .HasColumnName("CV_ID")
                .HasColumnType("int");

            builder.Property(t => t.Etablissement)
                .HasColumnName("Etablissement")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Diplome)
                .HasColumnName("Diplome")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Specialisation)
                .HasColumnName("Specialisation")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.AnneeObtention)
                .HasColumnName("AnneeObtention")
                .HasColumnType("date");

            // relationships
            builder.HasOne(t => t.CVs)
                .WithMany(t => t.ListFormations)
                .HasForeignKey(d => d.CvId)
                .HasConstraintName("FK__Formation__CV_ID__3E52440B");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Formations";
        }

        public struct Columns
        {
            public const string FormationID = "FormationID";
            public const string CvId = "CV_ID";
            public const string Etablissement = "Etablissement";
            public const string Diplome = "Diplome";
            public const string Specialisation = "Specialisation";
            public const string AnneeObtention = "AnneeObtention";
        }
        #endregion
    }
}
