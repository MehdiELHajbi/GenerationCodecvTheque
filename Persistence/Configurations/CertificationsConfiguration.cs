using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace InfrastructurePersistence
{
    public  class CertificationsConfiguration
        : IEntityTypeConfiguration<Certifications>
    {
        public void Configure(EntityTypeBuilder<Certifications> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Certifications", "dbo");

            // key
            builder.HasKey(t => t.CertificationID);

            // properties
            builder.Property(t => t.CertificationID)
                .IsRequired()
                .HasColumnName("CertificationID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CvId)
                .HasColumnName("CV_ID")
                .HasColumnType("int");

            builder.Property(t => t.Titre)
                .HasColumnName("Titre")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Organisme)
                .HasColumnName("Organisme")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.DateObtention)
                .HasColumnName("DateObtention")
                .HasColumnType("date");

            builder.Property(t => t.DateExpiration)
                .HasColumnName("DateExpiration")
                .HasColumnType("date");

            // relationships
            builder.HasOne(t => t.CVs)
                .WithMany(t => t.ListCertifications)
                .HasForeignKey(d => d.CvId)
                .HasConstraintName("FK__Certifica__CV_ID__4CA06362");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Certifications";
        }

        public struct Columns
        {
            public const string CertificationID = "CertificationID";
            public const string CvId = "CV_ID";
            public const string Titre = "Titre";
            public const string Organisme = "Organisme";
            public const string DateObtention = "DateObtention";
            public const string DateExpiration = "DateExpiration";
        }
        #endregion
    }
}
