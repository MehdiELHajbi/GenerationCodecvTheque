using System;
using System.Collections.Generic;

namespace Domain
{
    public  class Certifications
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Certifications"/> class.
        /// </summary>
        public Certifications()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CertificationID { get; set; }

        public int? CvId { get; set; }

        public string Titre { get; set; }

        public string Organisme { get; set; }

        public DateTime? DateObtention { get; set; }

        public DateTime? DateExpiration { get; set; }

        #endregion

        #region Generated Relationships
        /// <seealso cref="CvId" />
        public virtual CVs CVs { get; set; }

        #endregion

    }
}
