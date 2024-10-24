using System;
using System.Collections.Generic;

namespace Domain
{
    public  class CVCompetences
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CVCompetences"/> class.
        /// </summary>
        public CVCompetences()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CvId { get; set; }

        public int CompetenceID { get; set; }

        #endregion

        #region Generated Relationships
        /// <seealso cref="CompetenceID" />
        public virtual Competences Competences { get; set; }

        /// <seealso cref="CvId" />
        public virtual CVs CVs { get; set; }

        #endregion

    }
}
