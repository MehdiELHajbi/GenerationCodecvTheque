using System;
using System.Collections.Generic;

namespace Domain
{
    public  class Formations
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Formations"/> class.
        /// </summary>
        public Formations()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int FormationID { get; set; }

        public int? CvId { get; set; }

        public string Etablissement { get; set; }

        public string Diplome { get; set; }

        public string Specialisation { get; set; }

        public DateTime? AnneeObtention { get; set; }

        #endregion

        #region Generated Relationships
        /// <seealso cref="CvId" />
        public virtual CVs CVs { get; set; }

        #endregion

    }
}
