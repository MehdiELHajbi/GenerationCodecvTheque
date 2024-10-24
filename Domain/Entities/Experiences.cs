using System;
using System.Collections.Generic;

namespace Domain
{
    public  class Experiences
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Experiences"/> class.
        /// </summary>
        public Experiences()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int ExperienceID { get; set; }

        public int? CvId { get; set; }

        public string Entreprise { get; set; }

        public string Poste { get; set; }

        public string Description { get; set; }

        public DateTime? DateDebut { get; set; }

        public DateTime? DateFin { get; set; }

        #endregion

        #region Generated Relationships
        /// <seealso cref="CvId" />
        public virtual CVs CVs { get; set; }

        #endregion

    }
}
