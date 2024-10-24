using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace InfrastructurePersistence
{
    public  class CVsConfiguration
        : IEntityTypeConfiguration<CVs>
    {
        public void Configure(EntityTypeBuilder<CVs> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("CVs", "dbo");

            // key
            builder.HasKey(t => t.CvId);

            // properties
            builder.Property(t => t.CvId)
                .IsRequired()
                .HasColumnName("CV_ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.EmployeID)
                .HasColumnName("EmployeID")
                .HasColumnType("int");

            builder.Property(t => t.Titre)
                .HasColumnName("Titre")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "CVs";
        }

        public struct Columns
        {
            public const string CvId = "CV_ID";
            public const string EmployeID = "EmployeID";
            public const string Titre = "Titre";
        }
        #endregion
    }
}
