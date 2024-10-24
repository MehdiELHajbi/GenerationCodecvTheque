using System;
using System.Collections.Generic;

namespace Domain
{
    public  class ReferencesContact
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencesContact"/> class.
        /// </summary>
        public ReferencesContact()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int ReferenceID { get; set; }

        public int? CvId { get; set; }

        public string Nom { get; set; }

        public string Relation { get; set; }

        public string ContactInfo { get; set; }

        #endregion

        #region Generated Relationships
        /// <seealso cref="CvId" />
        public virtual CVs CVs { get; set; }

        #endregion

    }
}
