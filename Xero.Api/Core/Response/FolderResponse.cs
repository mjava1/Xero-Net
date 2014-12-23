using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Core.Model;

namespace Xero.Api.Core.Response
{
    [DataContract(Namespace = "", Name = "Folder")]
    public class FolderResponse : XeroResponse<Folder>
    {
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int FileCount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Email { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool IsInbox { get; set; }

        public override IList<Folder> Values
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}