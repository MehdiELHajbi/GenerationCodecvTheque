using Domain;
using Microsoft.EntityFrameworkCore;

namespace InfrastructurePersistence
{
    public  class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<Certifications> Certifications { get; set; }

        public virtual DbSet<Competences> Competences { get; set; }

        public virtual DbSet<CVCompetences> CVCompetences { get; set; }

        public virtual DbSet<CVLangues> CVLangues { get; set; }

        public virtual DbSet<CVs> CVs { get; set; }

        public virtual DbSet<Experiences> Experiences { get; set; }

        public virtual DbSet<Formations> Formations { get; set; }

        public virtual DbSet<Langues> Langues { get; set; }

        public virtual DbSet<Logs> Logs { get; set; }

        public virtual DbSet<Loisirs> Loisirs { get; set; }

        public virtual DbSet<ProjetsPersonnels> ProjetsPersonnels { get; set; }

        public virtual DbSet<ReferencesContact> ReferencesContacts { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new CertificationsConfiguration());
            modelBuilder.ApplyConfiguration(new CompetencesConfiguration());
            modelBuilder.ApplyConfiguration(new CVCompetencesConfiguration());
            modelBuilder.ApplyConfiguration(new CVLanguesConfiguration());
            modelBuilder.ApplyConfiguration(new CVsConfiguration());
            modelBuilder.ApplyConfiguration(new ExperiencesConfiguration());
            modelBuilder.ApplyConfiguration(new FormationsConfiguration());
            modelBuilder.ApplyConfiguration(new LanguesConfiguration());
            modelBuilder.ApplyConfiguration(new LogsConfiguration());
            modelBuilder.ApplyConfiguration(new LoisirsConfiguration());
            modelBuilder.ApplyConfiguration(new ProjetsPersonnelsConfiguration());
            modelBuilder.ApplyConfiguration(new ReferencesContactConfiguration());
            #endregion
        }
    }
}
