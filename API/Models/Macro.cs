using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Macro
    {
        public int MacroId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
