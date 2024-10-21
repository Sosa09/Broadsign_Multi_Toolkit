using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadsign_Multi_Toolkit.Model
{
    internal class Host : IBroadsignModel
    {
        public string Name { get ; set ; }
        public string Id { get ; set ; }
        public string Active { get ; set ; }
        public string ConfigProfileBagId { get ; set ; }
        public string ContainerId { get ; set ; }
        public string CustomUniqueId { get ; set ; }
        public string DiscoveryStatus { get ; set ; }
        public string DisplayUnitId { get ; set ; }
        public string DomainId { get ; set ; }
        public string Geolocation { get ; set ; }
        public string Nscreens { get ; set ; }
        public string PrimaryMacAddress { get ; set ; }
        public string PublicKeyFingerprint { get ; set ; }
        public string RemoteClearDbTmUtc { get ; set ; }
        public string RemoteRebootTmUtc { get ; set ; }
        public string SecondaryMacAddress { get ; set ; }
        public string Volume { get ; set ; }

    }
}
