using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MacroItem
    {
        public int MacroItemId { get; set; }
        public int? MacroId { get; set; }
        public int? Enum { get; set; }
        public int? OrdinalNumber { get; set; }
        public int? Sleep { get; set; }
        public string SqlProcedure { get; set; }
        public string ActiveFormClass { get; set; }
        public string ActiveForm { get; set; }
        public string Control { get; set; }
        public string ControlClass { get; set; }
        public string ControlParent { get; set; }
        public string ControlValue { get; set; }
        public string EditValue { get; set; }
        public int? Key { get; set; }
        public string Shortcut { get; set; }
        public string ActiveView { get; set; }
        public string Filter { get; set; }
        public int? PageIndex { get; set; }
        public int? RecordIndex { get; set; }
        public int? ToolId { get; set; }
        public int? Category { get; set; }
        public int? ModalParent { get; set; }
        public int? ParentRecordId { get; set; }
        public string ParentPkvalue { get; set; }
        public int? Mode { get; set; }
        public int? AccessLevel { get; set; }
        public string StaticParams { get; set; }
        public string DynamicParams { get; set; }
        public string ModalParams { get; set; }
    }
}
