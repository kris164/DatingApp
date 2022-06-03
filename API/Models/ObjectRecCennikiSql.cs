using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Cenniki dla obiektów
    /// </summary>
    public partial class ObjectRecCennikiSql
    {
        public int IdObjectRecCennikiSql { get; set; }
        public int? ObjectId { get; set; }
        public int? RecId { get; set; }
    }
}
