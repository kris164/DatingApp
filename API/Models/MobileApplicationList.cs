using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MobileApplicationList
    {
        public int MobileApplicationListId { get; set; }
        public int? MobileApplicationId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? SchemaId { get; set; }
        public string Fingerprint { get; set; }
        public string Qrconfiguration { get; set; }
        public string Qrlink { get; set; }
        public byte[] Qr { get; set; }
        public string BackgroundColor { get; set; }
        public string FontColor { get; set; }
        public string ButtonColor { get; set; }
        public string ButtonFontColor { get; set; }
        public byte[] Logo { get; set; }
        public int? StartIndex { get; set; }
        public int? StopIndex { get; set; }
        public int? Active { get; set; }
        public int? Default { get; set; }
        public int? LoginMethodId { get; set; }
    }
}
