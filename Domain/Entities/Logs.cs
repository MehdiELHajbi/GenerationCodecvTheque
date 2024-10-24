using System;
using System.Collections.Generic;

namespace Domain
{
    public  class Logs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Logs"/> class.
        /// </summary>
        public Logs()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Message { get; set; }

        public string MessageTemplate { get; set; }

        public string Level { get; set; }

        public DateTime? TimeStamp { get; set; }

        public string Exception { get; set; }

        public string Properties { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
