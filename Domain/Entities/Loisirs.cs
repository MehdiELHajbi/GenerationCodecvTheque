using System;
using System.Collections.Generic;

namespace Domain
{
    public  class Loisirs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Loisirs"/> class.
        /// </summary>
        public Loisirs()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int LoisirID { get; set; }

        public int? CvId { get; set; }

        public string Description { get; set; }

        #endregion

        #region Generated Relationships
        /// <seealso cref="CvId" />
        public virtual CVs CVs { get; set; }

        #endregion

    }
}
