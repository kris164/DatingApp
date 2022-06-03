using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZdarzeniaIstatystyki
    {
        public int? SessionId { get; set; }
        public int? MacierzZleceniaTaborId { get; set; }
        public string Mode { get; set; }
        public string Driver1 { get; set; }
        public string Dt { get; set; }
        public string Time { get; set; }
        public string Info { get; set; }
        public string DriverId { get; set; }
        public string CalculateDt { get; set; }
        public string StartOfWeekDt { get; set; }
        public string StartOfDayDt { get; set; }
        public string LastActivityDt { get; set; }
        public string LastTachoDt { get; set; }
        public string LastTachoStatus { get; set; }
        public string LastTachoTime { get; set; }
        public string Drive10hUsed { get; set; }
        public string Drive10hLeft { get; set; }
        public string Drive10hMax { get; set; }
        public string Rest9hUsed { get; set; }
        public string Rest9hLeft { get; set; }
        public string Rest9hMax { get; set; }
        public string WorkDayUsed { get; set; }
        public string DutyDayUsed { get; set; }
        public string Drive4h30Used { get; set; }
        public string Drive4h30Left { get; set; }
        public string Drive4h30Max { get; set; }
        public string DriveDayUsed { get; set; }
        public string DriveDayLeft { get; set; }
        public string DriveDayMax { get; set; }
        public string DriveOneWeekUsed { get; set; }
        public string DriveOneWeekLeft { get; set; }
        public string DriveOneWeekMax { get; set; }
        public string DriveTwoWeeksUsed { get; set; }
        public string DriveTwoWeeksLeft { get; set; }
        public string DriveTwoWeeksMax { get; set; }
        public string DailyRestUsed { get; set; }
        public string DailyRestLeft { get; set; }
        public string DailyRestMin { get; set; }
        public string DailyRestNext { get; set; }
        public string WeeklyRestUsed { get; set; }
        public string WeeklyRestLeft { get; set; }
        public string WeeklyRestMin { get; set; }
        public string WeeklyRestNext { get; set; }
        public string WeeklyRestLastUsed { get; set; }
        public string WeeklyRestShortened { get; set; }
        public string WeeklyRestTimeToNext { get; set; }
    }
}
