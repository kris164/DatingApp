using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class FileTransferProtocol
    {
        public int FileTransferProtocolId { get; set; }
        public string Name { get; set; }
        public string RemotHost { get; set; }
        public int? RemotePort { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int? Ssl { get; set; }
        public int? SslstartMode { get; set; }
        public int? Ssh { get; set; }
        public int? SshauthMode { get; set; }
        public int? CipherType { get; set; }
        public string RemoteHost { get; set; }
    }
}
