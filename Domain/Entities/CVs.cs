using System;
using System.Collections.Generic;

namespace Domain
{
    public  class CVs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CVs"/> class.
        /// </summary>
        public CVs()
        {
            #region Generated Constructor
            ListCertifications = new HashSet<Certifications>();
            ListCVCompetences = new HashSet<CVCompetences>();
            ListCVLangues = new HashSet<CVLangues>();
            ListExperiences = new HashSet<Experiences>();
            ListFormations = new HashSet<Formations>();
            ListLoisirs = new HashSet<Loisirs>();
            ListProjetsPersonnels = new HashSet<ProjetsPersonnels>();
            ListReferencesContact = new HashSet<ReferencesContact>();
            #endregion
        }

        #region Generated Properties
        public int CvId { get; set; }

        public int? EmployeID { get; set; }

        public string Titre { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Certifications> ListCertifications { get; set; }

        public virtual ICollection<CVCompetences> ListCVCompetences { get; set; }

        public virtual ICollection<CVLangues> ListCVLangues { get; set; }

        public virtual ICollection<Experiences> ListExperiences { get; set; }

        public virtual ICollection<Formations> ListFormations { get; set; }

        public virtual ICollection<Loisirs> ListLoisirs { get; set; }

        public virtual ICollection<ProjetsPersonnels> ListProjetsPersonnels { get; set; }

        public virtual ICollection<ReferencesContact> ListReferencesContact { get; set; }

        #endregion

    }
}
