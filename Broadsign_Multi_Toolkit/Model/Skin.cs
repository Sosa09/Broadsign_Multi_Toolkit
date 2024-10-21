using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadsign_Multi_Toolkit.Model
{
    internal class Skin : IBroadsignModel
    {
        public string Active { get; set; } 
        public string DomainId { get; set; } 
        public string GeometryType { get; set; } 
        public string Height { get; set; } 
        public string InteractivityTimeout { get; set; } 
        public string InteractivityTriggerId { get; set; } 
        public string LoopPolicyId { get; set; } 
        public string ParentId { get; set; } 
        public string ScreenNr{ get; set; } 
        public string Width{ get; set; } 
        public string X { get; set; } 
        public string Y { get; set; } 
        public string Z { get; set; }
        public string Name { get; set; }

        public string Id { get; set; }
    }
}
