using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace InfrastructurePersistence
{
    public  class ReferencesContactConfiguration
        : IEntityTypeConfiguration<ReferencesContact>
    {
        public void Configure(EntityTypeBuilder<ReferencesContact> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ReferencesContact", "dbo");

            // key
            builder.HasKey(t => t.ReferenceID);

            // properties
            builder.Property(t => t.ReferenceID)
                .IsRequired()
                .HasColumnName("ReferenceID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CvId)
                .HasColumnName("CV_ID")
                .HasColumnType("int");

            builder.Property(t => t.Nom)
                .HasColumnName("Nom")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Relation)
                .HasColumnName("Relation")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.ContactInfo)
                .HasColumnName("ContactInfo")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships
            builder.HasOne(t => t.CVs)
                .WithMany(t => t.ListReferencesContact)
                .HasForeignKey(d => d.CvId)
                .HasConstraintName("FK__Reference__CV_ID__52593CB8");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "ReferencesContact";
        }

        public struct Columns
        {
            public const string ReferenceID = "ReferenceID";
            public const string CvId = "CV_ID";
            public const string Nom = "Nom";
            public const string Relation = "Relation";
            public const string ContactInfo = "ContactInfo";
        }
        #endregion
    }
}
