using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace InfrastructurePersistence
{
    public  class CVLanguesConfiguration
        : IEntityTypeConfiguration<CVLangues>
    {
        public void Configure(EntityTypeBuilder<CVLangues> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("CVLangues", "dbo");

            // key
            builder.HasKey(t => new { t.CvId, t.LangueID });

            // properties
            builder.Property(t => t.CvId)
                .IsRequired()
                .HasColumnName("CV_ID")
                .HasColumnType("int");

            builder.Property(t => t.LangueID)
                .IsRequired()
                .HasColumnName("LangueID")
                .HasColumnType("int");

            builder.Property(t => t.NiveauMaîtrise)
                .HasColumnName("NiveauMaîtrise")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            // relationships
            builder.HasOne(t => t.CVs)
                .WithMany(t => t.ListCVLangues)
                .HasForeignKey(d => d.CvId)
                .HasConstraintName("FK__CVLangues__CV_ID__48CFD27E");

            builder.HasOne(t => t.Langues)
                .WithMany(t => t.ListCVLangues)
                .HasForeignKey(d => d.LangueID)
                .HasConstraintName("FK__CVLangues__Langu__49C3F6B7");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "CVLangues";
        }

        public struct Columns
        {
            public const string CvId = "CV_ID";
            public const string LangueID = "LangueID";
            public const string NiveauMaîtrise = "NiveauMaîtrise";
        }
        #endregion
    }
}
