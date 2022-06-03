using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// SID-y dla obiektów
    /// </summary>
    public partial class ObjectSid
    {
        public int IdObjectSid { get; set; }
        /// <summary>
        /// Relacja do OBJECT
        /// </summary>
        public int ObjectId { get; set; }
        /// <summary>
        /// Relacja do SID
        /// </summary>
        public int SidId { get; set; }
        /// <summary>
        /// Nazwa SID-a
        /// </summary>
        public string Name { get; set; }
    }
}
