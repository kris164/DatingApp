using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ApplicationSetting
    {
        public int ApplicationSettingsId { get; set; }
        public int ApplicationProfileId { get; set; }
        public int? HideRibbon { get; set; }
        public int? HideRibbonTabs { get; set; }
        public int? HideNavBar { get; set; }
        public int? HideActionBar { get; set; }
        public int? HideActionPanel { get; set; }
        public int? HideTabs { get; set; }
        public int? HideDesktopMeters { get; set; }
        public int? HideToolDescription { get; set; }
        public int? HideToolHeader { get; set; }
        public int? HideStatusBar { get; set; }
        public int? StatusBarPanels { get; set; }
        public int? FullScreen { get; set; }
        public int? BorderStyle { get; set; }
        public int? DesktopItemClickToExecute { get; set; }
        public int? ActionPanelBevels { get; set; }
        public int? ActionPanelBorder { get; set; }
        public int? BoxBorder { get; set; }
        public int? ActivateExistingTool { get; set; }
        public int? AskBeforeCreateTool { get; set; }
        public int? ClientWidth { get; set; }
        public int? ClientHeight { get; set; }
        public int? DesktopElementFontSize { get; set; }
        public int? DesktopElementLineCount { get; set; }
        public int? DesktopElementWidth { get; set; }
    }
}
