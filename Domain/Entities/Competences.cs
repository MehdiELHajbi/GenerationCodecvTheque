using System;
using System.Collections.Generic;

namespace Domain
{
    public  class Competences
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Competences"/> class.
        /// </summary>
        public Competences()
        {
            #region Generated Constructor
            ListCVCompetences = new HashSet<CVCompetences>();
            #endregion
        }

        #region Generated Properties
        public int CompetenceID { get; set; }

        public string Nom { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<CVCompetences> ListCVCompetences { get; set; }

        #endregion

    }
}
