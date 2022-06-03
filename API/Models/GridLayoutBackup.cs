using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GridLayoutBackup
    {
        public int GridLayoutBackupId { get; set; }
        public int? UserId { get; set; }
        public int? GridSettingsId { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Language { get; set; }
        public byte[] Layout { get; set; }
        public int? DefaultView { get; set; }
        public int? FilteringColumnFilteredItemsList { get; set; }
        public int? SortingClearOnExit { get; set; }
        public int? FixedBandSeparatorFixedBandSeparatorWidth { get; set; }
        public string FixedBandSeparatorFixedBandSeparatorColor { get; set; }
        public int? StylesContentEvenStyle { get; set; }
        public int? FilterBoxVisible { get; set; }
        public int? FilterRowVisible { get; set; }
    }
}
