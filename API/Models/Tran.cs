using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Tran
    {
        public int IdTrans { get; set; }
        public int? UserId { get; set; }
        public string AccessToken { get; set; }
        public DateTime? AccessTokenDt { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenDt { get; set; }
    }
}
