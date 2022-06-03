using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Cenniki dla obiektów
    /// </summary>
    public partial class ObjectCennikiSql
    {
        public int IdObjectCennikiSql { get; set; }
        /// <summary>
        /// Relacja do OBJECT
        /// </summary>
        public int ObjectId { get; set; }
        /// <summary>
        /// Relacja do CENNIKI_SQL
        /// </summary>
        public int CennikiSqlId { get; set; }
        /// <summary>
        /// Nazwa cennika
        /// </summary>
        public string Name { get; set; }
    }
}
