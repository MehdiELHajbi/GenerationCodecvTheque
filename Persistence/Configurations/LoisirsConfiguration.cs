using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace InfrastructurePersistence
{
    public  class LoisirsConfiguration
        : IEntityTypeConfiguration<Loisirs>
    {
        public void Configure(EntityTypeBuilder<Loisirs> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Loisirs", "dbo");

            // key
            builder.HasKey(t => t.LoisirID);

            // properties
            builder.Property(t => t.LoisirID)
                .IsRequired()
                .HasColumnName("LoisirID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CvId)
                .HasColumnName("CV_ID")
                .HasColumnType("int");

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships
            builder.HasOne(t => t.CVs)
                .WithMany(t => t.ListLoisirs)
                .HasForeignKey(d => d.CvId)
                .HasConstraintName("FK__Loisirs__CV_ID__5535A963");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Loisirs";
        }

        public struct Columns
        {
            public const string LoisirID = "LoisirID";
            public const string CvId = "CV_ID";
            public const string Description = "Description";
        }
        #endregion
    }
}
