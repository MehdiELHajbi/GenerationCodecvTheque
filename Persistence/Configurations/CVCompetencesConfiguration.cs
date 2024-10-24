using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace InfrastructurePersistence
{
    public  class CVCompetencesConfiguration
        : IEntityTypeConfiguration<CVCompetences>
    {
        public void Configure(EntityTypeBuilder<CVCompetences> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("CVCompetences", "dbo");

            // key
            builder.HasKey(t => new { t.CvId, t.CompetenceID });

            // properties
            builder.Property(t => t.CvId)
                .IsRequired()
                .HasColumnName("CV_ID")
                .HasColumnType("int");

            builder.Property(t => t.CompetenceID)
                .IsRequired()
                .HasColumnName("CompetenceID")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Competences)
                .WithMany(t => t.ListCVCompetences)
                .HasForeignKey(d => d.CompetenceID)
                .HasConstraintName("FK__CVCompete__Compe__440B1D61");

            builder.HasOne(t => t.CVs)
                .WithMany(t => t.ListCVCompetences)
                .HasForeignKey(d => d.CvId)
                .HasConstraintName("FK__CVCompete__CV_ID__4316F928");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "CVCompetences";
        }

        public struct Columns
        {
            public const string CvId = "CV_ID";
            public const string CompetenceID = "CompetenceID";
        }
        #endregion
    }
}
