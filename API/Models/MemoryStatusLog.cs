using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MemoryStatusLog
    {
        public int IdMemoryStatusLog { get; set; }
        public Guid? Session { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? UserId { get; set; }
        public string Class { get; set; }
        public string Action { get; set; }
        public long? MsMemoryLoad { get; set; }
        public long? MsTotalPhys { get; set; }
        public long? MsAvailPhys { get; set; }
        public long? MsTotalPageFile { get; set; }
        public long? MsAvailPageFile { get; set; }
        public long? MsTotalVirtual { get; set; }
        public long? MsAvailVirtual { get; set; }
        public long? MsAvailExtendedVirtual { get; set; }
        public long? HsTotalAddrSpace { get; set; }
        public long? HsTotalUncommitted { get; set; }
        public long? HsTotalCommitted { get; set; }
        public long? HsTotalAllocated { get; set; }
        public long? HsTotalFree { get; set; }
        public long? HsFreeSmall { get; set; }
        public long? HsFreeBig { get; set; }
        public long? HsOverhead { get; set; }
        public long? HsHeapErrorCode { get; set; }
        public int? OptReadMax { get; set; }
        public int? OptReadCnt { get; set; }
        public int? OptReadCnt2 { get; set; }
        public int? OptWriteMax { get; set; }
        public int? OptWriteCnt { get; set; }
        public int? OptWriteCnt2 { get; set; }
    }
}
