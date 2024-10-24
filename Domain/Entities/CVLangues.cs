using System;
using System.Collections.Generic;

namespace Domain
{
    public  class CVLangues
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CVLangues"/> class.
        /// </summary>
        public CVLangues()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CvId { get; set; }

        public int LangueID { get; set; }

        public string NiveauMaîtrise { get; set; }

        #endregion

        #region Generated Relationships
        /// <seealso cref="CvId" />
        public virtual CVs CVs { get; set; }

        /// <seealso cref="LangueID" />
        public virtual Langues Langues { get; set; }

        #endregion

    }
}
