using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int? UzyttkownikId { get; set; }
    }
}
