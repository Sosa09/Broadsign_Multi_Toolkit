using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Broadsign_Multi_Toolkit.Model
{
    internal class DisplayUnit : IBroadsignModel
    {
      public string Active { get; set; }
      public string Address { get; set; }
      public string BmbHostId { get; set; }
      public string ContainerId { get; set; }
      public string DisplayUnitTypeId { get; set; }
      public string DomainId { get; set; }
      public string EnforceDayParts { get; set; }
      public string EnforceScreenControls { get; set; }
      public string ExportEnabled { get; set; }
      public string ExportFirstEnabledByUserId { get; set; }
      public string ExportFirstEnabledTm { get; set; }
      public string ExportRetiredByUserId { get; set; }
      public string ExportRetiredOnTm { get; set; }
      public string ExternalId { get; set; }
      public string Geolocation { get; set; }
      public string HostScreenCount { get; set; }
      public string Timezone { get; set; }
      public string VirtualHostDcreenCount { get; set; }
      public string VirtualId { get; set; }
      public string Zipcode { get; set; }
    public string Name { get ; set ; }
    public string Id { get ; set ; }
    }
}
