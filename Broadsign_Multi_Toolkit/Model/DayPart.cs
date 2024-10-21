using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadsign_Multi_Toolkit.Model
{
    public class DayPart : IBroadsignModel
    {
        public string Active { get; set; } 
        public string DayMask { get; set; }
        public string DomainId { get; set; }
        public string EndDate { get; set;}
        public string EndTime { get; set;}
        public string Id { get; set;}
        public string ImpressionsPerHour { get; set;}
        public string MinuteMask { get; set;}
        public string Name { get; set;}
        public string ParentId { get; set;}
        public string StartDate { get; set;}
        public string StartTime { get; set;}
        public string VirtualEndDate { get; set;}
        public string VirtualStartDate { get; set;}
        public string Wheight { get; set;}

    }
}
