using System;
using System.Collections.Generic;

namespace Domain
{
    public  class Langues
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Langues"/> class.
        /// </summary>
        public Langues()
        {
            #region Generated Constructor
            ListCVLangues = new HashSet<CVLangues>();
            #endregion
        }

        #region Generated Properties
        public int LangueID { get; set; }

        public string Nom { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<CVLangues> ListCVLangues { get; set; }

        #endregion

    }
}
