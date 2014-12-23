using System.Runtime.Serialization;

namespace Xero.Api.Core.Model
{  
    [DataContract(Namespace = "", Name = "NamedFolder")]
    public class Folder
    {
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }
    }
}