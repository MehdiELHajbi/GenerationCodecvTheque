using System;
using System.Collections.Generic;

namespace Domain
{
    public  class ProjetsPersonnels
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjetsPersonnels"/> class.
        /// </summary>
        public ProjetsPersonnels()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int ProjetID { get; set; }

        public int? CvId { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }

        public string Lien { get; set; }

        public DateTime? DateDebut { get; set; }

        public DateTime? DateFin { get; set; }

        #endregion

        #region Generated Relationships
        /// <seealso cref="CvId" />
        public virtual CVs CVs { get; set; }

        #endregion

    }
}
